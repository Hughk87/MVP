namespace Core
{
    public abstract class ViewData : IViewData
    {
        //public abstract void Print();
    }

    public abstract class Model : IBindable, IModelable
    {
        public ViewData viewData;
        //public abstract ViewData GetData();
    }
}