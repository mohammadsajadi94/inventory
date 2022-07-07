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
    public partial class createSale : Form
    {
        public string EMP = null;
        public SqlConnection cn = new SqlConnection();
        public createSale()
        {
            InitializeComponent();
        }

        private void createSale_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT DISTINCT CATEGORY FROM Pruducts ", cn);
            SqlDataReader Reader = cm.ExecuteReader();
            while (Reader.Read())
            {
                comboBoxtypep.Items.Add(Reader["CATEGORY"]);
            }
            Reader.Close();
            SqlCommand cm2 = new SqlCommand("SELECT DISTINCT NAMEMOSH FROM Factor_forosh ", cn);
            SqlDataReader Reader2 = cm2.ExecuteReader();
            while (Reader2.Read())
            {
                comboBoxcustom.Items.Add(Reader2["NAMEMOSH"]);
            }
            Reader2.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT NAME,FAMILY,SEMAT FROM Member WHERE EMPLOYEID='" + EMP + "'", cn);
            SqlDataReader Reader = cm.ExecuteReader();
            Reader.Read();
            string name = Reader["NAME"].ToString();
            string family = Reader["FAMILY"].ToString();
            string semat = Reader["SEMAT"].ToString();
            Reader.Close();
            SqlCommand Command = new SqlCommand("INSERT Factor_forosh(ModifiedDate,FactorID,CATEGORY,PRUDUCTID,PNAME,PRICE,TEDAD,DISCONT,TOTALPRICE,NAMEMOSH,EMPLOYEID,NAME,FAMILY,SEMAT) VALUES(@date,@fid,@cat,@pid,@pname,@price,@qty,@dis,@tprice,@namemosh,@eid,@name,@fam,@semat)", cn);
            Command.Parameters.Add("@date", SqlDbType.DateTime);
            Command.Parameters["@date"].Value = DateTime.Now.ToString();
            Command.Parameters.Add("@fid", SqlDbType.Int);
            Command.Parameters["@fid"].Value = Convert.ToInt32(txtshf.Text);
            Command.Parameters.Add("@cat", SqlDbType.NVarChar, 100);
            Command.Parameters["@cat"].Value = comboBoxtypep.Text;
            Command.Parameters.Add("@pid", SqlDbType.Int);
            Command.Parameters["@pid"].Value = Convert.ToInt32(comboBoxshp.Text);
            Command.Parameters.Add("@pname", SqlDbType.NVarChar, 100);
            Command.Parameters["@pname"].Value = comboBoxnamep.Text;
            Command.Parameters.Add("@price", SqlDbType.Int);
            Command.Parameters["@price"].Value = Convert.ToInt32(comboBoxprice.Text);
            SqlCommand cm2 = new SqlCommand("SELECT TEDAD FROM Pruducts WHERE PruductID LIKE '" +comboBoxshp.Text+ "' AND PNAME LIKE N'"+comboBoxnamep.Text+"' ", cn);
            SqlDataReader Reader2 = cm2.ExecuteReader();
            Reader2.Read();
            string tedad = Reader2["TEDAD"].ToString();
            Reader2.Close();
            try
            {
                if (Convert.ToDouble(txtdiscont.Text) <= 1 && Convert.ToInt32(comboBoxqty.Text) <= Convert.ToInt32(tedad))
                {
                    Command.Parameters.Add("@qty", SqlDbType.Int);
                    Command.Parameters["@qty"].Value = Convert.ToInt32(comboBoxqty.Text);
                    SqlCommand cm3 = new SqlCommand("UPDATE Pruducts SET TEDAD=@tedad WHERE PruductID LIKE '" + comboBoxshp.Text + "' AND PNAME LIKE N'" + comboBoxnamep.Text + "' ", cn);
                    cm3.Parameters.Add("@tedad", SqlDbType.Int);
                    cm3.Parameters["@tedad"].Value = Convert.ToInt32(tedad) - Convert.ToInt32(comboBoxqty.Text);
                    cm3.ExecuteNonQuery();
                    Command.Parameters.Add("@dis", SqlDbType.Float);
                    Command.Parameters["@dis"].Value = Convert.ToDouble(txtdiscont.Text);
                    Command.Parameters.Add("@tprice", SqlDbType.Decimal);
                    Command.Parameters["@tprice"].Value = Convert.ToDecimal((Convert.ToInt32(comboBoxprice.Text) - (Convert.ToInt32(comboBoxprice.Text) * Convert.ToDouble(txtdiscont.Text))) * Convert.ToInt32(comboBoxqty.Text));
                    Command.Parameters.Add("@namemosh", SqlDbType.NVarChar, 100);
                    Command.Parameters["@namemosh"].Value = comboBoxcustom.Text;
                    Command.Parameters.Add("@eid", SqlDbType.Int);
                    Command.Parameters["@eid"].Value = Convert.ToInt32(EMP);
                    Command.Parameters.Add("@name", SqlDbType.NVarChar, 50);
                    Command.Parameters["@name"].Value = name;
                    Command.Parameters.Add("@fam", SqlDbType.NVarChar, 50);
                    Command.Parameters["@fam"].Value = family;
                    Command.Parameters.Add("@semat", SqlDbType.NVarChar, 50);
                    Command.Parameters["@semat"].Value = semat;
                    Command.ExecuteNonQuery();
                    MessageBox.Show("فاکتور با موفقیت ثبت شد");
                }
                else if (Convert.ToInt32(comboBoxqty.Text) > Convert.ToInt32(tedad))
                {
                    MessageBox.Show("این تعداد از کالا مجود نیست", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(Convert.ToDouble(txtdiscont.Text) > 1)
                {
                    MessageBox.Show("مقدار تخفیف مجاز نیست", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("مقادیر نا معتبر است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtshf.Clear();
            comboBoxshp.ResetText();
            comboBoxtypep.ResetText();
            comboBoxnamep.ResetText();
            comboBoxprice.ResetText();
            comboBoxqty.ResetText();
            comboBoxcustom.ResetText();
            txtdiscont.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBoxtypep_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxshp.Items.Clear();
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT DISTINCT PruductID FROM Pruducts WHERE CATEGORY LIKE N'"+comboBoxtypep.Text+"' ", cn);
            SqlDataReader Reader = cm.ExecuteReader();
            while (Reader.Read())
            {
                comboBoxshp.Items.Add(Reader["PruductID"]);
            }
            Reader.Close();
        }

        private void comboBoxshp_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxnamep.Items.Clear();
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT DISTINCT PNAME FROM Pruducts WHERE CATEGORY LIKE N'" + comboBoxtypep.Text + "' AND PruductID LIKE '" + comboBoxshp.Text + "' ", cn);
            SqlDataReader Reader = cm.ExecuteReader();
            while (Reader.Read())
            {
                comboBoxnamep.Items.Add(Reader["PNAME"]);
            }
            Reader.Close();
        }

        private void comboBoxnamep_SelectedValueChanged(object sender, EventArgs e)
        {
            comboBoxprice.Items.Clear();
            comboBoxqty.Items.Clear();
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT DISTINCT PRICE FROM Pruducts WHERE PNAME LIKE N'" + comboBoxnamep.Text + "' AND PruductID LIKE '" + comboBoxshp.Text + "' ", cn);
            SqlDataReader Reader = cm.ExecuteReader();
            while (Reader.Read())
            {
                comboBoxprice.Items.Add(Reader["PRICE"]);
            }
            Reader.Close();
            SqlCommand cm2 = new SqlCommand("SELECT DISTINCT TEDAD FROM Pruducts WHERE PNAME LIKE N'" + comboBoxnamep.Text + "' AND PruductID LIKE '" + comboBoxshp.Text + "' ", cn);
            SqlDataReader Reader2 = cm2.ExecuteReader();
            while (Reader2.Read())
            {
                comboBoxqty.Items.Add(Reader2["TEDAD"]);
            }
            Reader2.Close();
        }
    }
}
