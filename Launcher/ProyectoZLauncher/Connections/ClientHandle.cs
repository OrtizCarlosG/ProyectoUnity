using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;
using ProyectoZLauncher.Objetos;

namespace ProyectoZLauncher.Connections
{
    public class ClientHandle
    {
        public static void getID(Packet _packet)
        {
            int _myId = _packet.ReadInt();
            Client.myId = _myId;

            Client.udp.Connect(((IPEndPoint)Client.tcp.socket.Client.LocalEndPoint).Port);
        }

        public static void loginResult(Packet _packet)
        {
            bool _result = _packet.ReadBool();
            int _trys = _packet.ReadInt();
            if (!_result)
            {
                if (_trys < 5)
                    Globals.getLoginForm().setErrorMessage($"Usuario o contraseña incorrectos [{_trys}/5]"); 
            }
            else
            {
                Globals.getMenu().hideWindow();
                GameForm _form = new GameForm();
                _form.ShowDialog();
                Globals.getMenu().closeWindow();
            }
        }

        public static void banResult(Packet _packet)
        {
            string _reason = _packet.ReadString();
            bool isPerm = _packet.ReadBool();
            string _until = _packet.ReadString();
            if (!isPerm)
            {
                Globals.getLoginForm().setErrorMessage($"Intenelo de nuevo en {_until} minutos");
            }
            else
            {
                Globals.getLoginForm().setErrorMessage($"Has sido bloqueado permanentemente");
            }
        }

        public static void ClientCode(Packet _packet)
        {
            string _code = _packet.ReadString();
            Globals._ClientKey = _code;
        }

        public static void drawImage(Packet _packet)
        {
            string image = _packet.ReadString();

            Globals.getGameForm().profileImage.Image = imageConverter.converToImage(image);
        }


    }
}
