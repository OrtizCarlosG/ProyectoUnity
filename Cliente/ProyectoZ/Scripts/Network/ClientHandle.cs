using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;
using InfimaGames.LowPolyShooterPack;
using System;

public class ClientHandle : MonoBehaviour
{
    public static void Welcome(Packet _packet)
    {
        string _msg = _packet.ReadString();
        int _myId = _packet.ReadInt();

        Debug.Log($"Message from server: {_msg}");
        Client.instance.myId = _myId;
        ClientSend.WelcomeReceived();

        // Now that we have the client's id, connect UDP
        Client.instance.udp.Connect(((IPEndPoint)Client.instance.tcp.socket.Client.LocalEndPoint).Port);
    }

    public static void SpawnPlayer(Packet _packet)
    {
        int _id = _packet.ReadInt();
        string _username = _packet.ReadString();
        Vector3 _position = _packet.ReadVector3();
        Quaternion _rotation = _packet.ReadQuaternion();

        GameManager.instance.SpawnLowPolyPlayer(_id, _username, _position, _rotation);
    }

    public static void PlayerPosition(Packet _packet)
    {
        int _id = _packet.ReadInt();
        Vector3 _position = _packet.ReadVector3();
        int _input = _packet.ReadInt();
        Vector2 _inputDirection = _packet.ReadVector2();

        if (GameManager._characters.TryGetValue(_id, out Character _player))
        {
            _player.transform.position = _position;
            _player.setInput(_input, _inputDirection);
        }
    }

    public static void PlayerRotation(Packet _packet)
    {
        int _id = _packet.ReadInt();
        Quaternion _rotation = _packet.ReadQuaternion();

        if (GameManager.players.TryGetValue(_id, out PlayerManager _player))
        {
            _player.transform.rotation = _rotation;
        }
    }

    public static void PlayerDisconnected(Packet _packet)
    {
        int _id = _packet.ReadInt();

        Destroy(GameManager.players[_id].gameObject);
        GameManager.players.Remove(_id);
    }

    public static void PlayerHealth(Packet _packet)
    {
        int _id = _packet.ReadInt();
        float _health = _packet.ReadFloat();

        GameManager.players[_id].SetHealth(_health);
    }

    public static void PlayerRespawned(Packet _packet)
    {
        int _id = _packet.ReadInt();

        GameManager.players[_id].Respawn();
    }

    public static void CreateItemSpawner(Packet _packet)
    {
        int _spawnerId = _packet.ReadInt();
        Vector3 _spawnerPosition = _packet.ReadVector3();
        bool _hasItem = _packet.ReadBool();

        GameManager.instance.CreateItemSpawner(_spawnerId, _spawnerPosition, _hasItem);
    }

    public static void ItemSpawned(Packet _packet)
    {
        int _spawnerId = _packet.ReadInt();

        GameManager.itemSpawners[_spawnerId].ItemSpawned();
    }

    public static void ItemPickedUp(Packet _packet)
    {
        int _spawnerId = _packet.ReadInt();
        int _byPlayer = _packet.ReadInt();

        GameManager.itemSpawners[_spawnerId].ItemPickedUp();
        GameManager.players[_byPlayer].itemCount++;
    }

    public static void SpawnProjectile(Packet _packet)
    {
        int _projectileId = _packet.ReadInt();
        Vector3 _position = _packet.ReadVector3();
        int _thrownByPlayer = _packet.ReadInt();

        GameManager.instance.SpawnProjectile(_projectileId, _position);
        GameManager.players[_thrownByPlayer].itemCount--;
    }

    public static void ProjectilePosition(Packet _packet)
    {
        int _projectileId = _packet.ReadInt();
        Vector3 _position = _packet.ReadVector3();

        if (GameManager.projectiles.TryGetValue(_projectileId, out ProjectileManager _projectile))
        {
            _projectile.transform.position = _position;
        }
    }

    public static void ProjectileExploded(Packet _packet)
    {
        int _projectileId = _packet.ReadInt();
        Vector3 _position = _packet.ReadVector3();

        GameManager.projectiles[_projectileId].Explode(_position);
    }

