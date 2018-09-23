using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VinVentory
{
    public partial class NotificationForm : Form
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.V_NeedToOrder' table. You can move, or remove it, as needed.
            this.v_NeedToOrderTableAdapter.Fill(this.nicsInventory1DataSet.V_NeedToOrder);
            // TODO: This line of code loads data into the 'nicsInventory1DataSet.V_AllQuantities' table. You can move, or remove it, as needed.
            this.v_AllQuantitiesTableAdapter.Fill(this.nicsInventory1DataSet.V_AllQuantities);

        }

        private void NeedToOrderDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
