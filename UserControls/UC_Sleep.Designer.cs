
namespace DailyPlannerAppMarco.UserControls
{
    partial class UC_Sleep
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox = new System.Windows.Forms.ListBox();
            this.lblWokeUp = new System.Windows.Forms.Label();
            this.panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.shape = new Guna.UI2.WinForms.Guna2Shapes();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 37;
            this.listBox.Location = new System.Drawing.Point(172, 116);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(438, 41);
            this.listBox.TabIndex = 1;
            // 
            // lblWokeUp
            // 
            this.lblWokeUp.AutoSize = true;
            this.lblWokeUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWokeUp.Location = new System.Drawing.Point(167, 72);
            this.lblWokeUp.Name = "lblWokeUp";
            this.lblWokeUp.Size = new System.Drawing.Size(128, 26);
            this.lblWokeUp.TabIndex = 4;
            this.lblWokeUp.Text = "Woke up at,";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(111, 329);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(689, 22);
            this.panel.TabIndex = 27;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Transparent;
            this.btnPrev.BorderColor = System.Drawing.Color.Transparent;
            this.btnPrev.CheckedState.Parent = this.btnPrev;
            this.btnPrev.CustomImages.Parent = this.btnPrev;
            this.btnPrev.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrev.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrev.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrev.DisabledState.Parent = this.btnPrev;
            this.btnPrev.FillColor = System.Drawing.Color.Transparent;
            this.btnPrev.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrev.ForeColor = System.Drawing.Color.Transparent;
            this.btnPrev.HoverState.Parent = this.btnPrev;
            this.btnPrev.Image = global::DailyPlannerAppMarco.Properties.Resources.HourglassIcon;
            this.btnPrev.ImageSize = new System.Drawing.Size(34, 34);
            this.btnPrev.Location = new System.Drawing.Point(577, 174);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrev.ShadowDecoration.Parent = this.btnPrev;
            this.btnPrev.Size = new System.Drawing.Size(33, 34);
            this.btnPrev.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnPrev, "Views previous day\'s sleep times");
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Animated = true;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.CheckedState.Parent = this.btnAdd;
            this.btnAdd.CustomImages.Parent = this.btnAdd;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.DisabledState.Parent = this.btnAdd;
            this.btnAdd.FillColor = System.Drawing.Color.Transparent;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.HoverState.Parent = this.btnAdd;
            this.btnAdd.Image = global::DailyPlannerAppMarco.Properties.Resources.plusIcon;
            this.btnAdd.ImageSize = new System.Drawing.Size(34, 34);
            this.btnAdd.Location = new System.Drawing.Point(522, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(33, 34);
            this.btnAdd.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnAdd, "Adds new sleep time");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BorderColor = System.Drawing.Color.Transparent;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.DisabledState.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Image = global::DailyPlannerAppMarco.Properties.Resources.minusIcon;
            this.btnDelete.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDelete.Location = new System.Drawing.Point(464, 174);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(33, 34);
            this.btnDelete.TabIndex = 32;
            this.toolTip1.SetToolTip(this.btnDelete, "Deletes selected workout");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // shape
            // 
            this.shape.Location = new System.Drawing.Point(101, 101);
            this.shape.Name = "shape";
            this.shape.PolygonSkip = 1;
            this.shape.Rotate = 0F;
            this.shape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.shape.Size = new System.Drawing.Size(583, 72);
            this.shape.TabIndex = 43;
            this.shape.Text = "guna2Shapes1";
            this.shape.Zoom = 80;
            // 
            // UC_Sleep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblWokeUp);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.shape);
            this.Name = "UC_Sleep";
            this.Size = new System.Drawing.Size(800, 351);
            this.Click += new System.EventHandler(this.UC_Sleep_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label lblWokeUp;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrev;
        private Guna.UI2.WinForms.Guna2GradientPanel panel;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2Shapes shape;
    }
}
