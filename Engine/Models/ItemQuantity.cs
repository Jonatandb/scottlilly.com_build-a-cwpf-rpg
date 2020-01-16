// https://scottlilly.com/build-a-cwpf-rpg/lesson-06-1-creating-the-quest-factory/

namespace Engine.Models
{
    public class ItemQuantity
    {
        public int ItemId { get; set; }
        public int Quantity { get; set; }

        public ItemQuantity(int itemID, int quantity)
        {
            ItemId = itemID;
            Quantity = quantity;
        }
    }
}
