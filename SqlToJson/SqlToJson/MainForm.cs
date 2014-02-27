using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edi.ExtensionMethods;

namespace SqlToJson
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cbWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            if (cbWindowsAuth.Checked)
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;
            }
        }

        public void ValidateNullOrEmptyOrWhiteSpace(string[] strParameters)
        {
            foreach (var strParameter in strParameters.Where(strParameter => strParameter.IsNullOrEmptyOrWhiteSpace()))
            {
                throw new ArgumentNullException(strParameter);
            }
        }

        private async void btnTestConn_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateNullOrEmptyOrWhiteSpace(new[] { txtServer.Text, txtDatabase.Text });

                var response = await Operator.TestConnection(txtServer.Text, txtUsername.Text, txtPassword.Text,
                                                  initDb: txtDatabase.Text,
                                                  useWindowsAuth: cbWindowsAuth.Checked);

                MessageBox.Show(response.IsSuccess ? "OK" : response.Message, "Test Connection", MessageBoxButtons.OK,
                    response.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Blow Up!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGetJSON_Click(object sender, EventArgs e)
        {
            var opt = new Operator(txtServer.Text, txtUsername.Text, txtPassword.Text,
                initDb: txtDatabase.Text,
                useWindowsAuth: cbWindowsAuth.Checked);

            var response = opt.SqlToJson(txtSQL.Text);

            if (response.IsSuccess)
            {
                txtResult.Text = response.Item;
            }
            else
            {
                MessageBox.Show(response.Message, "Blow Up!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtResult.Text);
        }
    }
}
