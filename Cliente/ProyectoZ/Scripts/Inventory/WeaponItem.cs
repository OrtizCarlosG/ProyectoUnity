using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponItem : Item
{

    public bool canUseGrip = true, canUseSight = true, canUseMuzzle = true, canUseStock;
    public List<AttachmentItem> attachments = new List<AttachmentItem>();
    private Item _grip;
    private Item _sight;
    private Item _muzzle;
    private Item _stock;

    public enum WeaponType
    {
        Primary,
        Secondary
    }
    public WeaponType _weaponType;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
