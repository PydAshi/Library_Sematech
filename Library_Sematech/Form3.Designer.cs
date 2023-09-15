namespace Library_Sematech
{
    partial class frmAddSubscriber
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

        private TextBox txtSubsLastName;
        private TextBox txtSubsFirstName;
        private TextBox txtSubsPhoneNo;
        private TextBox txtSubsCode;
        private Label lblSubsCode;
        private Label lblSubsFirstName;
        private Label lblSubsLastName;
        private Label lblSubsPhoneNo;
        private DataGridView dataGridView1;
        private Button btnSaveSubs;
        private Button btnShowSubs;
        private Button btnClearSubs;
        private Button btnExitSubs;
    }
}