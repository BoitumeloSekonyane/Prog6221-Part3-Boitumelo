namespace CyberCrimeFightingBotPart2GUI
{
    partial class Form1
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitChat = new System.Windows.Forms.SplitContainer();
            this.lblTopics = new System.Windows.Forms.Label();
            this.lstTopics = new System.Windows.Forms.ListBox();
            this.tblChat = new System.Windows.Forms.TableLayoutPanel();
            this.btnSend = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.lblAscii = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitTasks = new System.Windows.Forms.SplitContainer();
            this.dtpReminder = new System.Windows.Forms.DateTimePicker();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnCompleteTask = new System.Windows.Forms.Button();
            this.btnViewTasks = new System.Windows.Forms.Button();
            this.bntAddTask = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtTaskDescription = new System.Windows.Forms.RichTextBox();
            this.txtDescription = new System.Windows.Forms.Label();
            this.TaskTitle = new System.Windows.Forms.Label();
            this.txtTaskTitle = new System.Windows.Forms.TextBox();
            this.lblAddNewTask = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.TaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReminderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnRestartQuiz = new System.Windows.Forms.Button();
            this.btnStartQuiz = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnA = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQuestionNumber = new System.Windows.Forms.Label();
            this.lblQuiz = new System.Windows.Forms.Label();
            this.pnlQuestionBox = new System.Windows.Forms.Panel();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEnterName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitChat)).BeginInit();
            this.splitChat.Panel1.SuspendLayout();
            this.splitChat.Panel2.SuspendLayout();
            this.splitChat.SuspendLayout();
            this.tblChat.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitTasks)).BeginInit();
            this.splitTasks.Panel1.SuspendLayout();
            this.splitTasks.Panel2.SuspendLayout();
            this.splitTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.pnlQuestionBox.SuspendLayout();
            this.pnLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Stencil", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(543, 44);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CYBER CRIME FIGHTING BOT";
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(1820, 345);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(10, 8);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1348, 677);
            this.tabControl1.TabIndex = 21;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitChat);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1340, 644);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chat Assistant";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // splitChat
            // 
            this.splitChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitChat.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitChat.Location = new System.Drawing.Point(3, 3);
            this.splitChat.Name = "splitChat";
            // 
            // splitChat.Panel1
            // 
            this.splitChat.Panel1.Controls.Add(this.lblTopics);
            this.splitChat.Panel1.Controls.Add(this.lstTopics);
            // 
            // splitChat.Panel2
            // 
            this.splitChat.Panel2.Controls.Add(this.tblChat);
            this.splitChat.Size = new System.Drawing.Size(1334, 638);
            this.splitChat.SplitterDistance = 580;
            this.splitChat.TabIndex = 0;
            // 
            // lblTopics
            // 
            this.lblTopics.AutoSize = true;
            this.lblTopics.BackColor = System.Drawing.Color.Transparent;
            this.lblTopics.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTopics.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTopics.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopics.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lblTopics.Location = new System.Drawing.Point(2, 4);
            this.lblTopics.Name = "lblTopics";
            this.lblTopics.Size = new System.Drawing.Size(195, 22);
            this.lblTopics.TabIndex = 0;
            this.lblTopics.Text = "Cybersecurity Topics";
            // 
            // lstTopics
            // 
            this.lstTopics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstTopics.FormattingEnabled = true;
            this.lstTopics.ItemHeight = 20;
            this.lstTopics.Location = new System.Drawing.Point(0, 0);
            this.lstTopics.Name = "lstTopics";
            this.lstTopics.Size = new System.Drawing.Size(580, 638);
            this.lstTopics.TabIndex = 1;
            // 
            // tblChat
            // 
            this.tblChat.ColumnCount = 1;
            this.tblChat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1050F));
            this.tblChat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChat.Controls.Add(this.btnSend, 0, 4);
            this.tblChat.Controls.Add(this.txtChat, 0, 1);
            this.tblChat.Controls.Add(this.label1, 0, 3);
            this.tblChat.Controls.Add(this.txtMessage, 0, 2);
            this.tblChat.Controls.Add(this.lblAscii, 0, 0);
            this.tblChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblChat.Location = new System.Drawing.Point(0, 0);
            this.tblChat.Name = "tblChat";
            this.tblChat.RowCount = 4;
            this.tblChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tblChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tblChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tblChat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblChat.Size = new System.Drawing.Size(750, 638);
            this.tblChat.TabIndex = 0;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSend.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnSend.Location = new System.Drawing.Point(3, 596);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(750, 39);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtChat
            // 
            this.txtChat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtChat.ForeColor = System.Drawing.SystemColors.Info;
            this.txtChat.Location = new System.Drawing.Point(3, 123);
            this.txtChat.Name = "txtChat";
            this.txtChat.ReadOnly = true;
            this.txtChat.Size = new System.Drawing.Size(744, 412);
            this.txtChat.TabIndex = 3;
            this.txtChat.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 8);
            this.label1.TabIndex = 0;
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtMessage.Location = new System.Drawing.Point(3, 541);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(750, 41);
            this.txtMessage.TabIndex = 4;
            // 
            // lblAscii
            // 
            this.lblAscii.AutoSize = true;
            this.lblAscii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAscii.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblAscii.Location = new System.Drawing.Point(3, 0);
            this.lblAscii.Name = "lblAscii";
            this.lblAscii.Size = new System.Drawing.Size(1044, 120);
            this.lblAscii.TabIndex = 1;
            this.lblAscii.Text = "AsciiArt";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitTasks);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1340, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Task Manager";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitTasks
            // 
            this.splitTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitTasks.Location = new System.Drawing.Point(3, 3);
            this.splitTasks.Name = "splitTasks";
            // 
            // splitTasks.Panel1
            // 
            this.splitTasks.Panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitTasks.Panel1.Controls.Add(this.dtpReminder);
            this.splitTasks.Panel1.Controls.Add(this.btnDeleteTask);
            this.splitTasks.Panel1.Controls.Add(this.btnCompleteTask);
            this.splitTasks.Panel1.Controls.Add(this.btnViewTasks);
            this.splitTasks.Panel1.Controls.Add(this.bntAddTask);
            this.splitTasks.Panel1.Controls.Add(this.dateTimePicker1);
            this.splitTasks.Panel1.Controls.Add(this.txtTaskDescription);
            this.splitTasks.Panel1.Controls.Add(this.txtDescription);
            this.splitTasks.Panel1.Controls.Add(this.TaskTitle);
            this.splitTasks.Panel1.Controls.Add(this.txtTaskTitle);
            this.splitTasks.Panel1.Controls.Add(this.lblAddNewTask);
            // 
            // splitTasks.Panel2
            // 
            this.splitTasks.Panel2.Controls.Add(this.dgvTasks);
            this.splitTasks.Size = new System.Drawing.Size(1334, 638);
            this.splitTasks.SplitterDistance = 350;
            this.splitTasks.TabIndex = 0;
            // 
            // dtpReminder
            // 
            this.dtpReminder.BackColor = System.Drawing.Color.White;
            this.dtpReminder.ForeColor = System.Drawing.Color.Magenta;
            this.dtpReminder.Location = new System.Drawing.Point(110, 342);
            this.dtpReminder.Name = "dtpReminder";
            this.dtpReminder.Size = new System.Drawing.Size(143, 27);
            this.dtpReminder.TabIndex = 11;
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnDeleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteTask.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.ForeColor = System.Drawing.Color.Magenta;
            this.btnDeleteTask.Location = new System.Drawing.Point(88, 587);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(194, 32);
            this.btnDeleteTask.TabIndex = 10;
            this.btnDeleteTask.Text = "Delete Task";
            this.btnDeleteTask.UseVisualStyleBackColor = false;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnCompleteTask
            // 
            this.btnCompleteTask.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnCompleteTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCompleteTask.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompleteTask.ForeColor = System.Drawing.Color.Magenta;
            this.btnCompleteTask.Location = new System.Drawing.Point(88, 534);
            this.btnCompleteTask.Name = "btnCompleteTask";
            this.btnCompleteTask.Size = new System.Drawing.Size(194, 36);
            this.btnCompleteTask.TabIndex = 9;
            this.btnCompleteTask.Text = "Complete Task";
            this.btnCompleteTask.UseVisualStyleBackColor = false;
            this.btnCompleteTask.Click += new System.EventHandler(this.btnCompleteTask_Click);
            // 
            // btnViewTasks
            // 
            this.btnViewTasks.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnViewTasks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnViewTasks.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewTasks.ForeColor = System.Drawing.Color.Magenta;
            this.btnViewTasks.Location = new System.Drawing.Point(88, 482);
            this.btnViewTasks.Name = "btnViewTasks";
            this.btnViewTasks.Size = new System.Drawing.Size(194, 36);
            this.btnViewTasks.TabIndex = 8;
            this.btnViewTasks.Text = "View Tasks";
            this.btnViewTasks.UseVisualStyleBackColor = false;
            this.btnViewTasks.Click += new System.EventHandler(this.btnViewTasks_Click);
            // 
            // bntAddTask
            // 
            this.bntAddTask.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.bntAddTask.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bntAddTask.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntAddTask.ForeColor = System.Drawing.Color.Magenta;
            this.bntAddTask.Location = new System.Drawing.Point(88, 429);
            this.bntAddTask.Name = "bntAddTask";
            this.bntAddTask.Size = new System.Drawing.Size(194, 35);
            this.bntAddTask.TabIndex = 7;
            this.bntAddTask.Text = "Add Task";
            this.bntAddTask.UseVisualStyleBackColor = false;
            this.bntAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(27, 379);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(308, 27);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // txtTaskDescription
            // 
            this.txtTaskDescription.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtTaskDescription.Location = new System.Drawing.Point(9, 190);
            this.txtTaskDescription.Name = "txtTaskDescription";
            this.txtTaskDescription.Size = new System.Drawing.Size(326, 120);
            this.txtTaskDescription.TabIndex = 4;
            this.txtTaskDescription.Text = "";
            // 
            // txtDescription
            // 
            this.txtDescription.AutoSize = true;
            this.txtDescription.BackColor = System.Drawing.Color.Snow;
            this.txtDescription.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.Magenta;
            this.txtDescription.Location = new System.Drawing.Point(110, 155);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(122, 23);
            this.txtDescription.TabIndex = 3;
            this.txtDescription.Text = "Description:";
            // 
            // TaskTitle
            // 
            this.TaskTitle.AutoSize = true;
            this.TaskTitle.BackColor = System.Drawing.Color.Snow;
            this.TaskTitle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskTitle.ForeColor = System.Drawing.Color.Magenta;
            this.TaskTitle.Location = new System.Drawing.Point(136, 50);
            this.TaskTitle.Name = "TaskTitle";
            this.TaskTitle.Size = new System.Drawing.Size(59, 23);
            this.TaskTitle.TabIndex = 2;
            this.TaskTitle.Text = "Title:";
            this.TaskTitle.Click += new System.EventHandler(this.Title_Click);
            // 
            // txtTaskTitle
            // 
            this.txtTaskTitle.Location = new System.Drawing.Point(4, 91);
            this.txtTaskTitle.Name = "txtTaskTitle";
            this.txtTaskTitle.Size = new System.Drawing.Size(331, 27);
            this.txtTaskTitle.TabIndex = 1;
            // 
            // lblAddNewTask
            // 
            this.lblAddNewTask.AutoSize = true;
            this.lblAddNewTask.ForeColor = System.Drawing.Color.MediumOrchid;
            this.lblAddNewTask.Location = new System.Drawing.Point(110, 10);
            this.lblAddNewTask.Name = "lblAddNewTask";
            this.lblAddNewTask.Size = new System.Drawing.Size(135, 20);
            this.lblAddNewTask.TabIndex = 0;
            this.lblAddNewTask.Text = "Add New Task";
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.White;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskID,
            this.Title,
            this.Description,
            this.ReminderDate,
            this.Completed});
            this.dgvTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTasks.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dgvTasks.Location = new System.Drawing.Point(0, 0);
            this.dgvTasks.MultiSelect = false;
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTasks.Size = new System.Drawing.Size(980, 638);
            this.dgvTasks.TabIndex = 0;
            // 
            // TaskID
            // 
            this.TaskID.HeaderText = "ID";
            this.TaskID.MinimumWidth = 6;
            this.TaskID.Name = "TaskID";
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            // 
            // ReminderDate
            // 
            this.ReminderDate.HeaderText = "Reminder";
            this.ReminderDate.MinimumWidth = 6;
            this.ReminderDate.Name = "ReminderDate";
            // 
            // Completed
            // 
            this.Completed.HeaderText = "Completed";
            this.Completed.MinimumWidth = 6;
            this.Completed.Name = "Completed";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnRestartQuiz);
            this.tabPage3.Controls.Add(this.btnStartQuiz);
            this.tabPage3.Controls.Add(this.lblFeedback);
            this.tabPage3.Controls.Add(this.btnD);
            this.tabPage3.Controls.Add(this.btnC);
            this.tabPage3.Controls.Add(this.btnB);
            this.tabPage3.Controls.Add(this.btnA);
            this.tabPage3.Controls.Add(this.lblScore);
            this.tabPage3.Controls.Add(this.lblQuestionNumber);
            this.tabPage3.Controls.Add(this.lblQuiz);
            this.tabPage3.Controls.Add(this.pnlQuestionBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1340, 644);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cyber Quiz";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnRestartQuiz
            // 
            this.btnRestartQuiz.BackColor = System.Drawing.Color.Indigo;
            this.btnRestartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnRestartQuiz.Location = new System.Drawing.Point(1160, 600);
            this.btnRestartQuiz.Name = "btnRestartQuiz";
            this.btnRestartQuiz.Size = new System.Drawing.Size(137, 36);
            this.btnRestartQuiz.TabIndex = 9;
            this.btnRestartQuiz.Text = "Restart Quiz";
            this.btnRestartQuiz.UseVisualStyleBackColor = false;
            this.btnRestartQuiz.Click += new System.EventHandler(this.btnRestartQuiz_Click);
            // 
            // btnStartQuiz
            // 
            this.btnStartQuiz.BackColor = System.Drawing.Color.Indigo;
            this.btnStartQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartQuiz.ForeColor = System.Drawing.Color.White;
            this.btnStartQuiz.Location = new System.Drawing.Point(29, 6);
            this.btnStartQuiz.Name = "btnStartQuiz";
            this.btnStartQuiz.Size = new System.Drawing.Size(116, 40);
            this.btnStartQuiz.TabIndex = 8;
            this.btnStartQuiz.Text = "Start Quiz";
            this.btnStartQuiz.UseVisualStyleBackColor = false;
            // 
            // lblFeedback
            // 
            this.lblFeedback.ForeColor = System.Drawing.Color.Black;
            this.lblFeedback.Location = new System.Drawing.Point(6, 529);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(1291, 68);
            this.lblFeedback.TabIndex = 1;
            this.lblFeedback.Text = "label3";
            this.lblFeedback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnD.ForeColor = System.Drawing.Color.Orange;
            this.btnD.Location = new System.Drawing.Point(10, 482);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(1291, 44);
            this.btnD.TabIndex = 7;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnC.ForeColor = System.Drawing.Color.Orange;
            this.btnC.Location = new System.Drawing.Point(10, 432);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(1291, 44);
            this.btnC.TabIndex = 6;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnB.ForeColor = System.Drawing.Color.Orange;
            this.btnB.Location = new System.Drawing.Point(10, 382);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(1291, 44);
            this.btnB.TabIndex = 5;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("Cooper Black", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnA.ForeColor = System.Drawing.Color.Orange;
            this.btnA.Location = new System.Drawing.Point(10, 332);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(1291, 44);
            this.btnA.TabIndex = 4;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Orange;
            this.lblScore.Location = new System.Drawing.Point(1110, 56);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(76, 20);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score: 0";
            this.lblScore.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblQuestionNumber
            // 
            this.lblQuestionNumber.AutoSize = true;
            this.lblQuestionNumber.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestionNumber.ForeColor = System.Drawing.Color.Orange;
            this.lblQuestionNumber.Location = new System.Drawing.Point(26, 60);
            this.lblQuestionNumber.Name = "lblQuestionNumber";
            this.lblQuestionNumber.Size = new System.Drawing.Size(130, 15);
            this.lblQuestionNumber.TabIndex = 2;
            this.lblQuestionNumber.Text = "Question Number:";
            // 
            // lblQuiz
            // 
            this.lblQuiz.AutoSize = true;
            this.lblQuiz.Font = new System.Drawing.Font("Rockwell", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuiz.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblQuiz.Location = new System.Drawing.Point(508, 3);
            this.lblQuiz.Name = "lblQuiz";
            this.lblQuiz.Size = new System.Drawing.Size(196, 25);
            this.lblQuiz.TabIndex = 1;
            this.lblQuiz.Text = "Cybersecurity Quiz";
            // 
            // pnlQuestionBox
            // 
            this.pnlQuestionBox.Controls.Add(this.lblQuestion);
            this.pnlQuestionBox.Location = new System.Drawing.Point(10, 98);
            this.pnlQuestionBox.Name = "pnlQuestionBox";
            this.pnlQuestionBox.Size = new System.Drawing.Size(1280, 228);
            this.pnlQuestionBox.TabIndex = 0;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblQuestion.Location = new System.Drawing.Point(9, 22);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(63, 22);
            this.lblQuestion.TabIndex = 0;
            this.lblQuestion.Text = "label4";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnLogin
            // 
            this.pnLogin.BackColor = System.Drawing.Color.Black;
            this.pnLogin.Controls.Add(this.btnStart);
            this.pnLogin.Controls.Add(this.txtName);
            this.pnLogin.Controls.Add(this.lblEnterName);
            this.pnLogin.Controls.Add(this.lblWelcome);
            this.pnLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnLogin.Location = new System.Drawing.Point(0, 44);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(1348, 677);
            this.pnLogin.TabIndex = 22;
            // 
            // btnStart
            // 
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.ForeColor = System.Drawing.Color.Tomato;
            this.btnStart.Location = new System.Drawing.Point(598, 325);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 45);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(514, 258);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(309, 27);
            this.txtName.TabIndex = 2;
            // 
            // lblEnterName
            // 
            this.lblEnterName.AutoSize = true;
            this.lblEnterName.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterName.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblEnterName.Location = new System.Drawing.Point(587, 219);
            this.lblEnterName.Name = "lblEnterName";
            this.lblEnterName.Size = new System.Drawing.Size(158, 22);
            this.lblEnterName.TabIndex = 1;
            this.lblEnterName.Text = "Enter Your Name:";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblWelcome.Location = new System.Drawing.Point(612, 141);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(102, 23);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(1348, 721);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyber Crime Fighting Bot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitChat.Panel1.ResumeLayout(false);
            this.splitChat.Panel1.PerformLayout();
            this.splitChat.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitChat)).EndInit();
            this.splitChat.ResumeLayout(false);
            this.tblChat.ResumeLayout(false);
            this.tblChat.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitTasks.Panel1.ResumeLayout(false);
            this.splitTasks.Panel1.PerformLayout();
            this.splitTasks.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitTasks)).EndInit();
            this.splitTasks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.pnlQuestionBox.ResumeLayout(false);
            this.pnlQuestionBox.PerformLayout();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel pnLogin;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEnterName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.SplitContainer splitChat;
        private System.Windows.Forms.Label lblTopics;
        private System.Windows.Forms.ListBox lstTopics;
        private System.Windows.Forms.TableLayoutPanel tblChat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAscii;
        private System.Windows.Forms.RichTextBox txtChat;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.SplitContainer splitTasks;
        private System.Windows.Forms.Label lblAddNewTask;
        private System.Windows.Forms.TextBox txtTaskTitle;
        private System.Windows.Forms.Label txtDescription;
        private System.Windows.Forms.Label TaskTitle;
        private System.Windows.Forms.RichTextBox txtTaskDescription;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnCompleteTask;
        private System.Windows.Forms.Button btnViewTasks;
        private System.Windows.Forms.Button bntAddTask;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReminderDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Completed;
        private System.Windows.Forms.Panel pnlQuestionBox;
        private System.Windows.Forms.Label lblQuiz;
        private System.Windows.Forms.Label lblQuestionNumber;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnRestartQuiz;
        private System.Windows.Forms.Button btnStartQuiz;
        private System.Windows.Forms.DateTimePicker dtpReminder;
    }
}

