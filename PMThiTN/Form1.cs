using System.Data;
using System.Data.SqlClient;
namespace PMThiTN
{
    public partial class Form1 : Form
    {
        List<User> users = new List<User>();

        int id;
        bool isValid = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
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
                sqlCmd.CommandText = "Select * from Infor";
                SqlDataReader reader = sqlCmd.ExecuteReader();
                while (reader.Read())   
                {
                    users.Add(new User()
                    {
                        ID = reader["ID"]?.ToString(),
                        TENTK = reader["UserName"]?.ToString(),
                        MK = reader["PassWord"]?.ToString(),
                        DOB = reader["DOB"]?.ToString(),
                        NAME = reader["Name"]?.ToString(),
                        GIOITINH = reader["GioiTinh"]?.ToString(),
                    });
                }
            }

            connection.Close();
            return;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txtMatKhau.PasswordChar = '\0';
            }
            else
            {
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tenTK.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập tài khoản");
            }
            else if (txtMatKhau.TextLength == 0)
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu");
            }
            else
            {
                users.ForEach(user =>
                {
                    if(user.TENTK == tenTK.Text && user.MK == txtMatKhau.Text)
                    {
                        isValid = true;
                        id = int.Parse(user.ID);
                        if(id == 0)
                        {
                            ThiTN.name = user.NAME;
                            ThiTN.dob = user.DOB;
                            ThiTN.gioitinh = user.GIOITINH;
                        }
                        else
                        {
                            TaoCauHoi.tenGV = user.NAME;
                            TaoCauHoi.dobGV = user.DOB;
                            TaoCauHoi.gtGV = user.GIOITINH;
                        }

                        return;
                    }
                    return;
                });

                if (isValid && id == 0)
                {
                    ThiTN formThi = new ThiTN();
                    this.Hide();
                    formThi.ShowDialog();
                    this.Close();
                }
                else
                {
                    TaoCauHoi formCH = new TaoCauHoi();
                    this.Hide();
                    formCH.ShowDialog();
                    this.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}