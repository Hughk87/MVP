namespace Core
{
    public interface IDependencible
    {

    }

    public interface IInjectable
    {
        public void Inject(IDependencible dependencible);
    }

    public interface IPresentable
    {
        public void View();
    }
    public interface IViewable
    {
        public void View(IModelable model);
    }
    public interface IBindable
    {

    }
    public interface  IModelable
    {
        
    }
    public interface IViewData
    {
        //public void Print();
    }
}
