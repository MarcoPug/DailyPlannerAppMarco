
namespace DailyPlannerAppMarco.UserControls
{
    partial class UC_Calories
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
            this.listBoxCals = new System.Windows.Forms.ListBox();
            this.lblCalorieGoal = new System.Windows.Forms.Label();
            this.panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnUp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDown = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAddCalories = new Guna.UI2.WinForms.Guna2CircleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnCalGoal = new Guna.UI2.WinForms.Guna2Button();
            this.calGoalInput = new Guna.UI2.WinForms.Guna2Button();
            this.shape = new Guna.UI2.WinForms.Guna2Shapes();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(561, 35);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(132, 279);
            this.listBox.TabIndex = 2;
            // 
            // listBoxCals
            // 
            this.listBoxCals.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.listBoxCals.FormattingEnabled = true;
            this.listBoxCals.ItemHeight = 25;
            this.listBoxCals.Location = new System.Drawing.Point(699, 35);
            this.listBoxCals.Name = "listBoxCals";
            this.listBoxCals.Size = new System.Drawing.Size(73, 279);
            this.listBoxCals.TabIndex = 3;
            // 
            // lblCalorieGoal
            // 
            this.lblCalorieGoal.AutoSize = true;
            this.lblCalorieGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalorieGoal.Location = new System.Drawing.Point(40, 35);
            this.lblCalorieGoal.Name = "lblCalorieGoal";
            this.lblCalorieGoal.Size = new System.Drawing.Size(154, 31);
            this.lblCalorieGoal.TabIndex = 5;
            this.lblCalorieGoal.Text = "caloriesLeft";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(111, 329);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(689, 22);
            this.panel.TabIndex = 28;
            // 
            // btnUp
            // 
            this.btnUp.BackColor = System.Drawing.Color.Transparent;
            this.btnUp.BorderColor = System.Drawing.Color.Transparent;
            this.btnUp.CheckedState.Parent = this.btnUp;
            this.btnUp.CustomImages.Parent = this.btnUp;
            this.btnUp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUp.DisabledState.Parent = this.btnUp;
            this.btnUp.FillColor = System.Drawing.Color.Transparent;
            this.btnUp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUp.ForeColor = System.Drawing.Color.Transparent;
            this.btnUp.HoverState.Parent = this.btnUp;
            this.btnUp.Image = global::DailyPlannerAppMarco.Properties.Resources.directionIcon;
            this.btnUp.ImageSize = new System.Drawing.Size(34, 34);
            this.btnUp.Location = new System.Drawing.Point(522, 44);
            this.btnUp.Name = "btnUp";
            this.btnUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUp.ShadowDecoration.Parent = this.btnUp;
            this.btnUp.Size = new System.Drawing.Size(33, 34);
            this.btnUp.TabIndex = 27;
            this.toolTip1.SetToolTip(this.btnUp, "Move item up list");
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.BackColor = System.Drawing.Color.Transparent;
            this.btnDown.BorderColor = System.Drawing.Color.Transparent;
            this.btnDown.CheckedState.Parent = this.btnDown;
            this.btnDown.CustomImages.Parent = this.btnDown;
            this.btnDown.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDown.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDown.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDown.DisabledState.Parent = this.btnDown;
            this.btnDown.FillColor = System.Drawing.Color.Transparent;
            this.btnDown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDown.ForeColor = System.Drawing.Color.Transparent;
            this.btnDown.HoverState.Parent = this.btnDown;
            this.btnDown.Image = global::DailyPlannerAppMarco.Properties.Resources.directionIcon;
            this.btnDown.ImageSize = new System.Drawing.Size(34, 34);
            this.btnDown.Location = new System.Drawing.Point(522, 94);
            this.btnDown.Name = "btnDown";
            this.btnDown.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDown.ShadowDecoration.Parent = this.btnDown;
            this.btnDown.Size = new System.Drawing.Size(33, 34);
            this.btnDown.TabIndex = 26;
            this.toolTip1.SetToolTip(this.btnDown, "Move item down list");
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
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
            this.btnPrev.Location = new System.Drawing.Point(522, 280);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrev.ShadowDecoration.Parent = this.btnPrev;
            this.btnPrev.Size = new System.Drawing.Size(33, 34);
            this.btnPrev.TabIndex = 25;
            this.toolTip1.SetToolTip(this.btnPrev, "Views previous day\'s calories");
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(522, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(33, 34);
            this.btnDelete.TabIndex = 24;
            this.toolTip1.SetToolTip(this.btnDelete, "Deletes selected food");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddCalories
            // 
            this.btnAddCalories.Animated = true;
            this.btnAddCalories.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCalories.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddCalories.CheckedState.Parent = this.btnAddCalories;
            this.btnAddCalories.CustomImages.Parent = this.btnAddCalories;
            this.btnAddCalories.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCalories.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddCalories.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddCalories.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddCalories.DisabledState.Parent = this.btnAddCalories;
            this.btnAddCalories.FillColor = System.Drawing.Color.Transparent;
            this.btnAddCalories.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddCalories.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddCalories.HoverState.Parent = this.btnAddCalories;
            this.btnAddCalories.Image = global::DailyPlannerAppMarco.Properties.Resources.plusIcon;
            this.btnAddCalories.ImageSize = new System.Drawing.Size(34, 34);
            this.btnAddCalories.Location = new System.Drawing.Point(522, 174);
            this.btnAddCalories.Name = "btnAddCalories";
            this.btnAddCalories.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAddCalories.ShadowDecoration.Parent = this.btnAddCalories;
            this.btnAddCalories.Size = new System.Drawing.Size(33, 34);
            this.btnAddCalories.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnAddCalories, "Adds a new food");
            this.btnAddCalories.Click += new System.EventHandler(this.btnAddCalories_Click);
            // 
            // btnCalGoal
            // 
            this.btnCalGoal.Animated = true;
            this.btnCalGoal.AutoRoundedCorners = true;
            this.btnCalGoal.BorderRadius = 21;
            this.btnCalGoal.BorderThickness = 2;
            this.btnCalGoal.CheckedState.Parent = this.btnCalGoal;
            this.btnCalGoal.CustomImages.Parent = this.btnCalGoal;
            this.btnCalGoal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCalGoal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCalGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCalGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCalGoal.DisabledState.Parent = this.btnCalGoal;
            this.btnCalGoal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(84)))));
            this.btnCalGoal.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.btnCalGoal.ForeColor = System.Drawing.Color.White;
            this.btnCalGoal.HoverState.Parent = this.btnCalGoal;
            this.btnCalGoal.Location = new System.Drawing.Point(25, 275);
            this.btnCalGoal.Name = "btnCalGoal";
            this.btnCalGoal.ShadowDecoration.Parent = this.btnCalGoal;
            this.btnCalGoal.Size = new System.Drawing.Size(237, 45);
            this.btnCalGoal.TabIndex = 38;
            this.btnCalGoal.Text = "Calculate Daily";
            this.btnCalGoal.Click += new System.EventHandler(this.btnCalGoal_Click);
            // 
            // calGoalInput
            // 
            this.calGoalInput.Animated = true;
            this.calGoalInput.AutoRoundedCorners = true;
            this.calGoalInput.BorderRadius = 14;
            this.calGoalInput.BorderThickness = 2;
            this.calGoalInput.CheckedState.Parent = this.calGoalInput;
            this.calGoalInput.CustomImages.Parent = this.calGoalInput;
            this.calGoalInput.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.calGoalInput.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.calGoalInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calGoalInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.calGoalInput.DisabledState.Parent = this.calGoalInput;
            this.calGoalInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(84)))));
            this.calGoalInput.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold);
            this.calGoalInput.ForeColor = System.Drawing.Color.White;
            this.calGoalInput.HoverState.Parent = this.calGoalInput;
            this.calGoalInput.Location = new System.Drawing.Point(268, 290);
            this.calGoalInput.Name = "calGoalInput";
            this.calGoalInput.ShadowDecoration.Parent = this.calGoalInput;
            this.calGoalInput.Size = new System.Drawing.Size(152, 30);
            this.calGoalInput.TabIndex = 39;
            this.calGoalInput.Text = "Add Daily";
            this.calGoalInput.Click += new System.EventHandler(this.calGoalInput_Click);
            // 
            // shape
            // 
            this.shape.Location = new System.Drawing.Point(-15, 0);
            this.shape.Name = "shape";
            this.shape.PolygonSkip = 1;
            this.shape.Rotate = 0F;
            this.shape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.shape.Size = new System.Drawing.Size(446, 139);
            this.shape.TabIndex = 40;
            this.shape.Text = "guna2Shapes1";
            this.shape.Zoom = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(586, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 25);
            this.label1.TabIndex = 41;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(683, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 41;
            this.label2.Text = "Calories";
            // 
            // UC_Calories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calGoalInput);
            this.Controls.Add(this.btnCalGoal);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAddCalories);
            this.Controls.Add(this.lblCalorieGoal);
            this.Controls.Add(this.listBoxCals);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.shape);
            this.Name = "UC_Calories";
            this.Size = new System.Drawing.Size(800, 351);
            this.Load += new System.EventHandler(this.UC_Calories_Load);
            this.Click += new System.EventHandler(this.UC_Calories_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.ListBox listBoxCals;
        private System.Windows.Forms.Label lblCalorieGoal;
        private Guna.UI2.WinForms.Guna2CircleButton btnAddCalories;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrev;
        private Guna.UI2.WinForms.Guna2CircleButton btnUp;
        private Guna.UI2.WinForms.Guna2CircleButton btnDown;
        private Guna.UI2.WinForms.Guna2GradientPanel panel;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Button btnCalGoal;
        private Guna.UI2.WinForms.Guna2Button calGoalInput;
        private Guna.UI2.WinForms.Guna2Shapes shape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
