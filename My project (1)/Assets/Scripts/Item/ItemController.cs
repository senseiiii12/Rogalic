using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public Item item;
    public Button remove;
    

    public void RemoveItem()
    {
        InventoryController.Instance.Remove(item);
        Destroy(gameObject);
    }
    public void AddItem(Item newItem)
    {
        item = newItem;
    }
    public void UseItem()
    {

    }



    void Start()
    {
        
    }   
    void Update()
    {
        
    }
}
