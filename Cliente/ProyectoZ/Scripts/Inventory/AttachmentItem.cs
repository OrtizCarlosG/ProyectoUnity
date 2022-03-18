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
    public AttachmentTypes _attachmentType;
    public int _extraSlots;
    public List<Item> _slots = new List<Item>();
    public Item _attachedTo;
    public int _attachmentID;

    public void AddAttachmentToSlot(Item _item)
    {
     _slots.Add(_item);
    }

    public void RemoveAttachmentFromSlot(Item _item)
    {
      _slots.Add(_item);
    }

}
