﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"D:\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug\file.pdf");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 form = new Form1();
            form.ShowDialog();
            Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
