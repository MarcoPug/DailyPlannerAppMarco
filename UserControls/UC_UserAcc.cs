using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlannerAppMarco.UserControls
{
    public partial class UC_UserAcc : UserControl
    {
        readonly MongoCRUD db;
        public UC_UserAcc()
        {
            InitializeComponent();
            db = new MongoCRUD(Form1.dbName);
            var currRecord = db.LoadRecordById<User>(Form1.dbName, Form1.currId);


            txtShowEmail.Text = currRecord.Email;

            string passHidden = new string('*', currRecord.Password.Length);
            txtShowPassword.Text = passHidden;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var currRecord = db.LoadRecordById<User>(Form1.dbName, Form1.currId);

            string error = "";

            if (txtEmail.Text.Length != 0 && txtEmail.Text.Contains("@") && txtEmail.Text.Contains("."))
            {
                
                currRecord.Email = txtEmail.Text;
                db.UpsertRecord(Form1.dbName, Form1.currId, currRecord);
                txtEmail.Clear();
                txtShowEmail.Text = currRecord.Email;
                MessageBox.Show("Email updated successfully");
                
            }
            else if(txtEmail.Text.Length != 0)
            {
                error = "email";
            }


            if (txtPassword.Text.Length != 0 && txtPassword.TextLength > 3)
            {
                lblError.Visible = false;
                currRecord.Password = txtPassword.Text;
                db.UpsertRecord(Form1.dbName, Form1.currId, currRecord);
                txtPassword.Clear();
                string passHidden = new string('*', currRecord.Password.Length);
                txtShowPassword.Text = passHidden;
                if (cbPass.Checked)
                {
                    cbPass.Checked = !cbPass.Checked;
                }
                MessageBox.Show("Password updated successfully");
            }
            else if (txtPassword.Text.Length != 0)
            {
                error = error + "password";
            }


            if (error == "email")
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Email";
            }
            else if (error == "password")
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Password";
            }
            else if (error == "emailpassword")
            {
                lblError.Visible = true;
                lblError.Text = "Invalid Information";
            }
            else
            {
                lblError.Visible = false;
            }
        }

        private void cbPass_CheckedChanged(object sender, EventArgs e)
        {
            var currRecord = db.LoadRecordById<User>(Form1.dbName, Form1.currId);

            if (cbPass.Checked)
            {
                txtShowPassword.Text = currRecord.Password;
            }
            else if (!cbPass.Checked)
            {
                string passHidden = new string('*', currRecord.Password.Length);
                txtShowPassword.Text = passHidden;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to permanently delete your account?", "Delete Account", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.DeleteRecord<User>(Form1.dbName, Form1.currId);

                Application.Restart();
                Environment.Exit(0);
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }


        }
    }
}
