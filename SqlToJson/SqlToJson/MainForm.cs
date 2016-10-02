using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edi.ExtensionMethods;

namespace SqlToJson
{
    public partial class MainForm : Form
    {
        public Operator SqlOperator { get; set; }

        public MainForm()
        {
            InitializeComponent();

            txtSQL.Enabled = false;
            txtResult.Enabled = false;
            cmbDatabaseList.Enabled = false;
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
                ValidateNullOrEmptyOrWhiteSpace(new[] { txtServer.Text });

                var response = await Operator.TestConnection(txtServer.Text, txtUsername.Text, txtPassword.Text,
                                                  initDb: cmbDatabaseList.SelectedText,
                                                  useWindowsAuth: cbWindowsAuth.Checked);

                MessageBox.Show(response.IsSuccess ? "OK" : response.Message, "Test Connection", MessageBoxButtons.OK,
                    response.IsSuccess ? MessageBoxIcon.Information : MessageBoxIcon.Error);

                if (response.IsSuccess)
                {
                    txtSQL.Enabled = true;
                    txtResult.Enabled = true;
                    cmbDatabaseList.Enabled = true;

                    SqlOperator = new Operator(txtServer.Text, txtUsername.Text, txtPassword.Text, string.Empty, useWindowsAuth: cbWindowsAuth.Checked);

                    LoadDatabaseList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Blow Up!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDatabaseList()
        {
            var response = SqlOperator.GetDatabaseList();
            if (response.IsSuccess)
            {
                cmbDatabaseList.DataSource = response.Item;
            }
        }

        private void btnGetJSON_Click(object sender, EventArgs e)
        {
            var response = SqlOperator.SqlToJson(txtSQL.Text);

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

        private void lblEdiWang_Click(object sender, EventArgs e)
        {

        }

        private void cmbDatabaseList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlOperator = new Operator(txtServer.Text, txtUsername.Text, txtPassword.Text, initDb: (string)cmbDatabaseList.SelectedValue, useWindowsAuth: cbWindowsAuth.Checked);
        }
    }
}
