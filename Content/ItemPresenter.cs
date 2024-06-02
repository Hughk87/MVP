using Core;

namespace MVP.Content
{
    internal class ItemPresenter : Presenter
    {
        protected ItemModel? model;
        protected ItemViewer? viewer;
        public override void Bind(IModelable modelable)
        {
            if (modelable is ItemModel model)
                this.model = model;
        }
        public override void Inject(IDependencible dependencible)
        {
            if (dependencible is ItemViewer viewer)
                this.viewer = viewer;
        }
        public override void View()
        {
            viewer?.View(model);
        }
        public void Increase(int amount)
        {
            viewer?.View(model.Increase(amount));
        }
        public void Decrease(int amount)
        {
            viewer?.View(model.Decrease(amount));
        }
    }
}
