using BOSSAPP;
using itemList;
using System.Collections.Generic;

namespace itemList
{
    public class ItemManager
    {
        private DiscoveryFeature discoveryFeature;
        private Discovery discoveryForm;

        public ItemManager(DiscoveryFeature discoveryFeature, Discovery discoveryForm)
        {
            this.discoveryFeature = discoveryFeature;
            this.discoveryForm = discoveryForm;
        }

        public void AddItem()
        {
            var item1 = new Item { Id = 1, Name = "Item 1", Price = 10 };
            discoveryFeature.AddItem(item1);
            discoveryForm.AddItemToListView(item1);

            var item2 = new Item { Id = 2, Name = "Item 2", Price = 20 };
            discoveryFeature.AddItem(item2);
            discoveryForm.AddItemToListView(item2);

            var item3 = new Item { Id = 3, Name = "Item 3", Price = 30 };
            discoveryFeature.AddItem(item3);
            discoveryForm.AddItemToListView(item3);

            var item4 = new Item { Id = 4, Name = "Item 4", Price = 40 };
            discoveryFeature.AddItem(item4);
            discoveryForm.AddItemToListView(item4);
        }
    }


}
