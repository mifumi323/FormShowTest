using System;
using System.Windows.Forms;

namespace FormShowTest
{
    public partial class FormShowTest : Form
    {
        public FormShowTest()
        {
            InitializeComponent();
        }

        private void btnShowDialog_Click(object sender, EventArgs e)
        {
            // よくある例
            using (var f = new Form())
            {
                f.ShowDialog();
            }
        }

        private void btnShowUsing_Click(object sender, EventArgs e)
        {
            // よくない例
            using (var f = new Form())
            {
                f.Show();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            // よい例
            var f = new Form();
            f.Show();
        }
    }
}
