namespace RenameAllFilesOnce
{
    partial class Main
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
            this.cmdRename = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTypeFrom = new System.Windows.Forms.ComboBox();
            this.cmbTypeTo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmdRename
            // 
            this.cmdRename.Location = new System.Drawing.Point(12, 46);
            this.cmdRename.Name = "cmdRename";
            this.cmdRename.Size = new System.Drawing.Size(317, 28);
            this.cmdRename.TabIndex = 0;
            this.cmdRename.Text = "Rename All ";
            this.cmdRename.UseVisualStyleBackColor = true;
            this.cmdRename.Click += new System.EventHandler(this.cmdRename_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "From Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Type";
            // 
            // cmbTypeFrom
            // 
            this.cmbTypeFrom.FormattingEnabled = true;
            this.cmbTypeFrom.Items.AddRange(new object[] {
            "*.JPG",
            "*.JPGE",
            "*.txt",
            "*.doc",
            "*.docx",
            "*.avi",
            "*.mpge",
            "*.mkv",
            "*.pdf",
            "*.mp3",
            "*.mp4"});
            this.cmbTypeFrom.Location = new System.Drawing.Point(67, 12);
            this.cmbTypeFrom.Name = "cmbTypeFrom";
            this.cmbTypeFrom.Size = new System.Drawing.Size(91, 21);
            this.cmbTypeFrom.TabIndex = 5;
            // 
            // cmbTypeTo
            // 
            this.cmbTypeTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeTo.FormattingEnabled = true;
            this.cmbTypeTo.Items.AddRange(new object[] {
            "*.JPG",
            "*.JPGE",
            "*.txt",
            "*.doc",
            "*.docx",
            "*.avi",
            "*.mpge",
            "*.mkv",
            "*.pdf",
            "*.mp3",
            "*.mp4"});
            this.cmbTypeTo.Location = new System.Drawing.Point(228, 12);
            this.cmbTypeTo.Name = "cmbTypeTo";
            this.cmbTypeTo.Size = new System.Drawing.Size(89, 21);
            this.cmbTypeTo.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ABEy";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 94);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTypeTo);
            this.Controls.Add(this.cmbTypeFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdRename);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main (Drifking8887@gmail.com)";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTypeFrom;
        private System.Windows.Forms.ComboBox cmbTypeTo;
        private System.Windows.Forms.Label label3;

    }
}