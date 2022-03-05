
namespace AutoService
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.GroupBox_1 = new System.Windows.Forms.GroupBox();
            this.Do_Step = new System.Windows.Forms.Button();
            this.RB_Auto = new System.Windows.Forms.RadioButton();
            this.RB_Hand = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.GroupBox_2 = new System.Windows.Forms.GroupBox();
            this.NumTwo = new System.Windows.Forms.NumericUpDown();
            this.L_2 = new System.Windows.Forms.Label();
            this.NumOne = new System.Windows.Forms.NumericUpDown();
            this.L_1 = new System.Windows.Forms.Label();
            this.GroupBox_3 = new System.Windows.Forms.GroupBox();
            this.LinQ_TB = new System.Windows.Forms.TextBox();
            this.L_3 = new System.Windows.Forms.Label();
            this.Two_Group = new System.Windows.Forms.Button();
            this.L_4 = new System.Windows.Forms.Label();
            this.ActionsLog_TB = new System.Windows.Forms.TextBox();
            this.GroupBox_4 = new System.Windows.Forms.GroupBox();
            this.L_17 = new System.Windows.Forms.Label();
            this.L_16 = new System.Windows.Forms.Label();
            this.L_15 = new System.Windows.Forms.Label();
            this.L_14 = new System.Windows.Forms.Label();
            this.L_13 = new System.Windows.Forms.Label();
            this.L_12 = new System.Windows.Forms.Label();
            this.L_11 = new System.Windows.Forms.Label();
            this.Queue_prior_ListBox_4 = new System.Windows.Forms.ListBox();
            this.Queue_prior_ListBox_3 = new System.Windows.Forms.ListBox();
            this.Queue_prior_ListBox_2 = new System.Windows.Forms.ListBox();
            this.Queue_prior_ListBox_1 = new System.Windows.Forms.ListBox();
            this.Queue_ListBox_4 = new System.Windows.Forms.ListBox();
            this.Queue_ListBox_3 = new System.Windows.Forms.ListBox();
            this.Queue_ListBox_2 = new System.Windows.Forms.ListBox();
            this.Queue_ListBox_1 = new System.Windows.Forms.ListBox();
            this.L_10 = new System.Windows.Forms.Label();
            this.L_9 = new System.Windows.Forms.Label();
            this.L_8 = new System.Windows.Forms.Label();
            this.L_7 = new System.Windows.Forms.Label();
            this.L_5 = new System.Windows.Forms.Label();
            this.Check_Electron_TB = new System.Windows.Forms.TextBox();
            this.Well_TB = new System.Windows.Forms.TextBox();
            this.Fluid_change_TB = new System.Windows.Forms.TextBox();
            this.Wash_TB = new System.Windows.Forms.TextBox();
            this.Timer_T = new System.Windows.Forms.Timer(this.components);
            this.GroupBox_1.SuspendLayout();
            this.GroupBox_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOne)).BeginInit();
            this.GroupBox_3.SuspendLayout();
            this.GroupBox_4.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_1
            // 
            this.GroupBox_1.Controls.Add(this.Do_Step);
            this.GroupBox_1.Controls.Add(this.RB_Auto);
            this.GroupBox_1.Controls.Add(this.RB_Hand);
            this.GroupBox_1.Location = new System.Drawing.Point(1123, 7);
            this.GroupBox_1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_1.Name = "GroupBox_1";
            this.GroupBox_1.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_1.Size = new System.Drawing.Size(295, 130);
            this.GroupBox_1.TabIndex = 0;
            this.GroupBox_1.TabStop = false;
            this.GroupBox_1.Text = "Управление";
            // 
            // Do_Step
            // 
            this.Do_Step.BackColor = System.Drawing.Color.Azure;
            this.Do_Step.Location = new System.Drawing.Point(8, 80);
            this.Do_Step.Margin = new System.Windows.Forms.Padding(4);
            this.Do_Step.Name = "Do_Step";
            this.Do_Step.Size = new System.Drawing.Size(279, 36);
            this.Do_Step.TabIndex = 1;
            this.Do_Step.Text = "Выполнить шаг";
            this.Do_Step.UseVisualStyleBackColor = false;
            this.Do_Step.Click += new System.EventHandler(this.Do_Step_Click);
            // 
            // RB_Auto
            // 
            this.RB_Auto.AutoSize = true;
            this.RB_Auto.Location = new System.Drawing.Point(8, 52);
            this.RB_Auto.Margin = new System.Windows.Forms.Padding(4);
            this.RB_Auto.Name = "RB_Auto";
            this.RB_Auto.Size = new System.Drawing.Size(127, 20);
            this.RB_Auto.TabIndex = 1;
            this.RB_Auto.Text = "Автоматически";
            this.RB_Auto.UseVisualStyleBackColor = true;
            this.RB_Auto.CheckedChanged += new System.EventHandler(this.RB_Auto_CheckedChanged);
            // 
            // RB_Hand
            // 
            this.RB_Hand.AutoSize = true;
            this.RB_Hand.Checked = true;
            this.RB_Hand.Location = new System.Drawing.Point(8, 23);
            this.RB_Hand.Margin = new System.Windows.Forms.Padding(4);
            this.RB_Hand.Name = "RB_Hand";
            this.RB_Hand.Size = new System.Drawing.Size(84, 20);
            this.RB_Hand.TabIndex = 2;
            this.RB_Hand.TabStop = true;
            this.RB_Hand.Text = "Вручную";
            this.RB_Hand.UseVisualStyleBackColor = true;
            this.RB_Hand.CheckedChanged += new System.EventHandler(this.RB_Hand_CheckedChanged);
            // 
            // GroupBox_2
            // 
            this.GroupBox_2.Controls.Add(this.NumTwo);
            this.GroupBox_2.Controls.Add(this.L_2);
            this.GroupBox_2.Controls.Add(this.NumOne);
            this.GroupBox_2.Controls.Add(this.L_1);
            this.GroupBox_2.Location = new System.Drawing.Point(1123, 144);
            this.GroupBox_2.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_2.Name = "GroupBox_2";
            this.GroupBox_2.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_2.Size = new System.Drawing.Size(295, 97);
            this.GroupBox_2.TabIndex = 1;
            this.GroupBox_2.TabStop = false;
            this.GroupBox_2.Text = "Новые машины";
            // 
            // NumTwo
            // 
            this.NumTwo.Location = new System.Drawing.Point(223, 62);
            this.NumTwo.Margin = new System.Windows.Forms.Padding(4);
            this.NumTwo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTwo.Name = "NumTwo";
            this.NumTwo.Size = new System.Drawing.Size(64, 22);
            this.NumTwo.TabIndex = 3;
            this.NumTwo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTwo.ValueChanged += new System.EventHandler(this.NumTwo_ValueChanged);
            // 
            // L_2
            // 
            this.L_2.AutoSize = true;
            this.L_2.Location = new System.Drawing.Point(8, 70);
            this.L_2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_2.Name = "L_2";
            this.L_2.Size = new System.Drawing.Size(132, 16);
            this.L_2.TabIndex = 3;
            this.L_2.Text = "Количество от 1 до";
            // 
            // NumOne
            // 
            this.NumOne.Location = new System.Drawing.Point(223, 30);
            this.NumOne.Margin = new System.Windows.Forms.Padding(4);
            this.NumOne.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOne.Name = "NumOne";
            this.NumOne.Size = new System.Drawing.Size(64, 22);
            this.NumOne.TabIndex = 2;
            this.NumOne.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumOne.ValueChanged += new System.EventHandler(this.NumOne_ValueChanged);
            // 
            // L_1
            // 
            this.L_1.AutoSize = true;
            this.L_1.Location = new System.Drawing.Point(8, 38);
            this.L_1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_1.Name = "L_1";
            this.L_1.Size = new System.Drawing.Size(193, 16);
            this.L_1.TabIndex = 2;
            this.L_1.Text = "Вероятность появления 1 из";
            // 
            // GroupBox_3
            // 
            this.GroupBox_3.Controls.Add(this.LinQ_TB);
            this.GroupBox_3.Controls.Add(this.L_3);
            this.GroupBox_3.Controls.Add(this.Two_Group);
            this.GroupBox_3.Location = new System.Drawing.Point(1123, 249);
            this.GroupBox_3.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_3.Name = "GroupBox_3";
            this.GroupBox_3.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_3.Size = new System.Drawing.Size(295, 405);
            this.GroupBox_3.TabIndex = 2;
            this.GroupBox_3.TabStop = false;
            this.GroupBox_3.Text = "Отчет";
            // 
            // LinQ_TB
            // 
            this.LinQ_TB.Location = new System.Drawing.Point(8, 120);
            this.LinQ_TB.Multiline = true;
            this.LinQ_TB.Name = "LinQ_TB";
            this.LinQ_TB.ReadOnly = true;
            this.LinQ_TB.Size = new System.Drawing.Size(279, 278);
            this.LinQ_TB.TabIndex = 7;
            // 
            // L_3
            // 
            this.L_3.AutoSize = true;
            this.L_3.Location = new System.Drawing.Point(8, 98);
            this.L_3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_3.Name = "L_3";
            this.L_3.Size = new System.Drawing.Size(135, 16);
            this.L_3.TabIndex = 3;
            this.L_3.Text = "Результат запроса";
            // 
            // Two_Group
            // 
            this.Two_Group.BackColor = System.Drawing.Color.Azure;
            this.Two_Group.Location = new System.Drawing.Point(8, 23);
            this.Two_Group.Margin = new System.Windows.Forms.Padding(4);
            this.Two_Group.Name = "Two_Group";
            this.Two_Group.Size = new System.Drawing.Size(279, 59);
            this.Two_Group.TabIndex = 1;
            this.Two_Group.Text = "Двухуровневая группировка по принадлежности автомобиля к одной из двух групп";
            this.Two_Group.UseVisualStyleBackColor = false;
            this.Two_Group.Click += new System.EventHandler(this.Two_Group_Click);
            // 
            // L_4
            // 
            this.L_4.AutoSize = true;
            this.L_4.Location = new System.Drawing.Point(10, 448);
            this.L_4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_4.Name = "L_4";
            this.L_4.Size = new System.Drawing.Size(284, 16);
            this.L_4.TabIndex = 4;
            this.L_4.Text = "Действия, выполнение на последнем шаге";
            // 
            // ActionsLog_TB
            // 
            this.ActionsLog_TB.BackColor = System.Drawing.Color.AliceBlue;
            this.ActionsLog_TB.Location = new System.Drawing.Point(13, 468);
            this.ActionsLog_TB.Margin = new System.Windows.Forms.Padding(4);
            this.ActionsLog_TB.Multiline = true;
            this.ActionsLog_TB.Name = "ActionsLog_TB";
            this.ActionsLog_TB.ReadOnly = true;
            this.ActionsLog_TB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ActionsLog_TB.Size = new System.Drawing.Size(1102, 179);
            this.ActionsLog_TB.TabIndex = 5;
            // 
            // GroupBox_4
            // 
            this.GroupBox_4.Controls.Add(this.L_17);
            this.GroupBox_4.Controls.Add(this.L_16);
            this.GroupBox_4.Controls.Add(this.L_15);
            this.GroupBox_4.Controls.Add(this.L_14);
            this.GroupBox_4.Controls.Add(this.L_13);
            this.GroupBox_4.Controls.Add(this.L_12);
            this.GroupBox_4.Controls.Add(this.L_11);
            this.GroupBox_4.Controls.Add(this.Queue_prior_ListBox_4);
            this.GroupBox_4.Controls.Add(this.Queue_prior_ListBox_3);
            this.GroupBox_4.Controls.Add(this.Queue_prior_ListBox_2);
            this.GroupBox_4.Controls.Add(this.Queue_prior_ListBox_1);
            this.GroupBox_4.Controls.Add(this.Queue_ListBox_4);
            this.GroupBox_4.Controls.Add(this.Queue_ListBox_3);
            this.GroupBox_4.Controls.Add(this.Queue_ListBox_2);
            this.GroupBox_4.Controls.Add(this.Queue_ListBox_1);
            this.GroupBox_4.Controls.Add(this.L_10);
            this.GroupBox_4.Controls.Add(this.L_9);
            this.GroupBox_4.Controls.Add(this.L_8);
            this.GroupBox_4.Controls.Add(this.L_7);
            this.GroupBox_4.Controls.Add(this.L_5);
            this.GroupBox_4.Controls.Add(this.Check_Electron_TB);
            this.GroupBox_4.Controls.Add(this.Well_TB);
            this.GroupBox_4.Controls.Add(this.Fluid_change_TB);
            this.GroupBox_4.Controls.Add(this.Wash_TB);
            this.GroupBox_4.Location = new System.Drawing.Point(16, 7);
            this.GroupBox_4.Margin = new System.Windows.Forms.Padding(4);
            this.GroupBox_4.Name = "GroupBox_4";
            this.GroupBox_4.Padding = new System.Windows.Forms.Padding(4);
            this.GroupBox_4.Size = new System.Drawing.Size(1099, 437);
            this.GroupBox_4.TabIndex = 6;
            this.GroupBox_4.TabStop = false;
            this.GroupBox_4.Text = "CTO ";
            // 
            // L_17
            // 
            this.L_17.AutoSize = true;
            this.L_17.Location = new System.Drawing.Point(961, 82);
            this.L_17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_17.Name = "L_17";
            this.L_17.Size = new System.Drawing.Size(79, 16);
            this.L_17.TabIndex = 35;
            this.L_17.Text = "Приоритет";
            // 
            // L_16
            // 
            this.L_16.AutoSize = true;
            this.L_16.Location = new System.Drawing.Point(828, 82);
            this.L_16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_16.Name = "L_16";
            this.L_16.Size = new System.Drawing.Size(67, 16);
            this.L_16.TabIndex = 34;
            this.L_16.Text = "Обычные";
            // 
            // L_15
            // 
            this.L_15.AutoSize = true;
            this.L_15.Location = new System.Drawing.Point(691, 82);
            this.L_15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_15.Name = "L_15";
            this.L_15.Size = new System.Drawing.Size(79, 16);
            this.L_15.TabIndex = 33;
            this.L_15.Text = "Приоритет";
            // 
            // L_14
            // 
            this.L_14.AutoSize = true;
            this.L_14.Location = new System.Drawing.Point(558, 82);
            this.L_14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_14.Name = "L_14";
            this.L_14.Size = new System.Drawing.Size(67, 16);
            this.L_14.TabIndex = 32;
            this.L_14.Text = "Обычные";
            // 
            // L_13
            // 
            this.L_13.AutoSize = true;
            this.L_13.Location = new System.Drawing.Point(421, 82);
            this.L_13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_13.Name = "L_13";
            this.L_13.Size = new System.Drawing.Size(79, 16);
            this.L_13.TabIndex = 31;
            this.L_13.Text = "Приоритет";
            // 
            // L_12
            // 
            this.L_12.AutoSize = true;
            this.L_12.Location = new System.Drawing.Point(286, 82);
            this.L_12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_12.Name = "L_12";
            this.L_12.Size = new System.Drawing.Size(67, 16);
            this.L_12.TabIndex = 30;
            this.L_12.Text = "Обычные";
            // 
            // L_11
            // 
            this.L_11.AutoSize = true;
            this.L_11.Location = new System.Drawing.Point(151, 82);
            this.L_11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_11.Name = "L_11";
            this.L_11.Size = new System.Drawing.Size(79, 16);
            this.L_11.TabIndex = 29;
            this.L_11.Text = "Приоритет";
            // 
            // Queue_prior_ListBox_4
            // 
            this.Queue_prior_ListBox_4.BackColor = System.Drawing.Color.AliceBlue;
            this.Queue_prior_ListBox_4.FormattingEnabled = true;
            this.Queue_prior_ListBox_4.ItemHeight = 16;
            this.Queue_prior_ListBox_4.Location = new System.Drawing.Point(964, 102);
            this.Queue_prior_ListBox_4.Margin = new System.Windows.Forms.Padding(4);
            this.Queue_prior_ListBox_4.Name = "Queue_prior_ListBox_4";
            this.Queue_prior_ListBox_4.Size = new System.Drawing.Size(127, 324);
            this.Queue_prior_ListBox_4.TabIndex = 28;
            // 
            // Queue_prior_ListBox_3
            // 
            this.Queue_prior_ListBox_3.BackColor = System.Drawing.Color.AliceBlue;
            this.Queue_prior_ListBox_3.FormattingEnabled = true;
            this.Queue_prior_ListBox_3.ItemHeight = 16;
            this.Queue_prior_ListBox_3.Location = new System.Drawing.Point(694, 102);
            this.Queue_prior_ListBox_3.Margin = new System.Windows.Forms.Padding(4);
            this.Queue_prior_ListBox_3.Name = "Queue_prior_ListBox_3";
            this.Queue_prior_ListBox_3.Size = new System.Drawing.Size(127, 324);
            this.Queue_prior_ListBox_3.TabIndex = 27;
            // 
            // Queue_prior_ListBox_2
            // 
            this.Queue_prior_ListBox_2.BackColor = System.Drawing.Color.AliceBlue;
            this.Queue_prior_ListBox_2.FormattingEnabled = true;
            this.Queue_prior_ListBox_2.ItemHeight = 16;
            this.Queue_prior_ListBox_2.Location = new System.Drawing.Point(424, 102);
            this.Queue_prior_ListBox_2.Margin = new System.Windows.Forms.Padding(4);
            this.Queue_prior_ListBox_2.Name = "Queue_prior_ListBox_2";
            this.Queue_prior_ListBox_2.Size = new System.Drawing.Size(127, 324);
            this.Queue_prior_ListBox_2.TabIndex = 26;
            // 
            // Queue_prior_ListBox_1
            // 
            this.Queue_prior_ListBox_1.BackColor = System.Drawing.Color.AliceBlue;
            this.Queue_prior_ListBox_1.FormattingEnabled = true;
            this.Queue_prior_ListBox_1.ItemHeight = 16;
            this.Queue_prior_ListBox_1.Location = new System.Drawing.Point(154, 102);
            this.Queue_prior_ListBox_1.Margin = new System.Windows.Forms.Padding(4);
            this.Queue_prior_ListBox_1.Name = "Queue_prior_ListBox_1";
            this.Queue_prior_ListBox_1.Size = new System.Drawing.Size(127, 324);
            this.Queue_prior_ListBox_1.TabIndex = 25;
            // 
            // Queue_ListBox_4
            // 
            this.Queue_ListBox_4.BackColor = System.Drawing.Color.AliceBlue;
            this.Queue_ListBox_4.FormattingEnabled = true;
            this.Queue_ListBox_4.ItemHeight = 16;
            this.Queue_ListBox_4.Location = new System.Drawing.Point(829, 102);
            this.Queue_ListBox_4.Margin = new System.Windows.Forms.Padding(4);
            this.Queue_ListBox_4.Name = "Queue_ListBox_4";
            this.Queue_ListBox_4.Size = new System.Drawing.Size(127, 324);
            this.Queue_ListBox_4.TabIndex = 22;
            // 
            // Queue_ListBox_3
            // 
            this.Queue_ListBox_3.BackColor = System.Drawing.Color.AliceBlue;
            this.Queue_ListBox_3.FormattingEnabled = true;
            this.Queue_ListBox_3.ItemHeight = 16;
            this.Queue_ListBox_3.Location = new System.Drawing.Point(559, 102);
            this.Queue_ListBox_3.Margin = new System.Windows.Forms.Padding(4);
            this.Queue_ListBox_3.Name = "Queue_ListBox_3";
            this.Queue_ListBox_3.Size = new System.Drawing.Size(127, 324);
            this.Queue_ListBox_3.TabIndex = 21;
            // 
            // Queue_ListBox_2
            // 
            this.Queue_ListBox_2.BackColor = System.Drawing.Color.AliceBlue;
            this.Queue_ListBox_2.FormattingEnabled = true;
            this.Queue_ListBox_2.ItemHeight = 16;
            this.Queue_ListBox_2.Location = new System.Drawing.Point(289, 102);
            this.Queue_ListBox_2.Margin = new System.Windows.Forms.Padding(4);
            this.Queue_ListBox_2.Name = "Queue_ListBox_2";
            this.Queue_ListBox_2.Size = new System.Drawing.Size(127, 324);
            this.Queue_ListBox_2.TabIndex = 20;
            // 
            // Queue_ListBox_1
            // 
            this.Queue_ListBox_1.BackColor = System.Drawing.Color.AliceBlue;
            this.Queue_ListBox_1.FormattingEnabled = true;
            this.Queue_ListBox_1.ItemHeight = 16;
            this.Queue_ListBox_1.Location = new System.Drawing.Point(21, 102);
            this.Queue_ListBox_1.Margin = new System.Windows.Forms.Padding(4);
            this.Queue_ListBox_1.Name = "Queue_ListBox_1";
            this.Queue_ListBox_1.Size = new System.Drawing.Size(125, 324);
            this.Queue_ListBox_1.TabIndex = 19;
            // 
            // L_10
            // 
            this.L_10.AutoSize = true;
            this.L_10.Location = new System.Drawing.Point(826, 33);
            this.L_10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_10.Name = "L_10";
            this.L_10.Size = new System.Drawing.Size(160, 16);
            this.L_10.TabIndex = 18;
            this.L_10.Text = "Проверка электроники";
            // 
            // L_9
            // 
            this.L_9.AutoSize = true;
            this.L_9.Location = new System.Drawing.Point(286, 31);
            this.L_9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_9.Name = "L_9";
            this.L_9.Size = new System.Drawing.Size(122, 16);
            this.L_9.TabIndex = 17;
            this.L_9.Text = "Замена жидкости";
            // 
            // L_8
            // 
            this.L_8.AutoSize = true;
            this.L_8.Location = new System.Drawing.Point(556, 33);
            this.L_8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_8.Name = "L_8";
            this.L_8.Size = new System.Drawing.Size(143, 16);
            this.L_8.TabIndex = 16;
            this.L_8.Text = "Балансировка колес";
            // 
            // L_7
            // 
            this.L_7.AutoSize = true;
            this.L_7.Location = new System.Drawing.Point(18, 30);
            this.L_7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_7.Name = "L_7";
            this.L_7.Size = new System.Drawing.Size(49, 16);
            this.L_7.TabIndex = 15;
            this.L_7.Text = "Мойка";
            // 
            // L_5
            // 
            this.L_5.AutoSize = true;
            this.L_5.Location = new System.Drawing.Point(18, 82);
            this.L_5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.L_5.Name = "L_5";
            this.L_5.Size = new System.Drawing.Size(67, 16);
            this.L_5.TabIndex = 13;
            this.L_5.Text = "Обычные";
            // 
            // Check_Electron_TB
            // 
            this.Check_Electron_TB.BackColor = System.Drawing.Color.Azure;
            this.Check_Electron_TB.Location = new System.Drawing.Point(829, 51);
            this.Check_Electron_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Check_Electron_TB.Name = "Check_Electron_TB";
            this.Check_Electron_TB.ReadOnly = true;
            this.Check_Electron_TB.Size = new System.Drawing.Size(262, 22);
            this.Check_Electron_TB.TabIndex = 10;
            // 
            // Well_TB
            // 
            this.Well_TB.BackColor = System.Drawing.Color.Azure;
            this.Well_TB.Location = new System.Drawing.Point(289, 51);
            this.Well_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Well_TB.Name = "Well_TB";
            this.Well_TB.ReadOnly = true;
            this.Well_TB.Size = new System.Drawing.Size(262, 22);
            this.Well_TB.TabIndex = 9;
            // 
            // Fluid_change_TB
            // 
            this.Fluid_change_TB.BackColor = System.Drawing.Color.Azure;
            this.Fluid_change_TB.Location = new System.Drawing.Point(559, 51);
            this.Fluid_change_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Fluid_change_TB.Name = "Fluid_change_TB";
            this.Fluid_change_TB.ReadOnly = true;
            this.Fluid_change_TB.Size = new System.Drawing.Size(262, 22);
            this.Fluid_change_TB.TabIndex = 8;
            // 
            // Wash_TB
            // 
            this.Wash_TB.BackColor = System.Drawing.Color.Azure;
            this.Wash_TB.Location = new System.Drawing.Point(21, 50);
            this.Wash_TB.Margin = new System.Windows.Forms.Padding(4);
            this.Wash_TB.Name = "Wash_TB";
            this.Wash_TB.ReadOnly = true;
            this.Wash_TB.Size = new System.Drawing.Size(260, 22);
            this.Wash_TB.TabIndex = 7;
            // 
            // Timer_T
            // 
            this.Timer_T.Tick += new System.EventHandler(this.Timer_T_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1431, 663);
            this.Controls.Add(this.GroupBox_4);
            this.Controls.Add(this.ActionsLog_TB);
            this.Controls.Add(this.L_4);
            this.Controls.Add(this.GroupBox_3);
            this.Controls.Add(this.GroupBox_2);
            this.Controls.Add(this.GroupBox_1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автосервис";
            this.Load += new System.EventHandler(this.Main_Load);
            this.GroupBox_1.ResumeLayout(false);
            this.GroupBox_1.PerformLayout();
            this.GroupBox_2.ResumeLayout(false);
            this.GroupBox_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOne)).EndInit();
            this.GroupBox_3.ResumeLayout(false);
            this.GroupBox_3.PerformLayout();
            this.GroupBox_4.ResumeLayout(false);
            this.GroupBox_4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_1;
        private System.Windows.Forms.Button Do_Step;
        private System.Windows.Forms.RadioButton RB_Auto;
        private System.Windows.Forms.RadioButton RB_Hand;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox GroupBox_2;
        private System.Windows.Forms.Label L_1;
        private System.Windows.Forms.Label L_2;
        private System.Windows.Forms.NumericUpDown NumTwo;
        private System.Windows.Forms.NumericUpDown NumOne;
        private System.Windows.Forms.GroupBox GroupBox_3;
        private System.Windows.Forms.Button Two_Group;
        private System.Windows.Forms.Label L_3;
        private System.Windows.Forms.Label L_4;
        private System.Windows.Forms.TextBox ActionsLog_TB;
        private System.Windows.Forms.GroupBox GroupBox_4;
        private System.Windows.Forms.TextBox Check_Electron_TB;
        private System.Windows.Forms.TextBox Well_TB;
        private System.Windows.Forms.TextBox Fluid_change_TB;
        private System.Windows.Forms.TextBox Wash_TB;
        private System.Windows.Forms.Label L_5;
        private System.Windows.Forms.Label L_10;
        private System.Windows.Forms.Label L_9;
        private System.Windows.Forms.Label L_8;
        private System.Windows.Forms.Label L_7;
        private System.Windows.Forms.ListBox Queue_ListBox_2;
        private System.Windows.Forms.ListBox Queue_ListBox_1;
        private System.Windows.Forms.TextBox LinQ_TB;
        private System.Windows.Forms.ListBox Queue_ListBox_4;
        private System.Windows.Forms.ListBox Queue_ListBox_3;
        private System.Windows.Forms.Timer Timer_T;
        private System.Windows.Forms.ListBox Queue_prior_ListBox_4;
        private System.Windows.Forms.ListBox Queue_prior_ListBox_3;
        private System.Windows.Forms.ListBox Queue_prior_ListBox_2;
        private System.Windows.Forms.ListBox Queue_prior_ListBox_1;
        private System.Windows.Forms.Label L_11;
        private System.Windows.Forms.Label L_17;
        private System.Windows.Forms.Label L_16;
        private System.Windows.Forms.Label L_15;
        private System.Windows.Forms.Label L_14;
        private System.Windows.Forms.Label L_13;
        private System.Windows.Forms.Label L_12;
    }
}

