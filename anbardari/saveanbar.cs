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
    public partial class saveanbar : Form
    {
        public SqlConnection cn = new SqlConnection();
        public string pid = null;
        public saveanbar()
        {
            InitializeComponent();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtshp.Clear();
            txttypep.Clear();
            txtnamep.Clear();
            txtprice.Clear();
            txtqty.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand Command = new SqlCommand("UPDATE Pruducts SET PruductID=@pid,CATEGORY=@cat,PNAME=@pname,PRICE=@price,TEDAD=@ted WHERE PruductID='"+pid+"' ", cn);
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
            Command.ExecuteNonQuery();
            MessageBox.Show("کالا با موفقیت ویرایش شد");
            Close();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
