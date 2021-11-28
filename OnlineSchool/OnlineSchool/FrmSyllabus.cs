using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OnlineSchool
{
    public partial class FrmSyllabus : Form
    {
        public FrmSyllabus()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader read;
        SqlCommand cmd;
        DataSet ds;

        void FieldClear()
        {
            REC_NO.Text = "";
            LESSON_NO.Text = "";
            TYPE_NO.Text = "";
            DAY_NAME.Text = "";
            ZOOM_LINK.Text = "";
        }

        void FillGrid()
        {
            try
            {
                da = new SqlDataAdapter("Select * From SYLLABUS", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "SYLLABUS");
                GridList.DataSource = ds.Tables["SYLLABUS"];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        public int RecordControl(string code)
        {
            con.Open();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SYLLABUS WHERE REC_NO ='" + code + "' ", con);
            int param = Convert.ToInt32(cmd.ExecuteScalar());
            cmd.Connection = con;
            con.Close();
            return param;
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FillGrid();
            FieldClear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (REC_NO.Text == "")
            {
                MessageBox.Show("Check for free fields!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RecordControl(REC_NO.Text) == 0)
            {
                MessageBox.Show("Record not found in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM SYLLABUS WHERE REC_NO = " + REC_NO.Text;
                cmd.ExecuteNonQuery();
                con.Close();
                //Grid dolduruluyor ve alanlar temizleniyor.
                FieldClear();
                FillGrid();
                MessageBox.Show("Delete Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if ((LESSON_NO.Text == "") || (TYPE_NO.Text == "") || (DAY_NAME.Text == "")
                || (ZOOM_LINK.Text == ""))
            {
                MessageBox.Show("Check for free fields!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (REC_NO.Text == "")
                REC_NO.Text = "-1";

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = @"EXEC PROC_SYLLABUS_INSERT " + REC_NO.Text + "," + LESSON_NO.Text 
                        + "," + TYPE_NO.Text + ",'" + DAY_NAME.Text + "','" + ZOOM_LINK.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                FieldClear();
                FillGrid();
                MessageBox.Show("Registration Successful", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                con.Close();
            }

        }

        private void GridList_DoubleClick(object sender, EventArgs e)
        {
            REC_NO.Text = GridList.CurrentRow.Cells[0].Value.ToString();
            LESSON_NO.Text = GridList.CurrentRow.Cells[1].Value.ToString();
            TYPE_NO.Text = GridList.CurrentRow.Cells[2].Value.ToString();
            DAY_NAME.Text = GridList.CurrentRow.Cells[3].Value.ToString();
            ZOOM_LINK.Text = GridList.CurrentRow.Cells[4].Value.ToString();
        }

        private void FrmSyllabus_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(FrmMenu.ConnectionString);
            con.Close();
            FillGrid();
        }

        private void REC_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
