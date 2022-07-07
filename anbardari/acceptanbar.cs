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
    public partial class acceptanbar : Form
    {
        public SqlConnection cn = new SqlConnection();
        public acceptanbar()
        {
            InitializeComponent();
        }

        private async void acceptanbar_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand CM = new SqlCommand("SELECT CATEGORY N'نوع کالا',PNAME N'نام کالا',SUM(TEDAD) N'تعداد کل'   FROM Pruducts GROUP BY CATEGORY,PNAME ", cn);
            SqlDataReader dr = await CM.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridViewshow.DataSource = Table;
        }

        private void btnacept_Click(object sender, EventArgs e)
        {
            try
            {
                if(checkBoxaccept.Checked==true)
                {
                    MessageBox.Show("موجودی تایید شد");
                }
                else
                {
                    MessageBox.Show("موجودی تایید نشده", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
