
namespace Contact_Tracing
{
    partial class Form1
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
            this.ownerName = new System.Windows.Forms.Label();
            this.contactTF = new System.Windows.Forms.GroupBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.sicknessLbl = new System.Windows.Forms.Label();
            this.sicknessCheckBox = new System.Windows.Forms.CheckedListBox();
            this.inputEmail = new System.Windows.Forms.TextBox();
            this.emailLbl = new System.Windows.Forms.Label();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.numberLbl = new System.Windows.Forms.Label();
            this.inputAge = new System.Windows.Forms.TextBox();
            this.inputTemp = new System.Windows.Forms.TextBox();
            this.inputAddress = new System.Windows.Forms.TextBox();
            this.inputName = new System.Windows.Forms.TextBox();
            this.submitBtn = new System.Windows.Forms.Button();
            this.goesOutside = new System.Windows.Forms.GroupBox();
            this.goesOutsideWhere = new System.Windows.Forms.TextBox();
            this.goesOutsideNo = new System.Windows.Forms.RadioButton();
            this.goesOutsideYes = new System.Windows.Forms.RadioButton();
            this.genderBox = new System.Windows.Forms.GroupBox();
            this.femaleRadio = new System.Windows.Forms.RadioButton();
            this.maleRadio = new System.Windows.Forms.RadioButton();
            this.tempLbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.nameLbl = new System.Windows.Forms.Label();
            this.manage = new System.Windows.Forms.Button();
            this.contactTF.SuspendLayout();
            this.goesOutside.SuspendLayout();
            this.genderBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ownerName
            // 
            this.ownerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ownerName.AutoSize = true;
            this.ownerName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ownerName.Location = new System.Drawing.Point(135, 9);
            this.ownerName.Name = "ownerName";
            this.ownerName.Size = new System.Drawing.Size(282, 28);
            this.ownerName.TabIndex = 0;
            this.ownerName.Text = "Tindahan Ni Aling Nena";
            this.ownerName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contactTF
            // 
            this.contactTF.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactTF.Controls.Add(this.clearBtn);
            this.contactTF.Controls.Add(this.sicknessLbl);
            this.contactTF.Controls.Add(this.sicknessCheckBox);
            this.contactTF.Controls.Add(this.inputEmail);
            this.contactTF.Controls.Add(this.emailLbl);
            this.contactTF.Controls.Add(this.inputNumber);
            this.contactTF.Controls.Add(this.numberLbl);
            this.contactTF.Controls.Add(this.inputAge);
            this.contactTF.Controls.Add(this.inputTemp);
            this.contactTF.Controls.Add(this.inputAddress);
            this.contactTF.Controls.Add(this.inputName);
            this.contactTF.Controls.Add(this.submitBtn);
            this.contactTF.Controls.Add(this.goesOutside);
            this.contactTF.Controls.Add(this.genderBox);
            this.contactTF.Controls.Add(this.tempLbl);
            this.contactTF.Controls.Add(this.ageLbl);
            this.contactTF.Controls.Add(this.addressLbl);
            this.contactTF.Controls.Add(this.nameLbl);
            this.contactTF.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactTF.Location = new System.Drawing.Point(13, 40);
            this.contactTF.Name = "contactTF";
            this.contactTF.Size = new System.Drawing.Size(526, 493);
            this.contactTF.TabIndex = 1;
            this.contactTF.TabStop = false;
            this.contactTF.Text = "Contact Tracing From";
            // 
            // clearBtn
            // 
            this.clearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearBtn.Location = new System.Drawing.Point(6, 453);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(157, 33);
            this.clearBtn.TabIndex = 14;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // sicknessLbl
            // 
            this.sicknessLbl.AutoSize = true;
            this.sicknessLbl.Location = new System.Drawing.Point(7, 241);
            this.sicknessLbl.Name = "sicknessLbl";
            this.sicknessLbl.Size = new System.Drawing.Size(336, 22);
            this.sicknessLbl.TabIndex = 21;
            this.sicknessLbl.Text = "Are you feeling any of the following?";
            // 
            // sicknessCheckBox
            // 
            this.sicknessCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sicknessCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.sicknessCheckBox.CheckOnClick = true;
            this.sicknessCheckBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sicknessCheckBox.FormattingEnabled = true;
            this.sicknessCheckBox.Items.AddRange(new object[] {
            "Cough",
            "Fever",
            "Tiredness",
            "Loss of taste or smell",
            "Difficulty breathing",
            "Loss of speech or mobility",
            "Chest pain"});
            this.sicknessCheckBox.Location = new System.Drawing.Point(7, 266);
            this.sicknessCheckBox.Name = "sicknessCheckBox";
            this.sicknessCheckBox.Size = new System.Drawing.Size(512, 144);
            this.sicknessCheckBox.TabIndex = 10;
            // 
            // inputEmail
            // 
            this.inputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputEmail.Location = new System.Drawing.Point(320, 424);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.PlaceholderText = "Email Address Optional";
            this.inputEmail.Size = new System.Drawing.Size(200, 23);
            this.inputEmail.TabIndex = 12;
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLbl.Location = new System.Drawing.Point(264, 430);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(53, 17);
            this.emailLbl.TabIndex = 18;
            this.emailLbl.Text = "Email:";
            // 
            // inputNumber
            // 
            this.inputNumber.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputNumber.Location = new System.Drawing.Point(130, 424);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.PlaceholderText = "Phone Number";
            this.inputNumber.Size = new System.Drawing.Size(128, 23);
            this.inputNumber.TabIndex = 11;
            this.inputNumber.Click += new System.EventHandler(this.inputNumber_Click);
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberLbl.Location = new System.Drawing.Point(6, 430);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(121, 17);
            this.numberLbl.TabIndex = 16;
            this.numberLbl.Text = "Phone Number:";
            // 
            // inputAge
            // 
            this.inputAge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputAge.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputAge.Location = new System.Drawing.Point(445, 46);
            this.inputAge.Name = "inputAge";
            this.inputAge.PlaceholderText = "Age";
            this.inputAge.Size = new System.Drawing.Size(69, 23);
            this.inputAge.TabIndex = 2;
            this.inputAge.Click += new System.EventHandler(this.inputAge_Click);
            this.inputAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputAge_KeyPress);
            // 
            // inputTemp
            // 
            this.inputTemp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputTemp.Location = new System.Drawing.Point(56, 131);
            this.inputTemp.Name = "inputTemp";
            this.inputTemp.PlaceholderText = "Temp";
            this.inputTemp.Size = new System.Drawing.Size(60, 23);
            this.inputTemp.TabIndex = 4;
            this.inputTemp.Click += new System.EventHandler(this.inputTemp_Click);
            this.inputTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTemp_KeyPress);
            // 
            // inputAddress
            // 
            this.inputAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputAddress.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputAddress.Location = new System.Drawing.Point(86, 80);
            this.inputAddress.Name = "inputAddress";
            this.inputAddress.PlaceholderText = "Address";
            this.inputAddress.Size = new System.Drawing.Size(428, 23);
            this.inputAddress.TabIndex = 3;
            this.inputAddress.Click += new System.EventHandler(this.inputAddress_Click);
            // 
            // inputName
            // 
            this.inputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputName.Location = new System.Drawing.Point(86, 47);
            this.inputName.Name = "inputName";
            this.inputName.PlaceholderText = "Full Name";
            this.inputName.Size = new System.Drawing.Size(318, 23);
            this.inputName.TabIndex = 1;
            this.inputName.Click += new System.EventHandler(this.inputName_Click);
            // 
            // submitBtn
            // 
            this.submitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitBtn.Location = new System.Drawing.Point(362, 454);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(157, 33);
            this.submitBtn.TabIndex = 13;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // goesOutside
            // 
            this.goesOutside.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goesOutside.Controls.Add(this.goesOutsideWhere);
            this.goesOutside.Controls.Add(this.goesOutsideNo);
            this.goesOutside.Controls.Add(this.goesOutsideYes);
            this.goesOutside.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.goesOutside.Location = new System.Drawing.Point(224, 137);
            this.goesOutside.Name = "goesOutside";
            this.goesOutside.Size = new System.Drawing.Size(296, 96);
            this.goesOutside.TabIndex = 6;
            this.goesOutside.TabStop = false;
            this.goesOutside.Text = "Have you go outside of NCR? (within 14 days)";
            // 
            // goesOutsideWhere
            // 
            this.goesOutsideWhere.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.goesOutsideWhere.Enabled = false;
            this.goesOutsideWhere.Location = new System.Drawing.Point(66, 36);
            this.goesOutsideWhere.Name = "goesOutsideWhere";
            this.goesOutsideWhere.PlaceholderText = "Where?";
            this.goesOutsideWhere.Size = new System.Drawing.Size(224, 25);
            this.goesOutsideWhere.TabIndex = 9;
            this.goesOutsideWhere.Click += new System.EventHandler(this.goesOutsideWhere_Click);
            // 
            // goesOutsideNo
            // 
            this.goesOutsideNo.AutoSize = true;
            this.goesOutsideNo.Location = new System.Drawing.Point(7, 66);
            this.goesOutsideNo.Name = "goesOutsideNo";
            this.goesOutsideNo.Size = new System.Drawing.Size(46, 21);
            this.goesOutsideNo.TabIndex = 8;
            this.goesOutsideNo.TabStop = true;
            this.goesOutsideNo.Text = "No";
            this.goesOutsideNo.UseVisualStyleBackColor = true;
            this.goesOutsideNo.CheckedChanged += new System.EventHandler(this.goesOutsideNo_CheckedChanged);
            // 
            // goesOutsideYes
            // 
            this.goesOutsideYes.AutoSize = true;
            this.goesOutsideYes.Location = new System.Drawing.Point(7, 39);
            this.goesOutsideYes.Name = "goesOutsideYes";
            this.goesOutsideYes.Size = new System.Drawing.Size(52, 21);
            this.goesOutsideYes.TabIndex = 7;
            this.goesOutsideYes.TabStop = true;
            this.goesOutsideYes.Text = "Yes";
            this.goesOutsideYes.UseVisualStyleBackColor = true;
            this.goesOutsideYes.Click += new System.EventHandler(this.goesOutsideYes_Click);
            // 
            // genderBox
            // 
            this.genderBox.Controls.Add(this.femaleRadio);
            this.genderBox.Controls.Add(this.maleRadio);
            this.genderBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.genderBox.Location = new System.Drawing.Point(122, 137);
            this.genderBox.Name = "genderBox";
            this.genderBox.Size = new System.Drawing.Size(95, 81);
            this.genderBox.TabIndex = 5;
            this.genderBox.TabStop = false;
            this.genderBox.Text = "Gender:";
            // 
            // femaleRadio
            // 
            this.femaleRadio.AutoSize = true;
            this.femaleRadio.Location = new System.Drawing.Point(7, 52);
            this.femaleRadio.Name = "femaleRadio";
            this.femaleRadio.Size = new System.Drawing.Size(79, 21);
            this.femaleRadio.TabIndex = 6;
            this.femaleRadio.TabStop = true;
            this.femaleRadio.Text = "Female";
            this.femaleRadio.UseVisualStyleBackColor = true;
            this.femaleRadio.CheckedChanged += new System.EventHandler(this.femaleRadio_CheckedChanged);
            // 
            // maleRadio
            // 
            this.maleRadio.AutoSize = true;
            this.maleRadio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.maleRadio.Location = new System.Drawing.Point(7, 25);
            this.maleRadio.Name = "maleRadio";
            this.maleRadio.Size = new System.Drawing.Size(60, 21);
            this.maleRadio.TabIndex = 5;
            this.maleRadio.TabStop = true;
            this.maleRadio.Text = "Male";
            this.maleRadio.UseVisualStyleBackColor = true;
            this.maleRadio.CheckedChanged += new System.EventHandler(this.maleRadio_CheckedChanged);
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tempLbl.Location = new System.Drawing.Point(6, 137);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(53, 17);
            this.tempLbl.TabIndex = 4;
            this.tempLbl.Text = "Temp:";
            // 
            // ageLbl
            // 
            this.ageLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ageLbl.AutoSize = true;
            this.ageLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ageLbl.Location = new System.Drawing.Point(406, 47);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(42, 17);
            this.ageLbl.TabIndex = 2;
            this.ageLbl.Text = "Age:";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressLbl.Location = new System.Drawing.Point(12, 86);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(74, 17);
            this.addressLbl.TabIndex = 1;
            this.addressLbl.Text = "Address:";
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLbl.Location = new System.Drawing.Point(31, 54);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(55, 17);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name:";
            // 
            // manage
            // 
            this.manage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.manage.Location = new System.Drawing.Point(467, 5);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(72, 32);
            this.manage.TabIndex = 22;
            this.manage.Text = "Manage";
            this.manage.UseVisualStyleBackColor = true;
            this.manage.Click += new System.EventHandler(this.manage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(551, 545);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.contactTF);
            this.Controls.Add(this.ownerName);
            this.MinimumSize = new System.Drawing.Size(567, 584);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.contactTF.ResumeLayout(false);
            this.contactTF.PerformLayout();
            this.goesOutside.ResumeLayout(false);
            this.goesOutside.PerformLayout();
            this.genderBox.ResumeLayout(false);
            this.genderBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ownerName;
        private System.Windows.Forms.GroupBox contactTF;
        private System.Windows.Forms.GroupBox genderBox;
        private System.Windows.Forms.RadioButton femaleRadio;
        private System.Windows.Forms.RadioButton maleRadio;
        private System.Windows.Forms.Label tempLbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.GroupBox goesOutside;
        private System.Windows.Forms.TextBox goesOutsideWhere;
        private System.Windows.Forms.RadioButton goesOutsideNo;
        private System.Windows.Forms.RadioButton goesOutsideYes;
        private System.Windows.Forms.TextBox inputAge;
        private System.Windows.Forms.TextBox inputTemp;
        private System.Windows.Forms.TextBox inputAddress;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label numberLbl;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label sicknessLbl;
        private System.Windows.Forms.CheckedListBox sicknessCheckBox;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button manage;
    }
}

