using Data;

namespace Domain
{
    public class Presenter : IPresenter
    {
        public IView View { get; set; }
        private IRepository _repository;

        public Presenter(IRepository repository)
        {
            _repository = repository;
        }

        public void TestMethod()
        {
            View.TestProperty = _repository.TestMethod();
        }
    }
}
