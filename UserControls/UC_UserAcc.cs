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


            if (txtEmail.Text != "" && txtEmail.Text.Contains("@"))
            {
                currRecord.Email = txtEmail.Text;
                db.UpsertRecord(Form1.dbName, Form1.currId, currRecord);
                txtEmail.Clear();
                txtShowEmail.Text = currRecord.Email;
                MessageBox.Show("Email updated successfully");
                
            }


            if (txtPassword.Text != "" && txtPassword.TextLength > 3)
            {
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
    }
}
