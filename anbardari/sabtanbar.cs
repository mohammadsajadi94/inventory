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
    public partial class sabtanbar : Form
    {
        public SqlConnection cn = new SqlConnection();
        public string EMP =null;
        public sabtanbar()
        {
            InitializeComponent();
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
            SqlCommand Command = new SqlCommand("INSERT Pruducts(PruductID,CATEGORY,PNAME,PRICE,TEDAD,EMPLOYEID,NAME,FAMILY,SEMAT) VALUES(@pid,@cat,@pname,@price,@ted,@eid,@name,@fam,@semat)", cn);
            Command.Parameters.Add("@pid", SqlDbType.Int);
            Command.Parameters["@pid"].Value = Convert.ToInt32(txtshp.Text);
            Command.Parameters.Add("@cat", SqlDbType.NVarChar, 100);
            Command.Parameters["@cat"].Value = txttypep.Text;
            Command.Parameters.Add("@pname", SqlDbType.NVarChar, 100);
            Command.Parameters["@pname"].Value = txtnamep.Text;
            Command.Parameters.Add("@price", SqlDbType.Int);
            Command.Parameters["@price"].Value = Convert.ToInt32(txtprice.Text);
            Command.Parameters.Add("@ted", SqlDbType.Int);
            Command.Parameters["@ted"].Value = Convert.ToInt32(txtqty.Text);
            Command.Parameters.Add("@eid", SqlDbType.Int);
            Command.Parameters["@eid"].Value = Convert.ToInt32(EMP);
            Command.Parameters.Add("@name", SqlDbType.NVarChar, 50);
            Command.Parameters["@name"].Value =name;
            Command.Parameters.Add("@fam", SqlDbType.NVarChar, 50);
            Command.Parameters["@fam"].Value = family;
            Command.Parameters.Add("@semat", SqlDbType.NVarChar, 50);
            Command.Parameters["@semat"].Value = semat;
            Command.ExecuteNonQuery();
            MessageBox.Show("کالا با موفقیت ثبت شد");
            Close();
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            txtshp.Clear();
            txttypep.Clear();
            txtnamep.Clear();
            txtprice.Clear();
            txtqty.Clear();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
