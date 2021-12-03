using BUS_SMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class GUI_QLSanPham : Form
    {
        bool tf, tf1;
        int id;
        BUS_Products busProducts = new BUS_Products();
        BUS_Category busCategory = new BUS_Category();
        BUS_Supplier busSupplier = new BUS_Supplier();

        public GUI_QLSanPham()
        {
            InitializeComponent();
            tf = tf1 = true;
            Lock_Unlock(tf);
            Lock_Unlock1(tf1);
        }

        void Lock_Unlock(bool tf)
        {
            btnNew.Enabled = tf;
            btnAdd.Enabled = txtProductName.Enabled = txtUnit.Enabled = txtPrice.Enabled = cmbSupplier.Enabled = cmbCategory.Enabled = !tf;
        }
        void Lock_Unlock1(bool tf1)
        {
            dgvProducts.Enabled = tf1;
            btnDelete.Enabled = btnUpdate.Enabled= txtProductName.Enabled = txtUnit.Enabled = txtPrice.Enabled = cmbSupplier.Enabled = cmbCategory.Enabled = !tf1;
        }

        private void GUI_QLSanPham_Load(object sender, EventArgs e)
        {
            DataTable supplierData = busSupplier.getAllSupplier();
            DataTable categoryData = busCategory.getAllCategory();
            for (int i = 0; i < categoryData.Rows.Count; i++)
            {
                cmbCategory.Items.Add(categoryData.Rows[i]["CategoryName"].ToString());
            }
            for (int i = 0; i < supplierData.Rows.Count; i++)
            {
                cmbSupplier.Items.Add(supplierData.Rows[i]["SupplierName"].ToString());
            }
            dgvProducts.DataSource = busProducts.getAllProducts();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                Lock_Unlock(tf);
                txtProductName.Text = txtUnit.Text = txtPrice.Text = "";
                txtProductName.Focus();
            }
            else MessageBox.Show("Updating or Deleting!\nClick Reset to do another thing.", "Information");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataTable supplierData = busSupplier.getAllSupplier();
            DataTable categoryData = busCategory.getAllCategory();
            if (txtProductName.Text != "" && txtUnit.Text != "" && txtPrice.Text != "" && cmbSupplier.SelectedIndex > -1 && cmbCategory.SelectedIndex > -1)
            {
                int CateID = int.Parse(categoryData.Rows[cmbCategory.SelectedIndex]["CategoryID"].ToString());
                int SupID = int.Parse(supplierData.Rows[cmbSupplier.SelectedIndex]["SupplierID"].ToString());
                if (busProducts.insertProduct(txtProductName.Text, txtUnit.Text,float.Parse(txtPrice.Text), CateID, SupID))
                {
                    MessageBox.Show("Insert successful.", "Information");
                    tf = !tf;
                    Lock_Unlock(tf);
                    dgvProducts.DataSource = busProducts.getAllProducts();
                }
                else
                {
                    MessageBox.Show("Insert fail.", "Information");
                }
            }
            else
            {
                MessageBox.Show("TextBox is Empty!\nInput data again.", "Information");
                txtProductName.Focus();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataTable supplierData = busSupplier.getAllSupplier();
            DataTable categoryData = busCategory.getAllCategory();
            if (txtProductName.Text != "" && txtUnit.Text != "" && txtPrice.Text != "" && cmbSupplier.SelectedIndex > -1 && cmbCategory.SelectedIndex > -1)
            {
                int CateID = int.Parse(categoryData.Rows[cmbCategory.SelectedIndex]["CategoryID"].ToString());
                int SupID = int.Parse(supplierData.Rows[cmbSupplier.SelectedIndex]["SupplierID"].ToString());
                if (busProducts.updateProduct(txtProductName.Text, txtUnit.Text, float.Parse(txtPrice.Text), CateID, SupID,id))
                {
                    MessageBox.Show("Update successful.", "Information");
                    tf = tf1 = true;
                    txtProductName.Text = txtUnit.Text = txtPrice.Text = "";
                    Lock_Unlock(tf);
                    Lock_Unlock1(tf1);
                    dgvProducts.DataSource = busProducts.getAllProducts();
                }
                else
                {
                    MessageBox.Show("Update fail", "Information");
                }
            }
            else
            {
                MessageBox.Show("TextBox is Empty!\nInput data again.", "Information");
                txtProductName.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(DialogResult.Yes == MessageBox.Show("Bạn có muốn xóa sản phẩm này?", "Confirm",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information))
            {
                busProducts.deleteProduct(id);
                MessageBox.Show("Delete successful.", "Information");
                dgvProducts.DataSource = busProducts.getAllProducts();
            }
            else
            {
                MessageBox.Show("Delete Error!", "Information");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tf = tf1 = true;
            txtProductName.Text = txtUnit.Text = txtPrice.Text = "";
            Lock_Unlock(tf);
            Lock_Unlock1(tf1);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {

            }else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }
        
        private void dgvProducts_Click(object sender, EventArgs e)
        {
            if (tf)
            {
                int i = dgvProducts.CurrentRow.Index;
                id = int.Parse(dgvProducts[0, i].Value.ToString());
                txtProductName.Text = dgvProducts[1, i].Value.ToString();
                cmbCategory.SelectedIndex = cmbCategory.FindStringExact(dgvProducts[7, i].Value.ToString());
                cmbSupplier.SelectedIndex = cmbSupplier.FindStringExact(dgvProducts[8, i].Value.ToString());
                txtUnit.Text = dgvProducts[4, i].Value.ToString();
                txtPrice.Text = dgvProducts[5, i].Value.ToString();
                txtProductName.Focus();
                tf1 = !tf1;
                Lock_Unlock1(tf1);
            }
            else MessageBox.Show("Inserting!\nClick Reset to do another thing.", "Information");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
