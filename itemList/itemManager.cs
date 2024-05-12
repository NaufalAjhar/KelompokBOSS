using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itemList
{
    internal class ItemManager
    {
        private DiscoveryFeature discoveryFeature;

        public ItemManager(DiscoveryFeature discoveryFeature)
        {
            this.discoveryFeature = discoveryFeature;
        }

        public void AddItem()
        {
            discoveryFeature.AddItem(new Item { Id = 1, Name = "Item 1", Price = 10 });
            discoveryFeature.AddItem(new Item { Id = 2, Name = "Item 2", Price = 20 });
            discoveryFeature.AddItem(new Item { Id = 3, Name = "Item 3", Price = 30 });
        }
    }
}