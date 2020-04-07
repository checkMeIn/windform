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
    public partial class main_window : Form
    {
        public main_window()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bookAroom_Click(object sender, EventArgs e)
        {
            var check_in_forms = new check_in_form();
            check_in_forms.Show();
        }

        private void vIEWROOMSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sTATUSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void STATUS_Click(object sender, EventArgs e)
        {
            var status = new room_status ();
            status.Show();


        }
    }
}
