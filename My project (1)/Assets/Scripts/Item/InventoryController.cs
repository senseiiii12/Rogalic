using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryController : MonoBehaviour
{
    public static InventoryController Instance;
    public List<Item> items = new List<Item>();
    public Transform ItemContent;
    public GameObject InventoryItem;
    public ItemController[] inventoryItems;
    public GameObject inventoryPanel;

    private void Awake()
    {
        Instance = this;
    }
    public void Add(Item item)
    {
        items.Add(item);
    }
    public void Remove(Item item)
    {
        items.Remove(item);
    }

    public void clear()
    {
        foreach (Transform item in ItemContent)
        {
            Destroy(item.gameObject);
        }
    }
    public void ListItems()
    {
        
        foreach(Item item in items)
        {
            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<Text>();
            var itemIcon = obj.transform.Find("ItemImage").GetComponent<Image>();
            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }
        SetInventoryItems();
    }

    public void SetInventoryItems()
    {
        inventoryItems = ItemContent.GetComponentsInChildren<ItemController>();
        for (int i = 0; i < items.Count; i++)
        {
            inventoryItems[i].AddItem(items[i]);
        }
    }

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            if (!inventoryPanel.activeSelf)
            {
                inventoryPanel.SetActive(true);
                ListItems();
            }
            else
            {
                inventoryPanel.SetActive(false);
                clear();
            }
        }
    }
}
