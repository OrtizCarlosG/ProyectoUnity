using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryField : MonoBehaviour
{
    public CharacterInventory characterInventory;

    private void Start()
    {
        characterInventory = this.gameObject.GetComponent<CharacterInventory>();
    }

    private void OnTriggerEnter(Collider other)
    { 
       // if (other.gameObject.GetComponent<Item>())
       // {
       //     characterInventory.itemsOnGround.Add(other.transform.GetComponent<Item>());
       //     characterInventory.itemsOnGroundUpdate();
       // }
    }

    private void OnTriggerExit(Collider other)
    {
       //if (other.gameObject.GetComponent<Item>())
       //{
       //    characterInventory.itemsOnGround.Remove(other.transform.GetComponent<Item>());
       //    characterInventory.itemsOnGroundUpdate();
       //}
    }
}
