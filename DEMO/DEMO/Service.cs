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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void c_ServiceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.c_ServiceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.щемелёв_ДемоDataSet);

        }

        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "щемелёв_ДемоDataSet.C_Service". При необходимости она может быть перемещена или удалена.
            this.c_ServiceTableAdapter.Fill(this.щемелёв_ДемоDataSet.C_Service);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Serv_type serv_Type = new Serv_type();
            serv_Type.ShowDialog();
        }
    }
}
