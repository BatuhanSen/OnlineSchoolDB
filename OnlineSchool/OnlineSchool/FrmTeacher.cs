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
    public partial class FrmTeacher : Form
    {
        public FrmTeacher()
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
            TEACHER_ID_NO.Text = "";
            NAME_SURNAME.Text = "";
            BIRTHDAY.Text = "";
            EMAIL.Text = "";
            ZOOM_EMAIL.Text = "";
            ADDRES.Text = "";
        }

        void FillGrid()
        {
            try
            {
                da = new SqlDataAdapter("Select * From TEACHER", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "TEACHER");
                GridList.DataSource = ds.Tables["TEACHER"];
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
            cmd = new SqlCommand("SELECT COUNT(*) FROM TEACHER WHERE TEACHER_ID_NO ='" + code + "' ", con);
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
            if (TEACHER_ID_NO.Text == "")
            {
                MessageBox.Show("Check for free fields!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RecordControl(TEACHER_ID_NO.Text) == 0)
            {
                MessageBox.Show("Record not found in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM TEACHER WHERE TEACHER_ID_NO = " + TEACHER_ID_NO.Text;
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
            if ((TEACHER_ID_NO.Text == "") || (NAME_SURNAME.Text == "") || (BIRTHDAY.Text == "") || (EMAIL.Text == "") || (ZOOM_EMAIL.Text == "")
                || (ADDRES.Text == ""))
            {
                MessageBox.Show("Check for free fields!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = @"DECLARE @DATES DATE = CONVERT(DATE, '" + BIRTHDAY.Value + "', 104) EXEC PROC_TEACHER_INSERT " + TEACHER_ID_NO.Text + ",'" + NAME_SURNAME.Text + "',@DATES"
                        + ",'" + EMAIL.Text + "','" + ZOOM_EMAIL.Text + "','" + ADDRES.Text + "'";
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
            TEACHER_ID_NO.Text = GridList.CurrentRow.Cells[0].Value.ToString();
            NAME_SURNAME.Text = GridList.CurrentRow.Cells[1].Value.ToString();
            BIRTHDAY.Text = GridList.CurrentRow.Cells[2].Value.ToString();
            EMAIL.Text = GridList.CurrentRow.Cells[3].Value.ToString();
            ZOOM_EMAIL.Text = GridList.CurrentRow.Cells[4].Value.ToString();
            ADDRES.Text = GridList.CurrentRow.Cells[5].Value.ToString();
        }

        private void FrmTeacher_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(FrmMenu.ConnectionString);
            con.Close();
            FillGrid();
        }
    }
}
