using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_SMS;

namespace SMS
{
    public partial class GUI_NV : Form
    {
        BUS_NV busNV = new BUS_NV();
        bool tf, tf1;
        int MaNV;
        public GUI_NV()
        {
            InitializeComponent();
            tf = tf1 = true;
            Lock_Unlock(tf);
            Lock_Unlock1(tf1);
        }
        void Lock_Unlock(bool tf)
        {
            btnNew.Enabled = tf;
            btnAdd.Enabled = txtTenNV.Enabled = txtGioiTinh.Enabled = txtSDT.Enabled = txtEmail.Enabled = txtDiaChi.Enabled = !tf;
        }
        void Lock_Unlock1(bool tf1)
        {
            dgvNV.Enabled = tf1;
            btnDelete.Enabled = btnUpdate.Enabled = txtTenNV.Enabled = txtGioiTinh.Enabled = txtSDT.Enabled = txtEmail.Enabled = txtDiaChi.Enabled = !tf1;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                Lock_Unlock(tf);
                txtTenNV.Text = txtGioiTinh.Text = txtSDT.Text = txtEmail.Text = txtDiaChi.Text = "";
                txtTenNV.Focus();
            }
            else MessageBox.Show("Updating or Deleting!\nClick Reset to do another thing.", "Information");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" && txtGioiTinh.Text != "" && txtSDT.Text != "" && txtEmail.Text != "" && txtDiaChi.Text != "")
            {
                if (busNV.insertNV(txtTenNV.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text))
                {
                    MessageBox.Show("Insert successful.", "Information");
                    tf = !tf;
                    Lock_Unlock(tf);
                    dgvNV.DataSource = busNV.getNV();
                }
                else
                {
                    MessageBox.Show("Insert fail.", "Information");
                }
            }
            else
            {
                MessageBox.Show("TextBox is Empty!\nInput data again.", "Information");
                txtTenNV.Focus();
            }

        }
        
        
        private void dgvNV_Click(object sender, EventArgs e)
        {
            if (tf)
            {
                int i = dgvNV.CurrentRow.Index;
                MaNV = int.Parse(dgvNV[0, i].Value.ToString());
                txtTenNV.Text = dgvNV[1, i].Value.ToString();
                txtGioiTinh.Text = dgvNV[2, i].Value.ToString();
                txtSDT.Text = dgvNV[3, i].Value.ToString();
                txtEmail.Text = dgvNV[4, i].Value.ToString();
                txtDiaChi.Text = dgvNV[5, i].Value.ToString();
                txtTenNV.Focus();
                tf1 = !tf1;
                Lock_Unlock1(tf1);
            }
            else MessageBox.Show("Inserting!\nClick Reset to do another thing.", "Information");

        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" && txtGioiTinh.Text != "" && txtSDT.Text != "" && txtEmail.Text != "" && txtDiaChi.Text != "")
            {
                if (busNV.updateNV(MaNV, txtTenNV.Text, txtGioiTinh.Text, txtSDT.Text, txtEmail.Text, txtDiaChi.Text))
                { 
                    MessageBox.Show("Update successful.", "Information");
                    tf = !tf1;
                    Lock_Unlock1(tf1);
                    dgvNV.DataSource = busNV.getNV();
                }
                else
                {
                    MessageBox.Show("Update fail", "Information");
                }
            }
            else
            {
                MessageBox.Show("TextBox is Empty!\nInput data again.", "Information");
                txtTenNV.Focus();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTenNV.Text != "" && txtGioiTinh.Text != "" && txtSDT.Text != "" && txtEmail.Text != "" && txtDiaChi.Text != "")
            {
                if (busNV.deleteNV(MaNV))
                {
                    MessageBox.Show("Delete successful.", "Information");
                    tf = !tf1;
                    Lock_Unlock1(tf1);
                    dgvNV.DataSource = busNV.getNV();
                }
                else
                {
                    MessageBox.Show("Delete fail", "Information");
                }
            }
            else
            {
                MessageBox.Show("TextBox is Empty!\nInput data again.", "Information");
                txtTenNV.Focus();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GUI_NV_Load(object sender, EventArgs e)
        {
            dgvNV.DataSource = busNV.getNV();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tf = tf1 = true;
            Lock_Unlock(tf); Lock_Unlock1(tf1);
        }
        /*
        private void button1_Click(object sender, EventArgs e)
        {
           // GUI_Find x = new GUI_Find();
          //  x.Show();
        }

        
        */
    }
}
