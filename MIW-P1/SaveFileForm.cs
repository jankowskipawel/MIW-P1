using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace MIW_P1
{
    public partial class SaveFileForm : Form
    {
        public Dataset dataSet = null;
        public SaveFileForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            textBox1.Text = saveFileDialog1.FileName;
        }

        //SAVE FILE BUTTON
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                StreamWriter sw = new StreamWriter(textBox1.Text);
                //if vertical column output
                if (radioButton1.Checked)
                {
                    for (int i = 0; i < dataSet.attributes[0].Count; i++)
                    {
                        List<object> tmp = new List<object>();
                        for (int j = 0; j < dataSet.attributes.Count; j++)
                        {
                            tmp.Add(dataSet.attributes[j][i]);
                        }
                        sw.WriteLine(string.Join(textBox2.Text, tmp));
                    }
                }
                //if horizontal column output
                else
                {
                    foreach (var column in dataSet.attributes)
                    {
                        sw.WriteLine(string.Join(textBox2.Text, column));
                    }
                }
                sw.Close();
            }
            else
            {
                MessageBox.Show("Please specify the file path");
            }

        }
    }
}
