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

        private BindingSource bindingSource1 = new BindingSource();

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
            PeopleGridView.DataSource = bindingSource1;
            bindingSource1.DataSource = DataCommon.LoadPeople();
            //PeopleGridView.DataSource = DataCommon.LoadPeople();

            cbAddPersonType.ValueMember = "PersonTypeId";
            cbAddPersonType.DisplayMember = "Description";
            cbAddPersonType.DataSource = DataCommon.LoadPeopleType();
        }

        private void PeopleGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //if (PeopleGridView.CurrentRow != null)
            //{
            //    DataGridViewRow dr = PeopleGridView.CurrentRow;
            //    DataCommon.PeopleAddEdit(dr);
            //    PeopleGridView.DataSource = DataCommon.LoadPeople();
            //}
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

        private void PeopleGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (PeopleGridView.CurrentRow != null)
            {
                DataGridViewRow dr = PeopleGridView.CurrentRow;
                if (dr.Cells["txtPersonId"].Value != null && dr.Cells["txtPersonId"].Value.ToString() == string.Empty)
                {
                    DataCommon.PeopleAddEdit(dr);
                    MessageBox.Show("Record Added");
                    //PeopleGridView.DataSource = DataCommon.LoadPeople();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (PeopleGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Are you sure you want to delete this row?", "PeopleGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DataGridViewRow dr = PeopleGridView.CurrentRow;
                    DataCommon.PeopleDelete(dr);
                    bindingSource1.DataSource = DataCommon.LoadPeople();
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataCommon.PeopleAdd(Convert.ToInt32(cbAddPersonType.SelectedValue),
                txtFirstNameAdd.Text.Trim(), txtLastNameAdd.Text.Trim(),
                txtPhoneAdd.Text.Trim(), txtEmailAdd.Text.Trim());

            ClearTextFields();
            MessageBox.Show("Record Added");
            PeopleGridView.DataSource = DataCommon.LoadPeople();
        }

        private void ClearTextFields()
        {
            cbAddPersonType.SelectedIndex = -1;
            txtFirstNameAdd.Text = string.Empty;
            txtLastNameAdd.Text = string.Empty;
            txtEmailAdd.Text = string.Empty;
            txtPhoneAdd.Text = string.Empty;

        }
    }
}
