using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quizmaker
{
    public partial class Form1 : Form
    {

        TestClass2 class2 = new TestClass2();


        DataLoader nowy = new DataLoader();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            nowy.Fun(richTextBox2);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    } }
