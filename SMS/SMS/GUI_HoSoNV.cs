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
    public partial class GUI_HoSoNV : Form
    {
        BUS_HoSoNV busHoSoNV = new BUS_HoSoNV();
        //BUS_NV BUS_NV = new BUS_NV();
        bool tf, tf1;
        //DataTable dtbNV;
        int MaHoSo;
        int MaNV;
        
        public GUI_HoSoNV()
        {
            InitializeComponent();
            tf = tf1 = true;
            Lock_Unlock(tf);
            Lock_Unlock1(tf1);
        }
        void Lock_Unlock(bool tf)
        {
            btnNew.Enabled = tf;
            btnAdd.Enabled = txtMaNV.Enabled = txtChucVu.Enabled = txtLuong.Enabled = txtCa.Enabled = txtChamCong.Enabled = !tf;
        }
        void Lock_Unlock1(bool tf1)
        {
            dgvHoSoNV.Enabled = tf1;
            btnDelete.Enabled = btnUpdate.Enabled = txtMaNV.Enabled = txtChucVu.Enabled = txtLuong.Enabled = txtCa.Enabled = txtChamCong.Enabled  = !tf1;
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            if (tf1)
            {
                tf = !tf;
                Lock_Unlock(tf);
                txtMaNV.Text = txtChucVu.Text = txtLuong.Text = txtCa.Text = txtChamCong.Text = "";
                txtMaNV.Focus();
            }
            else MessageBox.Show("Updating or Deleting!\nClick Reset to do another thing.", "Information");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtChucVu.Text != "" && txtLuong.Text != "" && txtCa.Text != "" && txtChamCong.Text != "")
            {
                if (busHoSoNV.insertHoSoNV(MaNV, txtChucVu.Text, txtLuong.Text, txtCa.Text, txtChamCong.Text))
                {
                    MessageBox.Show("Insert successful.", "Information");
                    tf = !tf;
                    Lock_Unlock(tf);
                    dgvHoSoNV.DataSource = busHoSoNV.getHoSoNV();
                }
                else
                {
                    MessageBox.Show("Insert fail.", "Information");
                }
            }
            else
            {
                MessageBox.Show("TextBox is Empty!\nInput data again.", "Information");
                txtMaNV.Focus();
            }

        }

        
        private void dgvHoSoNV_Click(object sender, EventArgs e)
        {
            if (tf)
            {
                int i = dgvHoSoNV.CurrentRow.Index;
                MaNV = int.Parse(dgvHoSoNV[0, i].Value.ToString());
                txtMaNV.Text = dgvHoSoNV[1, i].Value.ToString();
                txtChucVu.Text = dgvHoSoNV[2, i].Value.ToString();
                txtLuong.Text = dgvHoSoNV[3, i].Value.ToString();
                txtCa.Text = dgvHoSoNV[4, i].Value.ToString();
                txtChamCong.Text = dgvHoSoNV[5, i].Value.ToString();
                txtMaNV.Focus();
                tf1 = !tf1;
                Lock_Unlock1(tf1);
            }
            else MessageBox.Show("Inserting!\nClick Reset to do another thing.", "Information");

        }
        

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtChucVu.Text != "" && txtLuong.Text != "" && txtCa.Text != "" && txtChamCong.Text != "")
            {
                if (busHoSoNV.updateHoSoNV(MaHoSo, MaNV, txtChucVu.Text, txtLuong.Text, txtCa.Text, txtChamCong.Text))
                {
                    MessageBox.Show("Update successful.", "Information");
                    tf = !tf1;
                    Lock_Unlock1(tf1);
                    dgvHoSoNV.DataSource = busHoSoNV.getHoSoNV();
                }
                else
                {
                    MessageBox.Show("Update fail", "Information");
                }
            }
            else
            {
                MessageBox.Show("TextBox is Empty!\nInput data again.", "Information");
                txtMaNV.Focus();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text != "" && txtChucVu.Text != "" && txtLuong.Text != "" && txtCa.Text != "" && txtChamCong.Text != "")
            {
                if (busHoSoNV.deleteHoSoNV(MaHoSo))
                {
                    MessageBox.Show("Delete successful.", "Information");
                    tf = !tf1;
                    Lock_Unlock1(tf1);
                    dgvHoSoNV.DataSource = busHoSoNV.getHoSoNV();
                }
                else
                {
                    MessageBox.Show("Delete fail", "Information");
                }
            }
            else
            {
                MessageBox.Show("TextBox is Empty!\nInput data again.", "Information");
                txtMaNV.Focus();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GUI_HoSoNV_Load(object sender, EventArgs e)
        {
            dgvHoSoNV.DataSource = busHoSoNV.getHoSoNV();
        }

        private void btnTimNV_Click(object sender, EventArgs e)
        {

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
