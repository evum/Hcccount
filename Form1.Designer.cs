
namespace WindowsFormsApp1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxS = new System.Windows.Forms.TextBox();
            this.trackBarHcc = new System.Windows.Forms.TrackBar();
            this.labelHcc = new System.Windows.Forms.Label();
            this.labelOpss1 = new System.Windows.Forms.Label();
            this.trackBarOpss1 = new System.Windows.Forms.TrackBar();
            this.trackBarOck = new System.Windows.Forms.TrackBar();
            this.labelOck = new System.Windows.Forms.Label();
            this.trackBarOpss3 = new System.Windows.Forms.TrackBar();
            this.labelOpss3 = new System.Windows.Forms.Label();
            this.trackBarOpss2 = new System.Windows.Forms.TrackBar();
            this.labelOpss2 = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.buttonHcc = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOpss2 = new System.Windows.Forms.Button();
            this.buttonOpss1 = new System.Windows.Forms.Button();
            this.buttonOpss3 = new System.Windows.Forms.Button();
            this.buttonOck = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonD = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.buttonA = new System.Windows.Forms.Button();
            this.buttonV = new System.Windows.Forms.Button();
            this.textBoxV = new System.Windows.Forms.TextBox();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.buttonK = new System.Windows.Forms.Button();
            this.textBoxK_3 = new System.Windows.Forms.TextBox();
            this.textBoxK_2 = new System.Windows.Forms.TextBox();
            this.textBoxK_1 = new System.Windows.Forms.TextBox();
            this.buttonK_1 = new System.Windows.Forms.Button();
            this.buttonK_3 = new System.Windows.Forms.Button();
            this.buttonK_2 = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonOpenAll = new System.Windows.Forms.Button();
            this.checkBoxNerv = new System.Windows.Forms.CheckBox();
            this.trackBarRun = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarEat = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.trackBarThink = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.labelNervComp = new System.Windows.Forms.Label();
            this.buttonNerv = new System.Windows.Forms.Button();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHcc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpss1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpss3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpss2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThink)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxS
            // 
            this.textBoxS.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxS.Location = new System.Drawing.Point(12, 99);
            this.textBoxS.Name = "textBoxS";
            this.textBoxS.ReadOnly = true;
            this.textBoxS.Size = new System.Drawing.Size(120, 20);
            this.textBoxS.TabIndex = 3;
            this.textBoxS.Text = "Систолическое:";
            this.textBoxS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxS.Visible = false;
            // 
            // trackBarHcc
            // 
            this.trackBarHcc.Location = new System.Drawing.Point(6, 38);
            this.trackBarHcc.Maximum = 200;
            this.trackBarHcc.Name = "trackBarHcc";
            this.trackBarHcc.Size = new System.Drawing.Size(343, 45);
            this.trackBarHcc.TabIndex = 5;
            this.trackBarHcc.Value = 80;
            this.trackBarHcc.Visible = false;
            this.trackBarHcc.Scroll += new System.EventHandler(this.trackBarHcc_Scroll);
            // 
            // labelHcc
            // 
            this.labelHcc.AutoSize = true;
            this.labelHcc.Location = new System.Drawing.Point(222, 9);
            this.labelHcc.Name = "labelHcc";
            this.labelHcc.Size = new System.Drawing.Size(29, 13);
            this.labelHcc.TabIndex = 7;
            this.labelHcc.Text = "ЧСС";
            this.labelHcc.Visible = false;
            // 
            // labelOpss1
            // 
            this.labelOpss1.AutoSize = true;
            this.labelOpss1.Location = new System.Drawing.Point(891, 97);
            this.labelOpss1.Name = "labelOpss1";
            this.labelOpss1.Size = new System.Drawing.Size(43, 13);
            this.labelOpss1.TabIndex = 8;
            this.labelOpss1.Text = "ОПСС1";
            this.labelOpss1.Visible = false;
            // 
            // trackBarOpss1
            // 
            this.trackBarOpss1.LargeChange = 1;
            this.trackBarOpss1.Location = new System.Drawing.Point(856, 113);
            this.trackBarOpss1.Maximum = 6;
            this.trackBarOpss1.Name = "trackBarOpss1";
            this.trackBarOpss1.Size = new System.Drawing.Size(104, 45);
            this.trackBarOpss1.TabIndex = 1;
            this.trackBarOpss1.Value = 2;
            this.trackBarOpss1.Visible = false;
            this.trackBarOpss1.Scroll += new System.EventHandler(this.trackBarOpss1_Scroll);
            // 
            // trackBarOck
            // 
            this.trackBarOck.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarOck.LargeChange = 1;
            this.trackBarOck.Location = new System.Drawing.Point(856, 303);
            this.trackBarOck.Maximum = 7;
            this.trackBarOck.Name = "trackBarOck";
            this.trackBarOck.Size = new System.Drawing.Size(104, 45);
            this.trackBarOck.TabIndex = 1;
            this.trackBarOck.Value = 4;
            this.trackBarOck.Visible = false;
            this.trackBarOck.Scroll += new System.EventHandler(this.trackBarOck_Scroll);
            // 
            // labelOck
            // 
            this.labelOck.AutoSize = true;
            this.labelOck.Location = new System.Drawing.Point(887, 287);
            this.labelOck.Name = "labelOck";
            this.labelOck.Size = new System.Drawing.Size(30, 13);
            this.labelOck.TabIndex = 10;
            this.labelOck.Text = "ОЦК";
            this.labelOck.Visible = false;
            // 
            // trackBarOpss3
            // 
            this.trackBarOpss3.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarOpss3.LargeChange = 1;
            this.trackBarOpss3.Location = new System.Drawing.Point(856, 239);
            this.trackBarOpss3.Maximum = 6;
            this.trackBarOpss3.Name = "trackBarOpss3";
            this.trackBarOpss3.Size = new System.Drawing.Size(104, 45);
            this.trackBarOpss3.TabIndex = 1;
            this.trackBarOpss3.Value = 2;
            this.trackBarOpss3.Visible = false;
            this.trackBarOpss3.Scroll += new System.EventHandler(this.trackBarOpss3_Scroll);
            // 
            // labelOpss3
            // 
            this.labelOpss3.AutoSize = true;
            this.labelOpss3.Location = new System.Drawing.Point(887, 223);
            this.labelOpss3.Name = "labelOpss3";
            this.labelOpss3.Size = new System.Drawing.Size(43, 13);
            this.labelOpss3.TabIndex = 12;
            this.labelOpss3.Text = "ОПСС3";
            this.labelOpss3.Visible = false;
            // 
            // trackBarOpss2
            // 
            this.trackBarOpss2.LargeChange = 1;
            this.trackBarOpss2.Location = new System.Drawing.Point(856, 177);
            this.trackBarOpss2.Maximum = 6;
            this.trackBarOpss2.Name = "trackBarOpss2";
            this.trackBarOpss2.Size = new System.Drawing.Size(104, 45);
            this.trackBarOpss2.TabIndex = 1;
            this.trackBarOpss2.Value = 2;
            this.trackBarOpss2.Visible = false;
            this.trackBarOpss2.Scroll += new System.EventHandler(this.trackBarOpss2_Scroll);
            // 
            // labelOpss2
            // 
            this.labelOpss2.AutoSize = true;
            this.labelOpss2.Location = new System.Drawing.Point(891, 161);
            this.labelOpss2.Name = "labelOpss2";
            this.labelOpss2.Size = new System.Drawing.Size(43, 13);
            this.labelOpss2.TabIndex = 14;
            this.labelOpss2.Text = "ОПСС2";
            this.labelOpss2.Visible = false;
            // 
            // textBoxD
            // 
            this.textBoxD.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxD.Location = new System.Drawing.Point(12, 126);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.ReadOnly = true;
            this.textBoxD.Size = new System.Drawing.Size(120, 20);
            this.textBoxD.TabIndex = 16;
            this.textBoxD.Text = "Диастоличское:";
            this.textBoxD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxD.Visible = false;
            // 
            // buttonHcc
            // 
            this.buttonHcc.Location = new System.Drawing.Point(619, 161);
            this.buttonHcc.Name = "buttonHcc";
            this.buttonHcc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonHcc.Size = new System.Drawing.Size(15, 15);
            this.buttonHcc.TabIndex = 17;
            this.buttonHcc.UseVisualStyleBackColor = true;
            this.buttonHcc.Click += new System.EventHandler(this.buttonHcc_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 18;
            this.label6.Visible = false;
            // 
            // buttonOpss2
            // 
            this.buttonOpss2.Location = new System.Drawing.Point(638, 445);
            this.buttonOpss2.Name = "buttonOpss2";
            this.buttonOpss2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOpss2.Size = new System.Drawing.Size(15, 15);
            this.buttonOpss2.TabIndex = 19;
            this.buttonOpss2.UseVisualStyleBackColor = true;
            this.buttonOpss2.Click += new System.EventHandler(this.buttonOpss2_Click);
            // 
            // buttonOpss1
            // 
            this.buttonOpss1.Location = new System.Drawing.Point(683, 258);
            this.buttonOpss1.Name = "buttonOpss1";
            this.buttonOpss1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOpss1.Size = new System.Drawing.Size(15, 15);
            this.buttonOpss1.TabIndex = 20;
            this.buttonOpss1.UseVisualStyleBackColor = true;
            this.buttonOpss1.Click += new System.EventHandler(this.buttonOpss1_Click);
            // 
            // buttonOpss3
            // 
            this.buttonOpss3.Location = new System.Drawing.Point(649, 104);
            this.buttonOpss3.Name = "buttonOpss3";
            this.buttonOpss3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOpss3.Size = new System.Drawing.Size(15, 15);
            this.buttonOpss3.TabIndex = 21;
            this.buttonOpss3.UseVisualStyleBackColor = true;
            this.buttonOpss3.Click += new System.EventHandler(this.buttonOpss3_Click);
            // 
            // buttonOck
            // 
            this.buttonOck.Location = new System.Drawing.Point(570, 317);
            this.buttonOck.Name = "buttonOck";
            this.buttonOck.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonOck.Size = new System.Drawing.Size(15, 15);
            this.buttonOck.TabIndex = 22;
            this.buttonOck.UseVisualStyleBackColor = true;
            this.buttonOck.Click += new System.EventHandler(this.buttonOck_Click);
            // 
            // buttonS
            // 
            this.buttonS.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonS.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonS.Location = new System.Drawing.Point(671, 79);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(15, 15);
            this.buttonS.TabIndex = 23;
            this.buttonS.UseVisualStyleBackColor = false;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonD
            // 
            this.buttonD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonD.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonD.Location = new System.Drawing.Point(603, 239);
            this.buttonD.Name = "buttonD";
            this.buttonD.Size = new System.Drawing.Size(15, 15);
            this.buttonD.TabIndex = 24;
            this.buttonD.UseVisualStyleBackColor = false;
            this.buttonD.Click += new System.EventHandler(this.buttonD_Click);
            // 
            // textBoxA
            // 
            this.textBoxA.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxA.Location = new System.Drawing.Point(12, 152);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.ReadOnly = true;
            this.textBoxA.Size = new System.Drawing.Size(120, 20);
            this.textBoxA.TabIndex = 25;
            this.textBoxA.Text = "Артериолы";
            this.textBoxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxA.Visible = false;
            // 
            // buttonA
            // 
            this.buttonA.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonA.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonA.Location = new System.Drawing.Point(765, 258);
            this.buttonA.Name = "buttonA";
            this.buttonA.Size = new System.Drawing.Size(15, 15);
            this.buttonA.TabIndex = 26;
            this.buttonA.UseVisualStyleBackColor = false;
            this.buttonA.Click += new System.EventHandler(this.buttonA_Click);
            // 
            // buttonV
            // 
            this.buttonV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonV.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonV.Location = new System.Drawing.Point(712, 520);
            this.buttonV.Name = "buttonV";
            this.buttonV.Size = new System.Drawing.Size(15, 15);
            this.buttonV.TabIndex = 27;
            this.buttonV.UseVisualStyleBackColor = false;
            this.buttonV.Click += new System.EventHandler(this.buttonV_Click);
            // 
            // textBoxV
            // 
            this.textBoxV.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxV.Location = new System.Drawing.Point(12, 178);
            this.textBoxV.Name = "textBoxV";
            this.textBoxV.ReadOnly = true;
            this.textBoxV.Size = new System.Drawing.Size(120, 20);
            this.textBoxV.TabIndex = 28;
            this.textBoxV.Text = "Венулы";
            this.textBoxV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxV.Visible = false;
            // 
            // textBoxK
            // 
            this.textBoxK.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxK.Location = new System.Drawing.Point(12, 204);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.ReadOnly = true;
            this.textBoxK.Size = new System.Drawing.Size(120, 20);
            this.textBoxK.TabIndex = 29;
            this.textBoxK.Text = "Капилляры";
            this.textBoxK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxK.Visible = false;
            // 
            // buttonK
            // 
            this.buttonK.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonK.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonK.Location = new System.Drawing.Point(696, 143);
            this.buttonK.Name = "buttonK";
            this.buttonK.Size = new System.Drawing.Size(15, 15);
            this.buttonK.TabIndex = 30;
            this.buttonK.UseVisualStyleBackColor = false;
            this.buttonK.Click += new System.EventHandler(this.buttonK_Click);
            // 
            // textBoxK_3
            // 
            this.textBoxK_3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxK_3.Location = new System.Drawing.Point(12, 282);
            this.textBoxK_3.Name = "textBoxK_3";
            this.textBoxK_3.ReadOnly = true;
            this.textBoxK_3.Size = new System.Drawing.Size(120, 20);
            this.textBoxK_3.TabIndex = 31;
            this.textBoxK_3.Text = "Кровоток 3";
            this.textBoxK_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxK_3.Visible = false;
            // 
            // textBoxK_2
            // 
            this.textBoxK_2.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxK_2.Location = new System.Drawing.Point(12, 256);
            this.textBoxK_2.Name = "textBoxK_2";
            this.textBoxK_2.ReadOnly = true;
            this.textBoxK_2.Size = new System.Drawing.Size(120, 20);
            this.textBoxK_2.TabIndex = 32;
            this.textBoxK_2.Text = "Кровоток 2";
            this.textBoxK_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxK_2.Visible = false;
            // 
            // textBoxK_1
            // 
            this.textBoxK_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxK_1.Location = new System.Drawing.Point(12, 230);
            this.textBoxK_1.Name = "textBoxK_1";
            this.textBoxK_1.ReadOnly = true;
            this.textBoxK_1.Size = new System.Drawing.Size(120, 20);
            this.textBoxK_1.TabIndex = 33;
            this.textBoxK_1.Text = "Кровоток 1";
            this.textBoxK_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxK_1.Visible = false;
            // 
            // buttonK_1
            // 
            this.buttonK_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonK_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonK_1.Location = new System.Drawing.Point(712, 380);
            this.buttonK_1.Name = "buttonK_1";
            this.buttonK_1.Size = new System.Drawing.Size(15, 15);
            this.buttonK_1.TabIndex = 34;
            this.buttonK_1.UseVisualStyleBackColor = false;
            this.buttonK_1.Click += new System.EventHandler(this.buttonK_1_Click);
            // 
            // buttonK_3
            // 
            this.buttonK_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonK_3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonK_3.Location = new System.Drawing.Point(649, 287);
            this.buttonK_3.Name = "buttonK_3";
            this.buttonK_3.Size = new System.Drawing.Size(15, 15);
            this.buttonK_3.TabIndex = 35;
            this.buttonK_3.UseVisualStyleBackColor = false;
            this.buttonK_3.Click += new System.EventHandler(this.buttonK_3_Click);
            // 
            // buttonK_2
            // 
            this.buttonK_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonK_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonK_2.Location = new System.Drawing.Point(683, 183);
            this.buttonK_2.Name = "buttonK_2";
            this.buttonK_2.Size = new System.Drawing.Size(15, 15);
            this.buttonK_2.TabIndex = 36;
            this.buttonK_2.UseVisualStyleBackColor = false;
            this.buttonK_2.Click += new System.EventHandler(this.buttonK_2_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(12, 594);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(149, 61);
            this.buttonExit.TabIndex = 37;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonOpenAll
            // 
            this.buttonOpenAll.Location = new System.Drawing.Point(15, 445);
            this.buttonOpenAll.Name = "buttonOpenAll";
            this.buttonOpenAll.Size = new System.Drawing.Size(117, 23);
            this.buttonOpenAll.TabIndex = 42;
            this.buttonOpenAll.Text = "Открыть всё";
            this.buttonOpenAll.UseVisualStyleBackColor = true;
            this.buttonOpenAll.Click += new System.EventHandler(this.buttonOpenAll_Click);
            // 
            // checkBoxNerv
            // 
            this.checkBoxNerv.AutoSize = true;
            this.checkBoxNerv.Location = new System.Drawing.Point(856, 418);
            this.checkBoxNerv.Name = "checkBoxNerv";
            this.checkBoxNerv.Size = new System.Drawing.Size(109, 17);
            this.checkBoxNerv.TabIndex = 43;
            this.checkBoxNerv.Text = "Нерв-депрессор";
            this.checkBoxNerv.UseVisualStyleBackColor = true;
            this.checkBoxNerv.Visible = false;
            this.checkBoxNerv.CheckedChanged += new System.EventHandler(this.checkBoxNerv_CheckedChanged);
            // 
            // trackBarRun
            // 
            this.trackBarRun.LargeChange = 1;
            this.trackBarRun.Location = new System.Drawing.Point(856, 511);
            this.trackBarRun.Maximum = 6;
            this.trackBarRun.Name = "trackBarRun";
            this.trackBarRun.Size = new System.Drawing.Size(104, 45);
            this.trackBarRun.TabIndex = 44;
            this.trackBarRun.Value = 4;
            this.trackBarRun.Visible = false;
            this.trackBarRun.Scroll += new System.EventHandler(this.trackBarRun_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(853, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Мамонт догоняет";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Visible = false;
            // 
            // trackBarEat
            // 
            this.trackBarEat.LargeChange = 1;
            this.trackBarEat.Location = new System.Drawing.Point(856, 594);
            this.trackBarEat.Maximum = 6;
            this.trackBarEat.Name = "trackBarEat";
            this.trackBarEat.Size = new System.Drawing.Size(104, 45);
            this.trackBarEat.TabIndex = 46;
            this.trackBarEat.Value = 4;
            this.trackBarEat.Visible = false;
            this.trackBarEat.Scroll += new System.EventHandler(this.trackBarEat_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 578);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Мы зажарили мамонта";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Visible = false;
            // 
            // trackBarThink
            // 
            this.trackBarThink.LargeChange = 1;
            this.trackBarThink.Location = new System.Drawing.Point(856, 670);
            this.trackBarThink.Maximum = 6;
            this.trackBarThink.Name = "trackBarThink";
            this.trackBarThink.Size = new System.Drawing.Size(104, 45);
            this.trackBarThink.TabIndex = 48;
            this.trackBarThink.Value = 4;
            this.trackBarThink.Visible = false;
            this.trackBarThink.Scroll += new System.EventHandler(this.trackBarThink_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(805, 654);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Думаем, как поймать мамонта";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Visible = false;
            // 
            // labelNervComp
            // 
            this.labelNervComp.AutoSize = true;
            this.labelNervComp.Location = new System.Drawing.Point(15, 334);
            this.labelNervComp.Name = "labelNervComp";
            this.labelNervComp.Size = new System.Drawing.Size(33, 13);
            this.labelNervComp.TabIndex = 50;
            this.labelNervComp.Text = "Нерв";
            // 
            // buttonNerv
            // 
            this.buttonNerv.Location = new System.Drawing.Point(865, 444);
            this.buttonNerv.Name = "buttonNerv";
            this.buttonNerv.Size = new System.Drawing.Size(75, 23);
            this.buttonNerv.TabIndex = 51;
            this.buttonNerv.Text = "Нерв";
            this.buttonNerv.UseVisualStyleBackColor = true;
            this.buttonNerv.Click += new System.EventHandler(this.buttonNerv_Click);
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.Location = new System.Drawing.Point(822, 551);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(160, 24);
            this.buttonSaveLog.TabIndex = 52;
            this.buttonSaveLog.Text = "Сохранить данные";
            this.buttonSaveLog.UseVisualStyleBackColor = true;
            this.buttonSaveLog.Click += new System.EventHandler(this.buttonSaveLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Hcccount.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(1280, 766);
            this.ControlBox = false;
            this.Controls.Add(this.buttonSaveLog);
            this.Controls.Add(this.buttonNerv);
            this.Controls.Add(this.labelNervComp);
            this.Controls.Add(this.trackBarThink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.trackBarEat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBarRun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxNerv);
            this.Controls.Add(this.buttonOpenAll);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonK_2);
            this.Controls.Add(this.buttonK_3);
            this.Controls.Add(this.buttonK_1);
            this.Controls.Add(this.textBoxK_1);
            this.Controls.Add(this.textBoxK_2);
            this.Controls.Add(this.textBoxK_3);
            this.Controls.Add(this.buttonK);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.textBoxV);
            this.Controls.Add(this.buttonV);
            this.Controls.Add(this.buttonA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.buttonD);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.buttonOck);
            this.Controls.Add(this.buttonOpss3);
            this.Controls.Add(this.buttonOpss1);
            this.Controls.Add(this.buttonOpss2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonHcc);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.trackBarOpss2);
            this.Controls.Add(this.labelOpss2);
            this.Controls.Add(this.trackBarOpss3);
            this.Controls.Add(this.labelOpss3);
            this.Controls.Add(this.trackBarOck);
            this.Controls.Add(this.labelOck);
            this.Controls.Add(this.trackBarOpss1);
            this.Controls.Add(this.labelOpss1);
            this.Controls.Add(this.labelHcc);
            this.Controls.Add(this.trackBarHcc);
            this.Controls.Add(this.textBoxS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(4196, 2000);
            this.MinimumSize = new System.Drawing.Size(1000, 766);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hcccount";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.trackBarHcc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpss1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpss3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarOpss2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarEat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarThink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar trackBarHcc;
        private System.Windows.Forms.Label labelHcc;
        private System.Windows.Forms.Label labelOpss1;
        private System.Windows.Forms.TrackBar trackBarOpss1;
        private System.Windows.Forms.Label labelOck;
        private System.Windows.Forms.TrackBar trackBarOpss3;
        private System.Windows.Forms.Label labelOpss3;
        private System.Windows.Forms.TrackBar trackBarOpss2;
        private System.Windows.Forms.Label labelOpss2;
        private System.Windows.Forms.Button buttonHcc;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOpss2;
        private System.Windows.Forms.Button buttonOpss1;
        private System.Windows.Forms.Button buttonOpss3;
        private System.Windows.Forms.Button buttonOck;
        public System.Windows.Forms.TextBox textBoxS;
        public System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonD;
        public System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Button buttonA;
        private System.Windows.Forms.Button buttonV;
        public System.Windows.Forms.TextBox textBoxV;
        public System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Button buttonK;
        public System.Windows.Forms.TextBox textBoxK_3;
        public System.Windows.Forms.TextBox textBoxK_2;
        public System.Windows.Forms.TextBox textBoxK_1;
        private System.Windows.Forms.Button buttonK_1;
        private System.Windows.Forms.Button buttonK_3;
        private System.Windows.Forms.Button buttonK_2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TrackBar trackBarOck;
        private System.Windows.Forms.Button buttonOpenAll;
        private System.Windows.Forms.CheckBox checkBoxNerv;
        private System.Windows.Forms.TrackBar trackBarRun;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarEat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarThink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelNervComp;
        private System.Windows.Forms.Button buttonNerv;
        private System.Windows.Forms.Button buttonSaveLog;
    }
}