    public static void SpawnEnemy(Packet _packet)
    {
        int _enemyId = _packet.ReadInt();
        Vector3 _position = _packet.ReadVector3();

        GameManager.instance.SpawnEnemy(_enemyId, _position);
    }

    public static void EnemyPosition(Packet _packet)
    {
        int _enemyId = _packet.ReadInt();
        Vector3 _position = _packet.ReadVector3();

        if (GameManager.enemies.TryGetValue(_enemyId, out EnemyManager _enemy))
        {
            _enemy.transform.position = _position;
        }
    }

    public static void EnemyHealth(Packet _packet)
    {
        int _enemyId = _packet.ReadInt();
        float _health = _packet.ReadFloat();

        GameManager.enemies[_enemyId].SetHealth(_health);
    }

    public static void ReciveInventory(Packet _packet)
    {
        int _lootItems = _packet.ReadInt();
        if (_lootItems > 0)
        {
            for (int i = 0; i < _lootItems; i++)
            {
                GameManager._characters[Client.instance.myId].GetComponent<CharacterInventory>().itemsOnGround.Add(ReadItem(_packet));
            }
        }
        int _items = _packet.ReadInt();
        Debug.Log(_items);
        if (_items > 0)
        {
            for (int z = 0; z < _items; z++)
            {
                GameManager._characters[Client.instance.myId].GetComponent<CharacterInventory>().item.Add(ReadItem(_packet));
            }
        }

        GameManager._characters[Client.instance.myId].GetComponent<CharacterInventory>().itemsOnGroundUpdate();
    }

    public static void ReadItemTakeResult(Packet _packet)
    {
        bool _result = _packet.ReadBool();
        int _index = _packet.ReadInt();
        if (_result)
         GameManager._characters[Client.instance.myId].GetComponent<CharacterInventory>().MoveItemToInventory(_index);
    }
    public static void ReadItemDropResult(Packet _packet)
    {
        bool _result = _packet.ReadBool();
        int _index = _packet.ReadInt();
        if (_result)
            GameManager._characters[Client.instance.myId].GetComponent<CharacterInventory>().MoveItemToGround(_index);
    }

