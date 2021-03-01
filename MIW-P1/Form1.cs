using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIW_P1
{
    public partial class Form1 : Form
    {
        private Dataset dataset = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            textBox1.Text = openFileDialog1.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            textBox2.Text = openFileDialog2.FileName;
        }


        //LOAD DATASET BUTTON
        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                MessageBox.Show("Please specify the dataset delimiter");
            }
            else if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Please specify the dataset location");
            }
            else
            {
                dataset = new Dataset();
                string[] lines = File.ReadAllLines(textBox1.Text);
                for (int n = 0; n < lines.Length; n++)
                {
                    string[] columns = lines[n].Split(textBox3.Text);
                    //check type
                    for (int i = 0; i < columns.Length; i++)
                    {
                        float f;
                        string s;
                        int x;
                        if(Int32.TryParse(columns[i], out x))
                        {
                            if (n==0)
                            {
                                textBox4.Text += $"Column nr {i} is an int.{Environment.NewLine}";
                                dataset.attributes.Add(new List<object>(lines.Length) { x });
                                dataset.attributeTypes.Add("int");
                            }
                            else
                            {
                                dataset.attributes[i].Add(x);
                            }
                        }
                        else if(float.TryParse(columns[i], out f))
                        {
                            
                            if (n == 0)
                            {
                                textBox4.Text += $"Column nr {i} is a float.{Environment.NewLine}";
                                dataset.attributes.Add(new List<object>(lines.Length) { f });
                                dataset.attributeTypes.Add("float");
                            }
                            else
                            {
                                dataset.attributes[i].Add(f);
                            }
                        }
                        else if (Char.IsSymbol(columns[i], 0))
                        {
                            if (n == 0)
                            {
                                textBox4.Text += $"Column nr {i} is a symbol.{Environment.NewLine}";
                                dataset.attributes.Add(new List<object>(lines.Length) { columns[i] });
                                dataset.attributeTypes.Add("symbol");
                            }
                            else
                            {
                                dataset.attributes[i].Add(columns[i]);
                            }
                        }
                        else
                        {
                            
                            if (n == 0)
                            {
                                textBox4.Text += $"Column nr {i} is a string.{Environment.NewLine}";
                                dataset.attributes.Add(new List<object>(lines.Length){ columns[i] });
                                dataset.attributeTypes.Add("string");
                            }
                            else
                            {
                                dataset.attributes[i].Add(columns[i]);
                            }
                        }
                    }
                }
                textBox4.Text += $"Dataset loaded.{Environment.NewLine}";
                button5.Enabled = false;
                button5.Text = "Dataset loaded";
            }
        }

        //GENERATE CONFIG FILE BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataset == null)
            {
                MessageBox.Show("There is no dataset loaded!");
            }
            else if (dataset.attributes.Count == 0)
            {
                MessageBox.Show("Dataset is empty!");
            }
        }

        //CHECK DATASET BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataset == null)
            {
                MessageBox.Show("There is no dataset loaded!");
            }
            else if (dataset.attributes.Count == 0)
            {
                MessageBox.Show("Dataset is empty!");
            }
        }
    }
}
