namespace awesome_calculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.result_label = new System.Windows.Forms.Label();
            this.radio_add = new System.Windows.Forms.RadioButton();
            this.radio_multiply = new System.Windows.Forms.RadioButton();
            this.radio_subtract = new System.Windows.Forms.RadioButton();
            this.radio_divide = new System.Windows.Forms.RadioButton();
            this.calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Awesome Calculator";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(240, 108);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 2;
            // 
            // result_label
            // 
            this.result_label.AutoSize = true;
            this.result_label.Location = new System.Drawing.Point(144, 350);
            this.result_label.Name = "result_label";
            this.result_label.Size = new System.Drawing.Size(0, 16);
            this.result_label.TabIndex = 3;
            // 
            // radio_add
            // 
            this.radio_add.AutoSize = true;
            this.radio_add.Location = new System.Drawing.Point(108, 172);
            this.radio_add.Name = "radio_add";
            this.radio_add.Size = new System.Drawing.Size(53, 20);
            this.radio_add.TabIndex = 4;
            this.radio_add.TabStop = true;
            this.radio_add.Text = "Add";
            this.radio_add.UseVisualStyleBackColor = true;
            // 
            // radio_multiply
            // 
            this.radio_multiply.AutoSize = true;
            this.radio_multiply.Location = new System.Drawing.Point(237, 172);
            this.radio_multiply.Name = "radio_multiply";
            this.radio_multiply.Size = new System.Drawing.Size(73, 20);
            this.radio_multiply.TabIndex = 5;
            this.radio_multiply.TabStop = true;
            this.radio_multiply.Text = "Multiply";
            this.radio_multiply.UseVisualStyleBackColor = true;
            // 
            // radio_subtract
            // 
            this.radio_subtract.AutoSize = true;
            this.radio_subtract.Location = new System.Drawing.Point(108, 214);
            this.radio_subtract.Name = "radio_subtract";
            this.radio_subtract.Size = new System.Drawing.Size(77, 20);
            this.radio_subtract.TabIndex = 6;
            this.radio_subtract.TabStop = true;
            this.radio_subtract.Text = "Subtract";
            this.radio_subtract.UseVisualStyleBackColor = true;
            // 
            // radio_divide
            // 
            this.radio_divide.AutoSize = true;
            this.radio_divide.Location = new System.Drawing.Point(237, 214);
            this.radio_divide.Name = "radio_divide";
            this.radio_divide.Size = new System.Drawing.Size(67, 20);
            this.radio_divide.TabIndex = 7;
            this.radio_divide.TabStop = true;
            this.radio_divide.Text = "Divide";
            this.radio_divide.UseVisualStyleBackColor = true;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(178, 275);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(75, 23);
            this.calculate.TabIndex = 9;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 432);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.radio_divide);
            this.Controls.Add(this.radio_subtract);
            this.Controls.Add(this.radio_multiply);
            this.Controls.Add(this.radio_add);
            this.Controls.Add(this.result_label);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label result_label;
        private System.Windows.Forms.RadioButton radio_add;
        private System.Windows.Forms.RadioButton radio_multiply;
        private System.Windows.Forms.RadioButton radio_subtract;
        private System.Windows.Forms.RadioButton radio_divide;
        private System.Windows.Forms.Button calculate;
    }
}