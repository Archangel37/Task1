namespace Task1_yield
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.button_Evaluate = new System.Windows.Forms.Button();
            this.richTextBox_Result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(116, 30);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(239, 20);
            this.textBoxA.TabIndex = 0;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(116, 68);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(239, 20);
            this.textBoxB.TabIndex = 1;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(36, 33);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(63, 13);
            this.labelA.TabIndex = 2;
            this.labelA.Text = "DateTime A";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(36, 71);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(63, 13);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "DateTime B";
            // 
            // button_Evaluate
            // 
            this.button_Evaluate.Location = new System.Drawing.Point(398, 26);
            this.button_Evaluate.Name = "button_Evaluate";
            this.button_Evaluate.Size = new System.Drawing.Size(121, 62);
            this.button_Evaluate.TabIndex = 3;
            this.button_Evaluate.Text = "Evaluate";
            this.button_Evaluate.UseVisualStyleBackColor = true;
            this.button_Evaluate.Click += new System.EventHandler(this.button_Evaluate_Click);
            // 
            // richTextBox_Result
            // 
            this.richTextBox_Result.Location = new System.Drawing.Point(39, 137);
            this.richTextBox_Result.Name = "richTextBox_Result";
            this.richTextBox_Result.Size = new System.Drawing.Size(568, 307);
            this.richTextBox_Result.TabIndex = 4;
            this.richTextBox_Result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 456);
            this.Controls.Add(this.richTextBox_Result);
            this.Controls.Add(this.button_Evaluate);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Working with dates & IEnum & yield";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Button button_Evaluate;
        private System.Windows.Forms.RichTextBox richTextBox_Result;
    }
}

