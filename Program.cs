using Core;
using MVP.Content;

internal class Program
{
    static void Main(string[] args)
    {

        ItemPresenter presenter = new ItemPresenter();

        ItemModel model = new ItemModel(new Item("체력포션", 1));
        presenter.Bind(model);

        ItemViewer viewer = new ItemViewer();
        presenter.Inject(viewer);


        presenter.View();
        presenter.Increase(1);
        presenter.Decrease(1);
    }
}
