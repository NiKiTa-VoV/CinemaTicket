namespace CinemaTicket
{
    partial class FormСheque
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
            this.buttonSaveCheque = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelCheque = new System.Windows.Forms.Label();
            this.textBoxСheque = new System.Windows.Forms.TextBox();
            this.saveFileDialogCheque = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // buttonSaveCheque
            // 
            this.buttonSaveCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSaveCheque.Location = new System.Drawing.Point(111, 272);
            this.buttonSaveCheque.Name = "buttonSaveCheque";
            this.buttonSaveCheque.Size = new System.Drawing.Size(108, 23);
            this.buttonSaveCheque.TabIndex = 0;
            this.buttonSaveCheque.Text = "Сохранить чек";
            this.buttonSaveCheque.UseVisualStyleBackColor = true;
            this.buttonSaveCheque.Click += new System.EventHandler(this.buttonSaveCheque_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExit.Location = new System.Drawing.Point(253, 313);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 1;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelCheque
            // 
            this.labelCheque.AutoSize = true;
            this.labelCheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCheque.Location = new System.Drawing.Point(12, 11);
            this.labelCheque.Name = "labelCheque";
            this.labelCheque.Size = new System.Drawing.Size(106, 13);
            this.labelCheque.TabIndex = 2;
            this.labelCheque.Text = "Ваш чек на фильм: ";
            // 
            // textBoxСheque
            // 
            this.textBoxСheque.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxСheque.Location = new System.Drawing.Point(12, 38);
            this.textBoxСheque.Multiline = true;
            this.textBoxСheque.Name = "textBoxСheque";
            this.textBoxСheque.ReadOnly = true;
            this.textBoxСheque.Size = new System.Drawing.Size(316, 225);
            this.textBoxСheque.TabIndex = 3;
            // 
            // FormСheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 346);
            this.Controls.Add(this.textBoxСheque);
            this.Controls.Add(this.labelCheque);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonSaveCheque);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormСheque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Покупка билета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveCheque;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelCheque;
        private System.Windows.Forms.TextBox textBoxCheck;
        private System.Windows.Forms.SaveFileDialog saveFileDialogCheque;
        private System.Windows.Forms.TextBox textBoxС;
        private System.Windows.Forms.TextBox textBoxСheque;
    }
}