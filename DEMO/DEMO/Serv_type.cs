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
    public partial class Serv_type : Form
    {
        public Serv_type()
        {
            InitializeComponent();
        }

        private void service_TypeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.service_TypeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.щемелёв_ДемоDataSet);

        }

        private void Serv_type_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "щемелёв_ДемоDataSet.Service_Type". При необходимости она может быть перемещена или удалена.
            this.service_TypeTableAdapter.Fill(this.щемелёв_ДемоDataSet.Service_Type);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
