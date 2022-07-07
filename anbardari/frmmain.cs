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
    public partial class frmmain : Form
    {
        public SqlConnection cn = new SqlConnection();
        public string das = null;
        public string emp = null;
        public frmmain()
        {
            InitializeComponent();
        }
        private void frmmain_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand comand = new SqlCommand("SELECT USERNAME,_PASSWORD FROM _User1 WHERE EMPLOYEID='" + emp + "'", cn);
            SqlDataReader Reader = comand.ExecuteReader();
            Reader.Read();
            txtuser.Text = Reader["USERNAME"].ToString();
            txtpass.Text = Reader["_PASSWORD"].ToString();
            Reader.Close();
            SqlCommand comand2 = new SqlCommand("SELECT NAME,FAMILY,FNAME,PERSONALID FROM Member WHERE EMPLOYEID='" + emp + "'", cn);
            SqlDataReader Reader2 = comand2.ExecuteReader();
            Reader2.Read();
            txtname.Text = Reader2["NAME"].ToString();
            txtfamily.Text = Reader2["FAMILY"].ToString();
            txtnamef.Text = Reader2["FNAME"].ToString();
            txtpesonalid.Text = Reader2["PERSONALID"].ToString();
            Reader2.Close();
            if(das=="1")
            {
                menukharid.Enabled = false;
                menuforosh.Enabled = false;
                menuanbar.Enabled = false;
                menuhesab.Enabled = false;
                menumanag.Enabled = false;
            }
            if(das=="2")
            {
                menuforosh.Enabled = false;
                menuhesab.Enabled = false;
                menuuser.Enabled = false;
                menumanag.Enabled = false;
                menuanbar.Enabled = false;
            }
            if(das=="3")
            {
                menukharid.Enabled = false;
                menuhesab.Enabled = false;
                menuuser.Enabled = false;
                menumanag.Enabled = false;
                sabtmenuanbar.Enabled = false;
                editemenuanbar.Enabled = false;
            }
            if(das=="4")
            {
                menuuser.Enabled = false;
                menumanag.Enabled = false;
                menuhesab.Enabled = false;
                createmenukharid.Enabled = false;
                editemenukharid.Enabled = false;
                menuforosh.Enabled = false;
            }
            if(das=="5")
            {
                createmenukharid.Enabled = false;
                editemenukharid.Enabled = false;
                createmenuforosh.Enabled = false;
                editemenuforosh.Enabled = false;
                menuanbar.Enabled = false;
                menuuser.Enabled = false;
                menumanag.Enabled = false;
            }
            if(das=="6")
            {
                createmenuforosh.Enabled = false;
                editemenuforosh.Enabled = false;
                createmenukharid.Enabled = false;
                editemenukharid.Enabled = false;
                menuuser.Enabled = false;
                createmenuhesab.Enabled = false;
                editemenuhesab.Enabled = false;
                sabtmenuanbar.Enabled = false;
                editemenuanbar.Enabled = false;
            }
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuuser_Click(object sender, EventArgs e)
        {
            User frm = new User();
            frm.ShowDialog();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtfamily.Clear();
            txtnamef.Clear();
            txtpesonalid.Clear();
            txtuser.Clear();
            txtpass.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("UPDATE Member SET NAME=@name,FAMILY=@family,FNAME=@fname,PERSONALID=@PID WHERE EMPLOYEID='" + emp + "' ", cn);
            cm.Parameters.Add("@name", SqlDbType.NVarChar,50);
            cm.Parameters["@name"].Value =txtname.Text;
            cm.Parameters.Add("@family", SqlDbType.NVarChar,50);
            cm.Parameters["@family"].Value =txtfamily.Text;
            cm.Parameters.Add("@fname", SqlDbType.NVarChar,50);
            cm.Parameters["@fname"].Value =txtnamef.Text;
            cm.Parameters.Add("@PID",SqlDbType.Int);
            cm.Parameters["@PID"].Value = Convert.ToInt32(txtpesonalid.Text);
            cm.ExecuteNonQuery();
            SqlCommand cm2 = new SqlCommand("UPDATE _User1 SET USERNAME=@user,_PASSWORD=@passوNAME=@name,FAMILY=@family WHERE EMPLOYEID='" + emp + "' ", cn);
            cm2.Parameters.Add("@user", SqlDbType.NVarChar, 100);
            cm2.Parameters["@user"].Value =txtuser.Text;
            cm2.Parameters.Add("@pass", SqlDbType.NVarChar, 100);
            cm2.Parameters["@pass"].Value =txtpass.Text;
            cm2.Parameters.Add("@name", SqlDbType.NVarChar, 50);
            cm2.Parameters["@name"].Value = txtname.Text;
            cm2.Parameters.Add("@family", SqlDbType.NVarChar, 50);
            cm2.Parameters["@family"].Value = txtfamily.Text;
            cm2.ExecuteNonQuery();
            MessageBox.Show("تغییرات ذخیره شد");
        }

        private void sabtmenuanbar_Click(object sender, EventArgs e)
        {
            sabtanbar frm = new sabtanbar();
            frm.EMP = emp;
            frm.ShowDialog();
        }

        private void createmenukharid_Click(object sender, EventArgs e)
        {
            createBuy frm = new createBuy();
            frm.EMP = emp;
            frm.ShowDialog();
        }

        private void showmenuanbar_Click(object sender, EventArgs e)
        {
            showanbar frm = new showanbar();
            frm.ShowDialog();
        }

        private void showmenukharid_Click(object sender, EventArgs e)
        {
            showbuy frm = new showbuy();
            frm.ShowDialog();
        }

        private void showmenuforosh_Click(object sender, EventArgs e)
        {
            showsale frm = new showsale();
            frm.ShowDialog();
        }

        private void createmenuforosh_Click(object sender, EventArgs e)
        {
            createSale frm = new createSale();
            frm.EMP = emp;
            frm.ShowDialog();
        }

        private void pfmenumanag_Click(object sender, EventArgs e)
        {
            maxforosh frm = new maxforosh();
            frm.ShowDialog();
        }

        private void tmanbar_Click(object sender, EventArgs e)
        {
            acceptanbar frm = new acceptanbar();
            frm.ShowDialog();
        }

        private void createmenumessege_Click(object sender, EventArgs e)
        {
            createmessege frm = new createmessege();
            frm.eid = emp;
            frm.ShowDialog();
        }

        private void inbox_Click(object sender, EventArgs e)
        {
            inbox frm = new inbox();
            frm.eid = emp;
            frm.ShowDialog();
        }

        private void sendbox_Click(object sender, EventArgs e)
        {
            sendbox frm = new sendbox();
            frm.eid = emp;
            frm.ShowDialog();
        }
    }
}
