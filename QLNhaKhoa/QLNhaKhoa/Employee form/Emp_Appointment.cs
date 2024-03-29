﻿using System.Data;
using System.Data.SqlClient;

namespace QLNhaKhoa.Employee_form
{
    public partial class Emp_Appointment : Form
    {
        public string CurrentEmp { get; set; } = string.Empty;
        public Emp_Appointment()
        {
            InitializeComponent();
        }

        private void Emp_Appointment_Load(object sender, EventArgs e)
        {
            appointmentData.DataSource = Helper.getData("select * from LICHHEN").Tables[0];

            cboCustomer.DisplayMember = "HOTEN";
            cboCustomer.ValueMember = "MAKHACHHANG";
            cboCustomer.DataSource = Helper.getData("select HOTEN, MAKHACHHANG from KHACHHANG").Tables[0];

            cboDentists.DisplayMember = "HOTEN";
            cboDentists.ValueMember = "MANHANVIEN";
            cboDentists.DataSource = Helper.getData("select HOTEN, MANHANVIEN from NHANVIEN where LOAINHANVIEN = 1").Tables[0];
        }

        private void refresh()
        {
            Helper.refreshData("select * from LICHHEN", appointmentData);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            (appointmentData.DataSource as DataTable).DefaultView.RowFilter = String.Format("MALICHHEN like '%" + searchIDBox.Text + "%'");
        }

        private void makeAppButton_Click(object sender, EventArgs e)
        {
            try
            {

                string[] parts = appointTime.Text.Split(":");
                int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
                if (time < 480 || time > 1020)
                {
                    MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
                }
                var itemD = (DataRowView)cboDentists.SelectedItem;
                var itemC = (DataRowView)cboCustomer.SelectedItem;

                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_LICHHEN_INS", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@NGAY", appointDate.Text));
                cmd.Parameters.Add(new SqlParameter("@GIO", time));
                cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", itemC["MAKHACHHANG"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@MANHASI", itemD["MANHANVIEN"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@MANVDATLICH", CurrentEmp));

                cmd.Parameters.Add("@MALICHHEN", SqlDbType.VarChar, 10).Direction = ParameterDirection.Output;
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Đặt lịch hẹn thành công!");
                }
                else
                {
                    MessageBox.Show("Đặt lịch hẹn thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đặt lịch hẹn thất bại! " + ex.Message);
            }
        }

        private void updateAppButton_Click(object sender, EventArgs e)
        {
            try
            {

                string[] parts = appointTime.Text.Split(":");
                int time = int.Parse(parts[0]) * 60 + int.Parse(parts[1]);
                if (time < 480 || time > 1020)
                {
                    MessageBox.Show("Giờ hẹn không phù hợp! Vui lòng chọn từ 8h đến 17h");
                }
                var itemD = (DataRowView)cboDentists.SelectedItem;
                var itemC = (DataRowView)cboCustomer.SelectedItem;

                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                SqlCommand cmd = new SqlCommand("USP_LICHHEN_UPD", sqlCon);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@MALICHHEN", appIDBox.Text));
                cmd.Parameters.Add(new SqlParameter("@NGAY", appointDate.Text));
                cmd.Parameters.Add(new SqlParameter("@GIO", time));
                cmd.Parameters.Add(new SqlParameter("@MAKHACHHANG", itemC["MAKHACHHANG"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@MANHASI", itemD["MANHANVIEN"].ToString()));
                cmd.Parameters.Add(new SqlParameter("@MANVDATLICH", CurrentEmp));
                cmd.Parameters.Add(new SqlParameter("@NGUOIUPDATE", CurrentEmp));
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("Cập nhật lịch hẹn thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật lịch hẹn thất bại!");
                }
                refresh();
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cập nhật lịch hẹn thất bại! " + ex.Message);
            }
        }

        private void appointmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != appointmentData.RowCount)
            {
                DataGridViewRow dgvr = appointmentData.Rows[e.RowIndex];
                SqlConnection sqlCon = new SqlConnection(Helper.strCon);
                sqlCon.Open();
                string time_str = dgvr.Cells["GIO"].Value.ToString();

                if (time_str.All(char.IsDigit))
                {
                    int time = int.Parse(time_str);
                    int hour = time / 60;
                    int minutes = time - hour * 60;
                    appointTime.Text = hour + ":" + minutes;
                    appointDate.Text = dgvr.Cells["NGAY"].Value.ToString();
                    appIDBox.Text = dgvr.Cells["MALICHHEN"].Value.ToString();

                    SqlCommand cmd = new SqlCommand("select HOTEN from NHANVIEN where MANHANVIEN='" + dgvr.Cells["MANHASI"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cboDentists.Text = reader.GetString(0);
                        }
                    }

                    SqlCommand cmd2 = new SqlCommand("select HOTEN from KHACHHANG where MAKHACHHANG='" + dgvr.Cells["MAKHACHHANG"].Value.ToString() + "'", sqlCon);
                    using (SqlDataReader reader2 = cmd2.ExecuteReader())
                    {
                        if (reader2.Read())
                        {
                            cboCustomer.Text = reader2.GetString(0);
                        }
                    }
                }
                sqlCon.Close();
            }
        }
    }
}
