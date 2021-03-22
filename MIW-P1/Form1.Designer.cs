
namespace MIW_P1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.button9 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(555, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(540, 23);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "E:\\STD\\S6\\MIW\\australian.dat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dataset path:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(540, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Config file path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Data delimiter:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(110, 57);
            this.textBox3.MaxLength = 5;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 23);
            this.textBox3.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(407, 60);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(141, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Generate config file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(209, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Check dataset using config file";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(9, 227);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox4.Size = new System.Drawing.Size(570, 308);
            this.textBox4.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(219, 60);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(141, 23);
            this.button5.TabIndex = 11;
            this.button5.Text = "Load dataset";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(219, 99);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(141, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Normalize data";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(407, 98);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(141, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Save data as...";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(598, 563);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(590, 535);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Part I";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button10);
            this.tabPage2.Controls.Add(this.textBox9);
            this.tabPage2.Controls.Add(this.button9);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.textBox8);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(590, 535);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Part II";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(542, 105);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(24, 23);
            this.button10.TabIndex = 11;
            this.button10.Text = "...";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(33, 191);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox9.Size = new System.Drawing.Size(529, 334);
            this.textBox9.TabIndex = 10;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(306, 148);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(75, 23);
            this.button9.TabIndex = 9;
            this.button9.Text = "Load data";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "File path:";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(33, 106);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(503, 23);
            this.textBox8.TabIndex = 7;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(204, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 6;
            this.button8.Text = "Save data";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(468, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "-";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(486, 44);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(80, 23);
            this.textBox7.TabIndex = 4;
            this.textBox7.Text = "1";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(387, 47);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(75, 23);
            this.textBox6.TabIndex = 3;
            this.textBox6.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Range:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Structure:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(33, 47);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(348, 23);
            this.textBox5.TabIndex = 0;
            this.textBox5.Text = "3 2 2";
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 562);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MIW-P1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.Button button10;
    }
}

