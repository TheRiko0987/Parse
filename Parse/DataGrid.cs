using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parse
{
    public partial class DataGrid : Form
    {
        ApplicationContext db;
        public DataGrid()
        {
            InitializeComponent();

            db = new ApplicationContext();
            db.IpAdresses.Load();

            dataGridView1.DataSource = db.IpAdresses.Local.ToBindingList();
        }
    }
}
