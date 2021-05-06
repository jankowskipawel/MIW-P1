using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIW_P1
{
    public partial class Form1 : Form
    {
        private Dataset dataset = new Dataset();
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

        List<List<double>> TransposeList(List<List<double>> a)
        {
            List<List<double>> result = new List<List<double>>();
            int columns = a.Count;
            int rows = a[0].Count;
            for (int i = 0; i < rows; i++)
            {
                List<double> tmp = new List<double>();
                for (int j = 0; j < columns; j++)
                {
                    tmp.Add(a[j][i]);
                }

                result.Add(tmp);
            }

            return result;
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
                string[] lines;
                if (textBox1.Text.Substring(textBox1.Text.Length - 5) == ".json")
                {
                    string jsonString = File.ReadAllText(textBox1.Text);
                    List<List<double>> deserializedData = JsonSerializer.Deserialize<List<List<double>>>(jsonString);
                    List<List<double>> tmp = TransposeList(deserializedData);
                    lines = new string[tmp.Count];
                    for (int i = 0; i < tmp.Count; i++)
                    {
                        lines[i] = String.Join(textBox3.Text, tmp[i]);
                    }
                }
                else
                {
                    //read all lines from file
                    lines = File.ReadAllLines(textBox1.Text);
                }
                for (int n = 0; n < lines.Length; n++)
                {
                    string[] columns = lines[n].Split(textBox3.Text);
                    //check type and load
                    for (int i = 0; i < columns.Length; i++)
                    {
                        float f;
                        if(float.TryParse(columns[i], out f))
                        {
                            
                            if (n == 0)
                            {
                                textBox4.Text += $"Column nr {i} is numeric.{Environment.NewLine}";
                                dataset.attributes.Add(new List<object>(lines.Length) { f });
                                dataset.attributeTypes.Add("numeric");
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
                button3.Enabled = true;
                button7.Enabled = true;
                button6.Enabled = true;
                button4.Enabled = true;
            }
        }

        //GENERATE CONFIG FILE BUTTON
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataset.attributes.Count == 0)
            {
                MessageBox.Show("Dataset is empty!");
            }
            DateTime date = DateTime.Now;
            StreamWriter sw = new StreamWriter($"{System.IO.Path.GetDirectoryName(textBox1.Text)}\\config-{date.ToString("yyyy_MM_d_H-mm-ss")}.txt");
            sw.WriteLine("Column(numeric) x: type, min max");
            sw.WriteLine("Column(string/symbol) x: type, unique values");
            for (int i = 0; i < dataset.attributes.Count; i++)
            {
                if (dataset.attributeTypes[i] == "numeric")
                {
                    List<float> tmp = new List<float>();
                    foreach (var x in dataset.attributes[i])
                    {
                        if (Convert.ToString(x) == "?")
                        {
                            tmp.Add(tmp[0]);
                        }
                        else
                        {
                            tmp.Add(Convert.ToSingle(x));
                        }
                    }
                    var min = tmp.Min();
                    var max = tmp.Max();
                    sw.WriteLine($"Column {i}: {dataset.attributeTypes[i]}, {min}~{max}");
                }
                else
                {
                    List<object> tmp = dataset.attributes[i].Distinct().ToList();
                    tmp.RemoveAll(item => (string) item == "?");
                    sw.WriteLine($"Column {i}: {dataset.attributeTypes[i]}, {String.Join(" ", tmp)}");
                }
            }
            sw.Close();
            textBox4.Text += $"{Environment.NewLine}Config file generated at {System.IO.Path.GetDirectoryName(textBox1.Text)}\\config-{date.ToString("yyyy_MM_d_H-mm-ss")}.txt{Environment.NewLine}";
            textBox4.SelectionStart = textBox4.Text.Length;
            textBox4.ScrollToCaret();
        }

        //CHECK DATASET BUTTON
        private void button4_Click(object sender, EventArgs e)
        {
            if (dataset.attributes.Count == 0)
            {
                MessageBox.Show("Dataset is empty!");
            }
            else if (textBox2.Text.Length==0)
            {
                MessageBox.Show("Specify config file path");
            }
            else
            {
                textBox4.Text += $"{Environment.NewLine}Checking dataset using config file...{Environment.NewLine}";
                string[] lines = File.ReadAllLines(textBox2.Text);
                for (int n = 2; n < lines.Length; n++)
                {
                    int columnNumber = n - 2;
                    if (dataset.attributeTypes[columnNumber] == "numeric")
                    {
                        string[] data = lines[n].Split(":").Last().Trim().Split(",");
                        string type = data[0].Trim();
                        float min = float.Parse(data[1].Trim().Split("~")[0]);
                        float max = float.Parse(data[1].Trim().Split("~")[1]);
                        for (int i = 0; i < dataset.attributes[columnNumber].Count; i++)
                        {
                            if (Convert.ToString(dataset.attributes[columnNumber][i]) == "?")
                            {
                                textBox4.Text += $"Missing data at row {i}, column {columnNumber}{Environment.NewLine}";
                            }
                            else
                            {
                                if (Convert.ToSingle(dataset.attributes[columnNumber][i]) > max ||
                                    Convert.ToSingle(dataset.attributes[columnNumber][i]) < min)
                                {
                                    textBox4.Text += $"Data exceeds range at row {i}, column {columnNumber}{Environment.NewLine}";
                                }
                            }
                        }
                    }
                    else
                    {
                        string[] uniqueStrings = lines[n].Split(":").Last().Trim().Split(",")[1].Split(" ");
                        for (int i = 0; i < dataset.attributes[columnNumber].Count; i++)
                        {
                            if (Convert.ToString(dataset.attributes[columnNumber][i]) == "?")
                            {
                                textBox4.Text += $"Missing data at row {i}, column {columnNumber}{Environment.NewLine}";
                            }
                            else
                            {
                                bool isCorrect = false;
                                foreach (var x in uniqueStrings)
                                {
                                    if (x == (string)dataset.attributes[columnNumber][i])
                                    {
                                        isCorrect = true;
                                    }
                                }
                                if (!isCorrect)
                                {
                                    textBox4.Text+= $"Wrong data at row {i}, column {columnNumber}{Environment.NewLine}";
                                }
                            }
                        }
                    }
                }
                textBox4.Text += $"{Environment.NewLine}End of dataset check{Environment.NewLine}";
                textBox4.SelectionStart = textBox4.Text.Length;
                textBox4.ScrollToCaret();
            }
        }

        //NORMALIZE DATA BUTTON
        private void button6_Click(object sender, EventArgs e)
        {
            if (dataset.attributes.Count == 0)
            {
                MessageBox.Show("Dataset is empty!");
            }
            else
            {
                float minRange = Convert.ToSingle(textBox11.Text);
                float maxRange = Convert.ToSingle(textBox10.Text);
                List<List<object>> normalizedAttributes = new List<List<object>>(dataset.attributes.Count);
                for (int i = 0; i < dataset.attributes.Count; i++)
                {
                    if (dataset.attributeTypes[i] == "numeric")
                    {
                        List<float> tmpList = new List<float>();
                        foreach (var f in dataset.attributes[i])
                        {
                            if (Convert.ToString(f) == "?")
                            {
                                tmpList.Add(tmpList[0]);
                            }
                            else
                            {
                                tmpList.Add(Convert.ToSingle(f));
                            }
                        }
                        double maximum = (double)tmpList.Max();
                        double minimum = (double)tmpList.Min();
                        List<object> normalizedColumn = new List<object>(dataset.attributes[i].Count);
                        for (int j = 0; j < dataset.attributes[i].Count; j++)
                        {
                            double normalizedValue = (maxRange-minRange)*(((double)tmpList[j] -minimum)/(maximum-minimum))+minRange;
                            normalizedColumn.Add(normalizedValue);
                        }
                        normalizedAttributes.Add(normalizedColumn);
                    }
                    else
                    {
                        List<string> uniqueStrings = CreateUniqueList(dataset.attributes[i]);
                        int length = uniqueStrings.Count;
                        List<object> normalizedColumn = new List<object>();
                        foreach (var x in dataset.attributes[i])
                        {
                            double tmp;
                            if (Convert.ToString(x) == "?")
                            {
                                tmp = 0;
                            }
                            else
                            {
                                tmp = uniqueStrings.IndexOf(Convert.ToString(x)) / ((double) length-1);
                            }
                            normalizedColumn.Add(tmp);
                        }
                        normalizedAttributes.Add(normalizedColumn);
                    }
                }

                dataset.normalizedAttributes = normalizedAttributes;
                button6.Enabled = false;
                button6.Text = "Dataset normalized";
                textBox4.Text += $"Dataset normalized.{Environment.NewLine}";
                textBox4.SelectionStart = textBox4.Text.Length;
                textBox4.ScrollToCaret();
            }
        }

        public List<string> CreateUniqueList(List<object> list)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (Convert.ToString(list[i]) != "?" && !result.Contains(list[i]))
                {
                    result.Add(Convert.ToString(list[i]));
                }
            }
            return result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (dataset.normalizedAttributes.Count == 0)
            {
                MessageBox.Show("Normalize data before saving!");
            }
            else
            {
                SaveFileForm saveFileForm = new SaveFileForm();
                saveFileForm.dataSet = dataset;
                saveFileForm.UpdatePreview();
                saveFileForm.Show();
            }
        }

        // ############################################ PART II ############################################
        private void button10_Click(object sender, EventArgs e)
        {
            openFileDialog3.ShowDialog();
            textBox8.Text = openFileDialog3.FileName;
        }

        private DataStructure ds = new DataStructure();

        //SAVE DATA
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == 0)
            {
                MessageBox.Show("Specify file path first");
            }
            else
            {
                StreamWriter sw = new StreamWriter(textBox8.Text);
                ds.structure = textBox5.Text;
                List<List<float>> randomData = new List<List<float>>();
                List<int> dataCountList = new List<int>();
                sw.WriteLine(ds.structure);
                string[] structureList = textBox5.Text.Split(" ");
                for (int i = 0; i < structureList.Length-1; i++)
                {
                    dataCountList.Add(Int32.Parse(structureList[i])* Int32.Parse(structureList[i+1])+ Int32.Parse(structureList[i+1]));
                }

                float min = Convert.ToSingle(textBox6.Text);
                float max = Convert.ToSingle(textBox7.Text);
                Random rnd = new Random(DateTime.Now.Millisecond);

                foreach (var x in dataCountList)
                {
                    List<float> tmpList = new List<float>();
                    foreach (var i in Enumerable.Range(0, x))
                    {
                        tmpList.Add((float)rnd.NextDouble() * max + min);
                    }
                    randomData.Add(tmpList);
                    sw.WriteLine(string.Join(" ", tmpList));
                }
                ds.data = randomData;
                sw.Close();
                textBox9.Text += $"File saved to {Path.GetFullPath(textBox8.Text)}{Environment.NewLine}";
                textBox9.SelectionStart = textBox9.Text.Length;
                textBox9.ScrollToCaret();
            }
        }

        //LOAD DATA
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox8.Text.Length == 0)
            {
                MessageBox.Show("Specify file path first");
            }
            else
            {
                string[] lines = File.ReadAllLines(textBox8.Text);
                ds.structure = lines[0];
                textBox9.Text += $"Data structure: {ds.structure}{Environment.NewLine}";
                List<List<float>> loadedData = new List<List<float>>();
                for (int i = 1; i < lines.Length; i++)
                {
                    List<float> tmp = new List<float>();
                    string[] dataArrayString = lines[i].Split(" ");
                    foreach (var str in dataArrayString)
                    {
                        tmp.Add(Convert.ToSingle(str));
                    }
                    textBox9.Text += $"Data between {i-1} and {i} loaded. Count = {tmp.Count}{Environment.NewLine}";
                    loadedData.Add(tmp);
                }
                ds.data = loadedData;
                textBox9.Text += $"Data loaded from {Path.GetFullPath(textBox8.Text)}{Environment.NewLine}";
                textBox9.SelectionStart = textBox9.Text.Length;
                textBox9.ScrollToCaret();
            }
        }
    }
}
