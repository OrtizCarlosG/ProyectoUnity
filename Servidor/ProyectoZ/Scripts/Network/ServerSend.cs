using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ServerSend
{
    /// <summary>Sends a packet to a client via TCP.</summary>
    /// <param name="_toClient">The client to send the packet the packet to.</param>
    /// <param name="_packet">The packet to send to the client.</param>
    private static void SendTCPData(int _toClient, Packet _packet)
    {
        _packet.WriteLength();
        Server.clients[_toClient].tcp.SendData(_packet);
    }

    /// <summary>Sends a packet to a client via UDP.</summary>
    /// <param name="_toClient">The client to send the packet the packet to.</param>
    /// <param name="_packet">The packet to send to the client.</param>
    private static void SendUDPData(int _toClient, Packet _packet)
    {
        _packet.WriteLength();
        Server.clients[_toClient].udp.SendData(_packet);
    }

    /// <summary>Sends a packet to all clients via TCP.</summary>
    /// <param name="_packet">The packet to send.</param>
    private static void SendTCPDataToAll(Packet _packet)
    {
        _packet.WriteLength();
        for (int i = 1; i <= Server.MaxPlayers; i++)
        {
            Server.clients[i].tcp.SendData(_packet);
        }
    }
    /// <summary>Sends a packet to all clients except one via TCP.</summary>
    /// <param name="_exceptClient">The client to NOT send the data to.</param>
    /// <param name="_packet">The packet to send.</param>
    private static void SendTCPDataToAll(int _exceptClient, Packet _packet)
    {
        _packet.WriteLength();
        for (int i = 1; i <= Server.MaxPlayers; i++)
        {
            if (i != _exceptClient)
            {
                Server.clients[i].tcp.SendData(_packet);
            }
        }
    }

    /// <summary>Sends a packet to all clients via UDP.</summary>
    /// <param name="_packet">The packet to send.</param>
    private static void SendUDPDataToAll(Packet _packet)
    {
        _packet.WriteLength();
        for (int i = 1; i <= Server.MaxPlayers; i++)
        {
            Server.clients[i].udp.SendData(_packet);
        }
    }
    /// <summary>Sends a packet to all clients except one via UDP.</summary>
    /// <param name="_exceptClient">The client to NOT send the data to.</param>
    /// <param name="_packet">The packet to send.</param>
    private static void SendUDPDataToAll(int _exceptClient, Packet _packet)
    {
        _packet.WriteLength();
        for (int i = 1; i <= Server.MaxPlayers; i++)
        {
            if (i != _exceptClient)
            {
                Server.clients[i].udp.SendData(_packet);
            }
        }
    }

    #region Packets
    /// <summary>Sends a welcome message to the given client.</summary>
    /// <param name="_toClient">The client to send the packet to.</param>
    /// <param name="_msg">The message to send.</param>
    public static void Welcome(int _toClient, string _msg)
    {
        using (Packet _packet = new Packet((int)ServerPackets.welcome))
        {
            _packet.Write(_msg);
            _packet.Write(_toClient);

            SendTCPData(_toClient, _packet);
        }
    }

    /// <summary>Tells a client to spawn a player.</summary>
    /// <param name="_toClient">The client that should spawn the player.</param>
    /// <param name="_player">The player to spawn.</param>
    public static void SpawnPlayer(int _toClient, Player _player)
    {
        using (Packet _packet = new Packet((int)ServerPackets.spawnPlayer))
        {
            _packet.Write(_player.id);
            _packet.Write(_player.username);
            _packet.Write(_player.transform.position);
            _packet.Write(_player.transform.rotation);

            SendTCPData(_toClient, _packet);
        }
    }

    /// <summary>Sends a player's updated position to all clients.</summary>
    /// <param name="_player">The player whose position to update.</param>
    public static void PlayerPosition(Player _player, int _input, Vector2 _inputDirection)
    {
        using (Packet _packet = new Packet((int)ServerPackets.playerPosition))
        {
            _packet.Write(_player.id);
            _packet.Write(_player.transform.position);
            _packet.Write(_input);
            _packet.Write(_inputDirection);

            SendUDPDataToAll(_packet);
        }
    }

    /// <summary>Sends a player's updated rotation to all clients except to himself (to avoid overwriting the local player's rotation).</summary>
    /// <param name="_player">The player whose rotation to update.</param>
    public static void PlayerRotation(Player _player)
    {
        using (Packet _packet = new Packet((int)ServerPackets.playerRotation))
        {
            _packet.Write(_player.id);
            _packet.Write(_player.transform.rotation);

            SendUDPDataToAll(_player.id, _packet);
        }
    }

    public static void PlayerDisconnected(int _playerId)
    {
        using (Packet _packet = new Packet((int)ServerPackets.playerDisconnected))
        {
            _packet.Write(_playerId);

            SendTCPDataToAll(_packet);
        }
    }

    public static void PlayerHealth(Player _player)
    {
        using (Packet _packet = new Packet((int)ServerPackets.playerHealth))
        {
            _packet.Write(_player.id);
            _packet.Write(_player.health);

            SendTCPDataToAll(_packet);
        }
    }

    public static void PlayerRespawned(Player _player)
    {
        using (Packet _packet = new Packet((int)ServerPackets.playerRespawned))
        {
            _packet.Write(_player.id);

            SendTCPDataToAll(_packet);
        }
    }

    public static void CreateItemSpawner(int _toClient, int _spawnerId, Vector3 _spawnerPosition, bool _hasItem)
    {
        using (Packet _packet = new Packet((int)ServerPackets.createItemSpawner))
        {
            _packet.Write(_spawnerId);
            _packet.Write(_spawnerPosition);
            _packet.Write(_hasItem);

            SendTCPData(_toClient, _packet);
        }
    }

    public static void ItemSpawned(int _spawnerId)
    {
        using (Packet _packet = new Packet((int)ServerPackets.itemSpawned))
        {
            _packet.Write(_spawnerId);

            SendTCPDataToAll(_packet);
        }
    }

    public static void ItemPickedUp(int _spawnerId, int _byPlayer)
    {
        using (Packet _packet = new Packet((int)ServerPackets.itemPickedUp))
        {
            _packet.Write(_spawnerId);
            _packet.Write(_byPlayer);

            SendTCPDataToAll(_packet);
        }
    }

    public static void SpawnProjectile(Projectile _projectile, int _thrownByPlayer)
    {
        using (Packet _packet = new Packet((int)ServerPackets.spawnProjectile))
        {
            _packet.Write(_projectile.id);
            _packet.Write(_projectile.transform.position);
            _packet.Write(_thrownByPlayer);

            SendTCPDataToAll(_packet);
        }
    }

    public static void ProjectilePosition(Projectile _projectile)
    {
        using (Packet _packet = new Packet((int)ServerPackets.projectilePosition))
        {
            _packet.Write(_projectile.id);
            _packet.Write(_projectile.transform.position);

            SendUDPDataToAll(_packet);
        }
    }

    public static void ProjectileExploded(Projectile _projectile)
    {
        using (Packet _packet = new Packet((int)ServerPackets.projectileExploded))
        {
            _packet.Write(_projectile.id);
            _packet.Write(_projectile.transform.position);

            SendTCPDataToAll(_packet);
        }
    }

    public static void SpawnEnemy(Enemy _enemy)
    {
        using (Packet _packet = new Packet((int)ServerPackets.spawnEnemy))
        {
            SendTCPDataToAll(SpawnEnemy_Data(_enemy, _packet));
        }
    }
    public static void SpawnEnemy(int _toClient, Enemy _enemy)
    {
        using (Packet _packet = new Packet((int)ServerPackets.spawnEnemy))
        {
            SendTCPData(_toClient, SpawnEnemy_Data(_enemy, _packet));
        }
    }

    private static Packet SpawnEnemy_Data(Enemy _enemy, Packet _packet)
    {
        _packet.Write(_enemy.id);
        _packet.Write(_enemy.transform.position);
        return _packet;
    }

    public static void EnemyPosition(Enemy _enemy)
    {
        using (Packet _packet = new Packet((int)ServerPackets.enemyPosition))
        {
            _packet.Write(_enemy.id);
            _packet.Write(_enemy.transform.position);

            SendUDPDataToAll(_packet);
        }
    }

    public static void EnemyHealth(Enemy _enemy)
    {
        using (Packet _packet = new Packet((int)ServerPackets.enemyHealth))
        {
            _packet.Write(_enemy.id);
            _packet.Write(_enemy.health);

            SendTCPDataToAll(_packet);
        }
    }

    private static Packet ItemPacket(Item _item, Packet _packet)
    {
        _packet.Write(_item._itemName);
        _packet.Write(_item._itemID);
        _packet.Write(_item._hasDurability);
        _packet.Write(_item._durability);
        _packet.Write(_item.itemClass.ToString());
        Debug.Log($"WRITING PACKET ITEM: {_item._itemName} {_item._itemID} {_item._hasDurability} {_item._durability} {_item.itemClass.ToString()}");
        if (_item.itemClass.Equals(Item._itemClass.Weapon))
        {
            WeaponItem _weapon = _item.gameObject.GetComponent<WeaponItem>();
            _packet.Write(_weapon.canUseMuzzle);
            _packet.Write(_weapon.canUseGrip);
            _packet.Write(_weapon.canUseSight);
            _packet.Write(_weapon.canUseStock);
            _packet.Write(_weapon._weaponType.ToString());
            _packet.Write(_weapon._attachmentsList.Count);
            Debug.Log($"WRITING PACKET WEAPON PROPERTYS: {_weapon.canUseMuzzle} {_weapon.canUseGrip} {_weapon.canUseSight} {_weapon.canUseStock} {_weapon._weaponType.ToString()} {_weapon._attachmentsList.Count}");
            for (int j = 0; j < _weapon._attachmentsList.Count; j++)
            {
                _packet.Write(_weapon._attachmentsList[j]._attachmentTypes.ToString());
                _packet.Write(j);
                Debug.Log($"WRITING PACKET ATTACHMENT LIST: {_weapon._attachmentsList[j]._attachmentTypes.ToString()}");
                ItemPacket(_weapon._attachmentsList[j], _packet);
            }
        } else if (_item.itemClass.Equals(Item._itemClass.Attachment))
        {
            AttachmentItem _attachment = _item.gameObject.GetComponent<AttachmentItem>();
            if (!_attachment.isAttached)
            {
                _packet.Write(_attachment._slots.Count);
                Debug.Log($"WRITING PACKET ATTACHMENT USED SLOTS: {_attachment._slots.Count}");
                for (int k = 0; k < _attachment._slots.Count; k++)
                {
                    _packet.Write(_attachment._slots[k]._attachmentTypes.ToString());
                    Debug.Log($"WRITING PACKET ATTACHMENTS IN ATTACHMENT: {_attachment._slots.Count}");
                    ItemPacket(_attachment._slots[k], _packet);
                }
                _packet.Write(_attachment._extraSlots);
                Debug.Log($"WRITING PACKET ATTACHMENT EXTRA SLOTS: {_attachment._extraSlots}");
            }
        }
        return _packet;
    }
    public static void ReturnInventory(int _toClient, InventoryBase _player)
    {
        using (Packet _packet = new Packet((int)ServerPackets.returnInventory))
        {
            _packet.Write(_player._itemsOnGround.Count);
            for (int i = 0; i < _player._itemsOnGround.Count; i++)
            {
                ItemPacket(_player._itemsOnGround[i], _packet);
            }
            _packet.Write(_player._itemList.Count);
            for (int j = 0; j < _player._itemList.Count; j++)
            {
                ItemPacket(_player._itemList[j], _packet);
            }
            SendTCPData(_toClient, _packet);
        }
    }

    public static void ReturnItemTakeResult(int _toClient, bool _result, int _index)
    {
        using (Packet _packet = new Packet((int)ServerPackets.returnItemTakeResult))
        {
            _packet.Write(_result);
            _packet.Write(_index);
            Debug.Log($"Item result {_result} INDEX: {_index}");
            SendTCPData(_toClient, _packet);
        }
    }

    public static void ReturnItemDropResult(int _toClient, bool _result, int _index)
    {
        using (Packet _packet = new Packet((int)ServerPackets.returnItemDropResult))
        {
            _packet.Write(_result);
            _packet.Write(_index);
            Debug.Log($"Item result {_result} INDEX: {_index}");
            SendTCPData(_toClient, _packet);
        }
    }

    public static void DetectedItem(int _toClient, Item _item)
    {
        InventoryBase _inventory = Server.clients[_toClient].player.GetComponent<InventoryBase>();
        using (Packet _packet = new Packet((int)ServerPackets.detectedItem))
        {
            _packet.Write(_inventory._itemsOnGround.Count);
            SendTCPData(_toClient, ItemPacket(_item, _packet));
        }
    }

    public static void UndetectItem(int _toClient, int _index)
    {
        using (Packet _packet = new Packet((int)ServerPackets.removeDetectedItem))
        {
            _packet.Write(_index);
            SendTCPData(_toClient, _packet);
        }

    }

    public static void RemoveInventoryItem(int _toClient, int _index)
    {
        using (Packet _packet = new Packet((int)ServerPackets.removeInventoryItem))
        {
            _packet.Write(_index);
            SendTCPData(_toClient, _packet);
        }

    }

    public static void addInventoryItem(int _toClient, Item _item)
    {
        InventoryBase _inventory = Server.clients[_toClient].player.GetComponent<InventoryBase>();
        using (Packet _packet = new Packet((int)ServerPackets.detectedItem))
        {
            _packet.Write(_inventory._itemList.Count);
            SendTCPData(_toClient, ItemPacket(_item, _packet));
        }
    }


    #endregion
}
