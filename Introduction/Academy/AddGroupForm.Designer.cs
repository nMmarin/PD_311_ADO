
namespace Academy
{
	partial class AddGroupForm
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
			this.labelGroupName = new System.Windows.Forms.Label();
			this.textBoxGroupName = new System.Windows.Forms.TextBox();
			this.labelGroupDirection = new System.Windows.Forms.Label();
			this.labelGroupTime = new System.Windows.Forms.Label();
			this.labelGroupDays = new System.Windows.Forms.Label();
			this.comboBoxGroupDirection = new System.Windows.Forms.ComboBox();
			this.dateTimePickerGroupTime = new System.Windows.Forms.DateTimePicker();
			this.labelLearnningForm = new System.Windows.Forms.Label();
			this.comboBoxLearningForm = new System.Windows.Forms.ComboBox();
			this.labelStartDate = new System.Windows.Forms.Label();
			this.dateTimePickerGroupStart = new System.Windows.Forms.DateTimePicker();
			this.buttonSaveGroup = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.checkedListBoxGroupDays = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// labelGroupName
			// 
			this.labelGroupName.AutoSize = true;
			this.labelGroupName.Location = new System.Drawing.Point(13, 13);
			this.labelGroupName.Name = "labelGroupName";
			this.labelGroupName.Size = new System.Drawing.Size(99, 13);
			this.labelGroupName.TabIndex = 0;
			this.labelGroupName.Text = "Название группы:";
			// 
			// textBoxGroupName
			// 
			this.textBoxGroupName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.textBoxGroupName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.textBoxGroupName.Location = new System.Drawing.Point(118, 13);
			this.textBoxGroupName.Name = "textBoxGroupName";
			this.textBoxGroupName.Size = new System.Drawing.Size(173, 20);
			this.textBoxGroupName.TabIndex = 1;
			// 
			// labelGroupDirection
			// 
			this.labelGroupDirection.AutoSize = true;
			this.labelGroupDirection.Location = new System.Drawing.Point(13, 51);
			this.labelGroupDirection.Name = "labelGroupDirection";
			this.labelGroupDirection.Size = new System.Drawing.Size(75, 13);
			this.labelGroupDirection.TabIndex = 2;
			this.labelGroupDirection.Text = "Направление";
			// 
			// labelGroupTime
			// 
			this.labelGroupTime.AutoSize = true;
			this.labelGroupTime.Location = new System.Drawing.Point(232, 159);
			this.labelGroupTime.Name = "labelGroupTime";
			this.labelGroupTime.Size = new System.Drawing.Size(40, 13);
			this.labelGroupTime.TabIndex = 3;
			this.labelGroupTime.Text = "Время";
			//this.labelGroupTime.Click += new System.EventHandler(this.labelGroupTime_Click);
			// 
			// labelGroupDays
			// 
			this.labelGroupDays.AutoSize = true;
			this.labelGroupDays.Location = new System.Drawing.Point(13, 109);
			this.labelGroupDays.Name = "labelGroupDays";
			this.labelGroupDays.Size = new System.Drawing.Size(77, 13);
			this.labelGroupDays.TabIndex = 4;
			this.labelGroupDays.Text = "Дни обучения";
			//this.labelGroupDays.Click += new System.EventHandler(this.labelGroupDays_Click);
			// 
			// comboBoxGroupDirection
			// 
			this.comboBoxGroupDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxGroupDirection.FormattingEnabled = true;
			this.comboBoxGroupDirection.Location = new System.Drawing.Point(118, 43);
			this.comboBoxGroupDirection.Name = "comboBoxGroupDirection";
			this.comboBoxGroupDirection.Size = new System.Drawing.Size(173, 21);
			this.comboBoxGroupDirection.TabIndex = 5;
			// 
			// dateTimePickerGroupTime
			// 
			this.dateTimePickerGroupTime.CustomFormat = "HH:mm";
			this.dateTimePickerGroupTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePickerGroupTime.Location = new System.Drawing.Point(298, 159);
			this.dateTimePickerGroupTime.Name = "dateTimePickerGroupTime";
			this.dateTimePickerGroupTime.Size = new System.Drawing.Size(89, 20);
			this.dateTimePickerGroupTime.TabIndex = 6;
			// 
			// labelLearnningForm
			// 
			this.labelLearnningForm.AutoSize = true;
			this.labelLearnningForm.Location = new System.Drawing.Point(13, 76);
			this.labelLearnningForm.Name = "labelLearnningForm";
			this.labelLearnningForm.Size = new System.Drawing.Size(96, 13);
			this.labelLearnningForm.TabIndex = 8;
			this.labelLearnningForm.Text = "Форма обучения:";
			// 
			// comboBoxLearningForm
			// 
			this.comboBoxLearningForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxLearningForm.FormattingEnabled = true;
			this.comboBoxLearningForm.Location = new System.Drawing.Point(118, 76);
			this.comboBoxLearningForm.Name = "comboBoxLearningForm";
			this.comboBoxLearningForm.Size = new System.Drawing.Size(173, 21);
			this.comboBoxLearningForm.TabIndex = 9;
			// 
			// labelStartDate
			// 
			this.labelStartDate.AutoSize = true;
			this.labelStartDate.Location = new System.Drawing.Point(13, 159);
			this.labelStartDate.Name = "labelStartDate";
			this.labelStartDate.Size = new System.Drawing.Size(83, 13);
			this.labelStartDate.TabIndex = 10;
			this.labelStartDate.Text = "Старт занятий:";
			// 
			// dateTimePickerGroupStart
			// 
			this.dateTimePickerGroupStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePickerGroupStart.Location = new System.Drawing.Point(115, 157);
			this.dateTimePickerGroupStart.Name = "dateTimePickerGroupStart";
			this.dateTimePickerGroupStart.Size = new System.Drawing.Size(79, 20);
			this.dateTimePickerGroupStart.TabIndex = 11;
			// 
			// buttonSaveGroup
			// 
			this.buttonSaveGroup.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonSaveGroup.Location = new System.Drawing.Point(235, 184);
			this.buttonSaveGroup.Name = "buttonSaveGroup";
			this.buttonSaveGroup.Size = new System.Drawing.Size(75, 23);
			this.buttonSaveGroup.TabIndex = 12;
			this.buttonSaveGroup.Text = "Сохранить";
			this.buttonSaveGroup.UseVisualStyleBackColor = true;
			this.buttonSaveGroup.Click += new System.EventHandler(this.buttonSaveGroup_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(316, 184);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 13;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// checkedListBoxGroupDays
			// 
			this.checkedListBoxGroupDays.CheckOnClick = true;
			this.checkedListBoxGroupDays.ColumnWidth = 38;
			this.checkedListBoxGroupDays.FormattingEnabled = true;
			this.checkedListBoxGroupDays.Items.AddRange(new object[] {
            "Пн",
            "Вт",
            "Ср",
            "Чт",
            "Пт",
            "Сб",
            "Вс"});
			this.checkedListBoxGroupDays.Location = new System.Drawing.Point(118, 104);
			this.checkedListBoxGroupDays.MultiColumn = true;
			this.checkedListBoxGroupDays.Name = "checkedListBoxGroupDays";
			this.checkedListBoxGroupDays.Size = new System.Drawing.Size(269, 34);
			this.checkedListBoxGroupDays.TabIndex = 14;
			// 
			// AddGroupForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 222);
			this.Controls.Add(this.checkedListBoxGroupDays);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.buttonSaveGroup);
			this.Controls.Add(this.dateTimePickerGroupStart);
			this.Controls.Add(this.labelStartDate);
			this.Controls.Add(this.comboBoxLearningForm);
			this.Controls.Add(this.labelLearnningForm);
			this.Controls.Add(this.dateTimePickerGroupTime);
			this.Controls.Add(this.comboBoxGroupDirection);
			this.Controls.Add(this.labelGroupDays);
			this.Controls.Add(this.labelGroupTime);
			this.Controls.Add(this.labelGroupDirection);
			this.Controls.Add(this.textBoxGroupName);
			this.Controls.Add(this.labelGroupName);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "AddGroupForm";
			this.Text = "AddGroupForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelGroupName;
		private System.Windows.Forms.TextBox textBoxGroupName;
		private System.Windows.Forms.Label labelGroupDirection;
		private System.Windows.Forms.Label labelGroupTime;
		private System.Windows.Forms.Label labelGroupDays;
		private System.Windows.Forms.ComboBox comboBoxGroupDirection;
		private System.Windows.Forms.DateTimePicker dateTimePickerGroupTime;
		private System.Windows.Forms.Label labelLearnningForm;
		private System.Windows.Forms.ComboBox comboBoxLearningForm;
		private System.Windows.Forms.Label labelStartDate;
		private System.Windows.Forms.DateTimePicker dateTimePickerGroupStart;
		private System.Windows.Forms.Button buttonSaveGroup;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.CheckedListBox checkedListBoxGroupDays;
	}
}