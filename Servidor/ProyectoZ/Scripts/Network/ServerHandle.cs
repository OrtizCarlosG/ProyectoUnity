using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerHandle
{
    public static void WelcomeReceived(int _fromClient, Packet _packet)
    {
        int _clientIdCheck = _packet.ReadInt();
        string _username = _packet.ReadString();

        Debug.Log($"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connected successfully and is now player {_fromClient}.");
        if (_fromClient != _clientIdCheck)
        {
            Debug.Log($"Player \"{_username}\" (ID: {_fromClient}) has assumed the wrong client ID ({_clientIdCheck})!");
        }
        Server.clients[_fromClient].SendIntoGame(_username);
    }

    public static void PlayerMovement(int _fromClient, Packet _packet)
    {
        bool[] _inputs = new bool[_packet.ReadInt()];
        for (int i = 0; i < _inputs.Length; i++)
        {
            _inputs[i] = _packet.ReadBool();
        }
        Quaternion _rotation = _packet.ReadQuaternion();

        Server.clients[_fromClient].player.SetInput(_inputs, _rotation);
    }

    public static void PlayerShoot(int _fromClient, Packet _packet)
    {
        Vector3 _shootDirection = _packet.ReadVector3();

        Server.clients[_fromClient].player.Shoot(_shootDirection);
    }

    public static void PlayerThrowItem(int _fromClient, Packet _packet)
    {
        Vector3 _throwDirection = _packet.ReadVector3();

        Server.clients[_fromClient].player.ThrowItem(_throwDirection);
    }

    public static void ReturnInventory(int _fromClient, Packet _packet)
    {
        ServerSend.ReturnInventory(_fromClient, Server.clients[_fromClient].player.GetComponent<InventoryBase>());
    }

    public static void TakeItem(int _fromClient, Packet _packet)
    {
        int _itemIndex = _packet.ReadInt();
        InventoryBase _inventory = Server.clients[_fromClient].player.GetComponent<InventoryBase>();
        bool _result = false;
        if (_inventory.itemPickup(_inventory._itemsOnGround[_itemIndex]))
            _result = true;
        ServerSend.ReturnItemTakeResult(_fromClient, _result, _itemIndex);
    }

    public static void DropItem(int _fromClient, Packet _packet)
    {
        int _itemIndex = _packet.ReadInt();
        InventoryBase _inventory = Server.clients[_fromClient].player.GetComponent<InventoryBase>();
        bool _result = false;
        if (_inventory.dropItem(_inventory._itemList[_itemIndex]))
            _result = true;
        ServerSend.ReturnItemDropResult(_fromClient, _result, _itemIndex);
    }

    public static void RemoveAttachment(int _fromClient, Packet _packet)
    {
        int _itemIndex = _packet.ReadInt();
        int _itemRemove = _packet.ReadInt();
        int _loot = _packet.ReadInt();
        int _isInInventory = _packet.ReadInt();
        InventoryBase _inventory = Server.clients[_fromClient].player.GetComponent<InventoryBase>();
        if (_loot == 0 && _isInInventory == 0)
        {
            if (_inventory._itemList[_itemIndex].itemClass.Equals(Item._itemClass.Weapon))
            {

                Debug.Log($"Remove {_itemRemove} from {_itemIndex}");
                WeaponItem _weapon = _inventory._itemList[_itemIndex] as WeaponItem;
                AttachmentItem _attachment = _weapon.RemoveAttachmentFromSlot(_itemRemove);
                if (_attachment)
                {
                    _inventory._itemList.Add(_attachment);
                    _attachment.transform.SetParent(_inventory._inventoryChild);
                }
            }
        }
        else if (_loot == 1 && _isInInventory == 1)
        {
            if (_inventory._itemsOnGround[_itemIndex].itemClass.Equals(Item._itemClass.Weapon))
            {
                WeaponItem _weapon = _inventory._itemsOnGround[_itemIndex] as WeaponItem;
                AttachmentItem _attachment = _weapon.RemoveAttachmentFromSlot(_itemRemove);
                if (_attachment)
                {
                    _inventory._itemList.Add(_attachment);
                    _attachment.transform.SetParent(_inventory._inventoryChild);
                }
            }
        } else if (_loot == 0 && _isInInventory == 1)
        {
            if (_inventory._itemsOnGround[_itemIndex].itemClass.Equals(Item._itemClass.Weapon))
            {
                WeaponItem _weapon = _inventory._itemsOnGround[_itemIndex] as WeaponItem;
                AttachmentItem _attachment = _weapon.RemoveAttachmentFromSlot(_itemRemove);
                if (_attachment)
                {
                    _inventory._itemsOnGround.Add(_attachment);
                    _attachment.transform.SetParent(null);
                    _attachment._itemCollider.enabled = true;
                    _attachment._renderer.enabled = true;
                }
            }
        }else if (_loot == 1 && _isInInventory == 0)
        {
            if (_inventory._itemList[_itemIndex].itemClass.Equals(Item._itemClass.Weapon))
            {
                WeaponItem _weapon = _inventory._itemList[_itemIndex] as WeaponItem;
                AttachmentItem _attachment = _weapon.RemoveAttachmentFromSlot(_itemRemove);
                if (_attachment)
                {
                    _inventory._itemsOnGround.Add(_attachment);
                    _attachment.transform.SetParent(null);
                    _attachment._itemCollider.enabled = true;
                    _attachment._renderer.enabled = true;
                }
            }
        }
    }

    public static void AddAttachment(int _fromClient, Packet _packet)
    {
        int _modeIndex = _packet.ReadInt();
        int _itemIndex = _packet.ReadInt();
        int _itemAdd = _packet.ReadInt();
        int _loot = _packet.ReadInt();
        int _inInventory = _packet.ReadInt();
        InventoryBase _inventory = Server.clients[_fromClient].player.GetComponent<InventoryBase>();
        Debug.Log($"Recived attachment id {_itemIndex} to {_itemAdd} loot: {_loot}");
        if (_modeIndex == 1)
        {
            if (_loot == 1 && _inInventory == 1)
            {
                if (_inventory._itemList[_itemIndex].itemClass.Equals(Item._itemClass.Weapon))
                {
                    WeaponItem _weapon = _inventory._itemList[_itemIndex] as WeaponItem;
                    AttachmentItem _attachment = _inventory._itemsOnGround[_itemAdd] as AttachmentItem;
                    _weapon.AddAttachmentToSlot(_attachment);
                    ServerSend.UndetectItem(_fromClient, _inventory._itemsOnGround.IndexOf(_attachment));
                    _inventory._itemsOnGround.Remove(_attachment);
                    Debug.Log($"added attachment {_attachment._itemName} to weapon {_weapon._itemName}");
                }
            }
            else if (_loot == 0 && _inInventory == 1)
            {
                if (_inventory._itemsOnGround[_itemIndex].itemClass.Equals(Item._itemClass.Weapon))
                {
                    WeaponItem _weapon = _inventory._itemsOnGround[_itemIndex] as WeaponItem;
                    AttachmentItem _attachment = _inventory._itemList[_itemAdd] as AttachmentItem;
                    _weapon.AddAttachmentToSlot(_attachment);
                    ServerSend.RemoveInventoryItem(_fromClient, _inventory._itemList.IndexOf(_attachment));
                    _inventory._itemList.Remove(_attachment);
                    Debug.Log($"added attachment {_attachment._itemName} to weapon {_weapon._itemName}");
                }
            }
            else if (_loot == 0 && _inInventory == 0)
            {
                Debug.Log($"Item index {_itemIndex} class {_inventory._itemList[_itemIndex].itemClass} item to add {_itemAdd} {_inventory._itemList[_itemAdd].itemClass}");
                if (_inventory._itemList[_itemIndex].itemClass.Equals(Item._itemClass.Weapon))
                {
                    WeaponItem _weapon = _inventory._itemList[_itemIndex] as WeaponItem;
                    AttachmentItem _attachment = _inventory._itemList[_itemAdd] as AttachmentItem;
                    _weapon.AddAttachmentToSlot(_attachment);
                    ServerSend.RemoveInventoryItem(_fromClient, _inventory._itemList.IndexOf(_attachment));
                    _inventory._itemList.Remove(_attachment);
                    Debug.Log($"added attachment {_attachment._itemName} to weapon {_weapon._itemName}");
                }
            }
            else if (_loot == 1 && _inInventory == 0)
            {
                if (_inventory._itemsOnGround[_itemIndex].itemClass.Equals(Item._itemClass.Weapon))
                {
                    WeaponItem _weapon = _inventory._itemsOnGround[_itemIndex] as WeaponItem;
                    AttachmentItem _attachment = _inventory._itemsOnGround[_itemAdd] as AttachmentItem;
                    _weapon.AddAttachmentToSlot(_attachment);
                    ServerSend.UndetectItem(_fromClient, _inventory._itemsOnGround.IndexOf(_attachment));
                    _inventory._itemsOnGround.Remove(_attachment);
                    Debug.Log($"added attachment {_attachment._itemName} to weapon {_weapon._itemName}");
                }
            }
        }
    }
}
