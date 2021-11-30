
namespace DailyPlannerAppMarco.UserControls
{
    partial class UC_Home
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
            this.weekDays = new System.Windows.Forms.TableLayoutPanel();
            this.week7 = new System.Windows.Forms.Label();
            this.week6 = new System.Windows.Forms.Label();
            this.week5 = new System.Windows.Forms.Label();
            this.week4 = new System.Windows.Forms.Label();
            this.week3 = new System.Windows.Forms.Label();
            this.week2 = new System.Windows.Forms.Label();
            this.week1 = new System.Windows.Forms.Label();
            this.tasksNotDone = new System.Windows.Forms.ListBox();
            this.lblTasks = new System.Windows.Forms.Label();
            this.lblCalsRemaining = new System.Windows.Forms.Label();
            this.panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.shapeTask = new Guna.UI2.WinForms.Guna2Shapes();
            this.listBoxCals = new System.Windows.Forms.ListBox();
            this.shapeCals = new Guna.UI2.WinForms.Guna2Shapes();
            this.lblCalsLeft = new System.Windows.Forms.Label();
            this.lblWorkoutsLeft = new System.Windows.Forms.Label();
            this.listboxFitness = new System.Windows.Forms.ListBox();
            this.WorkoutsCount = new System.Windows.Forms.Label();
            this.shapeFitness = new Guna.UI2.WinForms.Guna2Shapes();
            this.tasksLeft = new System.Windows.Forms.Label();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.weekDays.SuspendLayout();
            this.SuspendLayout();
            // 
            // weekDays
            // 
            this.weekDays.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.weekDays.ColumnCount = 7;
            this.weekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.weekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.weekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.weekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.weekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.weekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.weekDays.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28572F));
            this.weekDays.Controls.Add(this.week7, 6, 0);
            this.weekDays.Controls.Add(this.week6, 5, 0);
            this.weekDays.Controls.Add(this.week5, 4, 0);
            this.weekDays.Controls.Add(this.week4, 3, 0);
            this.weekDays.Controls.Add(this.week3, 2, 0);
            this.weekDays.Controls.Add(this.week2, 1, 0);
            this.weekDays.Controls.Add(this.week1, 0, 0);
            this.weekDays.Location = new System.Drawing.Point(26, 193);
            this.weekDays.Name = "weekDays";
            this.weekDays.RowCount = 2;
            this.weekDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.weekDays.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.weekDays.Size = new System.Drawing.Size(755, 115);
            this.weekDays.TabIndex = 7;
            this.weekDays.MouseClick += new System.Windows.Forms.MouseEventHandler(this.weekDays_MouseClick);
            // 
            // week7
            // 
            this.week7.AutoSize = true;
            this.week7.Location = new System.Drawing.Point(647, 2);
            this.week7.Name = "week7";
            this.week7.Size = new System.Drawing.Size(35, 13);
            this.week7.TabIndex = 6;
            this.week7.Text = "label7";
            // 
            // week6
            // 
            this.week6.AutoSize = true;
            this.week6.Location = new System.Drawing.Point(540, 2);
            this.week6.Name = "week6";
            this.week6.Size = new System.Drawing.Size(35, 13);
            this.week6.TabIndex = 5;
            this.week6.Text = "label6";
            // 
            // week5
            // 
            this.week5.AutoSize = true;
            this.week5.Location = new System.Drawing.Point(433, 2);
            this.week5.Name = "week5";
            this.week5.Size = new System.Drawing.Size(35, 13);
            this.week5.TabIndex = 4;
            this.week5.Text = "label5";
            // 
            // week4
            // 
            this.week4.AutoSize = true;
            this.week4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.week4.Location = new System.Drawing.Point(326, 2);
            this.week4.Name = "week4";
            this.week4.Size = new System.Drawing.Size(41, 13);
            this.week4.TabIndex = 3;
            this.week4.Text = "label4";
            // 
            // week3
            // 
            this.week3.AutoSize = true;
            this.week3.Location = new System.Drawing.Point(219, 2);
            this.week3.Name = "week3";
            this.week3.Size = new System.Drawing.Size(35, 13);
            this.week3.TabIndex = 2;
            this.week3.Text = "label3";
            // 
            // week2
            // 
            this.week2.AutoSize = true;
            this.week2.Location = new System.Drawing.Point(112, 2);
            this.week2.Name = "week2";
            this.week2.Size = new System.Drawing.Size(35, 13);
            this.week2.TabIndex = 1;
            this.week2.Text = "label2";
            // 
            // week1
            // 
            this.week1.AutoSize = true;
            this.week1.Location = new System.Drawing.Point(5, 2);
            this.week1.Name = "week1";
            this.week1.Size = new System.Drawing.Size(35, 13);
            this.week1.TabIndex = 0;
            this.week1.Text = "label1";
            // 
            // tasksNotDone
            // 
            this.tasksNotDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksNotDone.FormattingEnabled = true;
            this.tasksNotDone.HorizontalScrollbar = true;
            this.tasksNotDone.ItemHeight = 20;
            this.tasksNotDone.Location = new System.Drawing.Point(30, 50);
            this.tasksNotDone.Name = "tasksNotDone";
            this.tasksNotDone.Size = new System.Drawing.Size(201, 84);
            this.tasksNotDone.TabIndex = 9;
            this.tasksNotDone.SelectedIndexChanged += new System.EventHandler(this.tasksNotDone_SelectedValueChanged);
            this.tasksNotDone.SelectedValueChanged += new System.EventHandler(this.tasksNotDone_SelectedValueChanged);
            this.tasksNotDone.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.tasksNotDone_MouseDoubleClick);
            // 
            // lblTasks
            // 
            this.lblTasks.AutoSize = true;
            this.lblTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTasks.Location = new System.Drawing.Point(93, 27);
            this.lblTasks.Name = "lblTasks";
            this.lblTasks.Size = new System.Drawing.Size(93, 20);
            this.lblTasks.TabIndex = 11;
            this.lblTasks.Text = "Tasks Left";
            // 
            // lblCalsRemaining
            // 
            this.lblCalsRemaining.AutoSize = true;
            this.lblCalsRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalsRemaining.Location = new System.Drawing.Point(368, 137);
            this.lblCalsRemaining.Name = "lblCalsRemaining";
            this.lblCalsRemaining.Size = new System.Drawing.Size(64, 25);
            this.lblCalsRemaining.TabIndex = 12;
            this.lblCalsRemaining.Text = "1000";
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(111, 329);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(689, 22);
            this.panel.TabIndex = 15;
            // 
            // shapeTask
            // 
            this.shapeTask.Location = new System.Drawing.Point(-4, -6);
            this.shapeTask.Name = "shapeTask";
            this.shapeTask.PolygonSkip = 1;
            this.shapeTask.Rotate = 0F;
            this.shapeTask.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.shapeTask.Size = new System.Drawing.Size(281, 200);
            this.shapeTask.TabIndex = 16;
            this.shapeTask.Text = "guna2Shapes1";
            this.shapeTask.Zoom = 80;
            // 
            // listBoxCals
            // 
            this.listBoxCals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCals.FormattingEnabled = true;
            this.listBoxCals.HorizontalScrollbar = true;
            this.listBoxCals.ItemHeight = 20;
            this.listBoxCals.Location = new System.Drawing.Point(300, 50);
            this.listBoxCals.Name = "listBoxCals";
            this.listBoxCals.Size = new System.Drawing.Size(201, 84);
            this.listBoxCals.TabIndex = 17;
            // 
            // shapeCals
            // 
            this.shapeCals.Location = new System.Drawing.Point(260, -6);
            this.shapeCals.Name = "shapeCals";
            this.shapeCals.PolygonSkip = 1;
            this.shapeCals.Rotate = 0F;
            this.shapeCals.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.shapeCals.Size = new System.Drawing.Size(281, 200);
            this.shapeCals.TabIndex = 18;
            this.shapeCals.Text = "guna2Shapes1";
            this.shapeCals.Zoom = 80;
            // 
            // lblCalsLeft
            // 
            this.lblCalsLeft.AutoSize = true;
            this.lblCalsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalsLeft.Location = new System.Drawing.Point(348, 27);
            this.lblCalsLeft.Name = "lblCalsLeft";
            this.lblCalsLeft.Size = new System.Drawing.Size(111, 20);
            this.lblCalsLeft.TabIndex = 19;
            this.lblCalsLeft.Text = "Calories Left";
            // 
            // lblWorkoutsLeft
            // 
            this.lblWorkoutsLeft.AutoSize = true;
            this.lblWorkoutsLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkoutsLeft.Location = new System.Drawing.Point(609, 27);
            this.lblWorkoutsLeft.Name = "lblWorkoutsLeft";
            this.lblWorkoutsLeft.Size = new System.Drawing.Size(122, 20);
            this.lblWorkoutsLeft.TabIndex = 23;
            this.lblWorkoutsLeft.Text = "Workouts Left";
            // 
            // listboxFitness
            // 
            this.listboxFitness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listboxFitness.FormattingEnabled = true;
            this.listboxFitness.HorizontalScrollbar = true;
            this.listboxFitness.ItemHeight = 20;
            this.listboxFitness.Location = new System.Drawing.Point(561, 50);
            this.listboxFitness.Name = "listboxFitness";
            this.listboxFitness.Size = new System.Drawing.Size(201, 84);
            this.listboxFitness.TabIndex = 21;
            // 
            // WorkoutsCount
            // 
            this.WorkoutsCount.AutoSize = true;
            this.WorkoutsCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkoutsCount.Location = new System.Drawing.Point(652, 137);
            this.WorkoutsCount.Name = "WorkoutsCount";
            this.WorkoutsCount.Size = new System.Drawing.Size(25, 25);
            this.WorkoutsCount.TabIndex = 20;
            this.WorkoutsCount.Text = "0";
            // 
            // shapeFitness
            // 
            this.shapeFitness.Location = new System.Drawing.Point(522, -6);
            this.shapeFitness.Name = "shapeFitness";
            this.shapeFitness.PolygonSkip = 1;
            this.shapeFitness.Rotate = 0F;
            this.shapeFitness.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.shapeFitness.Size = new System.Drawing.Size(281, 200);
            this.shapeFitness.TabIndex = 22;
            this.shapeFitness.Text = "guna2Shapes1";
            this.shapeFitness.Zoom = 80;
            // 
            // tasksLeft
            // 
            this.tasksLeft.AutoSize = true;
            this.tasksLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tasksLeft.Location = new System.Drawing.Point(122, 137);
            this.tasksLeft.Name = "tasksLeft";
            this.tasksLeft.Size = new System.Drawing.Size(25, 25);
            this.tasksLeft.TabIndex = 24;
            this.tasksLeft.Text = "0";
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
            this.btnPrev.Location = new System.Drawing.Point(3, 314);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrev.ShadowDecoration.Parent = this.btnPrev;
            this.btnPrev.Size = new System.Drawing.Size(33, 34);
            this.btnPrev.TabIndex = 55;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.tasksLeft);
            this.Controls.Add(this.lblWorkoutsLeft);
            this.Controls.Add(this.listboxFitness);
            this.Controls.Add(this.WorkoutsCount);
            this.Controls.Add(this.shapeFitness);
            this.Controls.Add(this.lblCalsLeft);
            this.Controls.Add(this.listBoxCals);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblCalsRemaining);
            this.Controls.Add(this.lblTasks);
            this.Controls.Add(this.tasksNotDone);
            this.Controls.Add(this.weekDays);
            this.Controls.Add(this.shapeTask);
            this.Controls.Add(this.shapeCals);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(800, 351);
            this.Click += new System.EventHandler(this.UC_Home_Click);
            this.weekDays.ResumeLayout(false);
            this.weekDays.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel weekDays;
        private System.Windows.Forms.Label week7;
        private System.Windows.Forms.Label week6;
        private System.Windows.Forms.Label week5;
        private System.Windows.Forms.Label week4;
        private System.Windows.Forms.Label week3;
        private System.Windows.Forms.Label week2;
        private System.Windows.Forms.Label week1;
        private System.Windows.Forms.ListBox tasksNotDone;
        private System.Windows.Forms.Label lblTasks;
        private System.Windows.Forms.Label lblCalsRemaining;
        private Guna.UI2.WinForms.Guna2GradientPanel panel;
        private Guna.UI2.WinForms.Guna2Shapes shapeTask;
        private System.Windows.Forms.ListBox listBoxCals;
        private Guna.UI2.WinForms.Guna2Shapes shapeCals;
        private System.Windows.Forms.Label lblCalsLeft;
        private System.Windows.Forms.Label lblWorkoutsLeft;
        private System.Windows.Forms.ListBox listboxFitness;
        private System.Windows.Forms.Label WorkoutsCount;
        private Guna.UI2.WinForms.Guna2Shapes shapeFitness;
        private System.Windows.Forms.Label tasksLeft;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrev;
    }
}
