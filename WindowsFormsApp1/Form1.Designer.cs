﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerateQRCode;

        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.TextBox txtTaskName;
        private System.Windows.Forms.Label lblTaskName;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Label lblProjectName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ComboBox cmbPriority;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtAssignee;
        private System.Windows.Forms.Label lblAssignee;
        private System.Windows.Forms.DateTimePicker dtpCreationDate;
        private System.Windows.Forms.Label lblCreationDate;
        private System.Windows.Forms.TextBox txtTaskNumber;
        private System.Windows.Forms.Label lblTaskNumber;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Button btnEditTask;
        private System.Windows.Forms.Button btnDeleteTask;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAddTask = new System.Windows.Forms.Button();
            this.txtTaskName = new System.Windows.Forms.TextBox();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.lblProjectName = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbPriority = new System.Windows.Forms.ComboBox();
            this.lblPriority = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtAssignee = new System.Windows.Forms.TextBox();
            this.lblAssignee = new System.Windows.Forms.Label();
            this.dtpCreationDate = new System.Windows.Forms.DateTimePicker();
            this.lblCreationDate = new System.Windows.Forms.Label();
            this.txtTaskNumber = new System.Windows.Forms.TextBox();
            this.lblTaskNumber = new System.Windows.Forms.Label();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.btnEditTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.buttonGenerateQR = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddTask
            // 
            this.btnAddTask.Location = new System.Drawing.Point(291, 292);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(100, 30);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Добавить задачу";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // txtTaskName
            // 
            this.txtTaskName.Location = new System.Drawing.Point(33, 67);
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.Size = new System.Drawing.Size(200, 20);
            this.txtTaskName.TabIndex = 3;
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Location = new System.Drawing.Point(30, 51);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(60, 13);
            this.lblTaskName.TabIndex = 4;
            this.lblTaskName.Text = "Название:";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(33, 107);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(200, 20);
            this.txtProjectName.TabIndex = 5;
            // 
            // lblProjectName
            // 
            this.lblProjectName.AutoSize = true;
            this.lblProjectName.Location = new System.Drawing.Point(30, 90);
            this.lblProjectName.Name = "lblProjectName";
            this.lblProjectName.Size = new System.Drawing.Size(104, 13);
            this.lblProjectName.TabIndex = 6;
            this.lblProjectName.Text = "Название проекта:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(33, 147);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(200, 20);
            this.txtDescription.TabIndex = 7;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(30, 130);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 13);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "Описание:";
            // 
            // cmbPriority
            // 
            this.cmbPriority.FormattingEnabled = true;
            this.cmbPriority.Items.AddRange(new object[] {
            "Низкий",
            "Средний",
            "Высокий"});
            this.cmbPriority.Location = new System.Drawing.Point(33, 186);
            this.cmbPriority.Name = "cmbPriority";
            this.cmbPriority.Size = new System.Drawing.Size(200, 21);
            this.cmbPriority.TabIndex = 9;
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(30, 170);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(64, 13);
            this.lblPriority.TabIndex = 10;
            this.lblPriority.Text = "Приоритет:";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "В ожидании",
            "В работе",
            "Выполнено"});
            this.cmbStatus.Location = new System.Drawing.Point(33, 226);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(200, 21);
            this.cmbStatus.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(30, 210);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(44, 13);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Статус:";
            // 
            // txtAssignee
            // 
            this.txtAssignee.Location = new System.Drawing.Point(33, 266);
            this.txtAssignee.Name = "txtAssignee";
            this.txtAssignee.Size = new System.Drawing.Size(200, 20);
            this.txtAssignee.TabIndex = 13;
            // 
            // lblAssignee
            // 
            this.lblAssignee.AutoSize = true;
            this.lblAssignee.Location = new System.Drawing.Point(30, 250);
            this.lblAssignee.Name = "lblAssignee";
            this.lblAssignee.Size = new System.Drawing.Size(77, 13);
            this.lblAssignee.TabIndex = 14;
            this.lblAssignee.Text = "Исполнитель:";
            // 
            // dtpCreationDate
            // 
            this.dtpCreationDate.Location = new System.Drawing.Point(936, 411);
            this.dtpCreationDate.Name = "dtpCreationDate";
            this.dtpCreationDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCreationDate.TabIndex = 15;
            // 
            // lblCreationDate
            // 
            this.lblCreationDate.AutoSize = true;
            this.lblCreationDate.Location = new System.Drawing.Point(933, 395);
            this.lblCreationDate.Name = "lblCreationDate";
            this.lblCreationDate.Size = new System.Drawing.Size(87, 13);
            this.lblCreationDate.TabIndex = 16;
            this.lblCreationDate.Text = "Дата создания:";
            // 
            // txtTaskNumber
            // 
            this.txtTaskNumber.Location = new System.Drawing.Point(33, 27);
            this.txtTaskNumber.Name = "txtTaskNumber";
            this.txtTaskNumber.Size = new System.Drawing.Size(200, 20);
            this.txtTaskNumber.TabIndex = 1;
            // 
            // lblTaskNumber
            // 
            this.lblTaskNumber.AutoSize = true;
            this.lblTaskNumber.Location = new System.Drawing.Point(30, 11);
            this.lblTaskNumber.Name = "lblTaskNumber";
            this.lblTaskNumber.Size = new System.Drawing.Size(82, 13);
            this.lblTaskNumber.TabIndex = 2;
            this.lblTaskNumber.Text = "Номер задачи:";
            // 
            // dgvTasks
            // 
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(291, 27);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(591, 259);
            this.dgvTasks.TabIndex = 17;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            this.dgvTasks.SelectionChanged += new System.EventHandler(this.dgvTasks_SelectionChanged);
            // 
            // btnEditTask
            // 
            this.btnEditTask.Location = new System.Drawing.Point(544, 292);
            this.btnEditTask.Name = "btnEditTask";
            this.btnEditTask.Size = new System.Drawing.Size(100, 30);
            this.btnEditTask.TabIndex = 18;
            this.btnEditTask.Text = "Редактировать";
            this.btnEditTask.UseVisualStyleBackColor = true;
            this.btnEditTask.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Location = new System.Drawing.Point(782, 292);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteTask.TabIndex = 19;
            this.btnDeleteTask.Text = "Удалить задачу";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // buttonGenerateQR
            // 
            this.buttonGenerateQR.Location = new System.Drawing.Point(945, 77);
            this.buttonGenerateQR.Name = "buttonGenerateQR";
            this.buttonGenerateQR.Size = new System.Drawing.Size(136, 25);
            this.buttonGenerateQR.TabIndex = 21;
            this.buttonGenerateQR.Text = "qrcode";
            this.buttonGenerateQR.UseVisualStyleBackColor = true;
            this.buttonGenerateQR.Click += new System.EventHandler(this.btnGenerateQRCode_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox.Location = new System.Drawing.Point(893, 130);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(243, 225);
            this.pictureBox.TabIndex = 22;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(93, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1148, 443);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonGenerateQR);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnEditTask);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.dtpCreationDate);
            this.Controls.Add(this.lblCreationDate);
            this.Controls.Add(this.txtAssignee);
            this.Controls.Add(this.lblAssignee);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.cmbPriority);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtProjectName);
            this.Controls.Add(this.lblProjectName);
            this.Controls.Add(this.txtTaskName);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.txtTaskNumber);
            this.Controls.Add(this.lblTaskNumber);
            this.Controls.Add(this.btnAddTask);
            this.Name = "Form1";
            this.Text = "Менеджер задач";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Button buttonGenerateQR;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}