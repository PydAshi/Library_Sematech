using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Reflection.Metadata.BlobBuilder;

namespace Library_Sematech
{
    public partial class frmAddSubscriber : Form
    {
        public frmAddSubscriber()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtSubsLastName = new TextBox();
            txtSubsFirstName = new TextBox();
            txtSubsPhoneNo = new TextBox();
            txtSubsCode = new TextBox();
            lblSubsCode = new Label();
            lblSubsFirstName = new Label();
            lblSubsLastName = new Label();
            lblSubsPhoneNo = new Label();
            dataGridView1 = new DataGridView();
            btnSaveSubs = new Button();
            btnShowSubs = new Button();
            btnClearSubs = new Button();
            btnExitSubs = new Button();
            ((ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtSubsLastName
            // 
            txtSubsLastName.Location = new Point(207, 195);
            txtSubsLastName.Name = "txtSubsLastName";
            txtSubsLastName.Size = new Size(211, 27);
            txtSubsLastName.TabIndex = 3;
            // 
            // txtSubsFirstName
            // 
            txtSubsFirstName.Location = new Point(207, 123);
            txtSubsFirstName.Name = "txtSubsFirstName";
            txtSubsFirstName.Size = new Size(211, 27);
            txtSubsFirstName.TabIndex = 2;
            // 
            // txtSubsPhoneNo
            // 
            txtSubsPhoneNo.Location = new Point(202, 282);
            txtSubsPhoneNo.Name = "txtSubsPhoneNo";
            txtSubsPhoneNo.Size = new Size(216, 27);
            txtSubsPhoneNo.TabIndex = 4;
            // 
            // txtSubsCode
            // 
            txtSubsCode.Location = new Point(207, 55);
            txtSubsCode.Name = "txtSubsCode";
            txtSubsCode.Size = new Size(125, 27);
            txtSubsCode.TabIndex = 1;
            txtSubsCode.KeyPress += txtSubsCode_KeyPress;
            // 
            // lblSubsCode
            // 
            lblSubsCode.AutoSize = true;
            lblSubsCode.Location = new Point(56, 62);
            lblSubsCode.Name = "lblSubsCode";
            lblSubsCode.Size = new Size(44, 20);
            lblSubsCode.TabIndex = 14;
            lblSubsCode.Text = "Code";
            // 
            // lblSubsFirstName
            // 
            lblSubsFirstName.AutoSize = true;
            lblSubsFirstName.Location = new Point(56, 130);
            lblSubsFirstName.Name = "lblSubsFirstName";
            lblSubsFirstName.Size = new Size(80, 20);
            lblSubsFirstName.TabIndex = 15;
            lblSubsFirstName.Text = "First Name";
            // 
            // lblSubsLastName
            // 
            lblSubsLastName.AutoSize = true;
            lblSubsLastName.Location = new Point(56, 202);
            lblSubsLastName.Name = "lblSubsLastName";
            lblSubsLastName.Size = new Size(79, 20);
            lblSubsLastName.TabIndex = 16;
            lblSubsLastName.Text = "Last Name";
            // 
            // lblSubsPhoneNo
            // 
            lblSubsPhoneNo.AutoSize = true;
            lblSubsPhoneNo.Location = new Point(61, 289);
            lblSubsPhoneNo.Name = "lblSubsPhoneNo";
            lblSubsPhoneNo.Size = new Size(74, 20);
            lblSubsPhoneNo.TabIndex = 17;
            lblSubsPhoneNo.Text = "Phone No";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 438);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 70;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(862, 234);
            dataGridView1.TabIndex = 18;
            // 
            // btnSaveSubs
            // 
            btnSaveSubs.Location = new Point(668, 12);
            btnSaveSubs.Name = "btnSaveSubs";
            btnSaveSubs.Size = new Size(133, 52);
            btnSaveSubs.TabIndex = 5;
            btnSaveSubs.Text = "Save";
            btnSaveSubs.UseVisualStyleBackColor = true;
            btnSaveSubs.Click += btnSaveSubs_Click;
            // 
            // btnShowSubs
            // 
            btnShowSubs.Location = new Point(668, 98);
            btnShowSubs.Name = "btnShowSubs";
            btnShowSubs.Size = new Size(133, 52);
            btnShowSubs.TabIndex = 6;
            btnShowSubs.Text = "Show";
            btnShowSubs.UseVisualStyleBackColor = true;
            btnShowSubs.Click += btnShowSubs_Click;
            // 
            // btnClearSubs
            // 
            btnClearSubs.Location = new Point(668, 202);
            btnClearSubs.Name = "btnClearSubs";
            btnClearSubs.Size = new Size(133, 52);
            btnClearSubs.TabIndex = 7;
            btnClearSubs.Text = "Clear";
            btnClearSubs.UseVisualStyleBackColor = true;
            btnClearSubs.Click += btnClearSubs_Click;
            // 
            // btnExitSubs
            // 
            btnExitSubs.Location = new Point(668, 313);
            btnExitSubs.Name = "btnExitSubs";
            btnExitSubs.Size = new Size(133, 52);
            btnExitSubs.TabIndex = 8;
            btnExitSubs.Text = "Exit";
            btnExitSubs.UseVisualStyleBackColor = true;
            btnExitSubs.Click += btnExitSubs_Click;
            // 
            // frmAddSubscriber
            // 
            ClientSize = new Size(862, 672);
            Controls.Add(dataGridView1);
            Controls.Add(lblSubsPhoneNo);
            Controls.Add(lblSubsLastName);
            Controls.Add(lblSubsFirstName);
            Controls.Add(lblSubsCode);
            Controls.Add(txtSubsCode);
            Controls.Add(txtSubsPhoneNo);
            Controls.Add(txtSubsFirstName);
            Controls.Add(txtSubsLastName);
            Controls.Add(btnExitSubs);
            Controls.Add(btnClearSubs);
            Controls.Add(btnShowSubs);
            Controls.Add(btnSaveSubs);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAddSubscriber";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add a subscriber";
            Load += frmAddSubscriber_Load;
            ((ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        List<Subscriber> Subscribers = new List<Subscriber>();



        private void frmAddSubscriber_Load(object sender, EventArgs e)
        {
            txtSubsCode.Focus();
        }

        private void btnSaveSubs_Click(object sender, EventArgs e)
        {
            Subscriber subscriber = new Subscriber(txtSubsCode.Text, txtSubsFirstName.Text, txtSubsLastName.Text, txtSubsPhoneNo.Text);
            Subscribers.Add(subscriber);

            MessageBox.Show("One subscriber has been added.");

            txtSubsCode.Text = string.Empty;
            txtSubsFirstName.Text = string.Empty;
            txtSubsLastName.Text = string.Empty;
            txtSubsPhoneNo.Text = string.Empty;

            txtSubsCode.Focus();


        }

        private void btnShowSubs_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Subscribers;
            dataGridView1.Refresh();

        }

        private void btnClearSubs_Click(object sender, EventArgs e)
        {

            txtSubsCode.Text = string.Empty;
            txtSubsFirstName.Text = string.Empty;
            txtSubsLastName.Text = string.Empty;
            txtSubsPhoneNo.Text = string.Empty;

        }

        private void btnExitSubs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSubsCode_KeyPress(object sender, KeyPressEventArgs e)
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
