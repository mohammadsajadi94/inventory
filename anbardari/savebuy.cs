﻿using System;
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
    public partial class savebuy : Form
    {
        public string fid = null;
        public SqlConnection cn = new SqlConnection();
        public savebuy()
        {
            InitializeComponent();
        }

        private void savebuy_Load(object sender, EventArgs e)
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
            SqlCommand cm2 = new SqlCommand("SELECT DISTINCT NAMESH FROM Factor_kharid ", cn);
            SqlDataReader Reader2 = cm2.ExecuteReader();
            while (Reader2.Read())
            {
                comboBoxnamefor.Items.Add(Reader2["NAMESH"]);
            }
            Reader2.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand Command = new SqlCommand("UPDATE Factor_kharid SET ModifiedDate=@date,FactorID=@fid,CATEGORY=@cat,PRUDUCTID=@pid,PNAME=@pname,PRICE=@price,TEDAD=@qty,DISCONT=@dis,TOTALPRICE=@tprice,NAMESH=@namesh   WHERE FactorID='"+fid+"' ", cn);
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
            Command.Parameters["@price"].Value = Convert.ToInt32(txtprice.Text);
            Command.Parameters.Add("@qty", SqlDbType.Int);
            Command.Parameters["@qty"].Value = Convert.ToInt32(txtqty.Text);
            try
            {
                if (Convert.ToDouble(txtdiscont.Text) <= 1)
                {
                    Command.Parameters.Add("@dis", SqlDbType.Float);
                    Command.Parameters["@dis"].Value = Convert.ToDouble(txtdiscont.Text);
                    Command.Parameters.Add("@tprice", SqlDbType.Decimal);
                    Command.Parameters["@tprice"].Value = Convert.ToDecimal((Convert.ToInt32(txtprice.Text) - (Convert.ToInt32(txtprice.Text) * Convert.ToDouble(txtdiscont.Text))) * Convert.ToInt32(txtqty.Text));
                    Command.Parameters.Add("@namesh", SqlDbType.NVarChar, 100);
                    Command.Parameters["@namesh"].Value = comboBoxnamefor.Text;
                    Command.ExecuteNonQuery();
                    MessageBox.Show("فاکتور با موفقیت ویرایش شد");
                }
                else
                {
                    MessageBox.Show("مقدار مجاز نیست", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            txtprice.Clear();
            txtqty.Clear();
            comboBoxnamefor.ResetText();
            txtdiscont.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
