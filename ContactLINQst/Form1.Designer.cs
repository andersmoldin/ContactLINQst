namespace ContactLINQst
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nameButton = new System.Windows.Forms.Button();
            this.nameDayJuly23Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(135, 276);
            this.listBox1.TabIndex = 0;
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(155, 13);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(180, 30);
            this.nameButton.TabIndex = 1;
            this.nameButton.Text = "Hitta alla \"And[...]\"";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // nameDayJuly23Button
            // 
            this.nameDayJuly23Button.Location = new System.Drawing.Point(155, 49);
            this.nameDayJuly23Button.Name = "nameDayJuly23Button";
            this.nameDayJuly23Button.Size = new System.Drawing.Size(180, 31);
            this.nameDayJuly23Button.TabIndex = 2;
            this.nameDayJuly23Button.Text = "Namnsdag 23 juli";
            this.nameDayJuly23Button.UseVisualStyleBackColor = true;
            this.nameDayJuly23Button.Click += new System.EventHandler(this.nameDayJuly23Button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Börjar på \"P\" och namnsdag i April";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Sök";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 329);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(322, 22);
            this.textBox2.TabIndex = 5;
            this.textBox2.Text = "Hitta namnsdag (t.ex 1 april 2015)";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 63);
            this.button2.TabIndex = 6;
            this.button2.Text = "Visa hur många det finns som börjar på varje bokstav";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(155, 204);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 42);
            this.button3.TabIndex = 7;
            this.button3.Text = "Namnsdag varje månad";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 37);
            this.button4.TabIndex = 8;
            this.button4.Text = "Namnsdag varje kvartal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(155, 296);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(179, 27);
            this.button5.TabIndex = 9;
            this.button5.Text = "Fem dagar då flest har namnsdag";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 363);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nameDayJuly23Button);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.listBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button nameDayJuly23Button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

