namespace SqlToJson
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtServer = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbDatabaseList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTestConn = new System.Windows.Forms.Button();
            this.cbWindowsAuth = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.txtSQL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnGetJSON = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(88, 25);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(624, 22);
            this.txtServer.TabIndex = 0;
            this.txtServer.Text = "(local)";
            // 
            // txtUsername
            // 
            this.txtUsername.Enabled = false;
            this.txtUsername.Location = new System.Drawing.Point(88, 60);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(132, 22);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(316, 60);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(132, 22);
            this.txtPassword.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbDatabaseList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnTestConn);
            this.groupBox1.Controls.Add(this.cbWindowsAuth);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtServer);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(17, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(860, 140);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL Server Configuration";
            // 
            // cmbDatabaseList
            // 
            this.cmbDatabaseList.FormattingEnabled = true;
            this.cmbDatabaseList.Location = new System.Drawing.Point(88, 97);
            this.cmbDatabaseList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbDatabaseList.Name = "cmbDatabaseList";
            this.cmbDatabaseList.Size = new System.Drawing.Size(360, 24);
            this.cmbDatabaseList.TabIndex = 11;
            this.cmbDatabaseList.SelectedIndexChanged += new System.EventHandler(this.cmbDatabaseList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 100);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database:";
            // 
            // btnTestConn
            // 
            this.btnTestConn.Location = new System.Drawing.Point(721, 23);
            this.btnTestConn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTestConn.Name = "btnTestConn";
            this.btnTestConn.Size = new System.Drawing.Size(131, 61);
            this.btnTestConn.TabIndex = 6;
            this.btnTestConn.Text = "Test Connection";
            this.btnTestConn.UseVisualStyleBackColor = true;
            this.btnTestConn.Click += new System.EventHandler(this.btnTestConn_Click);
            // 
            // cbWindowsAuth
            // 
            this.cbWindowsAuth.AutoSize = true;
            this.cbWindowsAuth.Checked = true;
            this.cbWindowsAuth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbWindowsAuth.Location = new System.Drawing.Point(457, 63);
            this.cbWindowsAuth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbWindowsAuth.Name = "cbWindowsAuth";
            this.cbWindowsAuth.Size = new System.Drawing.Size(209, 21);
            this.cbWindowsAuth.TabIndex = 5;
            this.cbWindowsAuth.Text = "Use Windows Authentication";
            this.cbWindowsAuth.UseVisualStyleBackColor = true;
            this.cbWindowsAuth.CheckedChanged += new System.EventHandler(this.cbWindowsAuth_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server:";
            // 
            // txtResult
            // 
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtResult.Location = new System.Drawing.Point(16, 342);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(861, 400);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "";
            // 
            // txtSQL
            // 
            this.txtSQL.Location = new System.Drawing.Point(17, 192);
            this.txtSQL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSQL.Multiline = true;
            this.txtSQL.Name = "txtSQL";
            this.txtSQL.Size = new System.Drawing.Size(712, 142);
            this.txtSQL.TabIndex = 5;
            this.txtSQL.Text = "SELECT 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 172);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "SQL Query:";
            // 
            // btnGetJSON
            // 
            this.btnGetJSON.Location = new System.Drawing.Point(740, 192);
            this.btnGetJSON.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetJSON.Name = "btnGetJSON";
            this.btnGetJSON.Size = new System.Drawing.Size(137, 142);
            this.btnGetJSON.TabIndex = 7;
            this.btnGetJSON.Text = "Get JSON";
            this.btnGetJSON.UseVisualStyleBackColor = true;
            this.btnGetJSON.Click += new System.EventHandler(this.btnGetJSON_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(777, 750);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(100, 31);
            this.btnCopy.TabIndex = 8;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 794);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnGetJSON);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSQL);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "SQL2JSON - Convert SQL Query Result to JSON string";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbWindowsAuth;
        private System.Windows.Forms.Button btnTestConn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txtResult;
        private System.Windows.Forms.TextBox txtSQL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGetJSON;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.ComboBox cmbDatabaseList;
    }
}

