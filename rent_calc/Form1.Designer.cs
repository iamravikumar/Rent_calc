﻿namespace rent_calc
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
            this.addressListBox = new System.Windows.Forms.ListBox();
            this.personListBox = new System.Windows.Forms.ListBox();
            this.eventListBox = new System.Windows.Forms.ListBox();
            this.newAddressButton = new System.Windows.Forms.Button();
            this.newPersonButton = new System.Windows.Forms.Button();
            this.newEventButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.changeCurrentAddressInfoButton = new System.Windows.Forms.Button();
            this.currentAddressDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.currentAddressNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.changeCurrentPersonInfoButton = new System.Windows.Forms.Button();
            this.currentPersonDescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.currentPersonNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBoxLeave = new System.Windows.Forms.GroupBox();
            this.groupBoxPayment = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.currentEventDateTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxContract = new System.Windows.Forms.GroupBox();
            this.currentEventTermEndDateUpDown = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.currentEventTermPenaltyUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentEventTermPaymentDateUpDown = new System.Windows.Forms.NumericUpDown();
            this.currentEventTermPaymentUpDown = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.deleteEventButton = new System.Windows.Forms.Button();
            this.deletePersonButton = new System.Windows.Forms.Button();
            this.deleteAddressButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.todayPenaltyTextBox = new System.Windows.Forms.TextBox();
            this.todayDebtTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lastTermEndDateTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.exportXLSButton = new System.Windows.Forms.Button();
            this.countCurrentButton = new System.Windows.Forms.Button();
            this.curDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.currentPenaltyTextBox = new System.Windows.Forms.TextBox();
            this.currentDebtTextBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxCustomWriteOff = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBoxPayment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBoxContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentEventTermPenaltyUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentEventTermPaymentDateUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentEventTermPaymentUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBoxCustomWriteOff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
            this.SuspendLayout();
            // 
            // addressListBox
            // 
            this.addressListBox.FormattingEnabled = true;
            this.addressListBox.HorizontalExtent = 1000;
            this.addressListBox.HorizontalScrollbar = true;
            this.addressListBox.Location = new System.Drawing.Point(13, 26);
            this.addressListBox.Name = "addressListBox";
            this.addressListBox.Size = new System.Drawing.Size(169, 368);
            this.addressListBox.TabIndex = 0;
            this.addressListBox.SelectedIndexChanged += new System.EventHandler(this.addressListBox_SelectedIndexChanged);
            // 
            // personListBox
            // 
            this.personListBox.FormattingEnabled = true;
            this.personListBox.HorizontalExtent = 1000;
            this.personListBox.HorizontalScrollbar = true;
            this.personListBox.Location = new System.Drawing.Point(188, 25);
            this.personListBox.Name = "personListBox";
            this.personListBox.Size = new System.Drawing.Size(169, 368);
            this.personListBox.TabIndex = 1;
            this.personListBox.SelectedIndexChanged += new System.EventHandler(this.personListBox_SelectedIndexChanged);
            // 
            // eventListBox
            // 
            this.eventListBox.FormattingEnabled = true;
            this.eventListBox.HorizontalExtent = 1000;
            this.eventListBox.HorizontalScrollbar = true;
            this.eventListBox.Location = new System.Drawing.Point(363, 25);
            this.eventListBox.Name = "eventListBox";
            this.eventListBox.Size = new System.Drawing.Size(266, 368);
            this.eventListBox.TabIndex = 2;
            this.eventListBox.SelectedIndexChanged += new System.EventHandler(this.eventListBox_SelectedIndexChanged);
            // 
            // newAddressButton
            // 
            this.newAddressButton.Location = new System.Drawing.Point(13, 404);
            this.newAddressButton.Name = "newAddressButton";
            this.newAddressButton.Size = new System.Drawing.Size(169, 28);
            this.newAddressButton.TabIndex = 3;
            this.newAddressButton.Text = "Новое помещение";
            this.newAddressButton.UseVisualStyleBackColor = true;
            this.newAddressButton.Click += new System.EventHandler(this.newAddressButton_Click);
            // 
            // newPersonButton
            // 
            this.newPersonButton.Location = new System.Drawing.Point(188, 404);
            this.newPersonButton.Name = "newPersonButton";
            this.newPersonButton.Size = new System.Drawing.Size(169, 28);
            this.newPersonButton.TabIndex = 4;
            this.newPersonButton.Text = "Новый арендатор";
            this.newPersonButton.UseVisualStyleBackColor = true;
            this.newPersonButton.Click += new System.EventHandler(this.newPersonButton_Click);
            // 
            // newEventButton
            // 
            this.newEventButton.Location = new System.Drawing.Point(364, 404);
            this.newEventButton.Name = "newEventButton";
            this.newEventButton.Size = new System.Drawing.Size(266, 28);
            this.newEventButton.TabIndex = 5;
            this.newEventButton.Text = "Новое событие";
            this.newEventButton.UseVisualStyleBackColor = true;
            this.newEventButton.Click += new System.EventHandler(this.newEventButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.changeCurrentAddressInfoButton);
            this.groupBox1.Controls.Add(this.currentAddressDescriptionTextBox);
            this.groupBox1.Controls.Add(this.currentAddressNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(636, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о помещении";
            // 
            // changeCurrentAddressInfoButton
            // 
            this.changeCurrentAddressInfoButton.Location = new System.Drawing.Point(10, 63);
            this.changeCurrentAddressInfoButton.Name = "changeCurrentAddressInfoButton";
            this.changeCurrentAddressInfoButton.Size = new System.Drawing.Size(76, 30);
            this.changeCurrentAddressInfoButton.TabIndex = 4;
            this.changeCurrentAddressInfoButton.Text = "Изменить";
            this.changeCurrentAddressInfoButton.UseVisualStyleBackColor = true;
            this.changeCurrentAddressInfoButton.Click += new System.EventHandler(this.changeCurrentAddressInfoButton_Click);
            // 
            // currentAddressDescriptionTextBox
            // 
            this.currentAddressDescriptionTextBox.Enabled = false;
            this.currentAddressDescriptionTextBox.Location = new System.Drawing.Point(92, 47);
            this.currentAddressDescriptionTextBox.Name = "currentAddressDescriptionTextBox";
            this.currentAddressDescriptionTextBox.Size = new System.Drawing.Size(228, 47);
            this.currentAddressDescriptionTextBox.TabIndex = 3;
            this.currentAddressDescriptionTextBox.Text = "";
            // 
            // currentAddressNameTextBox
            // 
            this.currentAddressNameTextBox.Enabled = false;
            this.currentAddressNameTextBox.Location = new System.Drawing.Point(92, 20);
            this.currentAddressNameTextBox.Name = "currentAddressNameTextBox";
            this.currentAddressNameTextBox.Size = new System.Drawing.Size(228, 20);
            this.currentAddressNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Адрес";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.changeCurrentPersonInfoButton);
            this.groupBox2.Controls.Add(this.currentPersonDescriptionTextBox);
            this.groupBox2.Controls.Add(this.currentPersonNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(636, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация об арендаторе";
            // 
            // changeCurrentPersonInfoButton
            // 
            this.changeCurrentPersonInfoButton.Location = new System.Drawing.Point(10, 63);
            this.changeCurrentPersonInfoButton.Name = "changeCurrentPersonInfoButton";
            this.changeCurrentPersonInfoButton.Size = new System.Drawing.Size(76, 30);
            this.changeCurrentPersonInfoButton.TabIndex = 4;
            this.changeCurrentPersonInfoButton.Text = "Изменить";
            this.changeCurrentPersonInfoButton.UseVisualStyleBackColor = true;
            this.changeCurrentPersonInfoButton.Click += new System.EventHandler(this.changeCurrentPersonInfoButton_Click);
            // 
            // currentPersonDescriptionTextBox
            // 
            this.currentPersonDescriptionTextBox.Enabled = false;
            this.currentPersonDescriptionTextBox.Location = new System.Drawing.Point(92, 47);
            this.currentPersonDescriptionTextBox.Name = "currentPersonDescriptionTextBox";
            this.currentPersonDescriptionTextBox.Size = new System.Drawing.Size(228, 47);
            this.currentPersonDescriptionTextBox.TabIndex = 3;
            this.currentPersonDescriptionTextBox.Text = "";
            // 
            // currentPersonNameTextBox
            // 
            this.currentPersonNameTextBox.Enabled = false;
            this.currentPersonNameTextBox.Location = new System.Drawing.Point(92, 20);
            this.currentPersonNameTextBox.Name = "currentPersonNameTextBox";
            this.currentPersonNameTextBox.Size = new System.Drawing.Size(228, 20);
            this.currentPersonNameTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ФИО";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBoxCustomWriteOff);
            this.groupBox3.Controls.Add(this.groupBoxLeave);
            this.groupBox3.Controls.Add(this.groupBoxPayment);
            this.groupBox3.Controls.Add(this.currentEventDateTextBox);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(636, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 240);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Информация о событии";
            // 
            // groupBoxLeave
            // 
            this.groupBoxLeave.Location = new System.Drawing.Point(6, 59);
            this.groupBoxLeave.Name = "groupBoxLeave";
            this.groupBoxLeave.Size = new System.Drawing.Size(314, 175);
            this.groupBoxLeave.TabIndex = 25;
            this.groupBoxLeave.TabStop = false;
            this.groupBoxLeave.Text = "Выезд";
            // 
            // groupBoxPayment
            // 
            this.groupBoxPayment.Controls.Add(this.label7);
            this.groupBoxPayment.Controls.Add(this.label8);
            this.groupBoxPayment.Controls.Add(this.numericUpDown1);
            this.groupBoxPayment.Controls.Add(this.label9);
            this.groupBoxPayment.Enabled = false;
            this.groupBoxPayment.Location = new System.Drawing.Point(6, 59);
            this.groupBoxPayment.Name = "groupBoxPayment";
            this.groupBoxPayment.Size = new System.Drawing.Size(314, 175);
            this.groupBoxPayment.TabIndex = 9;
            this.groupBoxPayment.TabStop = false;
            this.groupBoxPayment.Text = "Информация об оплате";
            this.groupBoxPayment.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(211, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 37);
            this.label8.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(79, 18);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(193, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Уплачено";
            // 
            // currentEventDateTextBox
            // 
            this.currentEventDateTextBox.Enabled = false;
            this.currentEventDateTextBox.Location = new System.Drawing.Point(51, 26);
            this.currentEventDateTextBox.Name = "currentEventDateTextBox";
            this.currentEventDateTextBox.Size = new System.Drawing.Size(269, 20);
            this.currentEventDateTextBox.TabIndex = 5;
            this.currentEventDateTextBox.TextChanged += new System.EventHandler(this.currentEventDateTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Дата";
            // 
            // groupBoxContract
            // 
            this.groupBoxContract.Controls.Add(this.currentEventTermEndDateUpDown);
            this.groupBoxContract.Controls.Add(this.label15);
            this.groupBoxContract.Controls.Add(this.label11);
            this.groupBoxContract.Controls.Add(this.currentEventTermPenaltyUpDown);
            this.groupBoxContract.Controls.Add(this.currentEventTermPaymentDateUpDown);
            this.groupBoxContract.Controls.Add(this.currentEventTermPaymentUpDown);
            this.groupBoxContract.Controls.Add(this.label10);
            this.groupBoxContract.Controls.Add(this.label12);
            this.groupBoxContract.Controls.Add(this.label13);
            this.groupBoxContract.Location = new System.Drawing.Point(642, 283);
            this.groupBoxContract.Name = "groupBoxContract";
            this.groupBoxContract.Size = new System.Drawing.Size(313, 175);
            this.groupBoxContract.TabIndex = 9;
            this.groupBoxContract.TabStop = false;
            this.groupBoxContract.Text = "Информация о договоре";
            // 
            // currentEventTermEndDateUpDown
            // 
            this.currentEventTermEndDateUpDown.Enabled = false;
            this.currentEventTermEndDateUpDown.Location = new System.Drawing.Point(9, 149);
            this.currentEventTermEndDateUpDown.Name = "currentEventTermEndDateUpDown";
            this.currentEventTermEndDateUpDown.Size = new System.Drawing.Size(298, 20);
            this.currentEventTermEndDateUpDown.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Дата завершения договора";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(309, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 164);
            this.label11.TabIndex = 24;
            this.label11.Text = "         ";
            // 
            // currentEventTermPenaltyUpDown
            // 
            this.currentEventTermPenaltyUpDown.DecimalPlaces = 5;
            this.currentEventTermPenaltyUpDown.Enabled = false;
            this.currentEventTermPenaltyUpDown.Location = new System.Drawing.Point(9, 109);
            this.currentEventTermPenaltyUpDown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentEventTermPenaltyUpDown.Name = "currentEventTermPenaltyUpDown";
            this.currentEventTermPenaltyUpDown.Size = new System.Drawing.Size(346, 20);
            this.currentEventTermPenaltyUpDown.TabIndex = 28;
            // 
            // currentEventTermPaymentDateUpDown
            // 
            this.currentEventTermPaymentDateUpDown.Enabled = false;
            this.currentEventTermPaymentDateUpDown.Location = new System.Drawing.Point(9, 70);
            this.currentEventTermPaymentDateUpDown.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.currentEventTermPaymentDateUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentEventTermPaymentDateUpDown.Name = "currentEventTermPaymentDateUpDown";
            this.currentEventTermPaymentDateUpDown.Size = new System.Drawing.Size(324, 20);
            this.currentEventTermPaymentDateUpDown.TabIndex = 27;
            this.currentEventTermPaymentDateUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // currentEventTermPaymentUpDown
            // 
            this.currentEventTermPaymentUpDown.Enabled = false;
            this.currentEventTermPaymentUpDown.InterceptArrowKeys = false;
            this.currentEventTermPaymentUpDown.Location = new System.Drawing.Point(9, 33);
            this.currentEventTermPaymentUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.currentEventTermPaymentUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.currentEventTermPaymentUpDown.Name = "currentEventTermPaymentUpDown";
            this.currentEventTermPaymentUpDown.Size = new System.Drawing.Size(324, 20);
            this.currentEventTermPaymentUpDown.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 93);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Пеня (В десятичных долях)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(185, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Дата оплаты (номер дня в месяце)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Сумма оплаты";
            // 
            // deleteEventButton
            // 
            this.deleteEventButton.Location = new System.Drawing.Point(363, 436);
            this.deleteEventButton.Name = "deleteEventButton";
            this.deleteEventButton.Size = new System.Drawing.Size(266, 28);
            this.deleteEventButton.TabIndex = 11;
            this.deleteEventButton.Text = "Удалить событие";
            this.deleteEventButton.UseVisualStyleBackColor = true;
            this.deleteEventButton.Click += new System.EventHandler(this.deleteEventButton_Click);
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Location = new System.Drawing.Point(187, 436);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(169, 28);
            this.deletePersonButton.TabIndex = 10;
            this.deletePersonButton.Text = "Удалить арендатора";
            this.deletePersonButton.UseVisualStyleBackColor = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // deleteAddressButton
            // 
            this.deleteAddressButton.Location = new System.Drawing.Point(12, 436);
            this.deleteAddressButton.Name = "deleteAddressButton";
            this.deleteAddressButton.Size = new System.Drawing.Size(169, 28);
            this.deleteAddressButton.TabIndex = 9;
            this.deleteAddressButton.Text = "Удалить помещение";
            this.deleteAddressButton.UseVisualStyleBackColor = true;
            this.deleteAddressButton.Click += new System.EventHandler(this.deleteAddressButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.todayPenaltyTextBox);
            this.groupBox4.Controls.Add(this.todayDebtTextBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(969, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(242, 100);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Состояние на сегодня";
            // 
            // todayPenaltyTextBox
            // 
            this.todayPenaltyTextBox.Enabled = false;
            this.todayPenaltyTextBox.Location = new System.Drawing.Point(58, 44);
            this.todayPenaltyTextBox.Name = "todayPenaltyTextBox";
            this.todayPenaltyTextBox.Size = new System.Drawing.Size(178, 20);
            this.todayPenaltyTextBox.TabIndex = 3;
            // 
            // todayDebtTextBox
            // 
            this.todayDebtTextBox.Enabled = false;
            this.todayDebtTextBox.Location = new System.Drawing.Point(58, 20);
            this.todayDebtTextBox.Name = "todayDebtTextBox";
            this.todayDebtTextBox.Size = new System.Drawing.Size(178, 20);
            this.todayDebtTextBox.TabIndex = 2;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 47);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Пеня";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Долг";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1223, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lastTermEndDateTextBox
            // 
            this.lastTermEndDateTextBox.Enabled = false;
            this.lastTermEndDateTextBox.Location = new System.Drawing.Point(969, 138);
            this.lastTermEndDateTextBox.Name = "lastTermEndDateTextBox";
            this.lastTermEndDateTextBox.Size = new System.Drawing.Size(178, 20);
            this.lastTermEndDateTextBox.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(966, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Последний договор действителен до";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.exportXLSButton);
            this.groupBox5.Controls.Add(this.countCurrentButton);
            this.groupBox5.Controls.Add(this.curDateCalendar);
            this.groupBox5.Controls.Add(this.currentPenaltyTextBox);
            this.groupBox5.Controls.Add(this.currentDebtTextBox);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Location = new System.Drawing.Point(969, 164);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(242, 300);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Состояние на";
            // 
            // exportXLSButton
            // 
            this.exportXLSButton.Location = new System.Drawing.Point(13, 272);
            this.exportXLSButton.Name = "exportXLSButton";
            this.exportXLSButton.Size = new System.Drawing.Size(222, 27);
            this.exportXLSButton.TabIndex = 12;
            this.exportXLSButton.Text = "Экспорт в .xls";
            this.exportXLSButton.UseVisualStyleBackColor = true;
            this.exportXLSButton.Click += new System.EventHandler(this.exportXLSButton_Click);
            // 
            // countCurrentButton
            // 
            this.countCurrentButton.Location = new System.Drawing.Point(11, 237);
            this.countCurrentButton.Name = "countCurrentButton";
            this.countCurrentButton.Size = new System.Drawing.Size(225, 27);
            this.countCurrentButton.TabIndex = 11;
            this.countCurrentButton.Text = "Рассчитать";
            this.countCurrentButton.UseVisualStyleBackColor = true;
            this.countCurrentButton.Click += new System.EventHandler(this.countCurrentButton_Click);
            // 
            // curDateCalendar
            // 
            this.curDateCalendar.Location = new System.Drawing.Point(11, 13);
            this.curDateCalendar.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.curDateCalendar.MaxSelectionCount = 1;
            this.curDateCalendar.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.curDateCalendar.Name = "curDateCalendar";
            this.curDateCalendar.ShowToday = false;
            this.curDateCalendar.ShowTodayCircle = false;
            this.curDateCalendar.TabIndex = 10;
            // 
            // currentPenaltyTextBox
            // 
            this.currentPenaltyTextBox.Enabled = false;
            this.currentPenaltyTextBox.Location = new System.Drawing.Point(58, 211);
            this.currentPenaltyTextBox.Name = "currentPenaltyTextBox";
            this.currentPenaltyTextBox.Size = new System.Drawing.Size(178, 20);
            this.currentPenaltyTextBox.TabIndex = 3;
            // 
            // currentDebtTextBox
            // 
            this.currentDebtTextBox.Enabled = false;
            this.currentDebtTextBox.Location = new System.Drawing.Point(58, 187);
            this.currentDebtTextBox.Name = "currentDebtTextBox";
            this.currentDebtTextBox.Size = new System.Drawing.Size(178, 20);
            this.currentDebtTextBox.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(19, 214);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Пеня";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 187);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(33, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Долг";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "Excel|*.xls";
            this.saveFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog2_FileOk);
            // 
            // groupBoxCustomWriteOff
            // 
            this.groupBoxCustomWriteOff.Controls.Add(this.richTextBox3);
            this.groupBoxCustomWriteOff.Controls.Add(this.label19);
            this.groupBoxCustomWriteOff.Controls.Add(this.label20);
            this.groupBoxCustomWriteOff.Controls.Add(this.label21);
            this.groupBoxCustomWriteOff.Controls.Add(this.numericUpDown6);
            this.groupBoxCustomWriteOff.Controls.Add(this.label22);
            this.groupBoxCustomWriteOff.Enabled = false;
            this.groupBoxCustomWriteOff.Location = new System.Drawing.Point(6, 59);
            this.groupBoxCustomWriteOff.Name = "groupBoxCustomWriteOff";
            this.groupBoxCustomWriteOff.Size = new System.Drawing.Size(313, 175);
            this.groupBoxCustomWriteOff.TabIndex = 26;
            this.groupBoxCustomWriteOff.TabStop = false;
            this.groupBoxCustomWriteOff.Text = "Начисление переменной части арендной платы";
            this.groupBoxCustomWriteOff.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Enabled = false;
            this.richTextBox3.Location = new System.Drawing.Point(6, 85);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(266, 84);
            this.richTextBox3.TabIndex = 13;
            this.richTextBox3.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 69);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 12;
            this.label19.Text = "Комментарий";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 257);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(0, 13);
            this.label20.TabIndex = 11;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(90, 37);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(100, 23);
            this.label21.TabIndex = 2;
            // 
            // numericUpDown6
            // 
            this.numericUpDown6.Enabled = false;
            this.numericUpDown6.Location = new System.Drawing.Point(10, 37);
            this.numericUpDown6.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericUpDown6.Name = "numericUpDown6";
            this.numericUpDown6.Size = new System.Drawing.Size(98, 20);
            this.numericUpDown6.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(41, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Сумма";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 470);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.lastTermEndDateTextBox);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBoxContract);
            this.Controls.Add(this.deleteEventButton);
            this.Controls.Add(this.deletePersonButton);
            this.Controls.Add(this.deleteAddressButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.newEventButton);
            this.Controls.Add(this.newPersonButton);
            this.Controls.Add(this.newAddressButton);
            this.Controls.Add(this.eventListBox);
            this.Controls.Add(this.personListBox);
            this.Controls.Add(this.addressListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxPayment.ResumeLayout(false);
            this.groupBoxPayment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBoxContract.ResumeLayout(false);
            this.groupBoxContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentEventTermPenaltyUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentEventTermPaymentDateUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentEventTermPaymentUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBoxCustomWriteOff.ResumeLayout(false);
            this.groupBoxCustomWriteOff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox addressListBox;
        private System.Windows.Forms.ListBox personListBox;
        private System.Windows.Forms.ListBox eventListBox;
        private System.Windows.Forms.Button newAddressButton;
        private System.Windows.Forms.Button newPersonButton;
        private System.Windows.Forms.Button newEventButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button changeCurrentAddressInfoButton;
        private System.Windows.Forms.RichTextBox currentAddressDescriptionTextBox;
        private System.Windows.Forms.TextBox currentAddressNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button changeCurrentPersonInfoButton;
        private System.Windows.Forms.RichTextBox currentPersonDescriptionTextBox;
        private System.Windows.Forms.TextBox currentPersonNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox currentEventDateTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxContract;
        private System.Windows.Forms.NumericUpDown currentEventTermPenaltyUpDown;
        private System.Windows.Forms.NumericUpDown currentEventTermPaymentDateUpDown;
        private System.Windows.Forms.NumericUpDown currentEventTermPaymentUpDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBoxLeave;
        private System.Windows.Forms.Button deleteEventButton;
        private System.Windows.Forms.Button deletePersonButton;
        private System.Windows.Forms.Button deleteAddressButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox todayPenaltyTextBox;
        private System.Windows.Forms.TextBox todayDebtTextBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox currentEventTermEndDateUpDown;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox lastTermEndDateTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox currentPenaltyTextBox;
        private System.Windows.Forms.TextBox currentDebtTextBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.MonthCalendar curDateCalendar;
        private System.Windows.Forms.Button countCurrentButton;
        private System.Windows.Forms.Button exportXLSButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.GroupBox groupBoxCustomWriteOff;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numericUpDown6;
        private System.Windows.Forms.Label label22;
    }
}

