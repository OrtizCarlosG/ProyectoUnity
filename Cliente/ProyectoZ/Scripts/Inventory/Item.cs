using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Item
{

    public string _itemName;
    public int _id;
    public int _itemID;
    public Sprite _itemImage;
    public bool _hasDurability;
    public float _durability;
    public enum ItemClass
    {
        Weapon,
        Attachment,
        Equipment
    }

    public ItemClass _itemClass;
}
