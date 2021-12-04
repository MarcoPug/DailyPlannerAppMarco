using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace DailyPlannerAppMarco
{
    public partial class logInForm : Form
    {
        readonly MongoCRUD db;

        int counter = 0;
        public logInForm()
        {
            InitializeComponent();

            db = new MongoCRUD(Form1.dbName);

            createAdminAccount();
            lblError.Text = "";
        }


        private void setButtons(string button)
        {
            
            if (button == "register")
            {
                lblMessage.Left = 51;
                lblMessage.Text = "Register";
                btnLogin.Text = "Create Account";
                btnRegister.Text = "Login";
            }
            if (button == "login")
            {
                lblMessage.Left = 76;
                lblMessage.Text = "Login";
                btnLogin.Text = "Login";
                btnRegister.Text = "Register";
            }
        }

        private void Login()
        {
            

            Guid testId = findAccount(db);
            if (testId == new Guid("00000000-0000-0000-0000-000000000000"))
            {

                lblError.Text = "Invalid login";
            }
            else
            {
                Form1.currId = testId;
                Form1.fillAppArrayDB();
                Form1.loggedIn = true;

                this.Close();
            }
        }
        private void Register()
        {

            
            if (isUniqueAccount(db) && txtEmail.Text != "" && txtPassword.Text != "" && txtEmail.Text.Contains("@") && txtPassword.TextLength > 3)
            {
                User user = new User
                {
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    listInfo = new userListInfo
                    {

                    },
                    appInfo = new userAppInfo
                    {
                        leftBefore = false


                    },
                    bmrInfo = new userBMRinfo
                    {

                    }
                };
                db.InsertRecord(Form1.dbName, user);
                MessageBox.Show("Account sucessfully created.");
                lblError.Text = "";
                btnLogin.Visible = true;
            }
            else
            {
                lblError.Text = "Incorrent Account information";
            }
        }

        private bool isUniqueAccount(MongoCRUD db)
        {
            bool unique = true;
            var recs = db.LoadRecords<User>(Form1.dbName);
            foreach (var rec in recs)
            {

                if (txtEmail.Text == rec.Email)
                {
                    unique = false;
                }
            }
            return unique;
        }

        private Guid findAccount(MongoCRUD db)
        {
            var recs = db.LoadRecords<User>(Form1.dbName);
            foreach (var rec in recs)
            {

                if (txtEmail.Text == rec.Email && txtPassword.Text == rec.Password)
                {
                    return rec.Id;
                }
            }
            return new Guid("00000000-0000-0000-0000-000000000000");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createAdminAccount()
        {
            int count = 0;

            var recs = db.LoadRecords<User>(Form1.dbName);
            foreach (var rec in recs)
            {

                if ("admin" == rec.Email)
                {
                    count++;
                }
            }

            if (count == 0)
            {

                User user = new User
                {
                    Email = "admin",
                    Password = "password",
                    listInfo = new userListInfo
                    {

                    },
                    appInfo = new userAppInfo
                    {
                        leftBefore = false,
                        Admin = true

                    },
                    bmrInfo = new userBMRinfo
                    {

                    }
                };
                db.InsertRecord(Form1.dbName, user);
            }

            
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (counter % 2 == 0)
            {
                Login();
            }
            else
            {

                Register();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            if (counter % 2 == 0)
            {
                setButtons("register");
            }
            else
            {
                setButtons("login");
            }
            counter++;

            if (counter > 1)
            {
                counter = counter - 2;
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
