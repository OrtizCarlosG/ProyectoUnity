using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ItemsDatabase : MonoBehaviour
{

    public Items _items;
    private static ItemsDatabase instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }


    public static ItemDB getItemByID(int _id)
    {
        return instance._items._items.FirstOrDefault(i => i._itemID == _id);
    }

}
