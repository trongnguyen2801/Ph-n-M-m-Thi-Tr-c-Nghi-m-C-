using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace PMThiTN
{
    public partial class TaoCauHoi : Form
    {
        public static string tenGV = " ";
        public static string dobGV = " ";
        public static string gtGV = " ";
        int id = 20;
        public TaoCauHoi()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void TaoCauHoi_Load(object sender, EventArgs e)
        {
            TENGV.Text = tenGV;
            NgaySinhGV.Text = dobGV;
            GioiTinhGV.Text = gtGV;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sqlStringBuilder = new SqlConnectionStringBuilder();
            sqlStringBuilder["Server"] = ".";
            sqlStringBuilder["Database"] = "UserInfor";
            sqlStringBuilder["UID"] = "sa";
            sqlStringBuilder["PWD"] = "123";

            var connection = new SqlConnection(sqlStringBuilder.ToString());

            connection.Open();

            if (connection.State == ConnectionState.Open)
            {
                var sqlCmd = new SqlCommand();
                sqlCmd.Connection = connection;
                //sqlCmd.Parameters.Add(new SqlParameter("@firstName", $"{user.firstName}"));
                sqlCmd.Parameters.Add(new SqlParameter("@cauhoi", $"{NdCauHoi.Text}"));
                sqlCmd.Parameters.Add(new SqlParameter("@dapan1", $"{D1.Text}"));
                sqlCmd.Parameters.Add(new SqlParameter("@dapan2", $"{D2.Text}"));
                sqlCmd.Parameters.Add(new SqlParameter("@dapan3", $"{D3.Text}"));
                sqlCmd.Parameters.Add(new SqlParameter("@dapan4", $"{D4.Text}"));
                sqlCmd.Parameters.Add(new SqlParameter("@dapandung", $"{DapAnDung.Text}"));
                sqlCmd.Parameters.Add(new SqlParameter("@id", $"{id++}"));
                sqlCmd.Parameters.Add(new SqlParameter("@made", $"{MaDe.Text}"));
                sqlCmd.CommandText = "Insert into CauHoi (CauHoi, DapAn1,DapAn2,DapAn3,DapAn4,DapAnDung,MaDe,Id) Values (@cauhoi, @dapan1,@dapan2,@dapan3,@dapan4,@dapandung,@made,@id)";
                sqlCmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
