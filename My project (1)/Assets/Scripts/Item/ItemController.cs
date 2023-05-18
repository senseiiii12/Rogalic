using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemController : MonoBehaviour
{
    public Item item;
    public Button remove;
    public static ItemController itemController;
    

    public void RemoveItem()
    {
        InventoryController.Instance.Remove(item);
        DropItem();
        Destroy(gameObject);
    }
    public void AddItem(Item newItem)
    {
        item = newItem;
    }
    public void UseItem()
    {
        switch (item.type)
        {
            case Item.ItemType.PotionHeal:
                PlayerStats.plStats.getHeal(item.value);
                RemoveItem();
                break;
            case Item.ItemType.PotionMana:
                PlayerStats.plStats.getMana(item.value);
                RemoveItem();
                break;
            case Item.ItemType.Weapon:
                PlayerStats.plStats.speed += item.value;
                RemoveItem();
                break;
        }
    }


    public void DropItem()
    {
            Vector3 point = (UnityEngine.Random.insideUnitSphere * 5) + PlayerStats.plStats.player.transform.position;
            Instantiate(item.prefab, point, Quaternion.Euler(new Vector3(0f, 0f, 0f)));
    }


   
}
