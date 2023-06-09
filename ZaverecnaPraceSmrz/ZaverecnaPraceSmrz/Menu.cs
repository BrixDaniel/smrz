namespace ZaverecnaPraceSmrz
{
    using ZaverecnaPraceBaseDLL;
    public partial class Menu : Form, IGameForm
    {
        IMainForm mainForm = new FakeForm();

        public Menu()
        {
            InitializeComponent();
        }

        public Form InitForm(IMainForm mainForm)
        {
            this.mainForm = mainForm;
            return this;
        }

        public void StartGame()
        {
            this.ShowDialog();
        }

        public void EndGame()
        {
            mainForm.SendData('B');
        }

        public void Restart()
        {
            //Mùže být prázdný
        }
    }
}