namespace CinemaTicket
{
    partial class FormTicket
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
            this.pictureBoxHall = new System.Windows.Forms.PictureBox();
            this.labelRyad = new System.Windows.Forms.Label();
            this.labelMest = new System.Windows.Forms.Label();
            this.numericUpDownRow = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPlace = new System.Windows.Forms.NumericUpDown();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonIssue = new System.Windows.Forms.Button();
            this.pictureBoxPrise = new System.Windows.Forms.PictureBox();
            this.labelPriceAll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrise)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxHall
            // 
            this.pictureBoxHall.Image = global::CinemaTicket.Properties.Resources.CinemaRow8Place24;
            this.pictureBoxHall.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxHall.Name = "pictureBoxHall";
            this.pictureBoxHall.Size = new System.Drawing.Size(762, 205);
            this.pictureBoxHall.TabIndex = 0;
            this.pictureBoxHall.TabStop = false;
            // 
            // labelRyad
            // 
            this.labelRyad.AutoSize = true;
            this.labelRyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRyad.Location = new System.Drawing.Point(23, 231);
            this.labelRyad.Name = "labelRyad";
            this.labelRyad.Size = new System.Drawing.Size(29, 13);
            this.labelRyad.TabIndex = 1;
            this.labelRyad.Text = "Ряд:";
            // 
            // labelMest
            // 
            this.labelMest.AutoSize = true;
            this.labelMest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMest.Location = new System.Drawing.Point(10, 258);
            this.labelMest.Name = "labelMest";
            this.labelMest.Size = new System.Drawing.Size(42, 13);
            this.labelMest.TabIndex = 2;
            this.labelMest.Text = "Место:";
            // 
            // numericUpDownRow
            // 
            this.numericUpDownRow.Location = new System.Drawing.Point(58, 229);
            this.numericUpDownRow.Name = "numericUpDownRow";
            this.numericUpDownRow.ReadOnly = true;
            this.numericUpDownRow.Size = new System.Drawing.Size(59, 23);
            this.numericUpDownRow.TabIndex = 0;
            this.numericUpDownRow.ValueChanged += new System.EventHandler(this.numericUpDownRyad_ValueChanged);
            // 
            // numericUpDownPlace
            // 
            this.numericUpDownPlace.Location = new System.Drawing.Point(58, 256);
            this.numericUpDownPlace.Name = "numericUpDownPlace";
            this.numericUpDownPlace.ReadOnly = true;
            this.numericUpDownPlace.Size = new System.Drawing.Size(59, 23);
            this.numericUpDownPlace.TabIndex = 1;
            this.numericUpDownPlace.ValueChanged += new System.EventHandler(this.numericUpDownMesto_ValueChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(700, 278);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonIssue
            // 
            this.buttonIssue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonIssue.Location = new System.Drawing.Point(609, 278);
            this.buttonIssue.Name = "buttonIssue";
            this.buttonIssue.Size = new System.Drawing.Size(75, 23);
            this.buttonIssue.TabIndex = 8;
            this.buttonIssue.Text = "Оформить";
            this.buttonIssue.UseVisualStyleBackColor = true;
            this.buttonIssue.Click += new System.EventHandler(this.buttonIssue_Click);
            // 
            // pictureBoxPrise
            // 
            this.pictureBoxPrise.Image = global::CinemaTicket.Properties.Resources.Price;
            this.pictureBoxPrise.InitialImage = null;
            this.pictureBoxPrise.Location = new System.Drawing.Point(483, 223);
            this.pictureBoxPrise.Name = "pictureBoxPrise";
            this.pictureBoxPrise.Size = new System.Drawing.Size(291, 42);
            this.pictureBoxPrise.TabIndex = 9;
            this.pictureBoxPrise.TabStop = false;
            // 
            // labelPriceAll
            // 
            this.labelPriceAll.AutoSize = true;
            this.labelPriceAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceAll.Location = new System.Drawing.Point(173, 229);
            this.labelPriceAll.Name = "labelPriceAll";
            this.labelPriceAll.Size = new System.Drawing.Size(37, 13);
            this.labelPriceAll.TabIndex = 10;
            this.labelPriceAll.Text = "Итог: ";
            // 
            // FormTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 313);
            this.Controls.Add(this.labelPriceAll);
            this.Controls.Add(this.pictureBoxPrise);
            this.Controls.Add(this.buttonIssue);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.numericUpDownPlace);
            this.Controls.Add(this.numericUpDownRow);
            this.Controls.Add(this.labelMest);
            this.Controls.Add(this.labelRyad);
            this.Controls.Add(this.pictureBoxHall);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormTicket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупка билета";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxHall;
        private System.Windows.Forms.Label labelRyad;
        private System.Windows.Forms.Label labelMest;
        private System.Windows.Forms.NumericUpDown numericUpDownRow;
        private System.Windows.Forms.NumericUpDown numericUpDownPlace;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonIssue;
        private System.Windows.Forms.PictureBox pictureBoxPrise;
        private System.Windows.Forms.Label labelPriceAll;
        private System.Windows.Forms.Button buttonCancel;
    }
}