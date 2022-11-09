namespace Assessment3_Toton
{
    partial class FrmThree
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
            this.lstCurrentData = new System.Windows.Forms.ListBox();
            this.lstSortedData = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.lblOriginalData = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstCurrentData
            // 
            this.lstCurrentData.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lstCurrentData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCurrentData.FormattingEnabled = true;
            this.lstCurrentData.ItemHeight = 18;
            this.lstCurrentData.Location = new System.Drawing.Point(172, 130);
            this.lstCurrentData.Name = "lstCurrentData";
            this.lstCurrentData.Size = new System.Drawing.Size(140, 238);
            this.lstCurrentData.TabIndex = 0;
            // 
            // lstSortedData
            // 
            this.lstSortedData.BackColor = System.Drawing.SystemColors.Info;
            this.lstSortedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSortedData.FormattingEnabled = true;
            this.lstSortedData.ItemHeight = 18;
            this.lstSortedData.Location = new System.Drawing.Point(409, 130);
            this.lstSortedData.Name = "lstSortedData";
            this.lstSortedData.Size = new System.Drawing.Size(138, 238);
            this.lstSortedData.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnExit.Location = new System.Drawing.Point(604, 432);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(126, 35);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Close";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnUpload.Location = new System.Drawing.Point(172, 432);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(111, 35);
            this.btnUpload.TabIndex = 5;
            this.btnUpload.Text = "Upload Data";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // lblOriginalData
            // 
            this.lblOriginalData.AutoSize = true;
            this.lblOriginalData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalData.Location = new System.Drawing.Point(172, 101);
            this.lblOriginalData.Name = "lblOriginalData";
            this.lblOriginalData.Size = new System.Drawing.Size(184, 23);
            this.lblOriginalData.TabIndex = 6;
            this.lblOriginalData.Text = "Original Input Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sorted Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(256, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Comparator - IComparable";
            // 
            // FrmThree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 545);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOriginalData);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lstSortedData);
            this.Controls.Add(this.lstCurrentData);
            this.Name = "FrmThree";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comparable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCurrentData;
        private System.Windows.Forms.ListBox lstSortedData;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label lblOriginalData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}