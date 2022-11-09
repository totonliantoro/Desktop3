namespace Assessment3_Toton
{
    partial class FrmMain
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
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.formOneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formTwoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formThreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.help = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.help});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 28);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formOneToolStripMenuItem,
            this.formTwoToolStripMenuItem,
            this.formThreeToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(46, 24);
            this.menuFile.Text = "File";
            // 
            // formOneToolStripMenuItem
            // 
            this.formOneToolStripMenuItem.Name = "formOneToolStripMenuItem";
            this.formOneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.formOneToolStripMenuItem.Text = "Form One";
            this.formOneToolStripMenuItem.Click += new System.EventHandler(this.formOneToolStripMenuItem_Click);
            // 
            // formTwoToolStripMenuItem
            // 
            this.formTwoToolStripMenuItem.Name = "formTwoToolStripMenuItem";
            this.formTwoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.formTwoToolStripMenuItem.Text = "Form Two";
            this.formTwoToolStripMenuItem.Click += new System.EventHandler(this.formTwoToolStripMenuItem_Click);
            // 
            // formThreeToolStripMenuItem
            // 
            this.formThreeToolStripMenuItem.Name = "formThreeToolStripMenuItem";
            this.formThreeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.formThreeToolStripMenuItem.Text = "Form Three";
            this.formThreeToolStripMenuItem.Click += new System.EventHandler(this.formThreeToolStripMenuItem_Click);
            // 
            // help
            // 
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(55, 24);
            this.help.Text = "Help";
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(601, 407);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 38);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(195, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 61);
            this.label1.TabIndex = 5;
            this.label1.Text = "Go to file menu to access other forms.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(195, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(474, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "This application is for complying Assessment 3. ";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 457);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assessment3";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem help;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ToolStripMenuItem formOneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formTwoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formThreeToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

