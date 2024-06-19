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
            var semen = new Item { Id = 1, Name = "Semen", Price = 100000 };
            discoveryFeature.AddItem(semen);
            discoveryForm.AddItemToListView(semen);

            var bata = new Item { Id = 2, Name = "Bata", Price = 50000 };
            discoveryFeature.AddItem(bata);
            discoveryForm.AddItemToListView(bata);

            var kayu = new Item { Id = 3, Name = "Kayu", Price = 300000 };
            discoveryFeature.AddItem(kayu);
            discoveryForm.AddItemToListView(kayu);

            var besi = new Item { Id = 4, Name = "Besi Beton", Price = 250000 };
            discoveryFeature.AddItem(besi);
            discoveryForm.AddItemToListView(besi);
        }
    }


}
