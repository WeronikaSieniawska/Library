namespace Library
{
    partial class HomePage
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
            this.welcome = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.updateAccount = new System.Windows.Forms.Label();
            this.usersList = new System.Windows.Forms.Label();
            this.booksList = new System.Windows.Forms.Label();
            this.addBook = new System.Windows.Forms.Label();
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.transactionsList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcome.Location = new System.Drawing.Point(36, 32);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(203, 25);
            this.welcome.TabIndex = 31;
            this.welcome.Text = "Welcome username";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(573, 372);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(189, 45);
            this.buttonDelete.TabIndex = 32;
            this.buttonDelete.Text = "Delete My Account";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // updateAccount
            // 
            this.updateAccount.AutoSize = true;
            this.updateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateAccount.ForeColor = System.Drawing.SystemColors.Desktop;
            this.updateAccount.Location = new System.Drawing.Point(37, 111);
            this.updateAccount.Name = "updateAccount";
            this.updateAccount.Size = new System.Drawing.Size(241, 20);
            this.updateAccount.TabIndex = 33;
            this.updateAccount.Text = "-> Update Account Information.";
            this.updateAccount.Click += new System.EventHandler(this.updateAccount_Click);
            // 
            // usersList
            // 
            this.usersList.AutoSize = true;
            this.usersList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usersList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.usersList.Location = new System.Drawing.Point(37, 172);
            this.usersList.Name = "usersList";
            this.usersList.Size = new System.Drawing.Size(112, 20);
            this.usersList.TabIndex = 34;
            this.usersList.Text = "-> Users List.";
            this.usersList.Click += new System.EventHandler(this.usersList_Click);
            // 
            // booksList
            // 
            this.booksList.AutoSize = true;
            this.booksList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.booksList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.booksList.Location = new System.Drawing.Point(37, 292);
            this.booksList.Name = "booksList";
            this.booksList.Size = new System.Drawing.Size(114, 20);
            this.booksList.TabIndex = 35;
            this.booksList.Text = "-> Books List.";
            this.booksList.Click += new System.EventHandler(this.booksList_Click);
            // 
            // addBook
            // 
            this.addBook.AutoSize = true;
            this.addBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.addBook.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addBook.Location = new System.Drawing.Point(37, 236);
            this.addBook.Name = "addBook";
            this.addBook.Size = new System.Drawing.Size(144, 20);
            this.addBook.TabIndex = 36;
            this.addBook.Text = "-> Add New Book.";
            this.addBook.Click += new System.EventHandler(this.addBook_Click);
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSignOut.Location = new System.Drawing.Point(641, 24);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(121, 45);
            this.buttonSignOut.TabIndex = 37;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // transactionsList
            // 
            this.transactionsList.AutoSize = true;
            this.transactionsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.transactionsList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.transactionsList.Location = new System.Drawing.Point(37, 345);
            this.transactionsList.Name = "transactionsList";
            this.transactionsList.Size = new System.Drawing.Size(164, 20);
            this.transactionsList.TabIndex = 38;
            this.transactionsList.Text = "-> Transactions List.";
            this.transactionsList.Click += new System.EventHandler(this.transactionsList_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transactionsList);
            this.Controls.Add(this.buttonSignOut);
            this.Controls.Add(this.addBook);
            this.Controls.Add(this.booksList);
            this.Controls.Add(this.usersList);
            this.Controls.Add(this.updateAccount);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.welcome);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label updateAccount;
        private System.Windows.Forms.Label usersList;
        private System.Windows.Forms.Label booksList;
        private System.Windows.Forms.Label addBook;
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.Label transactionsList;
    }
}