using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class craftingStation
{

    public Item[] itemArray;

    public craftingStation()
    {
        itemArray = new Item[3];
    }

    public bool isEmpty(int pos)
    {
        return itemArray[pos] == null;
    }

    public  Item getItem(int pos)
    {
        return itemArray[pos];
    }

    public void setItem(Item item, int pos)
    {
        itemArray[pos] = item;
    }

    public void moreOfItme(int pos)
    {
        getItem(pos)._amount++;
    }

    public void lessOfItme(int pos)
    {
        getItem(pos)._amount--;
    }

    public void removeItem(int pos)
    {
        setItem(null, pos);
    }
    public bool tryAddItem(Item item, int pos)
    {
        if(isEmpty(pos))
        {
            setItem(item, pos);
            return true;
        }
        else
        {
            return false;
        }

    }
}
