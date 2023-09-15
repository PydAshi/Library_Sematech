namespace Library_Sematech
{
    public partial class frmMainForm : Form
    {
        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {

            frmNewBook frmNewBook = new frmNewBook();
            frmNewBook.ShowDialog();

        }

        private void btnAddSubscriber_Click(object sender, EventArgs e)
        {
            frmAddSubscriber frmAddSubscriber = new frmAddSubscriber();

            frmAddSubscriber.ShowDialog();
        }
    }
}