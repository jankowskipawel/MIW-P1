using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace MIW_P1
{
    public partial class SaveFileForm : Form
    {
        public Dataset dataSet = null;
        private Random rnd = new Random(DateTime.Now.Millisecond);
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
                List<List<object>> data = new List<List<object>>();
                if (checkBox1.Checked)
                {
                    data = dataSet.normalizedAttributes;
                }
                else
                {
                    data = dataSet.attributes;
                }
                //if vertical column output
                if (radioButton1.Checked)
                {
                    for (int i = 0; i < data[0].Count; i++)
                    {
                        List<object> tmp = new List<object>();
                        for (int j = 0; j < data.Count; j++)
                        {
                            tmp.Add(data[j][i]);
                        }
                        sw.WriteLine(string.Join(textBox2.Text, tmp));
                    }
                }
                //if horizontal column output
                else if(radioButton2.Checked)
                {
                    foreach (var column in data)
                    {
                        sw.WriteLine(string.Join(textBox2.Text, column));
                    }
                }
                else
                {
                    string jsonFile = JsonSerializer.Serialize(data);
                    sw.Write(jsonFile);
                }
                sw.Close();
            }
            else
            {
                MessageBox.Show("Please specify the file path");
            }

        }

        public void UpdatePreview()
        {
            if (radioButton1.Checked)
            {
                for (int i = 0; i <= 10; i++)
                {
                    List<object> tmp = new List<object>();
                    for (int j = 0; j <= 5; j++)
                    {
                        if (!checkBox1.Checked)
                        {
                            tmp.Add(rnd.Next(0, 100));
                        }
                        else
                        {
                            tmp.Add(Math.Round(rnd.NextDouble(),2));
                        }

                    }
                    textBox3.Text += (string.Join(textBox2.Text, tmp));
                    textBox3.Text += Environment.NewLine;
                }
            }
            else if(radioButton2.Checked)
            {
                for (int i = 0; i <= 5; i++)
                {
                    List<object> tmp = new List<object>();
                    for (int j = 0; j <= 10; j++)
                    {
                        if (!checkBox1.Checked)
                        {
                            tmp.Add(rnd.Next(0, 100));
                        }
                        else
                        {
                            tmp.Add(Math.Round(rnd.NextDouble(), 2));
                        }
                    }

                    textBox3.Text += (string.Join(textBox2.Text, tmp));
                    textBox3.Text += Environment.NewLine;
                }
            }
            else
            {
                textBox3.Text = "JSON";
            }
            
        }


        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.Text = "";
            UpdatePreview();
        }

    }
}
