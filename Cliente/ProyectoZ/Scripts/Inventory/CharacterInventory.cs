using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInventory : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isActive = false;

    public GameObject mCamera;

    public GameObject inventory;
    public GameObject Cell;
    public GameObject _attachmentCell;
    public Transform parentCell;
    public Transform parentCellGround;
    public GameObject firstWeapon;
    public GameObject secondWeapon;

    public List<Item> item = new List<Item>();
    public List<Item> itemsOnGround = new List<Item>();


    public void inventoryUpdate()
    {
        InventoryActive();
        Ray ray = new Ray(mCamera.transform.position, mCamera.transform.forward * 5);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            if (hit.collider.tag.Equals("Item"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    item.Add(hit.collider.GetComponent<Item>());
                    Destroy(hit.transform.gameObject);
                }
            }
        }
    }

    public void itemsOnGroundUpdate()
    {

        for (int i = 0; i < parentCellGround.childCount; i++)
        {
            if (parentCellGround.transform.childCount > 0)
            {
                Destroy(parentCellGround.transform.GetChild(i).gameObject);
            }
        }

        int count = itemsOnGround.Count;

        for (int i = 0; i < count; i++)
        {
            Item _item = itemsOnGround[i];
            _item._id = i;
            CreateCellForItem(_item, parentCellGround, "Ground");
        }

        for (int i = 0; i < parentCell.childCount; i++)
        {
            if (parentCell.transform.childCount > 0)
            {
                Destroy(parentCell.transform.GetChild(i).gameObject);
            }
        }

        int itemCount = item.Count;

        for (int i = 0; i < itemCount; i++)
        {
            Item _item = item[i];
            _item._id = i;
            CreateCellForItem(_item, parentCell, "Inventory");
        }
    }

    public void InventoryActive()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (inventory.activeSelf)
            {
                itemsOnGround.Clear();
                item.Clear();

                isActive = false;
                inventory.SetActive(false);
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;

                for (int i = 0; i < parentCell.childCount; i++)
                {
                    if (parentCell.transform.childCount > 0)
                    {
                        Destroy(parentCell.transform.GetChild(i).gameObject);
                    }
                }
            } else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                inventory.SetActive(true);
                ClientSend.RequestInventory();
            }
        }
    }

    public void CreateCellForItem(Item _item, Transform _parent, string typelist)
    {
        ItemDB _itemdb = ItemsDatabase.getItemByID(_item._itemID);
        GameObject newCell = Instantiate(Cell);
        Cell _itemCell = newCell.GetComponent<Cell>();
        newCell.transform.SetParent(_parent);

        //newCell.transform.GetChild(3).GetComponent<Image>().rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, (70 * it._ItemDurability) / 100);
        //newCell.transform.GetChild(3).GetComponent<Image>().rectTransform.position = new Vector2(-229.2f, ((38 * it._ItemDurability) / 100) - 38);
        _itemCell._itemImage.sprite = _itemdb._itemSprite;
        _itemCell._itemText.text = _item._itemName;
        newCell.transform.GetComponent<Drag>().item = _item;
        newCell.transform.GetComponent<Drag>().typeList = typelist;
        if (_item._itemClass.Equals(Item.ItemClass.Weapon))
        {
            WeaponItem _weapon = _item as WeaponItem;
            for (int j = 0; j < _weapon.attachments.Count; j++)
            {
                GameObject _cell = Instantiate(_attachmentCell);
                ItemDB _attachmentDB = ItemsDatabase.getItemByID(_weapon.attachments[j]._itemID);
                Image _cellImage = _cell.GetComponent<Image>();
                Drag _drag = _cell.GetComponent<Drag>();
                if (_weapon.attachments[j]._attachmentType.Equals(AttachmentItem.AttachmentTypes.Scopes))
                {
                    _cell.transform.position = _itemCell._sightImage.transform.position;
                    _cell.transform.SetParent(_itemCell._sightImage.transform);
                    _drag.typeList = "Item Slot 3";
                }
                else if (_weapon.attachments[j]._attachmentType.Equals(AttachmentItem.AttachmentTypes.Muzzle))
                {
                    _cell.transform.position = _itemCell._muzzleImage.transform.position;
                    _cell.transform.SetParent(_itemCell._muzzleImage.transform);
                    _drag.typeList = "Item Slot 1";
                }
                else if (_weapon.attachments[j]._attachmentType.Equals(AttachmentItem.AttachmentTypes.Grip))
                {
                    _cell.transform.position = _itemCell._gripImage.transform.position;
                    _cell.transform.SetParent(_itemCell._gripImage.transform);
                    _drag.typeList = "Item Slot 2";
                }
                else if (_weapon.attachments[j]._attachmentType.Equals(AttachmentItem.AttachmentTypes.Stock))
                {
                    _cell.transform.position = _itemCell._stockImage.transform.position;
                    _cell.transform.SetParent(_itemCell._stockImage.transform);
                    _drag.typeList = "Item Slot 4";
                }
                _cellImage.sprite = _attachmentDB._itemSprite;
                _cell.transform.SetParent(newCell.transform);
                _cell.GetComponent<Drag>().item = _weapon.attachments[j];
                //_cell.GetComponent<Drop>()._dragParent = newCell.GetComponent<Drag>();
            }
            _itemCell._sightSlot.SetActive(true);
            _itemCell._gripSlot.SetActive(true);
            _itemCell._muzzleSlot.SetActive(true);
            _itemCell._stockSlot.SetActive(true);
            _itemCell._gripDrop._item = _weapon;
            _itemCell._sightDrop._item = _weapon;
            _itemCell._muzzleDrop._item = _weapon;
            _itemCell._stockDrop._item = _weapon;
            _itemCell._gripDrop._dragParent = newCell.GetComponent<Drag>();
            _itemCell._sightDrop._dragParent = newCell.GetComponent<Drag>();
            _itemCell._muzzleDrop._dragParent = newCell.GetComponent<Drag>();
            _itemCell._stockDrop._dragParent = newCell.GetComponent<Drag>();
        }
        else if (_item._itemClass.Equals(Item.ItemClass.Attachment))
        {
            AttachmentItem _attachment = new AttachmentItem();
            _attachment = _item as AttachmentItem;
            if (_attachment._extraSlots == 1)
            {
                _itemCell._muzzleSlot.SetActive(true);
            }
            else if (_attachment._extraSlots == 2)
            {
                _itemCell._muzzleSlot.SetActive(true);
                _itemCell._gripSlot.SetActive(true);
            }
            else if (_attachment._extraSlots == 3)
            {
                _itemCell._muzzleSlot.SetActive(true);
                _itemCell._gripSlot.SetActive(true);
                _itemCell._sightSlot.SetActive(true);
            }
            else if (_attachment._extraSlots > 3 && _attachment._extraSlots <= 4)
            {
                _itemCell._sightSlot.SetActive(true);
                _itemCell._gripSlot.SetActive(true);
                _itemCell._muzzleSlot.SetActive(true);
                _itemCell._stockSlot.SetActive(true);
            }
            else
            {
                _itemCell._sightSlot.SetActive(false);
                _itemCell._gripSlot.SetActive(false);
                _itemCell._muzzleSlot.SetActive(false);
                _itemCell._stockSlot.SetActive(false);
            }
        }
    }

    public void MoveItemToInventory(int _index)
    {
        itemsOnGround.RemoveAt(_index);
        parentCellGround.transform.GetChild(_index).SetParent(parentCell);
    }

    public void MoveItemToGround(int _index)
    {
        item.RemoveAt(_index);
        parentCell.transform.GetChild(_index).SetParent(parentCellGround);
    }
    public void RemoveItem(Drag drag)
    {
        Item it = drag.item;
        Destroy(drag.gameObject);
    }

    public void DeleteItemOnGround(int _index)
    {
        itemsOnGround.RemoveAt(_index);
        Destroy(parentCellGround.GetChild(_index).gameObject);
    }

    public void DeleteInventoryItem(int _index)
    {
        item.RemoveAt(_index);
        Destroy(parentCell.GetChild(_index).gameObject);
    }
    void Start()
    {
        InventoryBase _inventory = GameObject.Find("Canvas").GetComponent<InventoryBase>();
        inventory = _inventory._inventoryCanvas.gameObject;
        parentCell = _inventory._parentCell;
        parentCellGround = _inventory._parentGround;
    }

    // Update is called once per frame
    void Update()
    {
        InventoryActive();
    }
}
