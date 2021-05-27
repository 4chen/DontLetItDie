using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ui_inventory : MonoBehaviour
{
    private craftingRecepise _inventory;
    public Transform _itemSlotContainer;
    public Transform _itemSlotTemplate;

    private void Awake()
    {
        _itemSlotContainer = transform;
        _itemSlotTemplate = _itemSlotContainer.Find("Slot");
        RefreshInventory();
    }

    public void SetInventory(craftingRecepise inventory)
    {
        this._inventory = inventory;
    }

    private void RefreshInventory()
    {
        int y = 0;
        float itemSlotCount = 32f;

        foreach (Item item in _inventory.GetItemList())
        {
            RectTransform itemSlotRT = Instantiate(_itemSlotTemplate, _itemSlotContainer).GetComponent<RectTransform>();
            itemSlotRT.gameObject.SetActive(true);
            Image image = _itemSlotTemplate.GetComponent<Image>();
            itemSlotRT.anchoredPosition = new Vector2(itemSlotRT.anchoredPosition.x, y * itemSlotCount - 22);
            image.sprite = item.GetSprite();
            y--;
        }
        
    }
}
