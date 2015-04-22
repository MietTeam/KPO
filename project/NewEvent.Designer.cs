namespace project
{
    partial class NewEvent
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPriority = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            this.comboBoxHours = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutes = new System.Windows.Forms.ComboBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Тип";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Время";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Приоритет";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(129, 13);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(328, 22);
            this.textBoxTitle.TabIndex = 5;
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Тип А",
            "Тип Б",
            "Тип В"});
            this.comboBoxType.Location = new System.Drawing.Point(129, 58);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(328, 24);
            this.comboBoxType.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy.MM.dd";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(129, 101);
            this.dateTimePicker1.MinDate = new System.DateTime(2015, 3, 8, 1, 50, 43, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(328, 22);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2015, 3, 8, 1, 50, 43, 0);
            // 
            // comboBoxPriority
            // 
            this.comboBoxPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPriority.Items.AddRange(new object[] {
            "Высокий",
            "Средний",
            "Низкий"});
            this.comboBoxPriority.Location = new System.Drawing.Point(129, 187);
            this.comboBoxPriority.Name = "comboBoxPriority";
            this.comboBoxPriority.Size = new System.Drawing.Size(130, 24);
            this.comboBoxPriority.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Описание";
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(129, 235);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(328, 119);
            this.textBoxDescription.TabIndex = 11;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(360, 412);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(97, 28);
            this.buttonSend.TabIndex = 12;
            this.buttonSend.Text = "Отправить";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "ч.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(255, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "м.";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(22, 412);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(97, 28);
            this.buttonBack.TabIndex = 17;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // comboBoxHours
            // 
            this.comboBoxHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHours.FormattingEnabled = true;
            this.comboBoxHours.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBoxHours.Location = new System.Drawing.Point(129, 143);
            this.comboBoxHours.Name = "comboBoxHours";
            this.comboBoxHours.Size = new System.Drawing.Size(44, 24);
            this.comboBoxHours.TabIndex = 18;
            // 
            // comboBoxMinutes
            // 
            this.comboBoxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutes.FormattingEnabled = true;
            this.comboBoxMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBoxMinutes.Location = new System.Drawing.Point(205, 143);
            this.comboBoxMinutes.Name = "comboBoxMinutes";
            this.comboBoxMinutes.Size = new System.Drawing.Size(44, 24);
            this.comboBoxMinutes.TabIndex = 19;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(195, 412);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(97, 28);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // NewEvent
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(501, 486);
            this.ControlBox = false;
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.comboBoxMinutes);
            this.Controls.Add(this.comboBoxHours);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxPriority);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewEvent";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новое событие";
            this.Load += new System.EventHandler(this.NewEvent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBoxPriority;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.ComboBox comboBoxHours;
        private System.Windows.Forms.ComboBox comboBoxMinutes;
        private System.Windows.Forms.Button buttonClear;
    }
}