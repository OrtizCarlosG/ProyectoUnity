using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Proyecto Z/Inventario/Item")]
public class ItemDB : ScriptableObject
{
    public int _itemID;
    public Sprite _itemSprite;
    public GameObject _itemPrefab;
}
