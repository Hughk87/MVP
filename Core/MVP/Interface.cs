namespace Core
{
    public interface IPresentable
    {
        public void View();
    }
    public interface IViewable
    {
        public void View(IModelable model);
    }
    public interface IModelable
    {

    }
}
