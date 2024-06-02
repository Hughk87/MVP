namespace Core
{
    public abstract class Presenter<Model,Viewer> : IPresentable
        where Model : IModelable
        where Viewer : IViewable
    {
        protected Model? model;
        protected List<Viewer> viewers;

        public Presenter()
        {
            viewers = new List<Viewer>();
        }

        public abstract void Bind(Model modelable);
        public abstract void Regist(Viewer viewable);
        public abstract void Unregist(Viewer viewable);
        public abstract void View();
    }
}