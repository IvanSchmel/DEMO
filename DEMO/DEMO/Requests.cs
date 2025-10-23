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
    public partial class Requests : Form
    {
        public Requests()
        {
            InitializeComponent();
        }

        private void requestBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requestBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.щемелёв_ДемоDataSet);

        }

        private void Requests_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "щемелёв_ДемоDataSet.Request". При необходимости она может быть перемещена или удалена.
            this.requestTableAdapter.Fill(this.щемелёв_ДемоDataSet.Request);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReqDet reqDet = new ReqDet();
            reqDet.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
