using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework6.UI
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public void Init()
        {
            DataSet dset = new DataSet();
            string sql = string.Empty;

            string conn = null;
            SqlDataAdapter da1 = new SqlDataAdapter();
            da1.SelectCommand.Connection = new SqlConnection(conn);
            da1.SelectCommand.CommandText = sql;
            da1.Fill(dset);
        }
    }
}
