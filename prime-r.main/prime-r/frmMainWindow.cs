using System;
using System.Windows.Forms;
using prime_r.CallMakers;

namespace prime_r
{
    public partial class FrmMainWindow : Form
    {
        public FrmMainWindow()
        {
            InitializeComponent();
        }

        private void FrmMainWindow_Load(object sender, EventArgs e)
        {
            //could put a splash screen or something here.
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            DoCalcsAndSetInfo();
        }

        private void txtNumber_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DoCalcsAndSetInfo();
            }
        }

        private void DoCalcsAndSetInfo()
        {
            rTxtResult.Text = CalcAndInfoCallMaker.DoCalcsAndGetInfo(txtNumber.Text);
        }
    }
}
