using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class InventorySlot 
{

    [SerializeField] private InventoryItemData itemData;
    [SerializeField] private int stackSize;

    public InventoryItemData ItemData => itemData;

    public int StackSize => stackSize;

    public InventorySlot(InventoryItemData source, int amount)
    {
        itemData = source;
        stackSize = amount;
    
    }

    public InventorySlot()
    {
        ClearSlot();    
    }

    public void ClearSlot()
    {
        itemData = null;
        stackSize = -1;
    }

    public bool RoomLeftInStack(int amoutToAdd, out int amountRemaining)
    {
        amountRemaining = ItemData.MaxStackSize - stackSize;

        return RoomLeftStack(amoutToAdd);
    }

    public bool RoomLeftStack(int amoutToAdd)
    {
        if (stackSize + amoutToAdd <= itemData.MaxStackSize) return true;
        else return false;
    }
    

    public void AddToStack(int amout)
    {
        stackSize += amout;
    }

    public void RemoveFromStack(int amout)
    {
        stackSize -= amout;
    }
}
