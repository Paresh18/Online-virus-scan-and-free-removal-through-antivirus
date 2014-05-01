using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace anit1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int viruses = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Provide Folder Location");
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
            viruses = 0;
            label2.Text = "No. of Viruses found: " + viruses.ToString();
            progressBar1.Value = 0;
            listBox1.Items.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exit the Setup");
            this.Close();
            Close();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
            string[] search = Directory.GetFiles(@folderBrowserDialog1.SelectedPath, "*.*");
            progressBar1.Maximum = search.Length;
            foreach (string item in search)
            {
                try
                {
                    StreamReader stream = new StreamReader(item);
                    string read = stream.ReadLine();
                    string[] virus = new string[] { "trojan", "virus", "hacker" };
                    foreach (string st in virus)
                    {
                        if (Regex.IsMatch(read, st))
                        {
                            MessageBox.Show("Virus Detected!");
                            viruses += 1;
                            label2.Text = "No. of Viruses found: " + viruses.ToString();
                            listBox1.Items.Add(item);
                        }
                        progressBar1.Increment(1);

                    }
                }
                catch
                {
                    string read = item;
                    string[] virus = new string[] { "trojan", "virus", "hacker" };
                    foreach (string st in virus)
                    {
                        if (Regex.IsMatch(read, st))
                        {
                            MessageBox.Show("Virus Detected!");
                            viruses += 1;
                            label2.Text = "No. of Viruses found: " + viruses.ToString();
                            listBox1.Items.Add(item);
                        }
                        progressBar1.Increment(1);

                    }
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
             
            MessageBox.Show("Delete the files");
             string txt = listBox1.SelectedItem.ToString();
             FileInfo TheFile = new FileInfo(txt);
            if (TheFile.Exists)
            {
                File.Delete(txt);
            }

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
    }

