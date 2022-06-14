namespace CAPTCHATest
{
    partial class Win
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.buttonGeneration = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.checkBoxLetters = new System.Windows.Forms.CheckBox();
            this.checkBoxFix = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(11, 36);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(222, 72);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 114);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(221, 20);
            this.textBox.TabIndex = 1;
            // 
            // buttonGeneration
            // 
            this.buttonGeneration.Location = new System.Drawing.Point(12, 140);
            this.buttonGeneration.Name = "buttonGeneration";
            this.buttonGeneration.Size = new System.Drawing.Size(97, 23);
            this.buttonGeneration.TabIndex = 2;
            this.buttonGeneration.Text = "Генерация";
            this.buttonGeneration.UseVisualStyleBackColor = true;
            this.buttonGeneration.Click += new System.EventHandler(this.ButtonGeneration_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(135, 140);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(98, 23);
            this.buttonCheck.TabIndex = 3;
            this.buttonCheck.Text = "Проверка";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.ButtonCheck_Click);
            // 
            // checkBoxLetters
            // 
            this.checkBoxLetters.AutoSize = true;
            this.checkBoxLetters.Location = new System.Drawing.Point(13, 13);
            this.checkBoxLetters.Name = "checkBoxLetters";
            this.checkBoxLetters.Size = new System.Drawing.Size(101, 17);
            this.checkBoxLetters.TabIndex = 4;
            this.checkBoxLetters.Text = "Нужны буквы?";
            this.checkBoxLetters.UseVisualStyleBackColor = true;
            // 
            // checkBoxFix
            // 
            this.checkBoxFix.AutoSize = true;
            this.checkBoxFix.Location = new System.Drawing.Point(137, 12);
            this.checkBoxFix.Name = "checkBoxFix";
            this.checkBoxFix.Size = new System.Drawing.Size(96, 17);
            this.checkBoxFix.TabIndex = 5;
            this.checkBoxFix.Text = "Фиксировать";
            this.checkBoxFix.UseVisualStyleBackColor = true;
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 175);
            this.Controls.Add(this.checkBoxFix);
            this.Controls.Add(this.checkBoxLetters);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonGeneration);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.pictureBox);
            this.MaximizeBox = false;
            this.Name = "Win";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Капча";
            this.Load += new System.EventHandler(this.Win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button buttonGeneration;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.CheckBox checkBoxLetters;
        private System.Windows.Forms.CheckBox checkBoxFix;
    }
}

