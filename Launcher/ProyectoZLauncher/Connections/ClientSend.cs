using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoZLauncher.Objetos;
namespace ProyectoZLauncher.Connections
{
    public class ClientSend
    {
        /// <summary>Sends a packet to the server via TCP.</summary>
        /// <param name="_packet">The packet to send to the sever.</param>
        private static void SendTCPData(Packet _packet)
        {
            _packet.WriteLength();
            Client.tcp.SendData(_packet);
        }

        /// <summary>Sends a packet to the server via UDP.</summary>
        /// <param name="_packet">The packet to send to the sever.</param>
        private static void SendUDPData(Packet _packet)
        {
            _packet.WriteLength();
            Client.udp.SendData(_packet);
        }

        #region Packets
        /// <summary>Lets the server know that the welcome message was received.</summary>
        public static void LoginPacket(string _user, string _password)
        {
            using (Packet _packet = new Packet((int)ClientPackets.login))
            {
                _packet.Write(Client.myId);
                _packet.Write(Globals.getCPUId());
                _packet.Write(_user);
                _packet.Write(_password);

                SendTCPData(_packet);
            }
        }

        public static void RegisterPakcet(Account _account)
        {
            using (Packet _packet = new Packet((int)ClientPackets.register))
            {
                _packet.Write(_account.getAccount());
                _packet.Write(_account.getPassword());
                _packet.Write(_account.getRePass());
                _packet.Write(_account.getEmail());
                _packet.Write(_account.getAnswer());
                _packet.Write(Globals.getCPUId());

                SendTCPData(_packet);
            }

        }

        public static void StartAccount()
        {
            using (Packet _packet = new Packet((int)ClientPackets.startAcc))
            {
                _packet.Write(Globals.getCPUId());
                SendTCPData(_packet);
            }
        }

        public static void getProfileImage()
        {
            using (Packet _packet = new Packet((int)ClientPackets.profileImage))
            {
                SendTCPData(_packet);
            }
        }

        public static void changeProfileImage(string _image)
        {
            using (Packet _packet = new Packet((int)ClientPackets.changeImage))
            {
                _packet.Write(_image);
                SendTCPData(_packet);
            }
        }

        public static void requestCaptcha()
        {
            using (Packet _packet = new Packet((int)ClientPackets.requestCaptcha))
            {
                SendTCPData(_packet);
            }
        }
        #endregion
    }
}
