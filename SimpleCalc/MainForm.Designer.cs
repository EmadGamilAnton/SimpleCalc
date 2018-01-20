namespace SimpleCalc
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationTXT = new System.Windows.Forms.TextBox();
            this.oneBTN = new System.Windows.Forms.Button();
            this.twoBTN = new System.Windows.Forms.Button();
            this.threeBTN = new System.Windows.Forms.Button();
            this.sumBTN = new System.Windows.Forms.Button();
            this.subBTN = new System.Windows.Forms.Button();
            this.sixBTN = new System.Windows.Forms.Button();
            this.fiveBTN = new System.Windows.Forms.Button();
            this.fourBTN = new System.Windows.Forms.Button();
            this.mulBTN = new System.Windows.Forms.Button();
            this.nineBTN = new System.Windows.Forms.Button();
            this.eightBTN = new System.Windows.Forms.Button();
            this.sevenBTN = new System.Windows.Forms.Button();
            this.divBTN = new System.Windows.Forms.Button();
            this.equalBTN = new System.Windows.Forms.Button();
            this.zeroBTN = new System.Windows.Forms.Button();
            this.dotBTN = new System.Windows.Forms.Button();
            this.resultBTN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // operationTXT
            // 
            this.operationTXT.Location = new System.Drawing.Point(12, 31);
            this.operationTXT.Multiline = true;
            this.operationTXT.Name = "operationTXT";
            this.operationTXT.ReadOnly = true;
            this.operationTXT.Size = new System.Drawing.Size(386, 57);
            this.operationTXT.TabIndex = 1;
            // 
            // oneBTN
            // 
            this.oneBTN.Location = new System.Drawing.Point(13, 116);
            this.oneBTN.Name = "oneBTN";
            this.oneBTN.Size = new System.Drawing.Size(50, 45);
            this.oneBTN.TabIndex = 2;
            this.oneBTN.Text = "1";
            this.oneBTN.UseVisualStyleBackColor = true;
            this.oneBTN.Click += new System.EventHandler(this.oneBTN_Click);
            // 
            // twoBTN
            // 
            this.twoBTN.Location = new System.Drawing.Point(69, 116);
            this.twoBTN.Name = "twoBTN";
            this.twoBTN.Size = new System.Drawing.Size(50, 45);
            this.twoBTN.TabIndex = 3;
            this.twoBTN.Text = "2";
            this.twoBTN.UseVisualStyleBackColor = true;
            this.twoBTN.Click += new System.EventHandler(this.twoBTN_Click);
            // 
            // threeBTN
            // 
            this.threeBTN.Location = new System.Drawing.Point(125, 116);
            this.threeBTN.Name = "threeBTN";
            this.threeBTN.Size = new System.Drawing.Size(50, 45);
            this.threeBTN.TabIndex = 4;
            this.threeBTN.Text = "3";
            this.threeBTN.UseVisualStyleBackColor = true;
            this.threeBTN.Click += new System.EventHandler(this.threeBTN_Click);
            // 
            // sumBTN
            // 
            this.sumBTN.Location = new System.Drawing.Point(181, 116);
            this.sumBTN.Name = "sumBTN";
            this.sumBTN.Size = new System.Drawing.Size(50, 45);
            this.sumBTN.TabIndex = 5;
            this.sumBTN.Text = "+";
            this.sumBTN.UseVisualStyleBackColor = true;
            this.sumBTN.Click += new System.EventHandler(this.sumBTN_Click);
            // 
            // subBTN
            // 
            this.subBTN.Location = new System.Drawing.Point(181, 167);
            this.subBTN.Name = "subBTN";
            this.subBTN.Size = new System.Drawing.Size(50, 45);
            this.subBTN.TabIndex = 9;
            this.subBTN.Text = "-";
            this.subBTN.UseVisualStyleBackColor = true;
            this.subBTN.Click += new System.EventHandler(this.subBTN_Click);
            // 
            // sixBTN
            // 
            this.sixBTN.Location = new System.Drawing.Point(125, 167);
            this.sixBTN.Name = "sixBTN";
            this.sixBTN.Size = new System.Drawing.Size(50, 45);
            this.sixBTN.TabIndex = 8;
            this.sixBTN.Text = "6";
            this.sixBTN.UseVisualStyleBackColor = true;
            this.sixBTN.Click += new System.EventHandler(this.sixBTN_Click);
            // 
            // fiveBTN
            // 
            this.fiveBTN.Location = new System.Drawing.Point(69, 167);
            this.fiveBTN.Name = "fiveBTN";
            this.fiveBTN.Size = new System.Drawing.Size(50, 45);
            this.fiveBTN.TabIndex = 7;
            this.fiveBTN.Text = "5";
            this.fiveBTN.UseVisualStyleBackColor = true;
            this.fiveBTN.Click += new System.EventHandler(this.fiveBTN_Click);
            // 
            // fourBTN
            // 
            this.fourBTN.Location = new System.Drawing.Point(13, 167);
            this.fourBTN.Name = "fourBTN";
            this.fourBTN.Size = new System.Drawing.Size(50, 45);
            this.fourBTN.TabIndex = 6;
            this.fourBTN.Text = "4";
            this.fourBTN.UseVisualStyleBackColor = true;
            this.fourBTN.Click += new System.EventHandler(this.fourBTN_Click);
            // 
            // mulBTN
            // 
            this.mulBTN.Location = new System.Drawing.Point(181, 218);
            this.mulBTN.Name = "mulBTN";
            this.mulBTN.Size = new System.Drawing.Size(50, 45);
            this.mulBTN.TabIndex = 13;
            this.mulBTN.Text = "*";
            this.mulBTN.UseVisualStyleBackColor = true;
            this.mulBTN.Click += new System.EventHandler(this.mulBTN_Click);
            // 
            // nineBTN
            // 
            this.nineBTN.Location = new System.Drawing.Point(125, 218);
            this.nineBTN.Name = "nineBTN";
            this.nineBTN.Size = new System.Drawing.Size(50, 45);
            this.nineBTN.TabIndex = 12;
            this.nineBTN.Text = "9";
            this.nineBTN.UseVisualStyleBackColor = true;
            this.nineBTN.Click += new System.EventHandler(this.nineBTN_Click);
            // 
            // eightBTN
            // 
            this.eightBTN.Location = new System.Drawing.Point(69, 218);
            this.eightBTN.Name = "eightBTN";
            this.eightBTN.Size = new System.Drawing.Size(50, 45);
            this.eightBTN.TabIndex = 11;
            this.eightBTN.Text = "8";
            this.eightBTN.UseVisualStyleBackColor = true;
            this.eightBTN.Click += new System.EventHandler(this.eightBTN_Click);
            // 
            // sevenBTN
            // 
            this.sevenBTN.Location = new System.Drawing.Point(13, 218);
            this.sevenBTN.Name = "sevenBTN";
            this.sevenBTN.Size = new System.Drawing.Size(50, 45);
            this.sevenBTN.TabIndex = 10;
            this.sevenBTN.Text = "7";
            this.sevenBTN.UseVisualStyleBackColor = true;
            this.sevenBTN.Click += new System.EventHandler(this.sevenBTN_Click);
            // 
            // divBTN
            // 
            this.divBTN.Location = new System.Drawing.Point(181, 269);
            this.divBTN.Name = "divBTN";
            this.divBTN.Size = new System.Drawing.Size(50, 45);
            this.divBTN.TabIndex = 17;
            this.divBTN.Text = "/";
            this.divBTN.UseVisualStyleBackColor = true;
            this.divBTN.Click += new System.EventHandler(this.divBTN_Click);
            // 
            // equalBTN
            // 
            this.equalBTN.Location = new System.Drawing.Point(125, 269);
            this.equalBTN.Name = "equalBTN";
            this.equalBTN.Size = new System.Drawing.Size(50, 45);
            this.equalBTN.TabIndex = 16;
            this.equalBTN.Text = "=";
            this.equalBTN.UseVisualStyleBackColor = true;
            this.equalBTN.Click += new System.EventHandler(this.equalBTN_Click);
            // 
            // zeroBTN
            // 
            this.zeroBTN.Location = new System.Drawing.Point(69, 269);
            this.zeroBTN.Name = "zeroBTN";
            this.zeroBTN.Size = new System.Drawing.Size(50, 45);
            this.zeroBTN.TabIndex = 15;
            this.zeroBTN.Text = "0";
            this.zeroBTN.UseVisualStyleBackColor = true;
            this.zeroBTN.Click += new System.EventHandler(this.zeroBTN_Click);
            // 
            // dotBTN
            // 
            this.dotBTN.Location = new System.Drawing.Point(13, 269);
            this.dotBTN.Name = "dotBTN";
            this.dotBTN.Size = new System.Drawing.Size(50, 45);
            this.dotBTN.TabIndex = 14;
            this.dotBTN.Text = ".";
            this.dotBTN.UseVisualStyleBackColor = true;
            this.dotBTN.Click += new System.EventHandler(this.dotBTN_Click);
            // 
            // resultBTN
            // 
            this.resultBTN.Location = new System.Drawing.Point(246, 116);
            this.resultBTN.Name = "resultBTN";
            this.resultBTN.ReadOnly = true;
            this.resultBTN.Size = new System.Drawing.Size(149, 24);
            this.resultBTN.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Result";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 331);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultBTN);
            this.Controls.Add(this.divBTN);
            this.Controls.Add(this.equalBTN);
            this.Controls.Add(this.zeroBTN);
            this.Controls.Add(this.dotBTN);
            this.Controls.Add(this.mulBTN);
            this.Controls.Add(this.nineBTN);
            this.Controls.Add(this.eightBTN);
            this.Controls.Add(this.sevenBTN);
            this.Controls.Add(this.subBTN);
            this.Controls.Add(this.sixBTN);
            this.Controls.Add(this.fiveBTN);
            this.Controls.Add(this.fourBTN);
            this.Controls.Add(this.sumBTN);
            this.Controls.Add(this.threeBTN);
            this.Controls.Add(this.twoBTN);
            this.Controls.Add(this.oneBTN);
            this.Controls.Add(this.operationTXT);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Emad Cal";
            this.TopMost = true;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TextBox operationTXT;
        private System.Windows.Forms.Button oneBTN;
        private System.Windows.Forms.Button twoBTN;
        private System.Windows.Forms.Button threeBTN;
        private System.Windows.Forms.Button sumBTN;
        private System.Windows.Forms.Button subBTN;
        private System.Windows.Forms.Button sixBTN;
        private System.Windows.Forms.Button fiveBTN;
        private System.Windows.Forms.Button fourBTN;
        private System.Windows.Forms.Button mulBTN;
        private System.Windows.Forms.Button nineBTN;
        private System.Windows.Forms.Button eightBTN;
        private System.Windows.Forms.Button sevenBTN;
        private System.Windows.Forms.Button divBTN;
        private System.Windows.Forms.Button equalBTN;
        private System.Windows.Forms.Button zeroBTN;
        private System.Windows.Forms.Button dotBTN;
        private System.Windows.Forms.TextBox resultBTN;
        private System.Windows.Forms.Label label1;
    }
}

