namespace Core
{
    public abstract class Viewer : IViewable
    {
        public abstract void View(IModelable model);
    }
}