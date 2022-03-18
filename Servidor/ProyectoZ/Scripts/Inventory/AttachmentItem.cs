using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachmentItem : Item
{

    public enum AttachmentTypes
    {
        Scopes,
        Grip,
        Stock,
        Muzzle
    }
    public AttachmentTypes _attachmentTypes;
    public bool _hasExtraSlot;
    public int _extraSlots;
    public List<AttachmentItem> _slots = new List<AttachmentItem>();
    public bool isAttached = false;
    public Item _attachedTo;
    public int _attachmentID;
    public AttachmentItem()
    {
        itemClass = _itemClass.Attachment;
    }

    public void AddAttachmentToSlot(AttachmentItem _item)
    {
        if (_item.itemClass.Equals(AttachmentItem._itemClass.Attachment))
        {
            if (_item.GetComponent<AttachmentItem>()._attachmentTypes.Equals(this._attachmentTypes))
                _slots.Add(_item);
        }
    }

    public void RemoveAttachmentFromSlot(AttachmentItem _item)
    {
        if (_item.itemClass.Equals(AttachmentItem._itemClass.Attachment))
        {
            if (_slots.Contains(_item))
                _slots.Add(_item);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
