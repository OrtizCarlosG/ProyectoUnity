using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryField : MonoBehaviour
{
    public InventoryBase _inventory;
    private void OnTriggerEnter(Collider other)
    {
        Item _item = other.GetComponent<Item>();
        if (_item)
        {
            if (!_inventory._itemsOnGround.Contains(_item))
            {
                _inventory._itemsOnGround.Add(_item);
                ServerSend.DetectedItem(_inventory.gameObject.GetComponent<Player>().id, _item);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Item _item = other.GetComponent<Item>();
        if (_item)
        {
            if (_inventory._itemsOnGround.Contains(_item))
            {
                ServerSend.UndetectItem(_inventory.gameObject.GetComponent<Player>().id, _inventory._itemsOnGround.IndexOf(_item));
                _inventory._itemsOnGround.Remove(_item);
            }
        }
    }
}
