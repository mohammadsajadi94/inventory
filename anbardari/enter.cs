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
    public partial class enter : Form
    {
        public SqlCommand cm = new SqlCommand();
        public SqlConnection cn = new SqlConnection();
        public SqlDataReader dr;
        public enter()
        {
            InitializeComponent();
        }
        private void btnenter_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT  DASRES,EMPLOYEID  FROM _User1 WHERE EMPLOYEID=(SELECT EMPLOYEID FROM _User1 WHERE SEMAT LIKE N'" + comBoxsemat.Text + "') AND USERNAME LIKE '" + txtuser.Text + "' AND _PASSWORD LIKE '" + txtpass.Text + "'";
                cm = new SqlCommand(sql, cn);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows) 
                {
                        string DAS = dr["DASRES"].ToString();
                        string EMP=dr["EMPLOYEID"].ToString();
                        dr.Close();
                        frmmain frm = new frmmain();
                        frm.das = DAS;
                        frm.emp = EMP;
                        frm.ShowDialog();
                        Close();
                        return;
                }
                else
                {
                    MessageBox.Show("دسترسی امکان پذیر نیست!", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void enter_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection("Data Source = .;Initial Catalog = teamwork;Integrated Security = True");
            cn.Open();
            SqlCommand comand = new SqlCommand("SELECT DISTINCT SEMAT FROM _User1", cn);
            SqlDataReader Reader = comand.ExecuteReader();
            while (Reader.Read())
            {
                comBoxsemat.Items.Add(Reader["SEMAT"]);
            }
            Reader.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtpass.Clear();
            txtuser.Clear();
            comBoxsemat.ResetText();
        }
    }
}
