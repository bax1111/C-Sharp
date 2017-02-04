namespace Calculator
{
    partial class Calculator
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
            this.One = new System.Windows.Forms.Button();
            this.Four = new System.Windows.Forms.Button();
            this.Seven = new System.Windows.Forms.Button();
            this.Divide = new System.Windows.Forms.Button();
            this.Multiply = new System.Windows.Forms.Button();
            this.Addition = new System.Windows.Forms.Button();
            this.Subtract = new System.Windows.Forms.Button();
            this.Zero = new System.Windows.Forms.Button();
            this.Equals = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Nine = new System.Windows.Forms.Button();
            this.Six = new System.Windows.Forms.Button();
            this.Three = new System.Windows.Forms.Button();
            this.Period = new System.Windows.Forms.Button();
            this.Eight = new System.Windows.Forms.Button();
            this.Five = new System.Windows.Forms.Button();
            this.Two = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // One
            // 
            this.One.Location = new System.Drawing.Point(12, 139);
            this.One.Name = "One";
            this.One.Size = new System.Drawing.Size(51, 23);
            this.One.TabIndex = 0;
            this.One.Text = "1";
            this.One.UseVisualStyleBackColor = true;
            this.One.Click += new System.EventHandler(this.One_Click);
            // 
            // Four
            // 
            this.Four.Location = new System.Drawing.Point(12, 99);
            this.Four.Name = "Four";
            this.Four.Size = new System.Drawing.Size(51, 23);
            this.Four.TabIndex = 3;
            this.Four.Text = "4";
            this.Four.UseVisualStyleBackColor = true;
            this.Four.Click += new System.EventHandler(this.Four_Click);
            // 
            // Seven
            // 
            this.Seven.Location = new System.Drawing.Point(12, 60);
            this.Seven.Name = "Seven";
            this.Seven.Size = new System.Drawing.Size(51, 23);
            this.Seven.TabIndex = 6;
            this.Seven.Text = "7";
            this.Seven.UseVisualStyleBackColor = true;
            this.Seven.Click += new System.EventHandler(this.Seven_Click);
            // 
            // Divide
            // 
            this.Divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide.Location = new System.Drawing.Point(226, 60);
            this.Divide.Name = "Divide";
            this.Divide.Size = new System.Drawing.Size(53, 23);
            this.Divide.TabIndex = 9;
            this.Divide.Text = "/";
            this.Divide.UseVisualStyleBackColor = true;
            this.Divide.Click += new System.EventHandler(this.Divide_Click);
            // 
            // Multiply
            // 
            this.Multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiply.Location = new System.Drawing.Point(226, 99);
            this.Multiply.Name = "Multiply";
            this.Multiply.Size = new System.Drawing.Size(53, 23);
            this.Multiply.TabIndex = 10;
            this.Multiply.Text = "*";
            this.Multiply.UseVisualStyleBackColor = true;
            this.Multiply.Click += new System.EventHandler(this.Multiply_Click);
            // 
            // Addition
            // 
            this.Addition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addition.Location = new System.Drawing.Point(226, 139);
            this.Addition.Name = "Addition";
            this.Addition.Size = new System.Drawing.Size(53, 23);
            this.Addition.TabIndex = 11;
            this.Addition.Text = "+";
            this.Addition.UseVisualStyleBackColor = true;
            this.Addition.Click += new System.EventHandler(this.Addition_Click);
            // 
            // Subtract
            // 
            this.Subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subtract.Location = new System.Drawing.Point(226, 179);
            this.Subtract.Name = "Subtract";
            this.Subtract.Size = new System.Drawing.Size(53, 23);
            this.Subtract.TabIndex = 12;
            this.Subtract.Text = "-";
            this.Subtract.UseVisualStyleBackColor = true;
            this.Subtract.Click += new System.EventHandler(this.Subtract_Click);
            // 
            // Zero
            // 
            this.Zero.Location = new System.Drawing.Point(12, 179);
            this.Zero.Name = "Zero";
            this.Zero.Size = new System.Drawing.Size(51, 23);
            this.Zero.TabIndex = 13;
            this.Zero.Text = "0";
            this.Zero.UseVisualStyleBackColor = true;
            this.Zero.Click += new System.EventHandler(this.Zero_Click);
            // 
            // Equals
            // 
            this.Equals.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Equals.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Equals.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Equals.Location = new System.Drawing.Point(12, 220);
            this.Equals.Name = "Equals";
            this.Equals.Size = new System.Drawing.Size(267, 40);
            this.Equals.TabIndex = 16;
            this.Equals.Text = "=";
            this.Equals.UseVisualStyleBackColor = true;
            this.Equals.Click += new System.EventHandler(this.Equals_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(146, 179);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(51, 23);
            this.Clear.TabIndex = 21;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Nine
            // 
            this.Nine.Location = new System.Drawing.Point(146, 60);
            this.Nine.Name = "Nine";
            this.Nine.Size = new System.Drawing.Size(51, 23);
            this.Nine.TabIndex = 20;
            this.Nine.Text = "9";
            this.Nine.UseVisualStyleBackColor = true;
            this.Nine.Click += new System.EventHandler(this.Nine_Click);
            // 
            // Six
            // 
            this.Six.Location = new System.Drawing.Point(146, 99);
            this.Six.Name = "Six";
            this.Six.Size = new System.Drawing.Size(51, 23);
            this.Six.TabIndex = 19;
            this.Six.Text = "6";
            this.Six.UseVisualStyleBackColor = true;
            this.Six.Click += new System.EventHandler(this.Six_Click);
            // 
            // Three
            // 
            this.Three.Location = new System.Drawing.Point(146, 139);
            this.Three.Name = "Three";
            this.Three.Size = new System.Drawing.Size(51, 23);
            this.Three.TabIndex = 18;
            this.Three.Text = "3";
            this.Three.UseVisualStyleBackColor = true;
            this.Three.Click += new System.EventHandler(this.Three_Click);
            // 
            // Period
            // 
            this.Period.Location = new System.Drawing.Point(79, 179);
            this.Period.Name = "Period";
            this.Period.Size = new System.Drawing.Size(51, 23);
            this.Period.TabIndex = 25;
            this.Period.Text = ".";
            this.Period.UseVisualStyleBackColor = true;
            this.Period.Click += new System.EventHandler(this.Period_Click);
            // 
            // Eight
            // 
            this.Eight.Location = new System.Drawing.Point(79, 60);
            this.Eight.Name = "Eight";
            this.Eight.Size = new System.Drawing.Size(51, 23);
            this.Eight.TabIndex = 24;
            this.Eight.Text = "8";
            this.Eight.UseVisualStyleBackColor = true;
            this.Eight.Click += new System.EventHandler(this.Eight_Click);
            // 
            // Five
            // 
            this.Five.Location = new System.Drawing.Point(79, 99);
            this.Five.Name = "Five";
            this.Five.Size = new System.Drawing.Size(51, 23);
            this.Five.TabIndex = 23;
            this.Five.Text = "5";
            this.Five.UseVisualStyleBackColor = true;
            this.Five.Click += new System.EventHandler(this.Five_Click);
            // 
            // Two
            // 
            this.Two.Location = new System.Drawing.Point(79, 139);
            this.Two.Name = "Two";
            this.Two.Size = new System.Drawing.Size(51, 23);
            this.Two.TabIndex = 22;
            this.Two.Text = "2";
            this.Two.UseVisualStyleBackColor = true;
            this.Two.Click += new System.EventHandler(this.Two_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(291, 277);
            this.Controls.Add(this.Period);
            this.Controls.Add(this.Eight);
            this.Controls.Add(this.Five);
            this.Controls.Add(this.Two);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Nine);
            this.Controls.Add(this.Six);
            this.Controls.Add(this.Three);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Equals);
            this.Controls.Add(this.Zero);
            this.Controls.Add(this.Subtract);
            this.Controls.Add(this.Addition);
            this.Controls.Add(this.Multiply);
            this.Controls.Add(this.Divide);
            this.Controls.Add(this.Seven);
            this.Controls.Add(this.Four);
            this.Controls.Add(this.One);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Calculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button One;
        private System.Windows.Forms.Button Four;
        private System.Windows.Forms.Button Seven;
        private System.Windows.Forms.Button Divide;
        private System.Windows.Forms.Button Multiply;
        private System.Windows.Forms.Button Addition;
        private System.Windows.Forms.Button Subtract;
        private System.Windows.Forms.Button Zero;
        private new System.Windows.Forms.Button Equals;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Nine;
        private System.Windows.Forms.Button Six;
        private System.Windows.Forms.Button Three;
        private System.Windows.Forms.Button Period;
        private System.Windows.Forms.Button Eight;
        private System.Windows.Forms.Button Five;
        private System.Windows.Forms.Button Two;
    }
}

