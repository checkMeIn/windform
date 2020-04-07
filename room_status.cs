using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Me_In
{
    public partial class room_status : Form
    {
        public room_status()
        {
            InitializeComponent();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            var Update = new Update_window();
            Update.Show();


        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var Delete = new delete_record_win();
            Delete.Show();
        }
    }
}
