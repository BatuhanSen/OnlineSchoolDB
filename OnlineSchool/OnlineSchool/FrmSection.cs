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
    public partial class FrmSection : Form
    {
        public FrmSection()
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
            SECTION_NO.Text = "";
            SECTION_NAME.Text = "";
        }

        void FillGrid()
        {
            try
            {
                da = new SqlDataAdapter("Select * From SECTION", con);
                ds = new DataSet();
                con.Open();
                da.Fill(ds, "SECTION");
                GridList.DataSource = ds.Tables["SECTION"];
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
            cmd = new SqlCommand("SELECT COUNT(*) FROM SECTION WHERE SECTION_NO ='" + code + "' ", con);
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
            if (SECTION_NO.Text == "")
            {
                MessageBox.Show("Check for free fields!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (RecordControl(SECTION_NO.Text) == 0)
            {
                MessageBox.Show("Record not found in table.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "DELETE FROM SECTION WHERE SECTION_NO = " + SECTION_NO.Text;
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
            if ((SECTION_NO.Text == "") || (SECTION_NAME.Text == "") )
            {
                MessageBox.Show("Check for free fields!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "EXEC PROC_SECTION_INSERT " + SECTION_NO.Text + ",'" + SECTION_NAME.Text + "'";
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
            SECTION_NO.Text = GridList.CurrentRow.Cells[0].Value.ToString();
            SECTION_NAME.Text = GridList.CurrentRow.Cells[1].Value.ToString();
        }

        private void FrmSection_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(FrmMenu.ConnectionString);
            con.Close();
            FillGrid();
        }

        private void SECTION_NO_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
