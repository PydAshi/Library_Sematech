using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Sematech
{
    public partial class frmNewBook : Form
    {
        public frmNewBook()
        {
            InitializeComponent();

        }


        List<Book> books = new List<Book>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book(txtBookCode.Text, txtBookName.Text, txtBookAuthor.Text, txtBookDesc.Text, chkIfExists.Checked);
                books.Add(book);


                MessageBox.Show("One book has been added.");

                txtBookCode.Text = string.Empty;
                txtBookName.Text = string.Empty;
                txtBookAuthor.Text = string.Empty;
                txtBookDesc.Text = string.Empty;

                txtBookCode.Focus();
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = books;
            dataGridView1.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBookCode.Text = string.Empty;
            txtBookName.Text = string.Empty;
            txtBookAuthor.Text = string.Empty;
            txtBookDesc.Text = string.Empty;
        }

 

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewBook_Load(object sender, EventArgs e)
        {
            txtBookCode.Focus();
        }

        private void txtBookCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            bool IsDigit;
            IsDigit = General.ValidateNumericTextBox(ch);

            if (IsDigit == false)
            {
                MessageBox.Show("Only numeric value is allowed !");
                e.Handled = true;
            }
        }
    }
}
