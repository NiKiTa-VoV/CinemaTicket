namespace CinemaTicket
{
    partial class FormFilm
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
            this.dateTimePickerFilm = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFilm = new System.Windows.Forms.ComboBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelDescription2 = new System.Windows.Forms.Label();
            this.labelDataFilm = new System.Windows.Forms.Label();
            this.labelFilmList = new System.Windows.Forms.Label();
            this.comboBoxSession = new System.Windows.Forms.ComboBox();
            this.buttonTicket = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelTimeList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePickerFilm
            // 
            this.dateTimePickerFilm.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dateTimePickerFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePickerFilm.Location = new System.Drawing.Point(14, 43);
            this.dateTimePickerFilm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePickerFilm.Name = "dateTimePickerFilm";
            this.dateTimePickerFilm.Size = new System.Drawing.Size(141, 20);
            this.dateTimePickerFilm.TabIndex = 9;
            this.dateTimePickerFilm.ValueChanged += new System.EventHandler(this.dateTimePickerFilm_ValueChanged);
            // 
            // comboBoxFilm
            // 
            this.comboBoxFilm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxFilm.FormattingEnabled = true;
            this.comboBoxFilm.Location = new System.Drawing.Point(173, 43);
            this.comboBoxFilm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxFilm.Name = "comboBoxFilm";
            this.comboBoxFilm.Size = new System.Drawing.Size(170, 21);
            this.comboBoxFilm.TabIndex = 2;
            this.comboBoxFilm.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilm_SelectedIndexChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription.Location = new System.Drawing.Point(364, 33);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.MaximumSize = new System.Drawing.Size(260, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(35, 13);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "пусто";
            // 
            // labelDescription2
            // 
            this.labelDescription2.AutoSize = true;
            this.labelDescription2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDescription2.Location = new System.Drawing.Point(357, 14);
            this.labelDescription2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription2.Name = "labelDescription2";
            this.labelDescription2.Size = new System.Drawing.Size(128, 13);
            this.labelDescription2.TabIndex = 4;
            this.labelDescription2.Text = "Информация о фильме:";
            // 
            // labelDataFilm
            // 
            this.labelDataFilm.AutoSize = true;
            this.labelDataFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDataFilm.Location = new System.Drawing.Point(11, 14);
            this.labelDataFilm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataFilm.Name = "labelDataFilm";
            this.labelDataFilm.Size = new System.Drawing.Size(134, 26);
            this.labelDataFilm.TabIndex = 5;
            this.labelDataFilm.Text = "Выберите дату когда вы \r\nходите пойти в кино";
            // 
            // labelFilmList
            // 
            this.labelFilmList.AutoSize = true;
            this.labelFilmList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFilmList.Location = new System.Drawing.Point(170, 14);
            this.labelFilmList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilmList.Name = "labelFilmList";
            this.labelFilmList.Size = new System.Drawing.Size(118, 26);
            this.labelFilmList.TabIndex = 6;
            this.labelFilmList.Text = "Выберите фильм на \r\nкоторый хотите пойти";
            // 
            // comboBoxSession
            // 
            this.comboBoxSession.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSession.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxSession.FormattingEnabled = true;
            this.comboBoxSession.Location = new System.Drawing.Point(129, 117);
            this.comboBoxSession.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSession.Name = "comboBoxSession";
            this.comboBoxSession.Size = new System.Drawing.Size(79, 21);
            this.comboBoxSession.TabIndex = 7;
            this.comboBoxSession.SelectedIndexChanged += new System.EventHandler(this.comboBoxSession_SelectedIndexChanged);
            // 
            // buttonTicket
            // 
            this.buttonTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonTicket.Location = new System.Drawing.Point(453, 270);
            this.buttonTicket.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTicket.Name = "buttonTicket";
            this.buttonTicket.Size = new System.Drawing.Size(75, 23);
            this.buttonTicket.TabIndex = 8;
            this.buttonTicket.Text = "Далее";
            this.buttonTicket.UseVisualStyleBackColor = true;
            this.buttonTicket.Click += new System.EventHandler(this.buttonTicket_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(543, 270);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelTimeList
            // 
            this.labelTimeList.AutoSize = true;
            this.labelTimeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTimeList.Location = new System.Drawing.Point(124, 101);
            this.labelTimeList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeList.Name = "labelTimeList";
            this.labelTimeList.Size = new System.Drawing.Size(92, 13);
            this.labelTimeList.TabIndex = 10;
            this.labelTimeList.Text = "Выберите время";
            // 
            // FormFilm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 305);
            this.Controls.Add(this.labelTimeList);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonTicket);
            this.Controls.Add(this.comboBoxSession);
            this.Controls.Add(this.labelFilmList);
            this.Controls.Add(this.labelDataFilm);
            this.Controls.Add(this.labelDescription2);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.comboBoxFilm);
            this.Controls.Add(this.dateTimePickerFilm);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormFilm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупка билета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerFilm;
        private System.Windows.Forms.ComboBox comboBoxFilm;
        private System.Windows.Forms.Label labelOpisanie;
        private System.Windows.Forms.Label labelDescription2;
        private System.Windows.Forms.Label labelDataFilm;
        private System.Windows.Forms.Label labelFilmList;
        private System.Windows.Forms.ComboBox comboBoxSession;
        private System.Windows.Forms.Button buttonBilet;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelFilmTime;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonTicket;
        private System.Windows.Forms.Label labelTimeList;
        private System.Windows.Forms.Button buttonCancel;
    }
}