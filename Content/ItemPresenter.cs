using Core;

namespace MVP.Content
{
    internal class ItemPresenter : Presenter<ItemModel, ItemViewer>
    {
        public override void Bind(ItemModel model)
        {
            this.model = model;
        }
        public override void Regist(ItemViewer viewer)
        {
            viewers.Add(viewer);
        }
        public override void Unregist(ItemViewer viewer)
        {
            viewers.Remove(viewer);
        }
        public override void View()
        {
            foreach(var viewer in viewers)
                viewer.View(model);
        }
        public void Increase(int amount)
        {
            model.Increase(amount);
            View();
        }
        public void Decrease(int amount)
        {
            model.Decrease(amount);
            View();
        }
    }
}
