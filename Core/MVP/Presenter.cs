namespace Core
{
    public abstract class Presenter : IPresentable, IInjectable
    {
        public abstract void Bind(IModelable modelable);
        public abstract void Inject(IDependencible dependencible);
        public abstract void View();
    }
}