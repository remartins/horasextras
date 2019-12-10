using System;
using System.Windows.Forms;

namespace HorasExtrasX
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
            this.txbPath.Text = getCurrentPath();
        }

        private string getCurrentPath()
        {
            return Environment.CurrentDirectory;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool check = ((CheckBox)sender).Checked;

            this.btnFolder.Enabled = !check;
            this.txbPath.Enabled = !check;

            if (check)
            {
                this.txbPath.Text = getCurrentPath();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcProcess calc = new CalcProcess();
            this.lblResult.Text = calc.executeCalc(txbPath.Text);
        }


        private void btnFolder_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    this.txbPath.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
