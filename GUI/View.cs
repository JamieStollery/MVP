using Domain;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class View : Form, IView
    {
        private IPresenter _presenter;

        public View(IPresenter presenter)
        {
            _presenter = presenter;
            InitializeComponent();
        }

        public string TestProperty { set => lblTest.Text = value; }

        private void View_Load(object sender, EventArgs e)
        {
            _presenter.TestMethod();
        }
    }
}
