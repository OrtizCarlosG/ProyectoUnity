using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientSend : MonoBehaviour
{
    /// <summary>Sends a packet to the server via TCP.</summary>
    /// <param name="_packet">The packet to send to the sever.</param>
    private static void SendTCPData(Packet _packet)
    {
        _packet.WriteLength();
        Client.instance.tcp.SendData(_packet);
    }

    /// <summary>Sends a packet to the server via UDP.</summary>
    /// <param name="_packet">The packet to send to the sever.</param>
    private static void SendUDPData(Packet _packet)
    {
        _packet.WriteLength();
        Client.instance.udp.SendData(_packet);
    }

    #region Packets
    /// <summary>Lets the server know that the welcome message was received.</summary>
    public static void WelcomeReceived()
    {
        using (Packet _packet = new Packet((int)ClientPackets.welcomeReceived))
        {
            _packet.Write(Client.instance.myId);
            _packet.Write("Charles");

            SendTCPData(_packet);
        }
    }

    /// <summary>Sends player input to the server.</summary>
    /// <param name="_inputs"></param>
    public static void PlayerMovement(bool[] _inputs)
    {
        using (Packet _packet = new Packet((int)ClientPackets.playerMovement))
        {
            _packet.Write(_inputs.Length);
            foreach (bool _input in _inputs)
            {
                _packet.Write(_input);
            }
            _packet.Write(GameManager._characters[Client.instance.myId].transform.rotation);

            SendUDPData(_packet);
        }
    }

    public static void PlayerShoot(Vector3 _facing)
    {
        using (Packet _packet = new Packet((int)ClientPackets.playerShoot))
        {
            _packet.Write(_facing);

            SendTCPData(_packet);
        }
    }

    public static void PlayerThrowItem(Vector3 _facing)
    {
        using (Packet _packet = new Packet((int)ClientPackets.playerThrowItem))
        {
            _packet.Write(_facing);

            SendTCPData(_packet);
        }
    }

    public static void RequestInventory()
    {
        using (Packet _packet = new Packet((int)ClientPackets.requestInventory))
        {
            SendTCPData(_packet);
        }
    }

    public static void TakeItem(int _itemIndex)
    {
        using (Packet _packet = new Packet((int)ClientPackets.takeItem))
        {
            _packet.Write(_itemIndex);
            SendTCPData(_packet);
        }
    }
    public static void DropItem(int _itemIndex)
    {
        using (Packet _packet = new Packet((int)ClientPackets.dropItem))
        {
            _packet.Write(_itemIndex);
            SendTCPData(_packet);
        }
    } 

    public static void RemoveAttachment(int _itemIndex, int _itemRemoveIndex, int _loot, int _inventory)
    {
        using (Packet _packet = new Packet((int)ClientPackets.removeAttachment))
        {
            _packet.Write(_itemIndex);
            _packet.Write(_itemRemoveIndex);
            _packet.Write(_loot);
            _packet.Write(_inventory);
            SendTCPData(_packet);
        }
    }

    public static void addAttachment(int _itemIndex, int _itemAddIndex, int _loot, int _inventory)
    {
        using (Packet _packet = new Packet((int)ClientPackets.addAttachment))
        {
            _packet.Write(1);
            _packet.Write(_itemIndex);
            _packet.Write(_itemAddIndex);
            _packet.Write(_loot);
            _packet.Write(_inventory);
            SendTCPData(_packet);
        }
    }

    public static void addAttachment(int _itemIndex, int _fromItemIndex, int _toItemIndex, int _loot, int _inventory)
    {
        using (Packet _packet = new Packet((int)ClientPackets.addAttachment))
        {
            _packet.Write(2);
            _packet.Write(_itemIndex);
            _packet.Write(_fromItemIndex);
            _packet.Write(_toItemIndex);
            _packet.Write(_loot);
            _packet.Write(_inventory);
            SendTCPData(_packet);
        }
    }
    #endregion
}
