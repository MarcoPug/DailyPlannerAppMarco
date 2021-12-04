using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyPlannerAppMarco
{
    public partial class AdminPanel : Form
    {

        MongoCRUD db;
        public AdminPanel()
        {
            InitializeComponent();

            db = new MongoCRUD(Form1.dbName);

            loadData();

        }

        private void loadData()
        {
            var connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var database = server.GetDatabase(Form1.dbName);
            var collection = database.GetCollection<User>(Form1.dbName);



            BindingList<User> doclist = new BindingList<User>();

            foreach (var deger in collection.FindAll())
            {
                doclist.Add(deger);

                Application.DoEvents();
            }
            dataGridView1.DataSource = doclist;
        }


        private void AdminPanel_Load(object sender, EventArgs e)
        {


        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            if (txtEmail.Text != "" && txtPassword.Text != "")
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

                if (unique)
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
                    loadData();
                }
                else
                {
                    MessageBox.Show("Email already exists");
                }

                
            }
           

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            Guid testId = Guid.Parse(selectedID);
            if (testId != new Guid("00000000-0000-0000-0000-000000000000") && (txtEmail.Text != "" && txtPassword.Text != ""))
            {
                var oneRec = db.LoadRecordById<User>(Form1.dbName, testId);
                oneRec.Email = txtEmail.Text;
                oneRec.Password = txtPassword.Text;
                db.UpsertRecord(Form1.dbName, oneRec.Id, oneRec);

                loadData();
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            Guid testId = Guid.Parse(selectedID);

            if (testId != new Guid("00000000-0000-0000-0000-000000000000"))
            {
                var oneRec = db.LoadRecordById<User>(Form1.dbName, testId);
                db.DeleteRecord<User>(Form1.dbName, oneRec.Id);

                loadData();
            }



        }

        string selectedID = ("00000000-0000-0000-0000-000000000000");
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtId.Text = selectedID.ToString();
        }

        private void AdminPanel_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            dataGridView1.ClearSelection();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Report Sent to Manager");
        }
    }
}
