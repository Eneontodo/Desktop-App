namespace desktop
{
    public partial class sett
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sett));
            this.label1 = new System.Windows.Forms.Label();
            this.vsname = new System.Windows.Forms.TextBox();
            this.bootsettbtn = new System.Windows.Forms.Button();
            this.bootsett = new System.Windows.Forms.Panel();
            this.grap = new System.Windows.Forms.TextBox();
            this.browser = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Mse = new System.Windows.Forms.TextBox();
            this.Mspath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.permis = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.expname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.bootsett.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "путь до VStudio";
            // 
            // vsname
            // 
            this.vsname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vsname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.vsname.Enabled = false;
            this.vsname.Location = new System.Drawing.Point(117, 37);
            this.vsname.Name = "vsname";
            this.vsname.Size = new System.Drawing.Size(526, 13);
            this.vsname.TabIndex = 1;
            // 
            // bootsettbtn
            // 
            this.bootsettbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bootsettbtn.Location = new System.Drawing.Point(20, 120);
            this.bootsettbtn.Name = "bootsettbtn";
            this.bootsettbtn.Size = new System.Drawing.Size(158, 23);
            this.bootsettbtn.TabIndex = 2;
            this.bootsettbtn.Text = "расширенные настройки";
            this.bootsettbtn.UseVisualStyleBackColor = true;
            this.bootsettbtn.Click += new System.EventHandler(this.bootsettbtn_Click);
            // 
            // bootsett
            // 
            this.bootsett.Controls.Add(this.grap);
            this.bootsett.Controls.Add(this.browser);
            this.bootsett.Controls.Add(this.label7);
            this.bootsett.Controls.Add(this.label6);
            this.bootsett.Controls.Add(this.label5);
            this.bootsett.Controls.Add(this.Mse);
            this.bootsett.Controls.Add(this.Mspath);
            this.bootsett.Controls.Add(this.label4);
            this.bootsett.Controls.Add(this.button4);
            this.bootsett.Controls.Add(this.button3);
            this.bootsett.Controls.Add(this.permis);
            this.bootsett.Controls.Add(this.label3);
            this.bootsett.Controls.Add(this.expname);
            this.bootsett.Controls.Add(this.label2);
            this.bootsett.Controls.Add(this.vsname);
            this.bootsett.Controls.Add(this.label1);
            this.bootsett.Location = new System.Drawing.Point(14, 168);
            this.bootsett.Name = "bootsett";
            this.bootsett.Size = new System.Drawing.Size(646, 209);
            this.bootsett.TabIndex = 3;
            this.bootsett.Visible = false;
            // 
            // grap
            // 
            this.grap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.grap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grap.Enabled = false;
            this.grap.Location = new System.Drawing.Point(140, 152);
            this.grap.Name = "grap";
            this.grap.Size = new System.Drawing.Size(503, 13);
            this.grap.TabIndex = 14;
            // 
            // browser
            // 
            this.browser.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.browser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.browser.Enabled = false;
            this.browser.Location = new System.Drawing.Point(117, 128);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(526, 13);
            this.browser.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "путь до граф. редактора";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "путь до браузера";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "настройки";
            // 
            // Mse
            // 
            this.Mse.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Mse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mse.Enabled = false;
            this.Mse.Location = new System.Drawing.Point(117, 100);
            this.Mse.Name = "Mse";
            this.Mse.Size = new System.Drawing.Size(526, 13);
            this.Mse.TabIndex = 9;
            // 
            // Mspath
            // 
            this.Mspath.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Mspath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Mspath.Enabled = false;
            this.Mspath.Location = new System.Drawing.Point(116, 70);
            this.Mspath.Name = "Mspath";
            this.Mspath.Size = new System.Drawing.Size(527, 13);
            this.Mspath.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(29, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "путь до MStore";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 183);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(157, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "запретить редактирование";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(486, 183);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "разрешить редактирование";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // permis
            // 
            this.permis.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.permis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.permis.Enabled = false;
            this.permis.Location = new System.Drawing.Point(117, 189);
            this.permis.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.permis.Name = "permis";
            this.permis.Size = new System.Drawing.Size(41, 16);
            this.permis.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "per_usr ";
            // 
            // expname
            // 
            this.expname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.expname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.expname.Enabled = false;
            this.expname.Location = new System.Drawing.Point(117, 11);
            this.expname.Name = "expname";
            this.expname.Size = new System.Drawing.Size(526, 13);
            this.expname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "путь до проводника";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "скрыть расширенные настройки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(548, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 36);
            this.button2.TabIndex = 5;
            this.button2.Text = "сохранить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sett
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(670, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bootsett);
            this.Controls.Add(this.bootsettbtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "sett";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки Приложения";
            this.bootsett.ResumeLayout(false);
            this.bootsett.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.permis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox vsname;
        public System.Windows.Forms.Button bootsettbtn;
        public System.Windows.Forms.Panel bootsett;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox expname;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.NumericUpDown permis;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Button button4;
        public System.Windows.Forms.TextBox Mspath;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox Mse;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox browser;
        public System.Windows.Forms.TextBox grap;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ColorDialog colorDialog2;
    }
}