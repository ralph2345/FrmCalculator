namespace FrmCalculator1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            cbOperator = new ComboBox();
            label3 = new Label();
            textBoxInput2 = new TextBox();
            label4 = new Label();
            btnEqual = new Button();
            lblDisplayTotal = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(56, 51);
            label1.Name = "label1";
            label1.Size = new Size(219, 32);
            label1.TabIndex = 0;
            label1.Text = "Enter first number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 161);
            label2.Name = "label2";
            label2.Size = new Size(253, 32);
            label2.TabIndex = 1;
            label2.Text = "Enter second number:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 60);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(303, 116);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(121, 23);
            cbOperator.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(100, 223);
            label3.Name = "label3";
            label3.Size = new Size(89, 30);
            label3.TabIndex = 4;
            label3.Text = "Answer:";
            // 
            // textBoxInput2
            // 
            textBoxInput2.Location = new Point(303, 172);
            textBoxInput2.Name = "textBoxInput2";
            textBoxInput2.Size = new Size(121, 23);
            textBoxInput2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(160, 109);
            label4.Name = "label4";
            label4.Size = new Size(115, 30);
            label4.TabIndex = 6;
            label4.Text = "Operation:";
            // 
            // btnEqual
            // 
            btnEqual.BackColor = SystemColors.ActiveCaption;
            btnEqual.Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location = new Point(280, 256);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(144, 45);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "Calculate";
            btnEqual.UseVisualStyleBackColor = false;
            btnEqual.Click += btnEqual_Click;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTotal.Location = new Point(337, 223);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(52, 21);
            lblDisplayTotal.TabIndex = 8;
            lblDisplayTotal.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(492, 323);
            Controls.Add(lblDisplayTotal);
            Controls.Add(btnEqual);
            Controls.Add(label4);
            Controls.Add(textBoxInput2);
            Controls.Add(label3);
            Controls.Add(cbOperator);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox cbOperator;
        private Label label3;
        private TextBox textBoxInput2;
        private Label label4;
        private Button btnEqual;
        private Label lblDisplayTotal;
    }
}