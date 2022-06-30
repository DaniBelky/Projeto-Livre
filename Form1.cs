using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoLivre
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVelha_Click(object sender, EventArgs e)
        {
            var Form = new Form2();
            Form.Show();           
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculo_Click(object sender, EventArgs e)
        {
            var Form2 = new Form3();
            Form2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var Form4 = new Form4();
            Form4.Show();
        }
    }
}
