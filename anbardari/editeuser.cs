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
    public partial class editeuser : Form
    {
        public SqlConnection cn = new SqlConnection();
        public string eid = null;
        public editeuser()
        {
            InitializeComponent();
        }

        private void editeuser_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand comand3 = new SqlCommand("SELECT DISTINCT VAHED FROM _User1", cn);
            SqlDataReader Reader3 = comand3.ExecuteReader();
            while (Reader3.Read())
            {
                comboBoxvahed.Items.Add(Reader3["VAHED"]);
            }
            Reader3.Close();
            SqlCommand comand2 = new SqlCommand("SELECT DISTINCT DASRES FROM _User1", cn);
            SqlDataReader Reader2 = comand2.ExecuteReader();
            while (Reader2.Read())
            {
                comboBoxdasres.Items.Add(Reader2["DASRES"]);
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("UPDATE Member SET NAME=@name,FAMILY=@family,FNAME=@fname,PERSONALID=@PID,VAHED=@vahed,SEMAT=@semat WHERE EMPLOYEID='" + eid + "' ", cn);
            cm.Parameters.Add("@name", SqlDbType.NVarChar, 50);
            cm.Parameters["@name"].Value = txtname.Text;
            cm.Parameters.Add("@family", SqlDbType.NVarChar, 50);
            cm.Parameters["@family"].Value = txtfamily.Text;
            cm.Parameters.Add("@fname", SqlDbType.NVarChar, 50);
            cm.Parameters["@fname"].Value = txtnamef.Text;
            cm.Parameters.Add("@PID", SqlDbType.Int);
            cm.Parameters["@PID"].Value = Convert.ToInt32(txtpersonalid.Text);
            cm.Parameters.Add("@vahed", SqlDbType.NVarChar, 50);
            cm.Parameters["@vahed"].Value = comboBoxvahed.Text;
            cm.Parameters.Add("@semat", SqlDbType.NVarChar, 50);
            cm.Parameters["@semat"].Value = txtsemat.Text;
            cm.ExecuteNonQuery();
            SqlCommand cm2 = new SqlCommand("UPDATE _User1 SET USERNAME=@user,_PASSWORD=@passوNAME=@name,FAMILY=@family,DASRES=@dasres,VAHED=@vahed,SEMAT=@semat WHERE EMPLOYEID='" + eid + "' ", cn);
            cm2.Parameters.Add("@user", SqlDbType.NVarChar, 100);
            cm2.Parameters["@user"].Value = txtuser.Text;
            cm2.Parameters.Add("@pass", SqlDbType.NVarChar, 100);
            cm2.Parameters["@pass"].Value = txtpass.Text;
            cm2.Parameters.Add("@name", SqlDbType.NVarChar, 50);
            cm2.Parameters["@name"].Value = txtname.Text;
            cm2.Parameters.Add("@family", SqlDbType.NVarChar, 50);
            cm2.Parameters["@family"].Value = txtfamily.Text;
            cm.Parameters.Add("@dasres", SqlDbType.Int);
            cm.Parameters["@dasres"].Value = Convert.ToInt32(comboBoxdasres.Text);
            cm.Parameters.Add("@vahed", SqlDbType.NVarChar, 50);
            cm.Parameters["@vahed"].Value = comboBoxvahed.Text;
            cm.Parameters.Add("@semat", SqlDbType.NVarChar, 50);
            cm.Parameters["@semat"].Value = txtsemat.Text;
            cm2.ExecuteNonQuery();
            MessageBox.Show("تغییرات ذخیره شد");
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtfamily.Clear();
            txtnamef.Clear();
            txtpersonalid.Clear();
            txtemployid.Clear();
            txtsemat.Clear();
            txtuser.Clear();
            txtpass.Clear();
            comboBoxvahed.ResetText();
            comboBoxdasres.ResetText();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
