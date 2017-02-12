using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeLabels
{
    public partial class frmEmployeeLabel : Form
    {
        public frmEmployeeLabel()
        {
            InitializeComponent();
        }

        private void frmEmployeeLabel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'employeesDataSet.tblEmploy' table. You can move, or remove it, as needed.
            this.tblEmployTableAdapter.Fill(this.employeesDataSet.tblEmploy);

        }
    }
}
