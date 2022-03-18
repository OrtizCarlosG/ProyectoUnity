using System;
using System.Collections.Generic;
using System.Text;
using ProyectoZServer.Objetos;

namespace ProyectoZServer.ServerConnections
{
    class ServerHandle
    {
        public static void WelcomeReceived(int _fromClient, Packet _packet)
        {
            int _clientIdCheck = _packet.ReadInt();

            Globals.getForm().addToLog($"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and is now player {_fromClient}.");
            if (_fromClient != _clientIdCheck)
            {
               Globals.getForm().addToLog($"Player (ID: {_fromClient}) has assumed the wrong client ID ({_clientIdCheck})!");
            }
            //Server.clients[_fromClient].SendIntoGame(_username);
        }

        public static void LoginRecived(int _fromClient, Packet _packet)
        {
            int _client = _packet.ReadInt();
            if (!Server.clients[_fromClient]._isLoggedIn)
            {
                string _hwid = _packet.ReadString();
                string _account = _packet.ReadString();
                string _password = _packet.ReadString();
                string _ip = Server.RemovePort(Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint.ToString());
                Globals.getSQL().openDB();
                if (Ban.getUnbanDate(_hwid) < DateTime.Now)
                    Ban.deleteBan(_hwid);
                if (!Ban.isBanned(_hwid))
                {
                    int tryn = Login.getAccountTrys(_ip, _hwid, _account);
                    Globals.getForm().addToLog($"HWID {_hwid} tryed to log as {_account}");
                    bool _result = false;
                    Globals.getSQL().openDB();
                    _result = Login.checkAccout(_account, _password);
                    Globals.getSQL().closeDB();
                    if (_result)
                    {
                        Server.clients[_fromClient]._clientName = _account;
                        Server.clients[_fromClient]._isLoggedIn = true;
                        Globals.getForm().addToLog($"HWID {_hwid} logged successfully as {_account}");
                        Globals.getSQL().openDB();
                        Login.updateLoginData(_account, _hwid, _ip, DateTime.Now);
                        Globals.getSQL().closeDB();
                    }
                    else
                    {
                        Globals.getSQL().openDB();
                        if (Login.doesAccountExists(_account))
                        {
                            tryn = tryn + 1;
                            if (tryn < 5)
                            {
                                Globals.getForm().addToLog($"HWID {_hwid} tryed to log as {_account} try number {tryn}");
                                Login.insertNewLoginTry(_ip, _hwid, _account, tryn);
                            } else
                            {
                                Ban.insertNewBan(_hwid, _ip, "Demasiados intentos de login", false, DateTime.Now.AddMinutes(5));
                                ServerSend.sendBanPacket(_fromClient, Ban.getBanReason(_hwid), false, DateTime.Now.AddMinutes(5).ToString());
                            }
                        }
                        Globals.getSQL().closeDB();
                    }
                    Globals.getSQL().openDB();
                    ServerSend.sendLoginResult(_fromClient, _result, tryn);
                    Globals.getSQL().closeDB();
                } else
                {
                    DateTime _until = Ban.getUnbanDate(_hwid);
                    TimeSpan span = _until.Subtract(DateTime.Now);
                    ServerSend.sendBanPacket(_fromClient, Ban.getBanReason(_hwid), false, span.Minutes.ToString());
                }
                Globals.getSQL().closeDB();
            }
        }

        public static void RegisterRecived(int _fromClient, Packet _packet)
        {
            string _account = _packet.ReadString();
            string _password = _packet.ReadString();
            string _repass = _packet.ReadString();
            if (_password.Equals(_repass))
            {
                Globals.getSQL().openDB();
                if (!Login.doesAccountExists(_account))
                {
                    string _email = _packet.ReadString();
                    if (!Login.doesEmailExists(_email))
                    {
                        string _answer = _packet.ReadString();
                        string _hwid = _packet.ReadString();
                        string _ip = Server.RemovePort(Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint.ToString());
                        Register.insertNewAccount(_account, _password, _email, _hwid, _ip, DateTime.Now, ImageConverter.DefaultImage());
                    }
                }
                Globals.getSQL().closeDB();
            }
        }

        public static void AccountStartRecived(int _fromClient, Packet _packet)
        {
            string _hwid = _packet.ReadString();
            string _ip = Server.RemovePort(Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint.ToString());
            Globals.getForm().addToLog($"HWID {_hwid} launched the game");
            string _code = Client.RandomString(15);
            Globals.getSQL().openDB();
            if (AccountPlay.doesAccountExists(Server.clients[_fromClient]._clientName))
            {
                AccountPlay.updateAccountPlay(Server.clients[_fromClient]._clientName, _hwid, _ip, DateTime.Now, true, _code, "IN LAUNCHER");
                ServerSend.sendClientKey(_fromClient, _code);
            } else
            {
                if (Login.doesAccountExists(Server.clients[_fromClient]._clientName))
                     AccountPlay.insertNewAccountStatus(_ip, _hwid, Server.clients[_fromClient]._clientName, _code);
                ServerSend.sendClientKey(_fromClient, _code);
            }
            Globals.getSQL().closeDB();
        }

        public static void returnProfileImage(int _fromClient, Packet _packet)
        {
            Globals.getSQL().openDB();
            if (AccountPlay.doesAccountExists(Server.clients[_fromClient]._clientName))
            {
                ServerSend.sendProfilePhoto(_fromClient, Login.getAccountProfile(Server.clients[_fromClient]._clientName));
            }
            Globals.getSQL().closeDB();
        }

        public static void ChangeProfileImage(int _fromClient, Packet _packet)
        {
            Globals.getSQL().openDB();
            if (AccountPlay.doesAccountExists(Server.clients[_fromClient]._clientName))
            {
                Login.updateProfileImage(Server.clients[_fromClient]._clientName, _packet.ReadString());
                ServerSend.sendProfilePhoto(_fromClient, Login.getAccountProfile(Server.clients[_fromClient]._clientName));
            }
            Globals.getSQL().closeDB();
        }

    }
}