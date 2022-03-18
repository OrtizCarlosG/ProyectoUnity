using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponItem : Item
{

    public bool canUseGrip = true, canUseSight = true, canUseMuzzle = true, canUseStock;
    public List<AttachmentItem> _attachmentsList = new List<AttachmentItem>();
    private Item _grip;
    private Item _sight;
    private Item _muzzle;
    private Item _stock;
    public float _movmentMultiplier = 1.0f, _sideWaysMultiplier = 0.001f, _backwardsMultiplier = 0.001f;
    public float _speedAiming = 1f;
    public float _speedRunning = 1f;

    public enum WeaponType
    {
        Primary,
        Secondary
    }
    public WeaponType _weaponType;
    public WeaponItem()
    {
        itemClass = _itemClass.Weapon;
    }

    public void AddAttachmentToSlot(AttachmentItem _item)
    {
        if (_item.itemClass.Equals(AttachmentItem._itemClass.Attachment))
        {
            if (_item._attachmentTypes.Equals(AttachmentItem.AttachmentTypes.Scopes))
                _sight = _item;
            else if (_item._attachmentTypes.Equals(AttachmentItem.AttachmentTypes.Grip))
                _grip = _item;
            else if (_item._attachmentTypes.Equals(AttachmentItem.AttachmentTypes.Muzzle))
                _muzzle = _item;
            else if (_item._attachmentTypes.Equals(AttachmentItem.AttachmentTypes.Stock))
                _stock = _item;
            _item.transform.parent = this.transform;
            _item._itemCollider.enabled = false;
            _item._renderer.enabled = false;
            _item.isAttached = true;
            _item._attachedTo = this;
            _attachmentsList.Add(_item);
            _item._attachmentID = _attachmentsList.IndexOf(_item);
        }
    }

    public void RemoveAttachmentFromSlot(AttachmentItem _item)
    {
        if (_item.itemClass.Equals(AttachmentItem._itemClass.Attachment))
        {
            if (_attachmentsList.Contains(_item))
            {
                _item.transform.parent = this.transform;
                _item._itemCollider.enabled = false;
                _item._renderer.enabled = false;
                _item.isAttached = false;
                _item._attachedTo = null;
                _attachmentsList.Remove(_item);
            }
        }
    }

    public AttachmentItem RemoveAttachmentFromSlot(int _index)
    {
       AttachmentItem _item = _attachmentsList[_index];
       _attachmentsList.RemoveAt(_index);
        _item.isAttached = false;
          return _item;
    }
}
