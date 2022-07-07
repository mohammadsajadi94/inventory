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
    public partial class showanbar : Form
    {
        public SqlConnection cn = new SqlConnection();
        public showanbar()
        {
            InitializeComponent();
        }

        private async void showanbar_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT PruductID AS N'شماره کالا',CATEGORY N'نوع کالا',PNAME N'نام کالا',PRICE N'قیمت',TEDAD N'تعداد',EMPLOYEID N'شماره پرسنلی ثبت کننده',NAME N'نام ثبت کننده',FAMILY N'نام خانوادگی ثبت کننده',SEMAT N'سمت ثبت کننده'   FROM Pruducts", cn);
            SqlDataReader dr = await cm.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridViewshow.DataSource = Table;
        }

        private async void btnsearch_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT PruductID AS N'شماره کالا',CATEGORY N'نوع کالا',PNAME N'نام کالا',PRICE N'قیمت',TEDAD N'تعداد',EMPLOYEID N'شماره پرسنلی ثبت کننده',NAME N'نام ثبت کننده',FAMILY N'نام خانوادگی ثبت کننده',SEMAT N'سمت ثبت کننده'   FROM Pruducts WHERE PNAME LIKE N'"+txtsearch.Text+"'", cn);
            SqlDataReader dr = await cm.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridViewshow.DataSource = Table;
        }

        private async void txtsearch_TextChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT PruductID AS N'شماره کالا',CATEGORY N'نوع کالا',PNAME N'نام کالا',PRICE N'قیمت',TEDAD N'تعداد',EMPLOYEID N'شماره پرسنلی ثبت کننده',NAME N'نام ثبت کننده',FAMILY N'نام خانوادگی ثبت کننده',SEMAT N'سمت ثبت کننده'   FROM Pruducts", cn);
            SqlDataReader dr = await cm.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridViewshow.DataSource = Table;
        }
    }
}
