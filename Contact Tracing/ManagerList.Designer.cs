
namespace Contact_Tracing
{
    partial class ManagerList
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
            this.outputSaveFile = new System.Windows.Forms.TextBox();
            this.dateList = new System.Windows.Forms.ListBox();
            this.dateShowBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputSaveFile
            // 
            this.outputSaveFile.Location = new System.Drawing.Point(12, 98);
            this.outputSaveFile.Multiline = true;
            this.outputSaveFile.Name = "outputSaveFile";
            this.outputSaveFile.ReadOnly = true;
            this.outputSaveFile.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputSaveFile.Size = new System.Drawing.Size(549, 452);
            this.outputSaveFile.TabIndex = 0;
            // 
            // dateList
            // 
            this.dateList.FormattingEnabled = true;
            this.dateList.ItemHeight = 15;
            this.dateList.Items.AddRange(new object[] {
            "All"});
            this.dateList.Location = new System.Drawing.Point(12, 42);
            this.dateList.Name = "dateList";
            this.dateList.Size = new System.Drawing.Size(153, 139);
            this.dateList.TabIndex = 1;
            this.dateList.Visible = false;
            this.dateList.SelectedIndexChanged += new System.EventHandler(this.dateList_SelectedIndexChanged);
            this.dateList.Leave += new System.EventHandler(this.dateList_Leave);
            // 
            // dateShowBtn
            // 
            this.dateShowBtn.Location = new System.Drawing.Point(13, 13);
            this.dateShowBtn.Name = "dateShowBtn";
            this.dateShowBtn.Size = new System.Drawing.Size(152, 23);
            this.dateShowBtn.TabIndex = 2;
            this.dateShowBtn.Text = "Select Date";
            this.dateShowBtn.UseVisualStyleBackColor = true;
            this.dateShowBtn.Click += new System.EventHandler(this.dateShowBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(486, 69);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(75, 23);
            this.refreshBtn.TabIndex = 3;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // ManagerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 562);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.dateShowBtn);
            this.Controls.Add(this.dateList);
            this.Controls.Add(this.outputSaveFile);
            this.Enabled = false;
            this.Name = "ManagerList";
            this.Text = "ManagerList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerList_FormClosing);
            this.Load += new System.EventHandler(this.ManagerList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox outputSaveFile;
        private System.Windows.Forms.ListBox dateList;
        private System.Windows.Forms.Button dateShowBtn;
        private System.Windows.Forms.Button refreshBtn;
    }
}