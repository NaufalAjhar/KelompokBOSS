﻿using System.Collections.Generic;

namespace itemList
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
    }

    public class DiscoveryFeature
    {
        private List<Item> items;

        public DiscoveryFeature()
        {
            items = new List<Item>();
        }

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public List<Item> GetItems()
        {
            return items;
        }
    }
}
