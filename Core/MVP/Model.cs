namespace Core
{
    public abstract class ViewData : IViewData
    {

    }

    public abstract class Model : IBindable, IModelable
    {
        public ViewData viewData;
    }
}