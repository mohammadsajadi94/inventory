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
    public partial class inbox : Form
    {
        public SqlConnection cn = new SqlConnection();
        public string eid = null;
        public inbox()
        {
            InitializeComponent();
        }

        private async void inbox_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT MAILID,EMPLOYEIDSEND,NAME,FAMILY,VAHED,SEMAT,_SUBJECT,MESSEGE,EMPLOYEIDDAR   FROM MAIL  WHERE EMPLOYEIDDAR='" + eid + "'", cn);
            SqlDataReader dr = await cm.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridViewshow.DataSource = Table;
        }

        private async void btnreset_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT MAILID,EMPLOYEIDSEND,NAME,FAMILY,VAHED,SEMAT,_SUBJECT,MESSEGE,EMPLOYEIDDAR   FROM MAIL  WHERE EMPLOYEIDDAR='" + eid + "'", cn);
            SqlDataReader dr = await cm.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridViewshow.DataSource = Table;
        }
    }
}
