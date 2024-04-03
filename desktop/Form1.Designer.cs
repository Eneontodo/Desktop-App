namespace desktop
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.button11 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.MStore = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.start_MS = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.VStudio = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.brows = new System.Windows.Forms.TabPage();
            this.button12 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.GrapEdit = new System.Windows.Forms.TabPage();
            this.button9 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Xternus = new System.Windows.Forms.TabPage();
            this.Xternu = new System.Windows.Forms.Panel();
            this.pain = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.HistoryBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.applicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toTrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.MStore.SuspendLayout();
            this.VStudio.SuspendLayout();
            this.brows.SuspendLayout();
            this.GrapEdit.SuspendLayout();
            this.Xternus.SuspendLayout();
            this.Xternu.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.Home);
            this.tabControl1.Controls.Add(this.MStore);
            this.tabControl1.Controls.Add(this.VStudio);
            this.tabControl1.Controls.Add(this.brows);
            this.tabControl1.Controls.Add(this.GrapEdit);
            this.tabControl1.Controls.Add(this.Xternus);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl1.Location = new System.Drawing.Point(2, 32);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1918, 977);
            this.tabControl1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Green;
            this.Home.Controls.Add(this.button11);
            this.Home.Controls.Add(this.label7);
            this.Home.Location = new System.Drawing.Point(23, 4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1891, 969);
            this.Home.TabIndex = 5;
            this.Home.Text = "Home";
            // 
            // button11
            // 
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(911, 354);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(103, 36);
            this.button11.TabIndex = 4;
            this.button11.Text = "Настройки";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(407, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(637, 73);
            this.label7.TabIndex = 0;
            this.label7.Text = "Добро пожаловать!";
            // 
            // MStore
            // 
            this.MStore.BackColor = System.Drawing.Color.OliveDrab;
            this.MStore.Controls.Add(this.button7);
            this.MStore.Controls.Add(this.start_MS);
            this.MStore.Controls.Add(this.label3);
            this.MStore.Location = new System.Drawing.Point(23, 4);
            this.MStore.Name = "MStore";
            this.MStore.Padding = new System.Windows.Forms.Padding(3);
            this.MStore.Size = new System.Drawing.Size(1891, 969);
            this.MStore.TabIndex = 0;
            this.MStore.Text = "Microsoft Store";
            // 
            // button7
            // 
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.Image = ((System.Drawing.Image)(resources.GetObject("button7.Image")));
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(540, 205);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(107, 38);
            this.button7.TabIndex = 2;
            this.button7.Text = "Настройки";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // start_MS
            // 
            this.start_MS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_MS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_MS.Image = ((System.Drawing.Image)(resources.GetObject("start_MS.Image")));
            this.start_MS.Location = new System.Drawing.Point(6, 205);
            this.start_MS.Name = "start_MS";
            this.start_MS.Size = new System.Drawing.Size(528, 128);
            this.start_MS.TabIndex = 1;
            this.start_MS.UseVisualStyleBackColor = true;
            this.start_MS.Click += new System.EventHandler(this.start_MS_Click);
            // 
            // label3
            // 
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(6, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(800, 199);
            this.label3.TabIndex = 0;
            // 
            // VStudio
            // 
            this.VStudio.BackColor = System.Drawing.Color.DarkViolet;
            this.VStudio.Controls.Add(this.button8);
            this.VStudio.Controls.Add(this.label4);
            this.VStudio.Controls.Add(this.button4);
            this.VStudio.Location = new System.Drawing.Point(23, 4);
            this.VStudio.Name = "VStudio";
            this.VStudio.Padding = new System.Windows.Forms.Padding(3);
            this.VStudio.Size = new System.Drawing.Size(1891, 969);
            this.VStudio.TabIndex = 1;
            this.VStudio.Text = "Visual Studio";
            // 
            // button8
            // 
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(537, 245);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(107, 38);
            this.button8.TabIndex = 3;
            this.button8.Text = "Настройки";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button7_Click);
            // 
            // label4
            // 
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.Location = new System.Drawing.Point(6, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(802, 239);
            this.label4.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(6, 245);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(525, 129);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // brows
            // 
            this.brows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.brows.Controls.Add(this.button12);
            this.brows.Controls.Add(this.label5);
            this.brows.Controls.Add(this.button5);
            this.brows.Location = new System.Drawing.Point(23, 4);
            this.brows.Name = "brows";
            this.brows.Size = new System.Drawing.Size(1891, 969);
            this.brows.TabIndex = 3;
            this.brows.Text = "browser";
            // 
            // button12
            // 
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.Image = ((System.Drawing.Image)(resources.GetObject("button12.Image")));
            this.button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button12.Location = new System.Drawing.Point(551, 252);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(107, 38);
            this.button12.TabIndex = 4;
            this.button12.Text = "Настройки";
            this.button12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button7_Click);
            // 
            // label5
            // 
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.Location = new System.Drawing.Point(15, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(802, 237);
            this.label5.TabIndex = 1;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(18, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(527, 127);
            this.button5.TabIndex = 0;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // GrapEdit
            // 
            this.GrapEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(64)))), ((int)(((byte)(59)))));
            this.GrapEdit.Controls.Add(this.button9);
            this.GrapEdit.Controls.Add(this.button6);
            this.GrapEdit.Controls.Add(this.label6);
            this.GrapEdit.Location = new System.Drawing.Point(23, 4);
            this.GrapEdit.Name = "GrapEdit";
            this.GrapEdit.Size = new System.Drawing.Size(1891, 969);
            this.GrapEdit.TabIndex = 4;
            this.GrapEdit.Text = "Graphic Editor";
            // 
            // button9
            // 
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(539, 262);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(107, 38);
            this.button9.TabIndex = 3;
            this.button9.Text = "Настройки";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Image = ((System.Drawing.Image)(resources.GetObject("button6.Image")));
            this.button6.Location = new System.Drawing.Point(6, 251);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(527, 127);
            this.button6.TabIndex = 1;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label6
            // 
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(793, 249);
            this.label6.TabIndex = 0;
            // 
            // Xternus
            // 
            this.Xternus.BackColor = System.Drawing.SystemColors.Desktop;
            this.Xternus.Controls.Add(this.Xternu);
            this.Xternus.Controls.Add(this.label2);
            this.Xternus.Controls.Add(this.HistoryBox);
            this.Xternus.Controls.Add(this.label1);
            this.Xternus.Controls.Add(this.listBox1);
            this.Xternus.Location = new System.Drawing.Point(23, 4);
            this.Xternus.Name = "Xternus";
            this.Xternus.Size = new System.Drawing.Size(1891, 969);
            this.Xternus.TabIndex = 2;
            this.Xternus.Text = "Xternu";
            // 
            // Xternu
            // 
            this.Xternu.Controls.Add(this.pain);
            this.Xternu.Controls.Add(this.button1);
            this.Xternu.Location = new System.Drawing.Point(8, 193);
            this.Xternu.Name = "Xternu";
            this.Xternu.Size = new System.Drawing.Size(1180, 101);
            this.Xternu.TabIndex = 7;
            // 
            // pain
            // 
            this.pain.Location = new System.Drawing.Point(3, 77);
            this.pain.Name = "pain";
            this.pain.Size = new System.Drawing.Size(1093, 20);
            this.pain.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1102, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "отправить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(8, 795);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 174);
            this.label2.TabIndex = 5;
            this.label2.UseMnemonic = false;
            // 
            // HistoryBox
            // 
            this.HistoryBox.BackColor = System.Drawing.SystemColors.MenuText;
            this.HistoryBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.HistoryBox.ForeColor = System.Drawing.SystemColors.Info;
            this.HistoryBox.FormattingEnabled = true;
            this.HistoryBox.Location = new System.Drawing.Point(1194, 27);
            this.HistoryBox.Name = "HistoryBox";
            this.HistoryBox.Size = new System.Drawing.Size(697, 938);
            this.HistoryBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1190, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "History";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(11, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(1180, 290);
            this.listBox1.TabIndex = 0;
            this.listBox1.TabStop = false;
            this.listBox1.UseTabStops = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Green;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.applicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1940, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // applicationToolStripMenuItem
            // 
            this.applicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toTrayToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.applicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("applicationToolStripMenuItem.Image")));
            this.applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            this.applicationToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.applicationToolStripMenuItem.Text = "приложение";
            // 
            // toTrayToolStripMenuItem
            // 
            this.toTrayToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toTrayToolStripMenuItem.Image")));
            this.toTrayToolStripMenuItem.Name = "toTrayToolStripMenuItem";
            this.toTrayToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.toTrayToolStripMenuItem.Text = "to tray";
            this.toTrayToolStripMenuItem.Click += new System.EventHandler(this.toTrayToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem.Image")));
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.развернутьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 76);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.toolStripMenuItem1.Text = "выкл пк";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // развернутьToolStripMenuItem
            // 
            this.развернутьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("развернутьToolStripMenuItem.Image")));
            this.развернутьToolStripMenuItem.Name = "развернутьToolStripMenuItem";
            this.развернутьToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.развернутьToolStripMenuItem.Text = "развернуть";
            this.развернутьToolStripMenuItem.Click += new System.EventHandler(this.развернутьToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.выйтиToolStripMenuItem.Text = "выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(13, 1015);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 41);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(61, 1015);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 42);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1940, 1080);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            this.MStore.ResumeLayout(false);
            this.VStudio.ResumeLayout(false);
            this.brows.ResumeLayout(false);
            this.GrapEdit.ResumeLayout(false);
            this.Xternus.ResumeLayout(false);
            this.Xternus.PerformLayout();
            this.Xternu.ResumeLayout(false);
            this.Xternu.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage MStore;
        private System.Windows.Forms.TabPage VStudio;
        private System.Windows.Forms.ToolStripMenuItem applicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toTrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.TabPage Xternus;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox pain;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox HistoryBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button start_MS;
        private System.Windows.Forms.Panel Xternu;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage brows;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage GrapEdit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        public System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button11;
        public System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button9;
    }
}

