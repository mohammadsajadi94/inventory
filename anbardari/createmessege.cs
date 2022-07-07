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

namespace inventory
{
    public partial class createmessege : Form
    {
        public SqlConnection cn = new SqlConnection();
        public string eid = null;
        public createmessege()
        {
            InitializeComponent();
        }

        private void createmessege_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT EMPLOYEID FROM _User1 ", cn);
            SqlDataReader Reader = cm.ExecuteReader();
            while (Reader.Read())
            {
                comboBoxeid.Items.Add(Reader["EMPLOYEID"]);
            }
        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT NAME,FAMILY,SEMAT,VAHED FROM Member WHERE EMPLOYEID='" + eid + "'", cn);
            SqlDataReader Reader = cm.ExecuteReader();
            Reader.Read();
            string name = Reader["NAME"].ToString();
            string family = Reader["FAMILY"].ToString();
            string semat = Reader["SEMAT"].ToString();
            string vahed = Reader["VAHED"].ToString();
            Reader.Close();
            SqlCommand Command = new SqlCommand("INSERT MAIL(MAILID,EMPLOYEIDSEND,NAME,FAMILY,VAHED,SEMAT,_SUBJECT,MESSEGE,EMPLOYEIDDAR) VALUES(@mid,@eids,@name,@fam,@vahed,@semat,@sub,@mes,@eidd)", cn);
            Command.Parameters.Add("@mid", SqlDbType.Int);
            Command.Parameters["@mid"].Value = Convert.ToInt32(txtmid.Text);
            Command.Parameters.Add("@eids", SqlDbType.Int);
            Command.Parameters["@eids"].Value = Convert.ToInt32(eid);
            Command.Parameters.Add("@name", SqlDbType.NVarChar, 50);
            Command.Parameters["@name"].Value =name ;
            Command.Parameters.Add("@fam", SqlDbType.NVarChar, 50);
            Command.Parameters["@fam"].Value = family;
            Command.Parameters.Add("@vahed", SqlDbType.NVarChar, 50);
            Command.Parameters["@vahed"].Value = vahed;
            Command.Parameters.Add("@semat", SqlDbType.NVarChar, 50);
            Command.Parameters["@semat"].Value = semat;
            Command.Parameters.Add("@sub", SqlDbType.NVarChar, 200);
            Command.Parameters["@sub"].Value = semat;
            Command.Parameters.Add("@mes", SqlDbType.NVarChar, 400);
            Command.Parameters["@mes"].Value = semat;
            Command.Parameters.Add("@eidd", SqlDbType.Int);
            Command.Parameters["@eidd"].Value = Convert.ToInt32(comboBoxeid.Text);
            Command.ExecuteNonQuery();
            MessageBox.Show("پیام با موفقیت ارسال شد");
        }
    }
}
