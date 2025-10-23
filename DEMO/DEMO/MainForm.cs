using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 partnerForm = new Form1();
            partnerForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service serviceForm = new Service();
            serviceForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Requests requestForm = new Requests();
            requestForm.ShowDialog();
        }
    }
}
