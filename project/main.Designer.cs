namespace project
{
    partial class main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnePizdecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.событиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todayEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridAcceptedEvents = new System.Windows.Forms.DataGridView();
            this.IDEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameEvent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageAcceptedEvents = new System.Windows.Forms.TabPage();
            this.textBoxNoAcceptedEvents = new System.Windows.Forms.TextBox();
            this.tabPageNewEvents = new System.Windows.Forms.TabPage();
            this.textBoxNoNewEvents = new System.Windows.Forms.TextBox();
            this.dataGridNewEvents = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Accept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Decline = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ID_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.textBoxNoNewMessages = new System.Windows.Forms.TextBox();
            this.dataGridMessages = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteMessages = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelAcceptedEventsCount = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.labelSelectedDateEvents = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcceptedEvents)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageAcceptedEvents.SuspendLayout();
            this.tabPageNewEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewEvents)).BeginInit();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(1025, 332);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(97, 28);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(1070, 629);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(97, 28);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.событиеToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1190, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Enter += new System.EventHandler(this.main_Load);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnePizdecToolStripMenuItem,
            this.changeUserToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.menuToolStripMenuItem.Text = "Меню";
            // 
            // mnePizdecToolStripMenuItem
            // 
            this.mnePizdecToolStripMenuItem.Name = "mnePizdecToolStripMenuItem";
            this.mnePizdecToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.mnePizdecToolStripMenuItem.Text = "Обновить";
            this.mnePizdecToolStripMenuItem.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // changeUserToolStripMenuItem
            // 
            this.changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            this.changeUserToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.changeUserToolStripMenuItem.Text = "Сменить пользователя";
            this.changeUserToolStripMenuItem.Click += new System.EventHandler(this.changeUserToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.exitToolStripMenuItem.Text = "Выход";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // событиеToolStripMenuItem
            // 
            this.событиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEventToolStripMenuItem,
            this.deleteEventToolStripMenuItem,
            this.todayEventsToolStripMenuItem});
            this.событиеToolStripMenuItem.Name = "событиеToolStripMenuItem";
            this.событиеToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.событиеToolStripMenuItem.Text = "Событие";
            // 
            // addEventToolStripMenuItem
            // 
            this.addEventToolStripMenuItem.Name = "addEventToolStripMenuItem";
            this.addEventToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.addEventToolStripMenuItem.Text = "Добавить событе";
            this.addEventToolStripMenuItem.Click += new System.EventHandler(this.addEventToolStripMenuItem_Click);
            // 
            // deleteEventToolStripMenuItem
            // 
            this.deleteEventToolStripMenuItem.Enabled = false;
            this.deleteEventToolStripMenuItem.Name = "deleteEventToolStripMenuItem";
            this.deleteEventToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.deleteEventToolStripMenuItem.Text = "Удалить выделенное событе";
            this.deleteEventToolStripMenuItem.Click += new System.EventHandler(this.deleteEventToolStripMenuItem_Click);
            // 
            // todayEventsToolStripMenuItem
            // 
            this.todayEventsToolStripMenuItem.Name = "todayEventsToolStripMenuItem";
            this.todayEventsToolStripMenuItem.Size = new System.Drawing.Size(302, 24);
            this.todayEventsToolStripMenuItem.Text = "Показать сегодняшние события";
            this.todayEventsToolStripMenuItem.Click += new System.EventHandler(this.todayEventsToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // dataGridAcceptedEvents
            // 
            this.dataGridAcceptedEvents.AllowUserToAddRows = false;
            this.dataGridAcceptedEvents.AllowUserToDeleteRows = false;
            this.dataGridAcceptedEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridAcceptedEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridAcceptedEvents.ColumnHeadersHeight = 30;
            this.dataGridAcceptedEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEvent,
            this.NameEvent,
            this.Type,
            this.Priority,
            this.Data,
            this.Time,
            this.Discription});
            this.dataGridAcceptedEvents.Location = new System.Drawing.Point(0, 0);
            this.dataGridAcceptedEvents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridAcceptedEvents.MultiSelect = false;
            this.dataGridAcceptedEvents.Name = "dataGridAcceptedEvents";
            this.dataGridAcceptedEvents.ReadOnly = true;
            this.dataGridAcceptedEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridAcceptedEvents.Size = new System.Drawing.Size(949, 549);
            this.dataGridAcceptedEvents.TabIndex = 4;
            this.dataGridAcceptedEvents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridAcceptedEvents_CellClick);
            // 
            // IDEvent
            // 
            this.IDEvent.HeaderText = "Номер";
            this.IDEvent.Name = "IDEvent";
            this.IDEvent.ReadOnly = true;
            // 
            // NameEvent
            // 
            this.NameEvent.HeaderText = "Название";
            this.NameEvent.Name = "NameEvent";
            this.NameEvent.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Тип";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Приоритет";
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // Data
            // 
            this.Data.HeaderText = "Дата";
            this.Data.Name = "Data";
            this.Data.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Discription
            // 
            this.Discription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Discription.HeaderText = "Описание";
            this.Discription.Name = "Discription";
            this.Discription.ReadOnly = true;
            this.Discription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Discription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageAcceptedEvents);
            this.tabControl1.Controls.Add(this.tabPageNewEvents);
            this.tabControl1.Controls.Add(this.tabPageMessages);
            this.tabControl1.Location = new System.Drawing.Point(0, 31);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(18, 5);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(949, 574);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageAcceptedEvents
            // 
            this.tabPageAcceptedEvents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageAcceptedEvents.Controls.Add(this.textBoxNoAcceptedEvents);
            this.tabPageAcceptedEvents.Controls.Add(this.dataGridAcceptedEvents);
            this.tabPageAcceptedEvents.Location = new System.Drawing.Point(4, 29);
            this.tabPageAcceptedEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAcceptedEvents.Name = "tabPageAcceptedEvents";
            this.tabPageAcceptedEvents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageAcceptedEvents.Size = new System.Drawing.Size(941, 541);
            this.tabPageAcceptedEvents.TabIndex = 0;
            this.tabPageAcceptedEvents.Text = "Утвержденные события";
            // 
            // textBoxNoAcceptedEvents
            // 
            this.textBoxNoAcceptedEvents.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxNoAcceptedEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoAcceptedEvents.Location = new System.Drawing.Point(385, 254);
            this.textBoxNoAcceptedEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNoAcceptedEvents.Name = "textBoxNoAcceptedEvents";
            this.textBoxNoAcceptedEvents.Size = new System.Drawing.Size(281, 15);
            this.textBoxNoAcceptedEvents.TabIndex = 8;
            this.textBoxNoAcceptedEvents.Text = "Нет новых событий.";
            this.textBoxNoAcceptedEvents.Visible = false;
            this.textBoxNoAcceptedEvents.WordWrap = false;
            // 
            // tabPageNewEvents
            // 
            this.tabPageNewEvents.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPageNewEvents.Controls.Add(this.textBoxNoNewEvents);
            this.tabPageNewEvents.Controls.Add(this.dataGridNewEvents);
            this.tabPageNewEvents.Location = new System.Drawing.Point(4, 29);
            this.tabPageNewEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageNewEvents.Name = "tabPageNewEvents";
            this.tabPageNewEvents.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageNewEvents.Size = new System.Drawing.Size(941, 541);
            this.tabPageNewEvents.TabIndex = 1;
            this.tabPageNewEvents.Text = "Рассматриваемые события";
            // 
            // textBoxNoNewEvents
            // 
            this.textBoxNoNewEvents.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxNoNewEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoNewEvents.Location = new System.Drawing.Point(331, 251);
            this.textBoxNoNewEvents.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNoNewEvents.Name = "textBoxNoNewEvents";
            this.textBoxNoNewEvents.Size = new System.Drawing.Size(281, 15);
            this.textBoxNoNewEvents.TabIndex = 7;
            this.textBoxNoNewEvents.Text = "Нет событий, ожидающих рассмотрения.";
            this.textBoxNoNewEvents.Visible = false;
            // 
            // dataGridNewEvents
            // 
            this.dataGridNewEvents.AllowUserToAddRows = false;
            this.dataGridNewEvents.AllowUserToDeleteRows = false;
            this.dataGridNewEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridNewEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridNewEvents.ColumnHeadersHeight = 30;
            this.dataGridNewEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.Accept,
            this.Decline,
            this.ID_user});
            this.dataGridNewEvents.Location = new System.Drawing.Point(0, 0);
            this.dataGridNewEvents.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridNewEvents.Name = "dataGridNewEvents";
            this.dataGridNewEvents.ReadOnly = true;
            this.dataGridNewEvents.Size = new System.Drawing.Size(949, 549);
            this.dataGridNewEvents.TabIndex = 5;
            this.dataGridNewEvents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridNewEvents_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Название";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Тип";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Приоритет";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Время";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Accept
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Lime;
            this.Accept.DefaultCellStyle = dataGridViewCellStyle3;
            this.Accept.HeaderText = "";
            this.Accept.Name = "Accept";
            this.Accept.ReadOnly = true;
            this.Accept.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Accept.Text = "Принять";
            this.Accept.UseColumnTextForButtonValue = true;
            // 
            // Decline
            // 
            this.Decline.HeaderText = "";
            this.Decline.Name = "Decline";
            this.Decline.ReadOnly = true;
            this.Decline.Text = "Отклонить";
            this.Decline.UseColumnTextForButtonValue = true;
            // 
            // ID_user
            // 
            this.ID_user.HeaderText = "ID user";
            this.ID_user.Name = "ID_user";
            this.ID_user.ReadOnly = true;
            this.ID_user.Visible = false;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.textBoxNoNewMessages);
            this.tabPageMessages.Controls.Add(this.dataGridMessages);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 29);
            this.tabPageMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Size = new System.Drawing.Size(941, 541);
            this.tabPageMessages.TabIndex = 2;
            this.tabPageMessages.Text = "Сообщения";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // textBoxNoNewMessages
            // 
            this.textBoxNoNewMessages.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxNoNewMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNoNewMessages.Location = new System.Drawing.Point(357, 257);
            this.textBoxNoNewMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxNoNewMessages.Name = "textBoxNoNewMessages";
            this.textBoxNoNewMessages.Size = new System.Drawing.Size(281, 15);
            this.textBoxNoNewMessages.TabIndex = 6;
            this.textBoxNoNewMessages.Text = "У вас нет новых сообщений.";
            this.textBoxNoNewMessages.Visible = false;
            this.textBoxNoNewMessages.WordWrap = false;
            // 
            // dataGridMessages
            // 
            this.dataGridMessages.AllowUserToAddRows = false;
            this.dataGridMessages.AllowUserToDeleteRows = false;
            this.dataGridMessages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridMessages.ColumnHeadersHeight = 30;
            this.dataGridMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Message});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridMessages.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridMessages.Location = new System.Drawing.Point(0, 0);
            this.dataGridMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridMessages.Name = "dataGridMessages";
            this.dataGridMessages.ReadOnly = true;
            this.dataGridMessages.RowHeadersWidth = 40;
            this.dataGridMessages.RowTemplate.Height = 24;
            this.dataGridMessages.Size = new System.Drawing.Size(941, 545);
            this.dataGridMessages.TabIndex = 0;
            // 
            // Date
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Date.DefaultCellStyle = dataGridViewCellStyle4;
            this.Date.HeaderText = "Дата и время";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Date.Width = 110;
            // 
            // Message
            // 
            this.Message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Message.HeaderText = "Сообщение";
            this.Message.Name = "Message";
            this.Message.ReadOnly = true;
            // 
            // buttonDeleteMessages
            // 
            this.buttonDeleteMessages.Enabled = false;
            this.buttonDeleteMessages.Location = new System.Drawing.Point(1025, 386);
            this.buttonDeleteMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeleteMessages.Name = "buttonDeleteMessages";
            this.buttonDeleteMessages.Size = new System.Drawing.Size(97, 47);
            this.buttonDeleteMessages.TabIndex = 6;
            this.buttonDeleteMessages.Text = "Удалить все сообщения";
            this.buttonDeleteMessages.UseVisualStyleBackColor = true;
            this.buttonDeleteMessages.Click += new System.EventHandler(this.buttonDeleteMessages_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelAcceptedEventsCount
            // 
            this.labelAcceptedEventsCount.AutoSize = true;
            this.labelAcceptedEventsCount.BackColor = System.Drawing.Color.Transparent;
            this.labelAcceptedEventsCount.Location = new System.Drawing.Point(36, 629);
            this.labelAcceptedEventsCount.Name = "labelAcceptedEventsCount";
            this.labelAcceptedEventsCount.Size = new System.Drawing.Size(172, 17);
            this.labelAcceptedEventsCount.TabIndex = 8;
            this.labelAcceptedEventsCount.Text = "Утвержденных событий: ";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(975, 60);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 9;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // labelSelectedDateEvents
            // 
            this.labelSelectedDateEvents.AutoSize = true;
            this.labelSelectedDateEvents.BackColor = System.Drawing.SystemColors.Control;
            this.labelSelectedDateEvents.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSelectedDateEvents.Location = new System.Drawing.Point(967, 285);
            this.labelSelectedDateEvents.Name = "labelSelectedDateEvents";
            this.labelSelectedDateEvents.Size = new System.Drawing.Size(203, 17);
            this.labelSelectedDateEvents.TabIndex = 10;
            this.labelSelectedDateEvents.Text = "Событий в выделенный день:";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = global::project.Properties.Resources.abstract_colors_eola_gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1190, 676);
            this.Controls.Add(this.labelSelectedDateEvents);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelAcceptedEventsCount);
            this.Controls.Add(this.buttonDeleteMessages);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "main";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронный секретарь";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.buttonExit_Click);
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAcceptedEvents)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageAcceptedEvents.ResumeLayout(false);
            this.tabPageAcceptedEvents.PerformLayout();
            this.tabPageNewEvents.ResumeLayout(false);
            this.tabPageNewEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNewEvents)).EndInit();
            this.tabPageMessages.ResumeLayout(false);
            this.tabPageMessages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnePizdecToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridAcceptedEvents;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageAcceptedEvents;
        private System.Windows.Forms.TabPage tabPageNewEvents;
        private System.Windows.Forms.DataGridView dataGridNewEvents;
        private System.Windows.Forms.ToolStripMenuItem changeUserToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.DataGridView dataGridMessages;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewButtonColumn Accept;
        private System.Windows.Forms.DataGridViewButtonColumn Decline;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Message;
        private System.Windows.Forms.Button buttonDeleteMessages;
        private System.Windows.Forms.TextBox textBoxNoNewEvents;
        private System.Windows.Forms.TextBox textBoxNoNewMessages;
        private System.Windows.Forms.TextBox textBoxNoAcceptedEvents;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameEvent;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discription;
        private System.Windows.Forms.Label labelAcceptedEventsCount;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label labelSelectedDateEvents;
        private System.Windows.Forms.ToolStripMenuItem событиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todayEventsToolStripMenuItem;

    }
}