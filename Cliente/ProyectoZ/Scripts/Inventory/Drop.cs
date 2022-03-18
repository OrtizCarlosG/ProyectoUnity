using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drop : MonoBehaviour, IDropHandler
{

    public Drag drag;
    public string cellType;
    public Item _item;
    public Drag _dragParent;

    public void OnDrop(PointerEventData eventData)
    {
        drag = eventData.pointerDrag.GetComponent<Drag>();

        if (drag.old != drag.canvas)
        {
            if (cellType == "Inventory")
            {
                if (drag.typeList.Equals("Item Slot 1") || drag.typeList.Equals("Item Slot 2") || drag.typeList.Equals("Item Slot 3") || drag.typeList.Equals("Item Slot 4"))
                {
                    if (drag.old.GetComponent<Cell>()._gripDrop._dragParent.typeList.Equals("Inventory"))
                        ClientSend.RemoveAttachment(drag.old.GetComponent<Cell>()._gripDrop._item._id, drag.item._id, 0, 0);
                    else if (drag.old.GetComponent<Cell>()._gripDrop._dragParent.typeList.Equals("Ground"))
                        ClientSend.RemoveAttachment(drag.old.GetComponent<Cell>()._gripDrop._item._id, drag.item._id, 1, 1);
                }
                else
                    ClientSend.TakeItem(drag.item._id);
                drag.typeList = "Inventory";
            }
            else if (cellType == "Ground")
            {
                if (drag.typeList.Equals("Item Slot 1") || drag.typeList.Equals("Item Slot 2") || drag.typeList.Equals("Item Slot 3") || drag.typeList.Equals("Item Slot 4"))
                {
                    if (drag.old.GetComponent<Cell>()._gripDrop._dragParent.typeList.Equals("Inventory"))
                        ClientSend.RemoveAttachment(drag.old.GetComponent<Cell>()._gripDrop._item._id, drag.item._id, 1, 0);
                    else if (drag.old.GetComponent<Cell>()._gripDrop._dragParent.typeList.Equals("Ground"))
                        ClientSend.RemoveAttachment(drag.old.GetComponent<Cell>()._gripDrop._item._id, drag.item._id, 0, 1);
                 } else
                    ClientSend.DropItem(drag.item._id);
                drag.typeList = "Ground";
            } else if (cellType == "Primary")
            {
                drag.transform.SetParent(transform);
                drag.typeList = "Primary Weapon";
            } else if (cellType == "Secondary")
            {
                Debug.Log("Equiping Secondary weapon");
                drag.transform.SetParent(transform);
                drag.typeList = "Secondary Weapon";
            } else if (cellType.Equals("Item Slot 1") || cellType.Equals("Item Slot 2") || cellType.Equals("Item Slot 3") || cellType.Equals("Item Slot 4"))
            {
                if (drag.typeList.Equals("Ground") && _dragParent.typeList.Equals("Inventory"))
                    ClientSend.addAttachment(_item._id, drag.item._id, 1, 1);
                else if (drag.typeList.Equals("Inventory") && _dragParent.typeList.Equals("Inventory"))
                    ClientSend.addAttachment(_dragParent.item._id, drag.item._id, 0, 0);
                else if (drag.typeList.Equals("Inventory") && _dragParent.typeList.Equals("Ground"))
                    ClientSend.addAttachment(_dragParent.item._id, drag.item._id, 0, 1);
                else if (drag.typeList.Equals("Ground") && _dragParent.typeList.Equals("Ground"))
                    ClientSend.addAttachment(_dragParent.item._id, drag.item._id, 1, 0);
               // drag.typeList = "Item Slot 3";
            }
        }
    }
}
