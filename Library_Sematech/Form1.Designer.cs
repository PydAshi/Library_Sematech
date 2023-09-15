namespace Library_Sematech
{
    partial class frmMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddBook = new Button();
            btnAddSubscriber = new Button();
            SuspendLayout();
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(95, 140);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(213, 75);
            btnAddBook.TabIndex = 0;
            btnAddBook.Text = "Add a new book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnAddSubscriber
            // 
            btnAddSubscriber.Location = new Point(353, 140);
            btnAddSubscriber.Name = "btnAddSubscriber";
            btnAddSubscriber.Size = new Size(213, 75);
            btnAddSubscriber.TabIndex = 1;
            btnAddSubscriber.Text = "Add a new subscriber";
            btnAddSubscriber.UseVisualStyleBackColor = true;
            btnAddSubscriber.Click += btnAddSubscriber_Click;
            // 
            // frmMainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 386);
            Controls.Add(btnAddSubscriber);
            Controls.Add(btnAddBook);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddBook;
        private Button btnAddSubscriber;
    }
}