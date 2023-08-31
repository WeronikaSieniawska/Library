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
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.updatePassword = new System.Windows.Forms.TextBox();
            this.updateEmail = new System.Windows.Forms.TextBox();
            this.updateLastName = new System.Windows.Forms.TextBox();
            this.updateFirstName = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdate.Location = new System.Drawing.Point(160, 371);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(257, 42);
            this.buttonUpdate.TabIndex = 19;
            this.buttonUpdate.Text = "Update My Account Info";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // updatePassword
            // 
            this.updatePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updatePassword.Location = new System.Drawing.Point(160, 302);
            this.updatePassword.Name = "updatePassword";
            this.updatePassword.Size = new System.Drawing.Size(257, 30);
            this.updatePassword.TabIndex = 18;
            // 
            // updateEmail
            // 
            this.updateEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateEmail.Location = new System.Drawing.Point(160, 250);
            this.updateEmail.Name = "updateEmail";
            this.updateEmail.Size = new System.Drawing.Size(257, 30);
            this.updateEmail.TabIndex = 17;
            // 
            // updateLastName
            // 
            this.updateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateLastName.Location = new System.Drawing.Point(160, 197);
            this.updateLastName.Name = "updateLastName";
            this.updateLastName.Size = new System.Drawing.Size(257, 30);
            this.updateLastName.TabIndex = 16;
            // 
            // updateFirstName
            // 
            this.updateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.updateFirstName.Location = new System.Drawing.Point(160, 140);
            this.updateFirstName.Name = "updateFirstName";
            this.updateFirstName.Size = new System.Drawing.Size(257, 30);
            this.updateFirstName.TabIndex = 15;
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(18, 305);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(119, 25);
            this.password.TabIndex = 14;
            this.password.Text = "Password: ";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(59, 253);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(78, 25);
            this.email.TabIndex = 13;
            this.email.Text = "Email: ";
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(12, 197);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(125, 25);
            this.lastName.TabIndex = 12;
            this.lastName.Text = "Last name: ";
            // 
            // firstName
            // 
            this.firstName.AutoSize = true;
            this.firstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstName.Location = new System.Drawing.Point(11, 145);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(126, 25);
            this.firstName.TabIndex = 11;
            this.firstName.Text = "First name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(91, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Change Account Settings";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDelete.Location = new System.Drawing.Point(552, 371);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(188, 42);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Delete My Account";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.welcome.Location = new System.Drawing.Point(319, 28);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(203, 25);
            this.welcome.TabIndex = 22;
            this.welcome.Text = "Welcome username";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.updatePassword);
            this.Controls.Add(this.updateEmail);
            this.Controls.Add(this.updateLastName);
            this.Controls.Add(this.updateFirstName);
            this.Controls.Add(this.password);
            this.Controls.Add(this.email);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox updatePassword;
        private System.Windows.Forms.TextBox updateEmail;
        private System.Windows.Forms.TextBox updateLastName;
        private System.Windows.Forms.TextBox updateFirstName;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.Label firstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label welcome;
    }
}