    private static Item ReadItem(Packet _packet)
    {
        var _item = new Item();
        string _itemName = _packet.ReadString();
        int _itemID = _packet.ReadInt();
        bool _hasDurability = _packet.ReadBool();
        float _durability = _packet.ReadFloat();
        Item.ItemClass _class = (Item.ItemClass)Enum.Parse(typeof(Item.ItemClass), _packet.ReadString(), true);
        Debug.Log($"READING PACKET ITEM ID {_item._id} NAME: {_itemName} ID: {_itemID} Durability: {_hasDurability} Float: {_durability} Class {_class}");
        if (_class.Equals(Item.ItemClass.Weapon))
        {
            WeaponItem _weapon = new WeaponItem();
            _weapon.canUseMuzzle = _packet.ReadBool();
            _weapon.canUseGrip = _packet.ReadBool();
            _weapon.canUseSight = _packet.ReadBool();
            _weapon.canUseStock = _packet.ReadBool();
            _weapon._weaponType = (WeaponItem.WeaponType)Enum.Parse(typeof(WeaponItem.WeaponType), _packet.ReadString(), true);
            int _attachmentsCount = _packet.ReadInt();
            Debug.Log($"READING PACKET Weapon MUZZLE: {_weapon.canUseMuzzle} GRIP: {_weapon.canUseGrip} SIGHT: {_weapon.canUseSight} STOCK: {_weapon.canUseStock} TYPE: {_weapon._weaponType} ATTACHMENTS {_attachmentsCount}");
            for (int k = 0; k < _attachmentsCount; k++)
            {
                AttachmentItem _attachment = new AttachmentItem();
                _attachment._attachmentType = (AttachmentItem.AttachmentTypes)Enum.Parse(typeof(AttachmentItem.AttachmentTypes), _packet.ReadString(), true);
                _attachment._id = _packet.ReadInt();
                _attachment._itemName = _packet.ReadString();
                _attachment._itemID = _packet.ReadInt();
                _attachment._hasDurability = _packet.ReadBool();
                _attachment._durability = _packet.ReadFloat();
                _attachment._itemClass = (Item.ItemClass)Enum.Parse(typeof(Item.ItemClass), _packet.ReadString(), true);
                _attachment._attachedTo = _weapon;
                Debug.Log($"READING PACKET ATTACHMENT: {_attachment._attachmentType.ToString()} ITEM NAME: {_attachment._itemName} ID: {_attachment._itemID} Durability: {_attachment._hasDurability} Float: {_attachment._durability} Class {_attachment._itemClass.ToString()}");
                _weapon.attachments.Add(_attachment);
            }
            //_weapon._weaponType = (WeaponItem.WeaponType)Enum.Parse(typeof(WeaponItem.WeaponType), _packet.ReadString(), true);
            _item = _weapon;
        }
        else if (_class.Equals(Item.ItemClass.Attachment))
        {
            AttachmentItem _newAttachment = new AttachmentItem();
            for (int j = 0; j < _packet.ReadInt(); j++)
            {
                AttachmentItem _attachment = new AttachmentItem();
                _attachment._attachmentType = (AttachmentItem.AttachmentTypes)Enum.Parse(typeof(AttachmentItem.AttachmentTypes), _packet.ReadString(), true);
                _attachment._itemName = _packet.ReadString();
                _attachment._itemID = _packet.ReadInt();
                _attachment._hasDurability = _packet.ReadBool();
                _attachment._durability = _packet.ReadFloat();
                _attachment._itemClass = (Item.ItemClass)Enum.Parse(typeof(Item.ItemClass), _packet.ReadString(), true);
                Debug.Log($"READING PACKET ATTACHMENT: {_attachment._attachmentType.ToString()} ITEM NAME: {_attachment._itemName} ID: {_attachment._itemID} Durability: {_attachment._hasDurability} Float: {_attachment._durability} Class {_attachment._itemClass.ToString()}");
            }
            _newAttachment._extraSlots = _packet.ReadInt();
            _item = _newAttachment;
        }
        _item._itemName = _itemName;
        _item._itemID = _itemID;
        _item._hasDurability = _hasDurability;
        _item._durability = _durability;
        _item._itemClass = _class;
        return _item;
    }

    public static void ReadDetectedItem(Packet _packet)
    {
        int _id = _packet.ReadInt();
        Item _item = ReadItem(_packet);
        _item._id = _id;
        CharacterInventory _inventory = GameManager._characters[Client.instance.myId].GetComponent<CharacterInventory>();
        if (_inventory.itemsOnGround.Count <= _item._id)
        {
            if (_inventory.itemsOnGround[_item._id] == null)
            {
                _inventory.itemsOnGround.Add(_item);
                _inventory.CreateCellForItem(_item, _inventory.parentCellGround, "Ground");
            }
        }
    }

    public static void ReadUndetectItem(Packet _packet)
    {
        int _index = _packet.ReadInt();
        CharacterInventory _inventory = GameManager._characters[Client.instance.myId].GetComponent<CharacterInventory>();
        _inventory.DeleteItemOnGround(_index);

    }

    public static void addInventoryItem(Packet _packet)
    {
        int id = _packet.ReadInt();
        Item _item = ReadItem(_packet);
        _item._id = id;
        CharacterInventory _inventory = GameManager._characters[Client.instance.myId].GetComponent<CharacterInventory>();
        if (_inventory.item.Count < id)
        {
            _inventory.item.Add(_item);
            _inventory.CreateCellForItem(_item, _inventory.parentCell, "Inventory");
        }
    }
    public static void removeInventoryItem(Packet _packet)
    {
        int _index = _packet.ReadInt();
        Debug.Log($"Remove inventory item at index {_index}");
        CharacterInventory _inventory = GameManager._characters[Client.instance.myId].GetComponent<CharacterInventory>();
        _inventory.DeleteInventoryItem(_index);
         
    }

}
