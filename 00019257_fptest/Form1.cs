using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _00019257_fptest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_ClientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_ClientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientsDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // try catch added in case of exception
            try
            {
                this.tb_ClientTypeTableAdapter.Fill(this.clientsDataSet.tb_ClientType);
                this.tb_ClientTableAdapter.Fill(this.clientsDataSet.tb_Client);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            // making sure there's something to delete 
            if (tb_ClientBindingSource.Count == 0)
            {
                MessageBox.Show("So sorry, there's nothing left to delete.", "ERROR");
            }
            else
            {
                // double checking user wants to delete
                if (MessageBox.Show("Are you sure you want to delete?", "CONFIRMATION", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // try catch added as we're changing the dataset
                    try
                    {
                        tb_ClientBindingSource.RemoveCurrent();
                        MessageBox.Show("Deleted Successfully.", "SUCCESS");
                    }
                    catch (Exception del) 
                    {
                        MessageBox.Show(del.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Deleting Cancelled.", "CANCELLED");
                }
            }
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        // this method saves your data
        private void SaveData()
        {
            // if validated, content should be saved
            if (this.Validate())
            {
                try
                {
                    this.tb_ClientBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.clientsDataSet);
                    // tell user content has been saved
                    MessageBox.Show("Saved Successfully.", "SUCCESS");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Failed to validate.", "ERROR");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                // putting the choice of client type needed into a variable
                var clientType = (ClientsDataSet.tb_ClientTypeRow)((DataRowView)cbx_type_add.SelectedItem).Row;

                // adding the "added" row to the dataset
                clientsDataSet.tb_Client.Addtb_ClientRow(
                    tbx_name_add.Text,
                    cbx_active_add.Checked,
                    Convert.ToInt32(tbx_sales_add.Text),
                    rtbx_notes_add.Text,
                    clientType);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // if the dataset has changes, ask if content should be saved
            if (clientsDataSet.HasChanges())
            {
                if (MessageBox.Show("You have not yet saved everything. \nDo you want to save changes?", "EXITING WARNING", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SaveData();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tbx_search_TextChanged(object sender, EventArgs e)
        {
            // filter for serach bar
            tb_ClientBindingSource.Filter = $"ClientName LIKE ('%{tbx_search.Text}%')";
        }

        private void tbx_name_Validating(object sender, CancelEventArgs e)
        {
            // calls textbox validator function
            Tbx_Validator(tbx_name);
        }

        private void tbx_sales_Validating(object sender, CancelEventArgs e)
        {
            Tbx_Validator(tbx_sales);
        }

        private void rtbx_notes_Validating(object sender, CancelEventArgs e)
        {
            // calls rich textbox validator function
            Rtbx_Validator(rtbx_notes);
        }

        private void tbx_name_add_Validating(object sender, CancelEventArgs e)
        {
            Tbx_Validator(tbx_name_add);
        }

        private void tbx_sales_add_Validating(object sender, CancelEventArgs e)
        {
            Tbx_Validator(tbx_sales_add);
        }

        private void rtbx_notes_add_Validating(object sender, CancelEventArgs e)
        {
            Rtbx_Validator(rtbx_notes_add);
        }

        // this method takes a Textbox and makes sure it's not empty
        private void Tbx_Validator(TextBox being_validated)
        {
            if (string.IsNullOrEmpty(being_validated.Text))
            {
                MessageBox.Show("This cannot be empty.", "ERROR");
            }
        }

        // this method takes a RichTextBox and makes sure it's not empty
        private void Rtbx_Validator(RichTextBox being_validated)
        {
            if (string.IsNullOrEmpty(being_validated.Text))
            {
                MessageBox.Show("Notes cannot be empty, put N/A if there are no notes.", "ERROR");
            }
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            tb_ClientBindingSource.MoveFirst();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            tb_ClientBindingSource.MovePrevious();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            tb_ClientBindingSource.MoveNext();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            tb_ClientBindingSource.MoveLast();
        }
    }
}
