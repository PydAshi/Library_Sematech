namespace Library_Sematech
{
    partial class frmNewBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSaveBook = new Button();
            btnShowBook = new Button();
            btnClearBook = new Button();
            btnExitBook = new Button();
            lblBookCode = new Label();
            lblBookName = new Label();
            lblBookAuthor = new Label();
            lblBookDesc = new Label();
            txtBookCode = new TextBox();
            txtBookName = new TextBox();
            txtBookAuthor = new TextBox();
            txtBookDesc = new TextBox();
            chkIfExists = new CheckBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnSaveBook
            // 
            btnSaveBook.Location = new Point(668, 12);
            btnSaveBook.Name = "btnSaveBook";
            btnSaveBook.Size = new Size(133, 52);
            btnSaveBook.TabIndex = 6;
            btnSaveBook.Text = "Save";
            btnSaveBook.UseVisualStyleBackColor = true;
            btnSaveBook.Click += button1_Click;
            // 
            // btnShowBook
            // 
            btnShowBook.Location = new Point(668, 98);
            btnShowBook.Name = "btnShowBook";
            btnShowBook.Size = new Size(133, 52);
            btnShowBook.TabIndex = 7;
            btnShowBook.Text = "Show";
            btnShowBook.UseVisualStyleBackColor = true;
            btnShowBook.Click += btnShow_Click;
            // 
            // btnClearBook
            // 
            btnClearBook.Location = new Point(668, 202);
            btnClearBook.Name = "btnClearBook";
            btnClearBook.Size = new Size(133, 52);
            btnClearBook.TabIndex = 8;
            btnClearBook.Text = "Clear";
            btnClearBook.UseVisualStyleBackColor = true;
            btnClearBook.Click += btnClear_Click;
            // 
            // btnExitBook
            // 
            btnExitBook.Location = new Point(668, 313);
            btnExitBook.Name = "btnExitBook";
            btnExitBook.Size = new Size(133, 52);
            btnExitBook.TabIndex = 9;
            btnExitBook.Text = "Exit";
            btnExitBook.UseVisualStyleBackColor = true;
            btnExitBook.Click += btnExit_Click;
            // 
            // lblBookCode
            // 
            lblBookCode.AutoSize = true;
            lblBookCode.Location = new Point(56, 62);
            lblBookCode.Name = "lblBookCode";
            lblBookCode.Size = new Size(44, 20);
            lblBookCode.TabIndex = 4;
            lblBookCode.Text = "Code";
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(56, 130);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(49, 20);
            lblBookName.TabIndex = 5;
            lblBookName.Text = "Name";
            // 
            // lblBookAuthor
            // 
            lblBookAuthor.AutoSize = true;
            lblBookAuthor.Location = new Point(56, 202);
            lblBookAuthor.Name = "lblBookAuthor";
            lblBookAuthor.Size = new Size(54, 20);
            lblBookAuthor.TabIndex = 6;
            lblBookAuthor.Text = "Author";
            // 
            // lblBookDesc
            // 
            lblBookDesc.AutoSize = true;
            lblBookDesc.Location = new Point(56, 302);
            lblBookDesc.Name = "lblBookDesc";
            lblBookDesc.Size = new Size(85, 20);
            lblBookDesc.TabIndex = 7;
            lblBookDesc.Text = "Description";
            // 
            // txtBookCode
            // 
            txtBookCode.Location = new Point(207, 55);
            txtBookCode.Name = "txtBookCode";
            txtBookCode.Size = new Size(125, 27);
            txtBookCode.TabIndex = 1;
            txtBookCode.KeyPress += txtBookCode_KeyPress;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(207, 123);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(211, 27);
            txtBookName.TabIndex = 2;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(207, 195);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(211, 27);
            txtBookAuthor.TabIndex = 3;
            // 
            // txtBookDesc
            // 
            txtBookDesc.Location = new Point(207, 273);
            txtBookDesc.Multiline = true;
            txtBookDesc.Name = "txtBookDesc";
            txtBookDesc.Size = new Size(371, 49);
            txtBookDesc.TabIndex = 4;
            // 
            // chkIfExists
            // 
            chkIfExists.AutoSize = true;
            chkIfExists.Location = new Point(56, 373);
            chkIfExists.Name = "chkIfExists";
            chkIfExists.Size = new Size(67, 24);
            chkIfExists.TabIndex = 5;
            chkIfExists.Text = "Exists";
            chkIfExists.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 438);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(862, 234);
            dataGridView1.TabIndex = 14;
            // 
            // frmNewBook
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 672);
            Controls.Add(dataGridView1);
            Controls.Add(chkIfExists);
            Controls.Add(txtBookDesc);
            Controls.Add(txtBookAuthor);
            Controls.Add(txtBookName);
            Controls.Add(txtBookCode);
            Controls.Add(lblBookDesc);
            Controls.Add(lblBookAuthor);
            Controls.Add(lblBookName);
            Controls.Add(lblBookCode);
            Controls.Add(btnExitBook);
            Controls.Add(btnClearBook);
            Controls.Add(btnShowBook);
            Controls.Add(btnSaveBook);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmNewBook";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Book";
            Load += frmNewBook_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSaveBook;
        private Button btnShowBook;
        private Button btnClearBook;
        private Button btnExitBook;
        private Label lblBookCode;
        private Label lblBookName;
        private Label lblBookAuthor;
        private Label lblBookDesc;
        private TextBox txtBookCode;
        private TextBox txtBookName;
        private TextBox txtBookAuthor;
        private TextBox txtBookDesc;
        private CheckBox chkIfExists;
        private DataGridView dataGridView1;
    }
}