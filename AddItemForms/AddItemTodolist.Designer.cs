
namespace DailyPlannerAppMarco.AddItemForms
{
    partial class AddItemTodolist
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
            this.cbAMPM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbImportant = new System.Windows.Forms.CheckBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRepeating = new System.Windows.Forms.CheckBox();
            this.cbTimeDays = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cGroup = new System.Windows.Forms.ComboBox();
            this.txtDesc = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.importantNotif = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbAMPM
            // 
            this.cbAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cbAMPM.FormattingEnabled = true;
            this.cbAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbAMPM.Location = new System.Drawing.Point(259, 140);
            this.cbAMPM.Name = "cbAMPM";
            this.cbAMPM.Size = new System.Drawing.Size(121, 28);
            this.cbAMPM.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(19, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "Designated Time?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(72, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Repeating?";
            // 
            // cbTime
            // 
            this.cbTime.AutoSize = true;
            this.cbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cbTime.Location = new System.Drawing.Point(180, 147);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(15, 14);
            this.cbTime.TabIndex = 19;
            this.cbTime.UseVisualStyleBackColor = true;
            this.cbTime.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(76, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Important?";
            // 
            // cbImportant
            // 
            this.cbImportant.AutoSize = true;
            this.cbImportant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cbImportant.Location = new System.Drawing.Point(180, 75);
            this.cbImportant.Name = "cbImportant";
            this.cbImportant.Size = new System.Drawing.Size(15, 14);
            this.cbImportant.TabIndex = 17;
            this.cbImportant.UseVisualStyleBackColor = true;
            this.cbImportant.CheckedChanged += new System.EventHandler(this.cbImportant_CheckedChanged);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.Location = new System.Drawing.Point(180, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Name of Task?";
            // 
            // txtDays
            // 
            this.txtDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDays.Location = new System.Drawing.Point(248, 108);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(52, 26);
            this.txtDays.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(306, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Days?";
            // 
            // cbRepeating
            // 
            this.cbRepeating.AutoSize = true;
            this.cbRepeating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cbRepeating.Location = new System.Drawing.Point(179, 114);
            this.cbRepeating.Name = "cbRepeating";
            this.cbRepeating.Size = new System.Drawing.Size(15, 14);
            this.cbRepeating.TabIndex = 30;
            this.cbRepeating.UseVisualStyleBackColor = true;
            this.cbRepeating.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbTimeDays
            // 
            this.cbTimeDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cbTimeDays.FormattingEnabled = true;
            this.cbTimeDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cbTimeDays.Location = new System.Drawing.Point(205, 140);
            this.cbTimeDays.Name = "cbTimeDays";
            this.cbTimeDays.Size = new System.Drawing.Size(47, 28);
            this.cbTimeDays.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(42, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Add To Group?";
            // 
            // cGroup
            // 
            this.cGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cGroup.FormattingEnabled = true;
            this.cGroup.Location = new System.Drawing.Point(179, 184);
            this.cGroup.Name = "cGroup";
            this.cGroup.Size = new System.Drawing.Size(121, 28);
            this.cGroup.TabIndex = 33;
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txtDesc.Location = new System.Drawing.Point(180, 239);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtDesc.Size = new System.Drawing.Size(223, 44);
            this.txtDesc.TabIndex = 34;
            this.txtDesc.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(72, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 35;
            this.label7.Text = "Description";
            // 
            // importantNotif
            // 
            this.importantNotif.AutoSize = true;
            this.importantNotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importantNotif.Location = new System.Drawing.Point(77, 92);
            this.importantNotif.Name = "importantNotif";
            this.importantNotif.Size = new System.Drawing.Size(303, 16);
            this.importantNotif.TabIndex = 36;
            this.importantNotif.Text = "* Important tasks will send you notifications";
            this.importantNotif.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 21;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(84)))));
            this.btnAdd.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Location = new System.Drawing.Point(80, 310);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(237, 45);
            this.btnAdd.TabIndex = 39;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(193, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 40;
            this.label8.Text = "Every";
            this.label8.Visible = false;
            // 
            // AddItemTodolist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 381);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.importantNotif);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.cGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbTimeDays);
            this.Controls.Add(this.cbRepeating);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.cbAMPM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbImportant);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddItemTodolist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Task";
            this.Load += new System.EventHandler(this.AddItemTodolist_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbAMPM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbImportant;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbRepeating;
        private System.Windows.Forms.ComboBox cbTimeDays;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cGroup;
        private System.Windows.Forms.RichTextBox txtDesc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label importantNotif;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.Label label8;
    }
}