namespace Core
{
    public abstract class Viewer : IViewable, IDependencible
    {
        public abstract void View(IModelable model);
    }
}