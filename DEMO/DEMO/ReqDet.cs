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
    public partial class ReqDet : Form
    {
        public ReqDet()
        {
            InitializeComponent();
        }

        private void request_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.request_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.щемелёв_ДемоDataSet);

        }

        private void ReqDet_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "щемелёв_ДемоDataSet.Request_details". При необходимости она может быть перемещена или удалена.
            this.request_detailsTableAdapter.Fill(this.щемелёв_ДемоDataSet.Request_details);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
