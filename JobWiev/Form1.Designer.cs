namespace JobWiev
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
            this.Task1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MoneyHour = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MoneySecond = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Task2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Task3 = new System.Windows.Forms.TextBox();
            this.buttonTask1 = new System.Windows.Forms.Button();
            this.buttonTask2 = new System.Windows.Forms.Button();
            this.buttonTask3 = new System.Windows.Forms.Button();
            this.buttonTaskStop = new System.Windows.Forms.Button();
            this.TimerJob = new System.Windows.Forms.Timer(this.components);
            this.TaskInfo1 = new System.Windows.Forms.TextBox();
            this.TaskHour1 = new System.Windows.Forms.TextBox();
            this.TaskSumma1 = new System.Windows.Forms.TextBox();
            this.TaskMinute1 = new System.Windows.Forms.TextBox();
            this.TaskMinute2 = new System.Windows.Forms.TextBox();
            this.TaskSumma2 = new System.Windows.Forms.TextBox();
            this.TaskHour2 = new System.Windows.Forms.TextBox();
            this.TaskInfo2 = new System.Windows.Forms.TextBox();
            this.TaskMinute3 = new System.Windows.Forms.TextBox();
            this.TaskSumma3 = new System.Windows.Forms.TextBox();
            this.TaskHour3 = new System.Windows.Forms.TextBox();
            this.TaskInfo3 = new System.Windows.Forms.TextBox();
            this.TaskMinuteITOG = new System.Windows.Forms.TextBox();
            this.TaskSummaITOG = new System.Windows.Forms.TextBox();
            this.TaskHourITOG = new System.Windows.Forms.TextBox();
            this.TaskInfoITOG = new System.Windows.Forms.TextBox();
            this.buttonSBROS = new System.Windows.Forms.Button();
            this.buttonAdd_30 = new System.Windows.Forms.Button();
            this.buttonMinus_30 = new System.Windows.Forms.Button();
            this.buttonMinus_10 = new System.Windows.Forms.Button();
            this.buttonAdd_10 = new System.Windows.Forms.Button();
            this.buttonMinus_5 = new System.Windows.Forms.Button();
            this.buttonAdd_5 = new System.Windows.Forms.Button();
            this.buttonLast1 = new System.Windows.Forms.Button();
            this.buttonNext1 = new System.Windows.Forms.Button();
            this.buttonModify1 = new System.Windows.Forms.Button();
            this.buttonModify2 = new System.Windows.Forms.Button();
            this.buttonNext2 = new System.Windows.Forms.Button();
            this.buttonLast2 = new System.Windows.Forms.Button();
            this.buttonModify3 = new System.Windows.Forms.Button();
            this.buttonNext3 = new System.Windows.Forms.Button();
            this.buttonLast3 = new System.Windows.Forms.Button();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Task1
            // 
            this.Task1.Location = new System.Drawing.Point(93, 34);
            this.Task1.Name = "Task1";
            this.Task1.Size = new System.Drawing.Size(179, 20);
            this.Task1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Задача №1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ставка в час:";
            // 
            // MoneyHour
            // 
            this.MoneyHour.Location = new System.Drawing.Point(93, 8);
            this.MoneyHour.Name = "MoneyHour";
            this.MoneyHour.Size = new System.Drawing.Size(53, 20);
            this.MoneyHour.TabIndex = 2;
            this.MoneyHour.Text = "600";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(152, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ставка в сек:";
            // 
            // MoneySecond
            // 
            this.MoneySecond.Location = new System.Drawing.Point(232, 8);
            this.MoneySecond.Name = "MoneySecond";
            this.MoneySecond.ReadOnly = true;
            this.MoneySecond.Size = new System.Drawing.Size(40, 20);
            this.MoneySecond.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Задача №2:";
            // 
            // Task2
            // 
            this.Task2.Location = new System.Drawing.Point(93, 61);
            this.Task2.Name = "Task2";
            this.Task2.Size = new System.Drawing.Size(179, 20);
            this.Task2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Задача №3:";
            // 
            // Task3
            // 
            this.Task3.Location = new System.Drawing.Point(93, 90);
            this.Task3.Name = "Task3";
            this.Task3.Size = new System.Drawing.Size(179, 20);
            this.Task3.TabIndex = 8;
            // 
            // buttonTask1
            // 
            this.buttonTask1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTask1.Location = new System.Drawing.Point(12, 125);
            this.buttonTask1.Name = "buttonTask1";
            this.buttonTask1.Size = new System.Drawing.Size(72, 23);
            this.buttonTask1.TabIndex = 10;
            this.buttonTask1.Text = "Задача №1";
            this.buttonTask1.UseVisualStyleBackColor = true;
            this.buttonTask1.Click += new System.EventHandler(this.buttonTask1_Click);
            // 
            // buttonTask2
            // 
            this.buttonTask2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTask2.Location = new System.Drawing.Point(105, 125);
            this.buttonTask2.Name = "buttonTask2";
            this.buttonTask2.Size = new System.Drawing.Size(72, 23);
            this.buttonTask2.TabIndex = 11;
            this.buttonTask2.Text = "Задача №2";
            this.buttonTask2.UseVisualStyleBackColor = true;
            this.buttonTask2.Click += new System.EventHandler(this.buttonTask2_Click);
            // 
            // buttonTask3
            // 
            this.buttonTask3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTask3.Location = new System.Drawing.Point(200, 125);
            this.buttonTask3.Name = "buttonTask3";
            this.buttonTask3.Size = new System.Drawing.Size(72, 23);
            this.buttonTask3.TabIndex = 12;
            this.buttonTask3.Text = "Задача №3";
            this.buttonTask3.UseVisualStyleBackColor = true;
            this.buttonTask3.Click += new System.EventHandler(this.buttonTask3_Click);
            // 
            // buttonTaskStop
            // 
            this.buttonTaskStop.BackColor = System.Drawing.Color.Green;
            this.buttonTaskStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonTaskStop.Location = new System.Drawing.Point(12, 154);
            this.buttonTaskStop.Name = "buttonTaskStop";
            this.buttonTaskStop.Size = new System.Drawing.Size(72, 23);
            this.buttonTaskStop.TabIndex = 13;
            this.buttonTaskStop.Text = "СТОП";
            this.buttonTaskStop.UseVisualStyleBackColor = false;
            this.buttonTaskStop.Click += new System.EventHandler(this.buttonTaskStop_Click);
            // 
            // TimerJob
            // 
            this.TimerJob.Interval = 1000;
            this.TimerJob.Tick += new System.EventHandler(this.TimerJob_Tick);
            // 
            // TaskInfo1
            // 
            this.TaskInfo1.Location = new System.Drawing.Point(12, 188);
            this.TaskInfo1.Name = "TaskInfo1";
            this.TaskInfo1.ReadOnly = true;
            this.TaskInfo1.Size = new System.Drawing.Size(75, 20);
            this.TaskInfo1.TabIndex = 14;
            this.TaskInfo1.Text = "Задача №1";
            // 
            // TaskHour1
            // 
            this.TaskHour1.Location = new System.Drawing.Point(86, 188);
            this.TaskHour1.Name = "TaskHour1";
            this.TaskHour1.ReadOnly = true;
            this.TaskHour1.Size = new System.Drawing.Size(35, 20);
            this.TaskHour1.TabIndex = 15;
            // 
            // TaskSumma1
            // 
            this.TaskSumma1.Location = new System.Drawing.Point(165, 188);
            this.TaskSumma1.Name = "TaskSumma1";
            this.TaskSumma1.ReadOnly = true;
            this.TaskSumma1.Size = new System.Drawing.Size(66, 20);
            this.TaskSumma1.TabIndex = 16;
            // 
            // TaskMinute1
            // 
            this.TaskMinute1.Location = new System.Drawing.Point(120, 188);
            this.TaskMinute1.Name = "TaskMinute1";
            this.TaskMinute1.ReadOnly = true;
            this.TaskMinute1.Size = new System.Drawing.Size(46, 20);
            this.TaskMinute1.TabIndex = 17;
            // 
            // TaskMinute2
            // 
            this.TaskMinute2.Location = new System.Drawing.Point(120, 214);
            this.TaskMinute2.Name = "TaskMinute2";
            this.TaskMinute2.ReadOnly = true;
            this.TaskMinute2.Size = new System.Drawing.Size(46, 20);
            this.TaskMinute2.TabIndex = 21;
            // 
            // TaskSumma2
            // 
            this.TaskSumma2.Location = new System.Drawing.Point(165, 214);
            this.TaskSumma2.Name = "TaskSumma2";
            this.TaskSumma2.ReadOnly = true;
            this.TaskSumma2.Size = new System.Drawing.Size(66, 20);
            this.TaskSumma2.TabIndex = 20;
            // 
            // TaskHour2
            // 
            this.TaskHour2.Location = new System.Drawing.Point(86, 214);
            this.TaskHour2.Name = "TaskHour2";
            this.TaskHour2.ReadOnly = true;
            this.TaskHour2.Size = new System.Drawing.Size(35, 20);
            this.TaskHour2.TabIndex = 19;
            // 
            // TaskInfo2
            // 
            this.TaskInfo2.Location = new System.Drawing.Point(12, 214);
            this.TaskInfo2.Name = "TaskInfo2";
            this.TaskInfo2.ReadOnly = true;
            this.TaskInfo2.Size = new System.Drawing.Size(75, 20);
            this.TaskInfo2.TabIndex = 18;
            this.TaskInfo2.Text = "Задача №2";
            // 
            // TaskMinute3
            // 
            this.TaskMinute3.Location = new System.Drawing.Point(120, 240);
            this.TaskMinute3.Name = "TaskMinute3";
            this.TaskMinute3.ReadOnly = true;
            this.TaskMinute3.Size = new System.Drawing.Size(46, 20);
            this.TaskMinute3.TabIndex = 25;
            // 
            // TaskSumma3
            // 
            this.TaskSumma3.Location = new System.Drawing.Point(165, 240);
            this.TaskSumma3.Name = "TaskSumma3";
            this.TaskSumma3.ReadOnly = true;
            this.TaskSumma3.Size = new System.Drawing.Size(66, 20);
            this.TaskSumma3.TabIndex = 24;
            // 
            // TaskHour3
            // 
            this.TaskHour3.Location = new System.Drawing.Point(86, 240);
            this.TaskHour3.Name = "TaskHour3";
            this.TaskHour3.ReadOnly = true;
            this.TaskHour3.Size = new System.Drawing.Size(35, 20);
            this.TaskHour3.TabIndex = 23;
            // 
            // TaskInfo3
            // 
            this.TaskInfo3.Location = new System.Drawing.Point(12, 240);
            this.TaskInfo3.Name = "TaskInfo3";
            this.TaskInfo3.ReadOnly = true;
            this.TaskInfo3.Size = new System.Drawing.Size(75, 20);
            this.TaskInfo3.TabIndex = 22;
            this.TaskInfo3.Text = "Задача №3";
            // 
            // TaskMinuteITOG
            // 
            this.TaskMinuteITOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskMinuteITOG.Location = new System.Drawing.Point(120, 266);
            this.TaskMinuteITOG.Name = "TaskMinuteITOG";
            this.TaskMinuteITOG.ReadOnly = true;
            this.TaskMinuteITOG.Size = new System.Drawing.Size(46, 20);
            this.TaskMinuteITOG.TabIndex = 29;
            // 
            // TaskSummaITOG
            // 
            this.TaskSummaITOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskSummaITOG.Location = new System.Drawing.Point(165, 266);
            this.TaskSummaITOG.Name = "TaskSummaITOG";
            this.TaskSummaITOG.ReadOnly = true;
            this.TaskSummaITOG.Size = new System.Drawing.Size(66, 20);
            this.TaskSummaITOG.TabIndex = 28;
            // 
            // TaskHourITOG
            // 
            this.TaskHourITOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskHourITOG.Location = new System.Drawing.Point(86, 266);
            this.TaskHourITOG.Name = "TaskHourITOG";
            this.TaskHourITOG.ReadOnly = true;
            this.TaskHourITOG.Size = new System.Drawing.Size(35, 20);
            this.TaskHourITOG.TabIndex = 27;
            // 
            // TaskInfoITOG
            // 
            this.TaskInfoITOG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TaskInfoITOG.Location = new System.Drawing.Point(12, 266);
            this.TaskInfoITOG.Name = "TaskInfoITOG";
            this.TaskInfoITOG.ReadOnly = true;
            this.TaskInfoITOG.Size = new System.Drawing.Size(75, 20);
            this.TaskInfoITOG.TabIndex = 26;
            this.TaskInfoITOG.Text = "ИТОГО";
            // 
            // buttonSBROS
            // 
            this.buttonSBROS.BackColor = System.Drawing.SystemColors.Control;
            this.buttonSBROS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSBROS.Location = new System.Drawing.Point(200, 154);
            this.buttonSBROS.Name = "buttonSBROS";
            this.buttonSBROS.Size = new System.Drawing.Size(72, 23);
            this.buttonSBROS.TabIndex = 13;
            this.buttonSBROS.Text = "СБРОС";
            this.buttonSBROS.UseVisualStyleBackColor = false;
            this.buttonSBROS.Click += new System.EventHandler(this.buttonSBROS_Click);
            // 
            // buttonAdd_30
            // 
            this.buttonAdd_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd_30.Location = new System.Drawing.Point(93, 152);
            this.buttonAdd_30.Name = "buttonAdd_30";
            this.buttonAdd_30.Size = new System.Drawing.Size(28, 15);
            this.buttonAdd_30.TabIndex = 30;
            this.buttonAdd_30.Text = "30";
            this.buttonAdd_30.UseVisualStyleBackColor = true;
            this.buttonAdd_30.Click += new System.EventHandler(this.buttonAdd_30_Click);
            // 
            // buttonMinus_30
            // 
            this.buttonMinus_30.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus_30.Location = new System.Drawing.Point(93, 166);
            this.buttonMinus_30.Name = "buttonMinus_30";
            this.buttonMinus_30.Size = new System.Drawing.Size(28, 15);
            this.buttonMinus_30.TabIndex = 33;
            this.buttonMinus_30.Text = "-30";
            this.buttonMinus_30.UseVisualStyleBackColor = true;
            this.buttonMinus_30.Click += new System.EventHandler(this.buttonMinus_30_Click);
            // 
            // buttonMinus_10
            // 
            this.buttonMinus_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus_10.Location = new System.Drawing.Point(127, 166);
            this.buttonMinus_10.Name = "buttonMinus_10";
            this.buttonMinus_10.Size = new System.Drawing.Size(28, 15);
            this.buttonMinus_10.TabIndex = 35;
            this.buttonMinus_10.Text = "-10";
            this.buttonMinus_10.UseVisualStyleBackColor = true;
            this.buttonMinus_10.Click += new System.EventHandler(this.buttonMinus_10_Click);
            // 
            // buttonAdd_10
            // 
            this.buttonAdd_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd_10.Location = new System.Drawing.Point(127, 152);
            this.buttonAdd_10.Name = "buttonAdd_10";
            this.buttonAdd_10.Size = new System.Drawing.Size(28, 15);
            this.buttonAdd_10.TabIndex = 34;
            this.buttonAdd_10.Text = "10";
            this.buttonAdd_10.UseVisualStyleBackColor = true;
            this.buttonAdd_10.Click += new System.EventHandler(this.buttonAdd_10_Click);
            // 
            // buttonMinus_5
            // 
            this.buttonMinus_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus_5.Location = new System.Drawing.Point(161, 166);
            this.buttonMinus_5.Name = "buttonMinus_5";
            this.buttonMinus_5.Size = new System.Drawing.Size(28, 15);
            this.buttonMinus_5.TabIndex = 37;
            this.buttonMinus_5.Text = "-5";
            this.buttonMinus_5.UseVisualStyleBackColor = true;
            this.buttonMinus_5.Click += new System.EventHandler(this.buttonMinus_5_Click);
            // 
            // buttonAdd_5
            // 
            this.buttonAdd_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd_5.Location = new System.Drawing.Point(161, 152);
            this.buttonAdd_5.Name = "buttonAdd_5";
            this.buttonAdd_5.Size = new System.Drawing.Size(28, 15);
            this.buttonAdd_5.TabIndex = 36;
            this.buttonAdd_5.Text = "5";
            this.buttonAdd_5.UseVisualStyleBackColor = true;
            this.buttonAdd_5.Click += new System.EventHandler(this.buttonAdd_5_Click);
            // 
            // buttonLast1
            // 
            this.buttonLast1.Location = new System.Drawing.Point(231, 188);
            this.buttonLast1.Name = "buttonLast1";
            this.buttonLast1.Size = new System.Drawing.Size(13, 19);
            this.buttonLast1.TabIndex = 38;
            this.buttonLast1.Text = "<";
            this.buttonLast1.UseVisualStyleBackColor = true;
            this.buttonLast1.Click += new System.EventHandler(this.buttonLast1_Click);
            // 
            // buttonNext1
            // 
            this.buttonNext1.Location = new System.Drawing.Point(259, 188);
            this.buttonNext1.Name = "buttonNext1";
            this.buttonNext1.Size = new System.Drawing.Size(13, 19);
            this.buttonNext1.TabIndex = 39;
            this.buttonNext1.Text = ">";
            this.buttonNext1.UseVisualStyleBackColor = true;
            this.buttonNext1.Click += new System.EventHandler(this.buttonNext1_Click);
            // 
            // buttonModify1
            // 
            this.buttonModify1.Location = new System.Drawing.Point(242, 188);
            this.buttonModify1.Name = "buttonModify1";
            this.buttonModify1.Size = new System.Drawing.Size(19, 19);
            this.buttonModify1.TabIndex = 44;
            this.buttonModify1.UseVisualStyleBackColor = true;
            this.buttonModify1.Click += new System.EventHandler(this.buttonModify1_Click);
            // 
            // buttonModify2
            // 
            this.buttonModify2.Location = new System.Drawing.Point(242, 215);
            this.buttonModify2.Name = "buttonModify2";
            this.buttonModify2.Size = new System.Drawing.Size(19, 19);
            this.buttonModify2.TabIndex = 47;
            this.buttonModify2.UseVisualStyleBackColor = true;
            this.buttonModify2.Click += new System.EventHandler(this.buttonModify2_Click);
            // 
            // buttonNext2
            // 
            this.buttonNext2.Location = new System.Drawing.Point(259, 215);
            this.buttonNext2.Name = "buttonNext2";
            this.buttonNext2.Size = new System.Drawing.Size(13, 19);
            this.buttonNext2.TabIndex = 46;
            this.buttonNext2.Text = ">";
            this.buttonNext2.UseVisualStyleBackColor = true;
            this.buttonNext2.Click += new System.EventHandler(this.buttonNext2_Click);
            // 
            // buttonLast2
            // 
            this.buttonLast2.Location = new System.Drawing.Point(231, 215);
            this.buttonLast2.Name = "buttonLast2";
            this.buttonLast2.Size = new System.Drawing.Size(13, 19);
            this.buttonLast2.TabIndex = 45;
            this.buttonLast2.Text = "<";
            this.buttonLast2.UseVisualStyleBackColor = true;
            this.buttonLast2.Click += new System.EventHandler(this.buttonLast2_Click);
            // 
            // buttonModify3
            // 
            this.buttonModify3.Location = new System.Drawing.Point(242, 241);
            this.buttonModify3.Name = "buttonModify3";
            this.buttonModify3.Size = new System.Drawing.Size(19, 19);
            this.buttonModify3.TabIndex = 50;
            this.buttonModify3.UseVisualStyleBackColor = true;
            this.buttonModify3.Click += new System.EventHandler(this.buttonModify3_Click);
            // 
            // buttonNext3
            // 
            this.buttonNext3.Location = new System.Drawing.Point(259, 241);
            this.buttonNext3.Name = "buttonNext3";
            this.buttonNext3.Size = new System.Drawing.Size(13, 19);
            this.buttonNext3.TabIndex = 49;
            this.buttonNext3.Text = ">";
            this.buttonNext3.UseVisualStyleBackColor = true;
            this.buttonNext3.Click += new System.EventHandler(this.buttonNext3_Click);
            // 
            // buttonLast3
            // 
            this.buttonLast3.Location = new System.Drawing.Point(231, 241);
            this.buttonLast3.Name = "buttonLast3";
            this.buttonLast3.Size = new System.Drawing.Size(13, 19);
            this.buttonLast3.TabIndex = 48;
            this.buttonLast3.Text = "<";
            this.buttonLast3.UseVisualStyleBackColor = true;
            this.buttonLast3.Click += new System.EventHandler(this.buttonLast3_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 1000;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 292);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(260, 158);
            this.dataGridView1.TabIndex = 51;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "!Основные метаданные";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 33);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 23);
            this.button2.TabIndex = 53;
            this.button2.Text = "!Основные обработчики";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(283, 66);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 23);
            this.button3.TabIndex = 54;
            this.button3.Text = "!ОРАКЛ ТОП СКРИПТЫ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(283, 91);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(232, 23);
            this.button4.TabIndex = 55;
            this.button4.Text = "!SQL шаблоны";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(283, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(232, 23);
            this.button5.TabIndex = 56;
            this.button5.Text = "!Фишки Oracle";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(283, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(232, 23);
            this.button6.TabIndex = 57;
            this.button6.Text = "!Фишки C#.cs";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(283, 178);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(232, 23);
            this.button7.TabIndex = 58;
            this.button7.Text = "!Фишки.vb";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(283, 211);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(232, 23);
            this.button8.TabIndex = 59;
            this.button8.Text = "UltimaClient";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(283, 237);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(232, 23);
            this.button9.TabIndex = 60;
            this.button9.Text = "VisualStudio Client";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(283, 263);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(232, 23);
            this.button10.TabIndex = 61;
            this.button10.Text = "BUILD";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 458);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonModify3);
            this.Controls.Add(this.buttonNext3);
            this.Controls.Add(this.buttonLast3);
            this.Controls.Add(this.buttonModify2);
            this.Controls.Add(this.buttonNext2);
            this.Controls.Add(this.buttonLast2);
            this.Controls.Add(this.buttonModify1);
            this.Controls.Add(this.buttonNext1);
            this.Controls.Add(this.buttonLast1);
            this.Controls.Add(this.buttonMinus_5);
            this.Controls.Add(this.buttonAdd_5);
            this.Controls.Add(this.buttonMinus_10);
            this.Controls.Add(this.buttonAdd_10);
            this.Controls.Add(this.buttonMinus_30);
            this.Controls.Add(this.buttonAdd_30);
            this.Controls.Add(this.TaskMinuteITOG);
            this.Controls.Add(this.TaskSummaITOG);
            this.Controls.Add(this.TaskHourITOG);
            this.Controls.Add(this.TaskInfoITOG);
            this.Controls.Add(this.TaskMinute3);
            this.Controls.Add(this.TaskSumma3);
            this.Controls.Add(this.TaskHour3);
            this.Controls.Add(this.TaskInfo3);
            this.Controls.Add(this.TaskMinute2);
            this.Controls.Add(this.TaskSumma2);
            this.Controls.Add(this.TaskHour2);
            this.Controls.Add(this.TaskInfo2);
            this.Controls.Add(this.TaskMinute1);
            this.Controls.Add(this.TaskSumma1);
            this.Controls.Add(this.TaskHour1);
            this.Controls.Add(this.TaskInfo1);
            this.Controls.Add(this.buttonSBROS);
            this.Controls.Add(this.buttonTaskStop);
            this.Controls.Add(this.buttonTask3);
            this.Controls.Add(this.buttonTask2);
            this.Controls.Add(this.buttonTask1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Task3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Task2);
            this.Controls.Add(this.MoneySecond);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoneyHour);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Task1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JobWiev";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Task1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MoneyHour;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox MoneySecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Task2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Task3;
        private System.Windows.Forms.Button buttonTask1;
        private System.Windows.Forms.Button buttonTask2;
        private System.Windows.Forms.Button buttonTask3;
        private System.Windows.Forms.Button buttonTaskStop;
        private System.Windows.Forms.Timer TimerJob;
        private System.Windows.Forms.TextBox TaskInfo1;
        private System.Windows.Forms.TextBox TaskHour1;
        private System.Windows.Forms.TextBox TaskSumma1;
        private System.Windows.Forms.TextBox TaskMinute1;
        private System.Windows.Forms.TextBox TaskMinute2;
        private System.Windows.Forms.TextBox TaskSumma2;
        private System.Windows.Forms.TextBox TaskHour2;
        private System.Windows.Forms.TextBox TaskInfo2;
        private System.Windows.Forms.TextBox TaskMinute3;
        private System.Windows.Forms.TextBox TaskSumma3;
        private System.Windows.Forms.TextBox TaskHour3;
        private System.Windows.Forms.TextBox TaskInfo3;
        private System.Windows.Forms.TextBox TaskMinuteITOG;
        private System.Windows.Forms.TextBox TaskSummaITOG;
        private System.Windows.Forms.TextBox TaskHourITOG;
        private System.Windows.Forms.TextBox TaskInfoITOG;
        private System.Windows.Forms.Button buttonSBROS;
        private System.Windows.Forms.Button buttonAdd_30;
        private System.Windows.Forms.Button buttonMinus_30;
        private System.Windows.Forms.Button buttonMinus_10;
        private System.Windows.Forms.Button buttonAdd_10;
        private System.Windows.Forms.Button buttonMinus_5;
        private System.Windows.Forms.Button buttonAdd_5;
        private System.Windows.Forms.Button buttonLast1;
        private System.Windows.Forms.Button buttonNext1;
        private System.Windows.Forms.Button buttonModify1;
        private System.Windows.Forms.Button buttonModify2;
        private System.Windows.Forms.Button buttonNext2;
        private System.Windows.Forms.Button buttonLast2;
        private System.Windows.Forms.Button buttonModify3;
        private System.Windows.Forms.Button buttonNext3;
        private System.Windows.Forms.Button buttonLast3;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}

