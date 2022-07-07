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
    public partial class User : Form
    {
        //public delegate void CrossThreadHandler();
        public SqlConnection cn = new SqlConnection();
        public User()
        {
            InitializeComponent();
        }

        private async void User_Load(object sender, EventArgs e)
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
            Reader2.Close();
            SqlCommand CM = new SqlCommand("SELECT USERNAME AS N'نام کاربری',_PASSWORD AS N'رمز ورود',EMPLOYEID AS N'شماره پرسنلی',NAME AS N'نام',FAMILY AS N'نام خانوادگی',VAHED AS N'واحد',SEMAT AS N'سمت',DASRES AS N'سطح دسترسی' FROM _User1", cn);
            SqlDataReader dr = await CM.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridshow.DataSource = Table;
            //CM.BeginExecuteReader(new AsyncCallback(GetInfo), CM);
        }

        //void GetInfo(IAsyncResult item)
        //{
        //    SqlCommand Command = (SqlCommand)item.AsyncState;
        //    SqlDataReader Reader = Command.EndExecuteReader(item);
        //    try
        //    {
        //        Table = new DataTable();
        //        Table.Load(Reader);
        //        if (dataGridshow.InvokeRequired)
        //            dataGridshow.BeginInvoke(new CrossThreadHandler(FeedGrid));
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
        //void FeedGrid()
        //{
        //    dataGridshow.DataSource=Table;
        //}
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

        private void btnsave_Click(object sender, EventArgs e)
        {
            SqlCommand cm = new SqlCommand("INSERT Member (EMPLOYEID,NAME,FAMILY,FNAME,PERSONALID,VAHED,SEMAT) VALUES(@eid,@name,@fam,@fname,@pid,@vahed,@semat)", cn);
            cm.Parameters.Add("@eid", SqlDbType.Int);
            cm.Parameters["@eid"].Value = Convert.ToInt32(txtemployid.Text);
            cm.Parameters.Add("@name", SqlDbType.NVarChar, 50);
            cm.Parameters["@name"].Value = txtname.Text;
            cm.Parameters.Add("@fam", SqlDbType.NVarChar, 50);
            cm.Parameters["@fam"].Value = txtfamily.Text;
            cm.Parameters.Add("@fname", SqlDbType.NVarChar, 50);
            cm.Parameters["@fname"].Value = txtnamef.Text;
            cm.Parameters.Add("@pid", SqlDbType.Int);
            cm.Parameters["@pid"].Value = Convert.ToInt32(txtpersonalid.Text);
            cm.Parameters.Add("@vahed", SqlDbType.NVarChar ,50 );
            cm.Parameters["@vahed"].Value = comboBoxvahed.Text;
            cm.Parameters.Add("@semat", SqlDbType.NVarChar, 50);
            cm.Parameters["@semat"].Value = txtsemat.Text;
            SqlCommand cm2 = new SqlCommand("INSERT _User1 (USERNAME,_PASSWORD,EMPLOYEID,NAME,FAMILY,DASRES,VAHED,SEMAT) VALUES(@user,@pass,@eid,@name,@fam,@dasres,@vahed,@semat)", cn);
            cm2.Parameters.Add("@user", SqlDbType.NVarChar, 100);
            cm2.Parameters["@user"].Value = txtuser.Text;
            cm2.Parameters.Add("@pass", SqlDbType.NVarChar, 100);
            cm2.Parameters["@pass"].Value = txtpass.Text;
            cm2.Parameters.Add("@eid", SqlDbType.Int);
            cm2.Parameters["@eid"].Value = Convert.ToInt32(txtemployid.Text);
            cm2.Parameters.Add("@name", SqlDbType.NVarChar, 50);
            cm2.Parameters["@name"].Value = txtname.Text;
            cm2.Parameters.Add("@fam", SqlDbType.NVarChar, 50);
            cm2.Parameters["@fam"].Value = txtfamily.Text;
            cm2.Parameters.Add("@vahed", SqlDbType.NVarChar, 50);
            cm2.Parameters["@vahed"].Value = comboBoxvahed.Text;
            cm2.Parameters.Add("@semat", SqlDbType.NVarChar, 50);
            cm2.Parameters["@semat"].Value = txtsemat.Text;
            try
            { 
                if(Convert.ToInt32(comboBoxdasres.Text)<7)
                {
                    cm2.Parameters.Add("@dasres", SqlDbType.Int);
                    cm2.Parameters["@dasres"].Value = Convert.ToInt32(comboBoxdasres.Text);
                    cm.ExecuteNonQuery();
                    cm2.ExecuteNonQuery();
                    MessageBox.Show("کابر جدید با موفقیت ایجاد شد");
                    Close();
                }
                else
                {
                    MessageBox.Show("مقدار مجاز نیست", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand CM = new SqlCommand("SELECT USERNAME AS N'نام کاربری',_PASSWORD AS N'رمز ورود',EMPLOYEID AS N'شماره پرسنلی',NAME AS N'نام',FAMILY AS N'نام خانوادگی',VAHED AS N'واحد',SEMAT AS N'سمت',DASRES AS N'سطح دسترسی' FROM _User1 WHERE NAME LIKE N'"+textBox1.Text+"'", cn);
            SqlDataReader dr = await CM.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridshow.DataSource = Table;
        }

        private async void textBox1_TextChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand CM = new SqlCommand("SELECT USERNAME AS N'نام کاربری',_PASSWORD AS N'رمز ورود',EMPLOYEID AS N'شماره پرسنلی',NAME AS N'نام',FAMILY AS N'نام خانوادگی',VAHED AS N'واحد',SEMAT AS N'سمت',DASRES AS N'سطح دسترسی' FROM _User1  ", cn);
            SqlDataReader dr = await CM.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridshow.DataSource = Table;
        }

        private void btnsave2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridshow.SelectedCells.Count > 0)
                {
                    string EID = dataGridshow.SelectedCells[0].Value.ToString();
                    editeuser frm = new editeuser();
                    frm.eid = EID;
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("چیزی انتخاب نشده", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
