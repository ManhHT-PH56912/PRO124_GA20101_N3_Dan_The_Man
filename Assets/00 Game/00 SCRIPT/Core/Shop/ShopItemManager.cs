using System.Collections.Generic;
using UnityEngine;
using HuynnLib;

public class ShopItemManager : Singleton<ShopItemManager>
{
    [SerializeField] List<ItemBase> _items = new();
    public List<ItemBase> items => _items;
    
}