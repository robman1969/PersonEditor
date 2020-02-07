using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonEditor.DataAccess;

namespace PersonEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPersonType.ValueMember = "PersonTypeId";
            cbPersonType.DisplayMember = "Description";
            cbPersonType.DataSource = DataCommon.LoadPeopleType();

            PeopleGridView.AutoGenerateColumns = false;
            PeopleGridView.DataSource = DataCommon.LoadPeople();
        }

        private void PeopleGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (PeopleGridView.CurrentRow != null)
            {
                DataGridViewRow dr = PeopleGridView.CurrentRow;
                DataCommon.PeopleAddEdit(dr);
                PeopleGridView.DataSource = DataCommon.LoadPeople();
            }
        }

        private void PeopleGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (PeopleGridView.CurrentRow.Cells["txtPersonId"].Value != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "PeopleGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow dr = PeopleGridView.CurrentRow;
                    DataCommon.PeopleDelete(dr);
                }
                else
                    e.Cancel = true;
            }
            else
                e.Cancel = true;
        }
    }
}
