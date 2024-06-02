using Core;

namespace MVP.Content
{
    public class Item : ViewData
    {
        public string name;
        public int amount;
        public Item(string name, int amount)
        {
            this.name = name;
            this.amount = amount;
        }
    }
    public class ItemModel : Model
    {
        Item item;

        public ItemModel(Item item)
        {
            this.item = item;
        }

        public ItemModel Increase(int amount)
        {
            item.amount += amount;
            return this;
        }
        public ItemModel Decrease(int amount)
        {
            item.amount -= amount;
            return this;
        }

        public Item GetData()
        {
            return item;
        }
    }
}
