
namespace PasswordGenerator
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
            this.letter_checkbox = new System.Windows.Forms.CheckBox();
            this.number_checkbox = new System.Windows.Forms.CheckBox();
            this.symbols_checkbox = new System.Windows.Forms.CheckBox();
            this.generate_button = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.copy_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.length = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.contents = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // letter_checkbox
            // 
            this.letter_checkbox.AutoSize = true;
            this.letter_checkbox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.letter_checkbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.letter_checkbox.Location = new System.Drawing.Point(24, 44);
            this.letter_checkbox.Name = "letter_checkbox";
            this.letter_checkbox.Size = new System.Drawing.Size(73, 25);
            this.letter_checkbox.TabIndex = 1;
            this.letter_checkbox.Text = "Letter";
            this.letter_checkbox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.letter_checkbox.UseVisualStyleBackColor = true;
            // 
            // number_checkbox
            // 
            this.number_checkbox.AutoSize = true;
            this.number_checkbox.Checked = true;
            this.number_checkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.number_checkbox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.number_checkbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.number_checkbox.Location = new System.Drawing.Point(24, 13);
            this.number_checkbox.Name = "number_checkbox";
            this.number_checkbox.Size = new System.Drawing.Size(89, 25);
            this.number_checkbox.TabIndex = 3;
            this.number_checkbox.Text = "Number";
            this.number_checkbox.UseVisualStyleBackColor = true;
            // 
            // symbols_checkbox
            // 
            this.symbols_checkbox.AutoSize = true;
            this.symbols_checkbox.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.symbols_checkbox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.symbols_checkbox.Location = new System.Drawing.Point(24, 75);
            this.symbols_checkbox.Name = "symbols_checkbox";
            this.symbols_checkbox.Size = new System.Drawing.Size(91, 25);
            this.symbols_checkbox.TabIndex = 3;
            this.symbols_checkbox.Text = "Symbols";
            this.symbols_checkbox.UseVisualStyleBackColor = true;
            // 
            // generate_button
            // 
            this.generate_button.BackColor = System.Drawing.Color.Brown;
            this.generate_button.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.generate_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.generate_button.Location = new System.Drawing.Point(165, 259);
            this.generate_button.Name = "generate_button";
            this.generate_button.Size = new System.Drawing.Size(149, 63);
            this.generate_button.TabIndex = 4;
            this.generate_button.Text = "Generate";
            this.generate_button.UseVisualStyleBackColor = false;
            this.generate_button.Click += new System.EventHandler(this.generate_button_Click);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.maskedTextBox1.Location = new System.Drawing.Point(14, 76);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(298, 35);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(6, -21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 91);
            this.panel1.TabIndex = 6;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.title.Location = new System.Drawing.Point(6, 39);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(280, 40);
            this.title.TabIndex = 0;
            this.title.Text = "Password Generator";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(165, 130);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Türkçe";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(165, 170);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "English";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // copy_button
            // 
            this.copy_button.BackColor = System.Drawing.Color.Brown;
            this.copy_button.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.copy_button.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.copy_button.Location = new System.Drawing.Point(165, 210);
            this.copy_button.Name = "copy_button";
            this.copy_button.Size = new System.Drawing.Size(149, 43);
            this.copy_button.TabIndex = 4;
            this.copy_button.Text = "Copy";
            this.copy_button.UseVisualStyleBackColor = false;
            this.copy_button.Click += new System.EventHandler(this.copy_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.Controls.Add(this.letter_checkbox);
            this.panel2.Controls.Add(this.number_checkbox);
            this.panel2.Controls.Add(this.symbols_checkbox);
            this.panel2.Location = new System.Drawing.Point(14, 210);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(143, 112);
            this.panel2.TabIndex = 8;
            // 
            // length
            // 
            this.length.AutoSize = true;
            this.length.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.length.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.length.Location = new System.Drawing.Point(12, 130);
            this.length.Name = "length";
            this.length.Size = new System.Drawing.Size(71, 25);
            this.length.TabIndex = 9;
            this.length.Text = "Length";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(14, 158);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(143, 23);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // contents
            // 
            this.contents.AutoSize = true;
            this.contents.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contents.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contents.Location = new System.Drawing.Point(14, 179);
            this.contents.Name = "contents";
            this.contents.Size = new System.Drawing.Size(89, 25);
            this.contents.TabIndex = 9;
            this.contents.Text = "Contents";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(324, 334);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.contents);
            this.Controls.Add(this.length);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.copy_button);
            this.Controls.Add(this.generate_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox letter_checkbox;
        private System.Windows.Forms.CheckBox number_checkbox;
        private System.Windows.Forms.CheckBox symbols_checkbox;
        private System.Windows.Forms.Button generate_button;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button copy_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label length;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label contents;
    }
}

