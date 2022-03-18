using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public string _itemName;
    public int _itemID;
    public int _id;
    public enum _itemClass
    {
        Weapon,
        Attachment,
        Equipment
    }
    public _itemClass itemClass;
    public bool _hasDurability = true;
    public float _maxDurability, _durability;
    public float _itemWeight = 1f;
    public bool _canDrop = true;
    public BoxCollider _itemCollider;
    public MeshRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _itemCollider = GetComponent<BoxCollider>();
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
