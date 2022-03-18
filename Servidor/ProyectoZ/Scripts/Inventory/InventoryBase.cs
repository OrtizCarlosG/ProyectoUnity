using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBase : MonoBehaviour
{


    public float maxWeight = 5f;
    public int maxItems = 2;
    public Transform _inventoryChild;
    public List<Item> _itemList = new List<Item>();
    public List<Item> _itemsOnGround = new List<Item>();

    public bool itemPickup(Item item)
    {
        bool _result = false;
        if (item._itemWeight < maxWeight + item._itemWeight)
        {
            if (_itemList.Count < maxItems)
            {
                _itemList.Add(item);
                item.transform.parent = _inventoryChild;
                item._itemCollider.enabled = false;
                item._renderer.enabled = false;
                _itemsOnGround.Remove(item);
                _result = true;
               // Destroy(item.gameObject);
            }
        }
        return _result;
    }

    public bool dropItem(Item _item)
    {
        bool _result = false;
        if (_itemList.Contains(_item))
        {
            _itemList.Remove(_item);
            _item.transform.parent = null;
            _item._itemCollider.enabled = true;
            _item._renderer.enabled = true;
            _result = true;
        }
        return _result;
    }
}
