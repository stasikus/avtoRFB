namespace avtoRFB
{
    partial class RegistrationForm
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
            this.start_btnFB = new System.Windows.Forms.Button();
            this.stop_btnFB = new System.Windows.Forms.Button();
            this.quentity_boxFB = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.xls_rbFB = new System.Windows.Forms.RadioButton();
            this.txt_rbFB = new System.Windows.Forms.RadioButton();
            this.csv_rbFB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ControlTab = new System.Windows.Forms.TabControl();
            this.FBTabPage = new System.Windows.Forms.TabPage();
            this.FBcounter_label = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TWTabPage = new System.Windows.Forms.TabPage();
            this.TWcounter_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.start_btnTW = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_rbTW = new System.Windows.Forms.RadioButton();
            this.xls_rbTW = new System.Windows.Forms.RadioButton();
            this.stop_btnTW = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.quentity_boxTW = new System.Windows.Forms.NumericUpDown();
            this.csv_rbTW = new System.Windows.Forms.RadioButton();
            this.FBpanel = new System.Windows.Forms.Panel();
            this.TWpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.quentity_boxFB)).BeginInit();
            this.ControlTab.SuspendLayout();
            this.FBTabPage.SuspendLayout();
            this.TWTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quentity_boxTW)).BeginInit();
            this.FBpanel.SuspendLayout();
            this.TWpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btnFB
            // 
            this.start_btnFB.Location = new System.Drawing.Point(6, 36);
            this.start_btnFB.Name = "start_btnFB";
            this.start_btnFB.Size = new System.Drawing.Size(75, 23);
            this.start_btnFB.TabIndex = 0;
            this.start_btnFB.Text = "Start";
            this.start_btnFB.UseVisualStyleBackColor = true;
            this.start_btnFB.Click += new System.EventHandler(this.start_btnFB_Click);
            // 
            // stop_btnFB
            // 
            this.stop_btnFB.Location = new System.Drawing.Point(87, 36);
            this.stop_btnFB.Name = "stop_btnFB";
            this.stop_btnFB.Size = new System.Drawing.Size(75, 23);
            this.stop_btnFB.TabIndex = 1;
            this.stop_btnFB.Text = "Stop";
            this.stop_btnFB.UseVisualStyleBackColor = true;
            // 
            // quentity_boxFB
            // 
            this.quentity_boxFB.Location = new System.Drawing.Point(116, 1);
            this.quentity_boxFB.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quentity_boxFB.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quentity_boxFB.Name = "quentity_boxFB";
            this.quentity_boxFB.Size = new System.Drawing.Size(75, 20);
            this.quentity_boxFB.TabIndex = 2;
            this.quentity_boxFB.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Кол-во аккаунтов";
            // 
            // xls_rbFB
            // 
            this.xls_rbFB.AutoSize = true;
            this.xls_rbFB.Location = new System.Drawing.Point(59, 102);
            this.xls_rbFB.Name = "xls_rbFB";
            this.xls_rbFB.Size = new System.Drawing.Size(45, 17);
            this.xls_rbFB.TabIndex = 4;
            this.xls_rbFB.Text = "XLS";
            this.xls_rbFB.UseVisualStyleBackColor = true;
            // 
            // txt_rbFB
            // 
            this.txt_rbFB.AutoSize = true;
            this.txt_rbFB.Checked = true;
            this.txt_rbFB.Location = new System.Drawing.Point(7, 102);
            this.txt_rbFB.Name = "txt_rbFB";
            this.txt_rbFB.Size = new System.Drawing.Size(46, 17);
            this.txt_rbFB.TabIndex = 5;
            this.txt_rbFB.TabStop = true;
            this.txt_rbFB.Text = "TXT";
            this.txt_rbFB.UseVisualStyleBackColor = true;
            // 
            // csv_rbFB
            // 
            this.csv_rbFB.AutoSize = true;
            this.csv_rbFB.Location = new System.Drawing.Point(116, 102);
            this.csv_rbFB.Name = "csv_rbFB";
            this.csv_rbFB.Size = new System.Drawing.Size(46, 17);
            this.csv_rbFB.TabIndex = 6;
            this.csv_rbFB.Text = "CSV";
            this.csv_rbFB.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Сохранить аккаунты в формате";
            // 
            // ControlTab
            // 
            this.ControlTab.Controls.Add(this.FBTabPage);
            this.ControlTab.Controls.Add(this.TWTabPage);
            this.ControlTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlTab.Location = new System.Drawing.Point(0, 0);
            this.ControlTab.Name = "ControlTab";
            this.ControlTab.SelectedIndex = 0;
            this.ControlTab.Size = new System.Drawing.Size(487, 262);
            this.ControlTab.TabIndex = 8;
            // 
            // FBTabPage
            // 
            this.FBTabPage.Controls.Add(this.FBpanel);
            this.FBTabPage.Controls.Add(this.FBcounter_label);
            this.FBTabPage.Controls.Add(this.label5);
            this.FBTabPage.Location = new System.Drawing.Point(4, 22);
            this.FBTabPage.Name = "FBTabPage";
            this.FBTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FBTabPage.Size = new System.Drawing.Size(479, 236);
            this.FBTabPage.TabIndex = 0;
            this.FBTabPage.Text = "Facebook";
            this.FBTabPage.UseVisualStyleBackColor = true;
            // 
            // FBcounter_label
            // 
            this.FBcounter_label.AutoSize = true;
            this.FBcounter_label.Location = new System.Drawing.Point(128, 150);
            this.FBcounter_label.Name = "FBcounter_label";
            this.FBcounter_label.Size = new System.Drawing.Size(0, 13);
            this.FBcounter_label.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Созданно аккаунтов:";
            // 
            // TWTabPage
            // 
            this.TWTabPage.Controls.Add(this.TWpanel);
            this.TWTabPage.Controls.Add(this.TWcounter_label);
            this.TWTabPage.Controls.Add(this.label7);
            this.TWTabPage.Location = new System.Drawing.Point(4, 22);
            this.TWTabPage.Name = "TWTabPage";
            this.TWTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.TWTabPage.Size = new System.Drawing.Size(479, 236);
            this.TWTabPage.TabIndex = 1;
            this.TWTabPage.Text = "Twitter";
            this.TWTabPage.UseVisualStyleBackColor = true;
            // 
            // TWcounter_label
            // 
            this.TWcounter_label.AutoSize = true;
            this.TWcounter_label.Location = new System.Drawing.Point(128, 150);
            this.TWcounter_label.Name = "TWcounter_label";
            this.TWcounter_label.Size = new System.Drawing.Size(0, 13);
            this.TWcounter_label.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Созданно аккаунтов:";
            // 
            // start_btnTW
            // 
            this.start_btnTW.Location = new System.Drawing.Point(6, 36);
            this.start_btnTW.Name = "start_btnTW";
            this.start_btnTW.Size = new System.Drawing.Size(75, 23);
            this.start_btnTW.TabIndex = 8;
            this.start_btnTW.Text = "Start";
            this.start_btnTW.UseVisualStyleBackColor = true;
            this.start_btnTW.Click += new System.EventHandler(this.start_btnTW_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Сохранить аккаунты в формате";
            // 
            // txt_rbTW
            // 
            this.txt_rbTW.AutoSize = true;
            this.txt_rbTW.Checked = true;
            this.txt_rbTW.Location = new System.Drawing.Point(7, 102);
            this.txt_rbTW.Name = "txt_rbTW";
            this.txt_rbTW.Size = new System.Drawing.Size(46, 17);
            this.txt_rbTW.TabIndex = 13;
            this.txt_rbTW.TabStop = true;
            this.txt_rbTW.Text = "TXT";
            this.txt_rbTW.UseVisualStyleBackColor = true;
            // 
            // xls_rbTW
            // 
            this.xls_rbTW.AutoSize = true;
            this.xls_rbTW.Location = new System.Drawing.Point(59, 102);
            this.xls_rbTW.Name = "xls_rbTW";
            this.xls_rbTW.Size = new System.Drawing.Size(45, 17);
            this.xls_rbTW.TabIndex = 12;
            this.xls_rbTW.Text = "XLS";
            this.xls_rbTW.UseVisualStyleBackColor = true;
            // 
            // stop_btnTW
            // 
            this.stop_btnTW.Location = new System.Drawing.Point(87, 36);
            this.stop_btnTW.Name = "stop_btnTW";
            this.stop_btnTW.Size = new System.Drawing.Size(75, 23);
            this.stop_btnTW.TabIndex = 9;
            this.stop_btnTW.Text = "Stop";
            this.stop_btnTW.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Кол-во аккаунтов";
            // 
            // quentity_boxTW
            // 
            this.quentity_boxTW.Location = new System.Drawing.Point(116, 1);
            this.quentity_boxTW.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.quentity_boxTW.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quentity_boxTW.Name = "quentity_boxTW";
            this.quentity_boxTW.Size = new System.Drawing.Size(75, 20);
            this.quentity_boxTW.TabIndex = 10;
            this.quentity_boxTW.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // csv_rbTW
            // 
            this.csv_rbTW.AutoSize = true;
            this.csv_rbTW.Location = new System.Drawing.Point(116, 102);
            this.csv_rbTW.Name = "csv_rbTW";
            this.csv_rbTW.Size = new System.Drawing.Size(46, 17);
            this.csv_rbTW.TabIndex = 14;
            this.csv_rbTW.Text = "CSV";
            this.csv_rbTW.UseVisualStyleBackColor = true;
            // 
            // FBpanel
            // 
            this.FBpanel.Controls.Add(this.label1);
            this.FBpanel.Controls.Add(this.csv_rbFB);
            this.FBpanel.Controls.Add(this.quentity_boxFB);
            this.FBpanel.Controls.Add(this.start_btnFB);
            this.FBpanel.Controls.Add(this.stop_btnFB);
            this.FBpanel.Controls.Add(this.label2);
            this.FBpanel.Controls.Add(this.xls_rbFB);
            this.FBpanel.Controls.Add(this.txt_rbFB);
            this.FBpanel.Location = new System.Drawing.Point(8, 6);
            this.FBpanel.Name = "FBpanel";
            this.FBpanel.Size = new System.Drawing.Size(210, 130);
            this.FBpanel.TabIndex = 10;
            // 
            // TWpanel
            // 
            this.TWpanel.Controls.Add(this.label4);
            this.TWpanel.Controls.Add(this.csv_rbTW);
            this.TWpanel.Controls.Add(this.quentity_boxTW);
            this.TWpanel.Controls.Add(this.start_btnTW);
            this.TWpanel.Controls.Add(this.stop_btnTW);
            this.TWpanel.Controls.Add(this.label3);
            this.TWpanel.Controls.Add(this.xls_rbTW);
            this.TWpanel.Controls.Add(this.txt_rbTW);
            this.TWpanel.Location = new System.Drawing.Point(8, 6);
            this.TWpanel.Name = "TWpanel";
            this.TWpanel.Size = new System.Drawing.Size(210, 130);
            this.TWpanel.TabIndex = 18;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 262);
            this.Controls.Add(this.ControlTab);
            this.Name = "RegistrationForm";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.quentity_boxFB)).EndInit();
            this.ControlTab.ResumeLayout(false);
            this.FBTabPage.ResumeLayout(false);
            this.FBTabPage.PerformLayout();
            this.TWTabPage.ResumeLayout(false);
            this.TWTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quentity_boxTW)).EndInit();
            this.FBpanel.ResumeLayout(false);
            this.FBpanel.PerformLayout();
            this.TWpanel.ResumeLayout(false);
            this.TWpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_btnFB;
        private System.Windows.Forms.Button stop_btnFB;
        private System.Windows.Forms.NumericUpDown quentity_boxFB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton xls_rbFB;
        private System.Windows.Forms.RadioButton txt_rbFB;
        private System.Windows.Forms.RadioButton csv_rbFB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl ControlTab;
        private System.Windows.Forms.TabPage FBTabPage;
        private System.Windows.Forms.TabPage TWTabPage;
        private System.Windows.Forms.Button start_btnTW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton txt_rbTW;
        private System.Windows.Forms.RadioButton xls_rbTW;
        private System.Windows.Forms.Button stop_btnTW;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown quentity_boxTW;
        private System.Windows.Forms.RadioButton csv_rbTW;
        private System.Windows.Forms.Label FBcounter_label;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TWcounter_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel FBpanel;
        private System.Windows.Forms.Panel TWpanel;
    }
}

