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
<<<<<<< HEAD
        TestClass2 class2 = new TestClass2();
       
=======
        DataLoader nowy = new DataLoader();

>>>>>>> b76216474e6d15470760d5974435c1fe1ae6f6a8
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
       
=======
            nowy.Fun(richTextBox2);
>>>>>>> b76216474e6d15470760d5974435c1fe1ae6f6a8
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.newline
    }
}
