namespace Core
{
    public abstract class Presenter : IPresentable, IInjectable
    {
        //protected Model? model;
        //protected Viewer? viewer;
        public abstract void Bind(IModelable modelable);
        public abstract void Inject(IDependencible dependencible);
        public abstract void View();
    }
}