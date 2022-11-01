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

namespace PMThiTN
{
    public partial class Reward : Form
    {

        List<VInhDanh> rewards = new List<VInhDanh>();

        public static int diem;
        public Reward()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Reward_Load(object sender, EventArgs e)
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
                sqlCmd.CommandText = "Select * from Reward Order By Score DESC";
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    rewards.Add(new VInhDanh()
                    {
                        NAME = reader["Name"]?.ToString(),
                        SCORE = reader["Score"]?.ToString(),
                    });
                }
            }

            connection.Close();
            diemcuaban.Text = diem.ToString();
            nameTop1.Text = rewards[0].NAME.ToString();
            nameTop2.Text = rewards[1].NAME.ToString();
            nameTop3.Text = rewards[2].NAME.ToString();
            nameTop4.Text = rewards[3].NAME.ToString();

            diemTop1.Text = rewards[0].SCORE.ToString();
            diemTop2.Text = rewards[1].SCORE.ToString();
            diemTop3.Text = rewards[2].SCORE.ToString();
            diemTop4.Text = rewards[3].SCORE.ToString();
        }
    }
}
