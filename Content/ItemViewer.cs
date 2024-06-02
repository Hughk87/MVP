using Core;

namespace MVP.Content
{
    internal class ItemViewer : Viewer
    {
        public override void View(IModelable model)
        {
            if (model is ItemModel)
                View((ItemModel)model);
        }
        private void View(ItemModel model)
        {
            Item item = model.GetData();
            Console.WriteLine($"name : {item.name} / amount : {item.amount}");
        }
    }
}
