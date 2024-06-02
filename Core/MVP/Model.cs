namespace Core
{
    public abstract class ViewData
    {

    }

    public abstract class Model : IModelable
    {
        public ViewData viewData;
    }
}