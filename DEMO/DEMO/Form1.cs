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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void partnersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partnersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.щемелёв_ДемоDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "щемелёв_ДемоDataSet.Partners". При необходимости она может быть перемещена или удалена.
            this.partnersTableAdapter.Fill(this.щемелёв_ДемоDataSet.Partners);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
