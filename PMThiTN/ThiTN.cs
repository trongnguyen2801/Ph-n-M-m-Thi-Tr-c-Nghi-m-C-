using Microsoft.VisualBasic.ApplicationServices;
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
using System.Windows.Forms.VisualStyles;

namespace PMThiTN
{
    public partial class ThiTN : Form
    {
        List<CauHoi> question = new List<CauHoi>();
        Stack<CauHoi> questionStack = new Stack<CauHoi>();
        int QuesCur = 0;
        int Score = 0;
        int MaDe = 0;
        public static string name = "123";
        public static string dob = "";
        public static string gioitinh = "";

        public ThiTN()
        {
            InitializeComponent();
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ndQuestion_Enter(object sender, EventArgs e)
        {

        }

        private void loadQuestion()
        {
            if (question.Count >= 0)
            {
                Random rnd = new Random();
                int num = rnd.Next(0, question.Count);
                QuesCur = num;

                noidungCauhoi.Text = question[QuesCur].Question;
                D1.Text = question[QuesCur].DA1;
                D2.Text = question[QuesCur].DA2;
                D3.Text = question[QuesCur].DA3;
                D4.Text = question[QuesCur].DA4;
            }
            else
            {
                MessageBox.Show("Hết câu hỏi r broo nộp bài đii");
            }
        }

        private void ThiTN_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int num = rnd.Next(1,3);
            MaDe = 1;

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
                sqlCmd.CommandText = "Select * from CauHoi";
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["MaDe"].ToString() == MaDe.ToString())
                    {
                        question.Add(new CauHoi()
                        {
                            Question = reader["CauHoi"]?.ToString(),
                            DA1 = reader["DapAn1"]?.ToString(),
                            DA2 = reader["DapAn2"]?.ToString(),
                            DA3 = reader["DapAn3"]?.ToString(),
                            DA4 = reader["DapAn4"]?.ToString(),
                            DACorrect = reader["DapAnDung"]?.ToString(),
                        });
                    }
                }
            }

            connection.Close();
            loadQuestion();
            boxName.Text = name;
            ns.Text = dob;
            sex.Text = gioitinh;
            MaDeThi.Text = MaDe.ToString();
            return;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void RadioCheckScore()
        {
            var listradio = groupBox1.Controls.OfType<RadioButton>().ToList();
            var radioChecked = listradio.Find(r => r.Checked);
            if(radioChecked != null)
            {
                /*
                if (question.Count <= 0)
                {
                    if(radioChecked.Tag.ToString() == questionStack.Pop().DACorrect)
                    {
                        Score++;
                    }

                }*/
                //else
                //{
                    if (radioChecked.Tag.ToString() == question[QuesCur].DACorrect) {
                        Score++;
                    }
                //}
            }
            else
            {
                return;
            }
        }

        private void NextQuestion()
        {
            RadioCheckScore();
            questionStack.Push(question[QuesCur]);
            question.Remove(question[QuesCur]);
            //QuesCur++;
            label4.Text = Score.ToString();
            groupBox1.Controls.OfType<RadioButton>().ToList().ForEach(r =>
            {
                r.Checked = false;
            });
            if (question.Count > 0)
            {
                loadQuestion();
            }
            else
            {
                MessageBox.Show("Hết câu hỏi r brooo nghỉ đi");
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextQuestion();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;
            radio.Tag.ToString();
        }

        private void btnPre_Click(object sender, EventArgs e)
        {

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void boxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
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
                sqlCmd.Parameters.Add(new SqlParameter("@name", $"{name}"));
                sqlCmd.Parameters.Add(new SqlParameter("@score", $"{Score}"));
                sqlCmd.CommandText = "Insert into Reward (Name, Score) Values (@name, @score)";
                sqlCmd.ExecuteNonQuery();
            }

            connection.Close();
            Reward.diem = Score;
            Reward formReward = new Reward();
            this.Hide();
            formReward.ShowDialog();
            this.Close();
        }
    }
}
