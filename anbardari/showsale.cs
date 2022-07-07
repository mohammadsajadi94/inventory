using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.Data.SqlClient;

namespace inventory
{
    public partial class showsale : Form
    {
        public SqlConnection cn = new SqlConnection();
        public showsale()
        {
            InitializeComponent();
        }

        private async void showsale_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT ModifiedDate AS N'تاریخ ثبت',FactorID AS N'شماره فاکتور',PRUDUCTID AS N'شماره کالا',CATEGORY N'نوع کالا',PNAME N'نام کالا',PRICE N'قیمت',TEDAD N'تعداد',DISCONT AS N'درصد تخفیف',TOTALPRICE AS N'قیمت کل',NAMEMOSH AS N'نام مشتری',EMPLOYEID N'شماره پرسنلی ثبت کننده',NAME N'نام ثبت کننده',FAMILY N'نام خانوادگی ثبت کننده',SEMAT N'سمت ثبت کننده'   FROM Factor_forosh ", cn);
            SqlDataReader dr = await cm.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridViewshow.DataSource = Table;
        }

        private async void btnsearch_Click(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT ModifiedDate AS N'تاریخ ثبت',FactorID AS N'شماره فاکتور',PRUDUCTID AS N'شماره کالا',CATEGORY N'نوع کالا',PNAME N'نام کالا',PRICE N'قیمت',TEDAD N'تعداد',DISCONT AS N'درصد تخفیف',TOTALPRICE AS N'قیمت کل',NAMEMOSH AS N'نام مشتری',EMPLOYEID N'شماره پرسنلی ثبت کننده',NAME N'نام ثبت کننده',FAMILY N'نام خانوادگی ثبت کننده',SEMAT N'سمت ثبت کننده'   FROM Factor_forosh WHERE PNAME LIKE '"+txtsearch.Text+"' ", cn);
            SqlDataReader dr = await cm.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridViewshow.DataSource = Table;
        }

        private async void txtsearch_TextChanged(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand cm = new SqlCommand("SELECT ModifiedDate AS N'تاریخ ثبت',FactorID AS N'شماره فاکتور',PRUDUCTID AS N'شماره کالا',CATEGORY N'نوع کالا',PNAME N'نام کالا',PRICE N'قیمت',TEDAD N'تعداد',DISCONT AS N'درصد تخفیف',TOTALPRICE AS N'قیمت کل',NAMEMOSH AS N'نام مشتری',EMPLOYEID N'شماره پرسنلی ثبت کننده',NAME N'نام ثبت کننده',FAMILY N'نام خانوادگی ثبت کننده',SEMAT N'سمت ثبت کننده'   FROM Factor_forosh ", cn);
            SqlDataReader dr = await cm.ExecuteReaderAsync();
            DataTable Table = new DataTable();
            Table.Load(dr);
            dataGridViewshow.DataSource = Table;
        }
    }
}
