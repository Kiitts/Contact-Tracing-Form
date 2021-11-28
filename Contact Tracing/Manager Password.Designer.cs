
namespace Contact_Tracing
{
    partial class Manager_Password
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
            this.closeBtn = new System.Windows.Forms.Button();
            this.submitBtn = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.passwordNotCorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(257, 92);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(133, 92);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(75, 23);
            this.submitBtn.TabIndex = 1;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(92, 39);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.PlaceholderText = "Password";
            this.passwordInput.Size = new System.Drawing.Size(171, 23);
            this.passwordInput.TabIndex = 2;
            // 
            // passwordNotCorrect
            // 
            this.passwordNotCorrect.AutoSize = true;
            this.passwordNotCorrect.ForeColor = System.Drawing.Color.Red;
            this.passwordNotCorrect.Location = new System.Drawing.Point(122, 9);
            this.passwordNotCorrect.Name = "passwordNotCorrect";
            this.passwordNotCorrect.Size = new System.Drawing.Size(0, 15);
            this.passwordNotCorrect.TabIndex = 3;
            // 
            // Manager_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 127);
            this.ControlBox = false;
            this.Controls.Add(this.passwordNotCorrect);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.closeBtn);
            this.Name = "Manager_Password";
            this.Text = "Password Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Label passwordNotCorrect;
    }
}