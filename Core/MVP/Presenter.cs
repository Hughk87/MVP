using MVP.Content;

namespace Core
{
    public abstract class Presenter<Model,Viewer> : IPresentable
        where Model : IModelable
        where Viewer : IViewable
    {
        protected Model? model;
        protected Viewer? viewer;
        public abstract void Bind(Model modelable);
        public abstract void Inject(Viewer viewable);
        public abstract void View();
    }
}