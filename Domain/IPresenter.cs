namespace Domain
{
    public interface IPresenter
    {
        IView View { get; set; }
        void TestMethod();
    }
}
