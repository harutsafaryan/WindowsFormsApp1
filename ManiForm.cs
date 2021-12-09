using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ManiForm : Form
    {
        public ManiForm()
        {
            InitializeComponent();
        }

        private void ManiForm_Load(object sender, EventArgs e)
        {
            stringlstBx.DataSource = new List<string> { "lok", "mlo", "klop", "loc", "alo", "look", "lamp", "lov", "lop", "aslo", "sdtg", "bslo", "dslo" };
        }
    }
}
