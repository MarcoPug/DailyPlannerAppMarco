
namespace DailyPlannerAppMarco.AddItemForms
{
    partial class addSleepItem
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.cbTimeDays = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbAMPM = new Guna.UI2.WinForms.Guna2ComboBox();
            this.shape = new Guna.UI2.WinForms.Guna2Shapes();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(22, 21);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(167, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Good Morning!";
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.AutoRoundedCorners = true;
            this.btnAdd.BorderRadius = 21;
            this.btnAdd.BorderThickness = 2;
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
            this.btnAdd.Location = new System.Drawing.Point(95, 159);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(237, 45);
            this.btnAdd.TabIndex = 54;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbTimeDays
            // 
            this.cbTimeDays.BackColor = System.Drawing.Color.Transparent;
            this.cbTimeDays.BorderRadius = 2;
            this.cbTimeDays.BorderThickness = 2;
            this.cbTimeDays.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTimeDays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeDays.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTimeDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTimeDays.FocusedState.Parent = this.cbTimeDays;
            this.cbTimeDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbTimeDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTimeDays.HoverState.Parent = this.cbTimeDays;
            this.cbTimeDays.ItemHeight = 30;
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
            this.cbTimeDays.ItemsAppearance.Parent = this.cbTimeDays;
            this.cbTimeDays.Location = new System.Drawing.Point(115, 98);
            this.cbTimeDays.Name = "cbTimeDays";
            this.cbTimeDays.ShadowDecoration.Parent = this.cbTimeDays;
            this.cbTimeDays.Size = new System.Drawing.Size(95, 36);
            this.cbTimeDays.TabIndex = 55;
            // 
            // cbAMPM
            // 
            this.cbAMPM.BackColor = System.Drawing.Color.Transparent;
            this.cbAMPM.BorderRadius = 2;
            this.cbAMPM.BorderThickness = 2;
            this.cbAMPM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbAMPM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAMPM.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAMPM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbAMPM.FocusedState.Parent = this.cbAMPM;
            this.cbAMPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbAMPM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbAMPM.HoverState.Parent = this.cbAMPM;
            this.cbAMPM.ItemHeight = 30;
            this.cbAMPM.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbAMPM.ItemsAppearance.Parent = this.cbAMPM;
            this.cbAMPM.Location = new System.Drawing.Point(216, 98);
            this.cbAMPM.Name = "cbAMPM";
            this.cbAMPM.ShadowDecoration.Parent = this.cbAMPM;
            this.cbAMPM.Size = new System.Drawing.Size(95, 36);
            this.cbAMPM.TabIndex = 56;
            // 
            // shape
            // 
            this.shape.FillColor = System.Drawing.Color.DarkGray;
            this.shape.Location = new System.Drawing.Point(-54, -29);
            this.shape.Name = "shape";
            this.shape.PolygonSkip = 1;
            this.shape.Rotate = 0F;
            this.shape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.shape.Size = new System.Drawing.Size(532, 293);
            this.shape.TabIndex = 57;
            this.shape.Text = "guna2Shapes1";
            this.shape.Zoom = 80;
            // 
            // addSleepItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 234);
            this.Controls.Add(this.cbAMPM);
            this.Controls.Add(this.cbTimeDays);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.shape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addSleepItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "addSleepItem";
            this.Load += new System.EventHandler(this.addSleepItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2ComboBox cbTimeDays;
        private Guna.UI2.WinForms.Guna2ComboBox cbAMPM;
        private Guna.UI2.WinForms.Guna2Shapes shape;
    }
}