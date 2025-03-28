namespace Quiz_Application
{
    partial class Quiz_Form
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
            this.richTextBox_Question = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonOption_1 = new System.Windows.Forms.RadioButton();
            this.button_Next = new System.Windows.Forms.Button();
            this.radioButtonOption_2 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption_3 = new System.Windows.Forms.RadioButton();
            this.radioButtonOption_4 = new System.Windows.Forms.RadioButton();
            this.output = new System.Windows.Forms.Label();
            this.OUTTXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // richTextBox_Question
            // 
            this.richTextBox_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Question.Location = new System.Drawing.Point(108, 204);
            this.richTextBox_Question.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox_Question.Name = "richTextBox_Question";
            this.richTextBox_Question.Size = new System.Drawing.Size(765, 174);
            this.richTextBox_Question.TabIndex = 0;
            this.richTextBox_Question.Text = "";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(108, 382);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 5);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonOption_1
            // 
            this.radioButtonOption_1.AutoSize = true;
            this.radioButtonOption_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOption_1.Location = new System.Drawing.Point(110, 444);
            this.radioButtonOption_1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOption_1.Name = "radioButtonOption_1";
            this.radioButtonOption_1.Size = new System.Drawing.Size(57, 40);
            this.radioButtonOption_1.TabIndex = 2;
            this.radioButtonOption_1.TabStop = true;
            this.radioButtonOption_1.Text = "A";
            this.radioButtonOption_1.UseVisualStyleBackColor = true;
            this.radioButtonOption_1.Click += new System.EventHandler(this.radioButtonOption_1_Click);
            // 
            // button_Next
            // 
            this.button_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.button_Next.FlatAppearance.BorderSize = 0;
            this.button_Next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Next.ForeColor = System.Drawing.Color.White;
            this.button_Next.Location = new System.Drawing.Point(216, 604);
            this.button_Next.Margin = new System.Windows.Forms.Padding(4);
            this.button_Next.Name = "button_Next";
            this.button_Next.Size = new System.Drawing.Size(555, 58);
            this.button_Next.TabIndex = 3;
            this.button_Next.Text = "Next";
            this.button_Next.UseVisualStyleBackColor = false;
            this.button_Next.Click += new System.EventHandler(this.button_Next_Click);
            // 
            // radioButtonOption_2
            // 
            this.radioButtonOption_2.AutoSize = true;
            this.radioButtonOption_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOption_2.Location = new System.Drawing.Point(110, 525);
            this.radioButtonOption_2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOption_2.Name = "radioButtonOption_2";
            this.radioButtonOption_2.Size = new System.Drawing.Size(56, 40);
            this.radioButtonOption_2.TabIndex = 4;
            this.radioButtonOption_2.TabStop = true;
            this.radioButtonOption_2.Text = "B";
            this.radioButtonOption_2.UseVisualStyleBackColor = true;
            this.radioButtonOption_2.Click += new System.EventHandler(this.radioButtonOption_2_Click);
            // 
            // radioButtonOption_3
            // 
            this.radioButtonOption_3.AutoSize = true;
            this.radioButtonOption_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOption_3.Location = new System.Drawing.Point(412, 444);
            this.radioButtonOption_3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOption_3.Name = "radioButtonOption_3";
            this.radioButtonOption_3.Size = new System.Drawing.Size(57, 40);
            this.radioButtonOption_3.TabIndex = 5;
            this.radioButtonOption_3.TabStop = true;
            this.radioButtonOption_3.Text = "C";
            this.radioButtonOption_3.UseVisualStyleBackColor = true;
            this.radioButtonOption_3.Click += new System.EventHandler(this.radioButtonOption_3_Click);
            // 
            // radioButtonOption_4
            // 
            this.radioButtonOption_4.AutoSize = true;
            this.radioButtonOption_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOption_4.Location = new System.Drawing.Point(412, 525);
            this.radioButtonOption_4.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOption_4.Name = "radioButtonOption_4";
            this.radioButtonOption_4.Size = new System.Drawing.Size(57, 40);
            this.radioButtonOption_4.TabIndex = 6;
            this.radioButtonOption_4.TabStop = true;
            this.radioButtonOption_4.Text = "D";
            this.radioButtonOption_4.UseVisualStyleBackColor = true;
            this.radioButtonOption_4.Click += new System.EventHandler(this.radioButtonOption_4_Click);
            // 
            // output
            // 
            this.output.AutoSize = true;
            this.output.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(103, 92);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(94, 29);
            this.output.TabIndex = 7;
            this.output.Text = "NAME :";
            // 
            // OUTTXT
            // 
            this.OUTTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUTTXT.Location = new System.Drawing.Point(232, 92);
            this.OUTTXT.Multiline = true;
            this.OUTTXT.Name = "OUTTXT";
            this.OUTTXT.Size = new System.Drawing.Size(237, 36);
            this.OUTTXT.TabIndex = 8;
            // 
            // Quiz_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 697);
            this.Controls.Add(this.OUTTXT);
            this.Controls.Add(this.output);
            this.Controls.Add(this.radioButtonOption_4);
            this.Controls.Add(this.radioButtonOption_3);
            this.Controls.Add(this.radioButtonOption_2);
            this.Controls.Add(this.button_Next);
            this.Controls.Add(this.radioButtonOption_1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.richTextBox_Question);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Quiz_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz_Form";
            this.Load += new System.EventHandler(this.Quiz_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox_Question;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonOption_1;
        private System.Windows.Forms.Button button_Next;
        private System.Windows.Forms.RadioButton radioButtonOption_2;
        private System.Windows.Forms.RadioButton radioButtonOption_3;
        private System.Windows.Forms.RadioButton radioButtonOption_4;
        private System.Windows.Forms.Label output;
        private System.Windows.Forms.TextBox OUTTXT;
    }
}