
namespace DailyPlannerAppMarco.UserControls
{
    partial class UC_Fitness
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
            this.dayofWeek = new System.Windows.Forms.Label();
            this.listWorkouts = new System.Windows.Forms.ListBox();
            this.panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnStart = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddDay = new Guna.UI2.WinForms.Guna2Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblWed = new System.Windows.Forms.Label();
            this.lblThur = new System.Windows.Forms.Label();
            this.lblFri = new System.Windows.Forms.Label();
            this.lblMonday = new System.Windows.Forms.Label();
            this.lblTuesday = new System.Windows.Forms.Label();
            this.lblSat = new System.Windows.Forms.Label();
            this.lblMonName = new System.Windows.Forms.Label();
            this.lblTuesName = new System.Windows.Forms.Label();
            this.lblWedName = new System.Windows.Forms.Label();
            this.lblThurName = new System.Windows.Forms.Label();
            this.lblSun = new System.Windows.Forms.Label();
            this.lblFriName = new System.Windows.Forms.Label();
            this.lblSatName = new System.Windows.Forms.Label();
            this.lblSunName = new System.Windows.Forms.Label();
            this.shapeWeekday = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnCancelFilter = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrev = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnHistory = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDetails = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnUp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDown = new Guna.UI2.WinForms.Guna2CircleButton();
            this.monDelete = new Guna.UI2.WinForms.Guna2Button();
            this.tuesDelete = new Guna.UI2.WinForms.Guna2Button();
            this.wedDelete = new Guna.UI2.WinForms.Guna2Button();
            this.thurDelete = new Guna.UI2.WinForms.Guna2Button();
            this.friDelete = new Guna.UI2.WinForms.Guna2Button();
            this.satDelete = new Guna.UI2.WinForms.Guna2Button();
            this.sunDelete = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dayofWeek
            // 
            this.dayofWeek.AutoSize = true;
            this.dayofWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayofWeek.Location = new System.Drawing.Point(686, 314);
            this.dayofWeek.Name = "dayofWeek";
            this.dayofWeek.Size = new System.Drawing.Size(69, 16);
            this.dayofWeek.TabIndex = 19;
            this.dayofWeek.Text = "dayItsOn";
            // 
            // listWorkouts
            // 
            this.listWorkouts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.listWorkouts.FormattingEnabled = true;
            this.listWorkouts.ItemHeight = 25;
            this.listWorkouts.Location = new System.Drawing.Point(561, 15);
            this.listWorkouts.Name = "listWorkouts";
            this.listWorkouts.Size = new System.Drawing.Size(194, 254);
            this.listWorkouts.TabIndex = 25;
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(111, 329);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(689, 22);
            this.panel.TabIndex = 32;
            // 
            // btnStart
            // 
            this.btnStart.Animated = true;
            this.btnStart.AutoRoundedCorners = true;
            this.btnStart.BorderRadius = 21;
            this.btnStart.BorderThickness = 2;
            this.btnStart.CheckedState.Parent = this.btnStart;
            this.btnStart.CustomImages.Parent = this.btnStart;
            this.btnStart.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStart.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStart.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStart.DisabledState.Parent = this.btnStart;
            this.btnStart.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(84)))));
            this.btnStart.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.HoverState.Parent = this.btnStart;
            this.btnStart.Location = new System.Drawing.Point(25, 275);
            this.btnStart.Name = "btnStart";
            this.btnStart.ShadowDecoration.Parent = this.btnStart;
            this.btnStart.Size = new System.Drawing.Size(237, 45);
            this.btnStart.TabIndex = 37;
            this.btnStart.Text = "Start Workout";
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnAddDay
            // 
            this.btnAddDay.Animated = true;
            this.btnAddDay.AutoRoundedCorners = true;
            this.btnAddDay.BorderRadius = 14;
            this.btnAddDay.BorderThickness = 2;
            this.btnAddDay.CheckedState.Parent = this.btnAddDay;
            this.btnAddDay.CustomImages.Parent = this.btnAddDay;
            this.btnAddDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddDay.DisabledState.Parent = this.btnAddDay;
            this.btnAddDay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(179)))), ((int)(((byte)(84)))));
            this.btnAddDay.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnAddDay.ForeColor = System.Drawing.Color.White;
            this.btnAddDay.HoverState.Parent = this.btnAddDay;
            this.btnAddDay.Location = new System.Drawing.Point(268, 290);
            this.btnAddDay.Name = "btnAddDay";
            this.btnAddDay.ShadowDecoration.Parent = this.btnAddDay;
            this.btnAddDay.Size = new System.Drawing.Size(152, 30);
            this.btnAddDay.TabIndex = 38;
            this.btnAddDay.Text = "Add Workout Day";
            this.btnAddDay.Click += new System.EventHandler(this.btnAddDay_Click);
            // 
            // cbFilter
            // 
            this.cbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbFilter.BorderThickness = 3;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbFilter.FocusedState.Parent = this.cbFilter;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.cbFilter.ForeColor = System.Drawing.Color.Black;
            this.cbFilter.HoverState.Parent = this.cbFilter;
            this.cbFilter.ItemHeight = 30;
            this.cbFilter.ItemsAppearance.Parent = this.cbFilter;
            this.cbFilter.Location = new System.Drawing.Point(622, 275);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.ShadowDecoration.Parent = this.cbFilter;
            this.cbFilter.Size = new System.Drawing.Size(133, 36);
            this.cbFilter.TabIndex = 39;
            this.toolTip1.SetToolTip(this.cbFilter, "Filter");
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel1.Controls.Add(this.lblWed, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblThur, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblFri, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblMonday, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTuesday, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSat, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMonName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTuesName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblWedName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblThurName, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblSun, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblFriName, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblSatName, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblSunName, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(34, 29);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 225);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // lblWed
            // 
            this.lblWed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWed.AutoSize = true;
            this.lblWed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWed.Location = new System.Drawing.Point(6, 102);
            this.lblWed.Name = "lblWed";
            this.lblWed.Size = new System.Drawing.Size(102, 20);
            this.lblWed.TabIndex = 0;
            this.lblWed.Text = "Wednesday";
            // 
            // lblThur
            // 
            this.lblThur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThur.AutoSize = true;
            this.lblThur.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThur.Location = new System.Drawing.Point(16, 134);
            this.lblThur.Name = "lblThur";
            this.lblThur.Size = new System.Drawing.Size(82, 20);
            this.lblThur.TabIndex = 0;
            this.lblThur.Text = "Thursday";
            // 
            // lblFri
            // 
            this.lblFri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFri.AutoSize = true;
            this.lblFri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFri.Location = new System.Drawing.Point(28, 166);
            this.lblFri.Name = "lblFri";
            this.lblFri.Size = new System.Drawing.Size(58, 20);
            this.lblFri.TabIndex = 0;
            this.lblFri.Text = "Friday";
            // 
            // lblMonday
            // 
            this.lblMonday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonday.AutoSize = true;
            this.lblMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonday.Location = new System.Drawing.Point(22, 38);
            this.lblMonday.Name = "lblMonday";
            this.lblMonday.Size = new System.Drawing.Size(71, 20);
            this.lblMonday.TabIndex = 0;
            this.lblMonday.Text = "Monday";
            // 
            // lblTuesday
            // 
            this.lblTuesday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTuesday.AutoSize = true;
            this.lblTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesday.Location = new System.Drawing.Point(19, 70);
            this.lblTuesday.Name = "lblTuesday";
            this.lblTuesday.Size = new System.Drawing.Size(76, 20);
            this.lblTuesday.TabIndex = 0;
            this.lblTuesday.Text = "Tuesday";
            // 
            // lblSat
            // 
            this.lblSat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSat.AutoSize = true;
            this.lblSat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSat.Location = new System.Drawing.Point(17, 198);
            this.lblSat.Name = "lblSat";
            this.lblSat.Size = new System.Drawing.Size(81, 20);
            this.lblSat.TabIndex = 0;
            this.lblSat.Text = "Saturday";
            // 
            // lblMonName
            // 
            this.lblMonName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMonName.AutoSize = true;
            this.lblMonName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonName.Location = new System.Drawing.Point(246, 6);
            this.lblMonName.Name = "lblMonName";
            this.lblMonName.Size = new System.Drawing.Size(0, 20);
            this.lblMonName.TabIndex = 0;
            // 
            // lblTuesName
            // 
            this.lblTuesName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTuesName.AutoSize = true;
            this.lblTuesName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTuesName.Location = new System.Drawing.Point(246, 38);
            this.lblTuesName.Name = "lblTuesName";
            this.lblTuesName.Size = new System.Drawing.Size(0, 20);
            this.lblTuesName.TabIndex = 0;
            // 
            // lblWedName
            // 
            this.lblWedName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWedName.AutoSize = true;
            this.lblWedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWedName.Location = new System.Drawing.Point(246, 70);
            this.lblWedName.Name = "lblWedName";
            this.lblWedName.Size = new System.Drawing.Size(0, 20);
            this.lblWedName.TabIndex = 0;
            // 
            // lblThurName
            // 
            this.lblThurName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblThurName.AutoSize = true;
            this.lblThurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThurName.Location = new System.Drawing.Point(246, 102);
            this.lblThurName.Name = "lblThurName";
            this.lblThurName.Size = new System.Drawing.Size(0, 20);
            this.lblThurName.TabIndex = 0;
            // 
            // lblSun
            // 
            this.lblSun.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSun.AutoSize = true;
            this.lblSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSun.Location = new System.Drawing.Point(23, 6);
            this.lblSun.Name = "lblSun";
            this.lblSun.Size = new System.Drawing.Size(69, 20);
            this.lblSun.TabIndex = 0;
            this.lblSun.Text = "Sunday";
            // 
            // lblFriName
            // 
            this.lblFriName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFriName.AutoSize = true;
            this.lblFriName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriName.Location = new System.Drawing.Point(246, 134);
            this.lblFriName.Name = "lblFriName";
            this.lblFriName.Size = new System.Drawing.Size(0, 20);
            this.lblFriName.TabIndex = 0;
            // 
            // lblSatName
            // 
            this.lblSatName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSatName.AutoSize = true;
            this.lblSatName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatName.Location = new System.Drawing.Point(246, 166);
            this.lblSatName.Name = "lblSatName";
            this.lblSatName.Size = new System.Drawing.Size(0, 20);
            this.lblSatName.TabIndex = 0;
            // 
            // lblSunName
            // 
            this.lblSunName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSunName.AutoSize = true;
            this.lblSunName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSunName.Location = new System.Drawing.Point(246, 198);
            this.lblSunName.Name = "lblSunName";
            this.lblSunName.Size = new System.Drawing.Size(0, 20);
            this.lblSunName.TabIndex = 0;
            // 
            // shapeWeekday
            // 
            this.shapeWeekday.Location = new System.Drawing.Point(-24, -13);
            this.shapeWeekday.Name = "shapeWeekday";
            this.shapeWeekday.PolygonSkip = 1;
            this.shapeWeekday.Rotate = 0F;
            this.shapeWeekday.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.shapeWeekday.Size = new System.Drawing.Size(496, 311);
            this.shapeWeekday.TabIndex = 42;
            this.shapeWeekday.Text = "guna2Shapes1";
            this.shapeWeekday.Zoom = 80;
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.Animated = true;
            this.btnCancelFilter.BorderColor = System.Drawing.Color.Aqua;
            this.btnCancelFilter.BorderRadius = 10;
            this.btnCancelFilter.CheckedState.Parent = this.btnCancelFilter;
            this.btnCancelFilter.CustomImages.Parent = this.btnCancelFilter;
            this.btnCancelFilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelFilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancelFilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancelFilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancelFilter.DisabledState.Parent = this.btnCancelFilter;
            this.btnCancelFilter.FillColor = System.Drawing.Color.Black;
            this.btnCancelFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelFilter.ForeColor = System.Drawing.Color.White;
            this.btnCancelFilter.HoverState.Parent = this.btnCancelFilter;
            this.btnCancelFilter.Image = global::DailyPlannerAppMarco.Properties.Resources.exitIconSmall;
            this.btnCancelFilter.Location = new System.Drawing.Point(597, 283);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.ShadowDecoration.Parent = this.btnCancelFilter;
            this.btnCancelFilter.Size = new System.Drawing.Size(19, 19);
            this.btnCancelFilter.TabIndex = 40;
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
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
            this.btnPrev.Location = new System.Drawing.Point(761, 163);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnPrev.ShadowDecoration.Parent = this.btnPrev;
            this.btnPrev.Size = new System.Drawing.Size(33, 34);
            this.btnPrev.TabIndex = 36;
            this.toolTip1.SetToolTip(this.btnPrev, "Views previous workout times");
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnHistory.BorderColor = System.Drawing.Color.Transparent;
            this.btnHistory.CheckedState.Parent = this.btnHistory;
            this.btnHistory.CustomImages.Parent = this.btnHistory;
            this.btnHistory.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistory.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistory.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistory.DisabledState.Parent = this.btnHistory;
            this.btnHistory.FillColor = System.Drawing.Color.Transparent;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHistory.ForeColor = System.Drawing.Color.Transparent;
            this.btnHistory.HoverState.Parent = this.btnHistory;
            this.btnHistory.Image = global::DailyPlannerAppMarco.Properties.Resources.recycleBin;
            this.btnHistory.ImageSize = new System.Drawing.Size(34, 34);
            this.btnHistory.Location = new System.Drawing.Point(761, 224);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHistory.ShadowDecoration.Parent = this.btnHistory;
            this.btnHistory.Size = new System.Drawing.Size(33, 34);
            this.btnHistory.TabIndex = 35;
            this.toolTip1.SetToolTip(this.btnHistory, "Recycle bin");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnDetails.BorderColor = System.Drawing.Color.Transparent;
            this.btnDetails.CheckedState.Parent = this.btnDetails;
            this.btnDetails.CustomImages.Parent = this.btnDetails;
            this.btnDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDetails.DisabledState.Parent = this.btnDetails;
            this.btnDetails.FillColor = System.Drawing.Color.Transparent;
            this.btnDetails.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDetails.ForeColor = System.Drawing.Color.Transparent;
            this.btnDetails.HoverState.Parent = this.btnDetails;
            this.btnDetails.Image = global::DailyPlannerAppMarco.Properties.Resources.magnifyGlassIcon;
            this.btnDetails.ImageSize = new System.Drawing.Size(33, 33);
            this.btnDetails.Location = new System.Drawing.Point(758, 102);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDetails.ShadowDecoration.Parent = this.btnDetails;
            this.btnDetails.Size = new System.Drawing.Size(36, 34);
            this.btnDetails.TabIndex = 34;
            this.toolTip1.SetToolTip(this.btnDetails, "View selected workout");
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BorderColor = System.Drawing.Color.Transparent;
            this.btnEdit.CheckedState.Parent = this.btnEdit;
            this.btnEdit.CustomImages.Parent = this.btnEdit;
            this.btnEdit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEdit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEdit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEdit.DisabledState.Parent = this.btnEdit;
            this.btnEdit.FillColor = System.Drawing.Color.Transparent;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.HoverState.Parent = this.btnEdit;
            this.btnEdit.Image = global::DailyPlannerAppMarco.Properties.Resources.EditIcon;
            this.btnEdit.ImageSize = new System.Drawing.Size(34, 34);
            this.btnEdit.Location = new System.Drawing.Point(761, 44);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(33, 34);
            this.btnEdit.TabIndex = 33;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit selected workout");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDelete.TabIndex = 31;
            this.toolTip1.SetToolTip(this.btnDelete, "Deletes selected workout");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnAdd.TabIndex = 30;
            this.toolTip1.SetToolTip(this.btnAdd, "Adds a workout");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnUp.TabIndex = 29;
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
            this.btnDown.TabIndex = 28;
            this.toolTip1.SetToolTip(this.btnDown, "Move item down list");
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // monDelete
            // 
            this.monDelete.Animated = true;
            this.monDelete.BorderColor = System.Drawing.Color.Aqua;
            this.monDelete.BorderRadius = 10;
            this.monDelete.CheckedState.Parent = this.monDelete;
            this.monDelete.CustomImages.Parent = this.monDelete;
            this.monDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.monDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.monDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.monDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.monDelete.DisabledState.Parent = this.monDelete;
            this.monDelete.FillColor = System.Drawing.Color.Black;
            this.monDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.monDelete.ForeColor = System.Drawing.Color.White;
            this.monDelete.HoverState.Parent = this.monDelete;
            this.monDelete.Image = global::DailyPlannerAppMarco.Properties.Resources.exitIconSmall;
            this.monDelete.Location = new System.Drawing.Point(422, 36);
            this.monDelete.Name = "monDelete";
            this.monDelete.ShadowDecoration.Parent = this.monDelete;
            this.monDelete.Size = new System.Drawing.Size(19, 19);
            this.monDelete.TabIndex = 43;
            this.monDelete.Click += new System.EventHandler(this.monDelete_Click);
            // 
            // tuesDelete
            // 
            this.tuesDelete.Animated = true;
            this.tuesDelete.BorderColor = System.Drawing.Color.Aqua;
            this.tuesDelete.BorderRadius = 10;
            this.tuesDelete.CheckedState.Parent = this.tuesDelete;
            this.tuesDelete.CustomImages.Parent = this.tuesDelete;
            this.tuesDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tuesDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tuesDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tuesDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tuesDelete.DisabledState.Parent = this.tuesDelete;
            this.tuesDelete.FillColor = System.Drawing.Color.Black;
            this.tuesDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tuesDelete.ForeColor = System.Drawing.Color.White;
            this.tuesDelete.HoverState.Parent = this.tuesDelete;
            this.tuesDelete.Image = global::DailyPlannerAppMarco.Properties.Resources.exitIconSmall;
            this.tuesDelete.Location = new System.Drawing.Point(422, 68);
            this.tuesDelete.Name = "tuesDelete";
            this.tuesDelete.ShadowDecoration.Parent = this.tuesDelete;
            this.tuesDelete.Size = new System.Drawing.Size(19, 19);
            this.tuesDelete.TabIndex = 44;
            this.tuesDelete.Click += new System.EventHandler(this.tuesDelete_Click);
            // 
            // wedDelete
            // 
            this.wedDelete.Animated = true;
            this.wedDelete.BorderColor = System.Drawing.Color.Aqua;
            this.wedDelete.BorderRadius = 10;
            this.wedDelete.CheckedState.Parent = this.wedDelete;
            this.wedDelete.CustomImages.Parent = this.wedDelete;
            this.wedDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.wedDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.wedDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.wedDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.wedDelete.DisabledState.Parent = this.wedDelete;
            this.wedDelete.FillColor = System.Drawing.Color.Black;
            this.wedDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.wedDelete.ForeColor = System.Drawing.Color.White;
            this.wedDelete.HoverState.Parent = this.wedDelete;
            this.wedDelete.Image = global::DailyPlannerAppMarco.Properties.Resources.exitIconSmall;
            this.wedDelete.Location = new System.Drawing.Point(422, 102);
            this.wedDelete.Name = "wedDelete";
            this.wedDelete.ShadowDecoration.Parent = this.wedDelete;
            this.wedDelete.Size = new System.Drawing.Size(19, 19);
            this.wedDelete.TabIndex = 45;
            this.wedDelete.Click += new System.EventHandler(this.wedDelete_Click);
            // 
            // thurDelete
            // 
            this.thurDelete.Animated = true;
            this.thurDelete.BorderColor = System.Drawing.Color.Aqua;
            this.thurDelete.BorderRadius = 10;
            this.thurDelete.CheckedState.Parent = this.thurDelete;
            this.thurDelete.CustomImages.Parent = this.thurDelete;
            this.thurDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.thurDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.thurDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.thurDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.thurDelete.DisabledState.Parent = this.thurDelete;
            this.thurDelete.FillColor = System.Drawing.Color.Black;
            this.thurDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.thurDelete.ForeColor = System.Drawing.Color.White;
            this.thurDelete.HoverState.Parent = this.thurDelete;
            this.thurDelete.Image = global::DailyPlannerAppMarco.Properties.Resources.exitIconSmall;
            this.thurDelete.Location = new System.Drawing.Point(422, 132);
            this.thurDelete.Name = "thurDelete";
            this.thurDelete.ShadowDecoration.Parent = this.thurDelete;
            this.thurDelete.Size = new System.Drawing.Size(19, 19);
            this.thurDelete.TabIndex = 46;
            this.thurDelete.Click += new System.EventHandler(this.thurDelete_Click);
            // 
            // friDelete
            // 
            this.friDelete.Animated = true;
            this.friDelete.BorderColor = System.Drawing.Color.Aqua;
            this.friDelete.BorderRadius = 10;
            this.friDelete.CheckedState.Parent = this.friDelete;
            this.friDelete.CustomImages.Parent = this.friDelete;
            this.friDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.friDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.friDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.friDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.friDelete.DisabledState.Parent = this.friDelete;
            this.friDelete.FillColor = System.Drawing.Color.Black;
            this.friDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.friDelete.ForeColor = System.Drawing.Color.White;
            this.friDelete.HoverState.Parent = this.friDelete;
            this.friDelete.Image = global::DailyPlannerAppMarco.Properties.Resources.exitIconSmall;
            this.friDelete.Location = new System.Drawing.Point(422, 164);
            this.friDelete.Name = "friDelete";
            this.friDelete.ShadowDecoration.Parent = this.friDelete;
            this.friDelete.Size = new System.Drawing.Size(19, 19);
            this.friDelete.TabIndex = 47;
            this.friDelete.Click += new System.EventHandler(this.friDelete_Click);
            // 
            // satDelete
            // 
            this.satDelete.Animated = true;
            this.satDelete.BorderColor = System.Drawing.Color.Aqua;
            this.satDelete.BorderRadius = 10;
            this.satDelete.CheckedState.Parent = this.satDelete;
            this.satDelete.CustomImages.Parent = this.satDelete;
            this.satDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.satDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.satDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.satDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.satDelete.DisabledState.Parent = this.satDelete;
            this.satDelete.FillColor = System.Drawing.Color.Black;
            this.satDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.satDelete.ForeColor = System.Drawing.Color.White;
            this.satDelete.HoverState.Parent = this.satDelete;
            this.satDelete.Image = global::DailyPlannerAppMarco.Properties.Resources.exitIconSmall;
            this.satDelete.Location = new System.Drawing.Point(422, 196);
            this.satDelete.Name = "satDelete";
            this.satDelete.ShadowDecoration.Parent = this.satDelete;
            this.satDelete.Size = new System.Drawing.Size(19, 19);
            this.satDelete.TabIndex = 48;
            this.satDelete.Click += new System.EventHandler(this.satDelete_Click);
            // 
            // sunDelete
            // 
            this.sunDelete.Animated = true;
            this.sunDelete.BorderColor = System.Drawing.Color.Aqua;
            this.sunDelete.BorderRadius = 10;
            this.sunDelete.CheckedState.Parent = this.sunDelete;
            this.sunDelete.CustomImages.Parent = this.sunDelete;
            this.sunDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.sunDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.sunDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.sunDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.sunDelete.DisabledState.Parent = this.sunDelete;
            this.sunDelete.FillColor = System.Drawing.Color.Black;
            this.sunDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.sunDelete.ForeColor = System.Drawing.Color.White;
            this.sunDelete.HoverState.Parent = this.sunDelete;
            this.sunDelete.Image = global::DailyPlannerAppMarco.Properties.Resources.exitIconSmall;
            this.sunDelete.Location = new System.Drawing.Point(422, 228);
            this.sunDelete.Name = "sunDelete";
            this.sunDelete.ShadowDecoration.Parent = this.sunDelete;
            this.sunDelete.Size = new System.Drawing.Size(19, 19);
            this.sunDelete.TabIndex = 49;
            this.sunDelete.Click += new System.EventHandler(this.sunDelete_Click);
            // 
            // UC_Fitness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sunDelete);
            this.Controls.Add(this.satDelete);
            this.Controls.Add(this.friDelete);
            this.Controls.Add(this.thurDelete);
            this.Controls.Add(this.wedDelete);
            this.Controls.Add(this.tuesDelete);
            this.Controls.Add(this.monDelete);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCancelFilter);
            this.Controls.Add(this.cbFilter);
            this.Controls.Add(this.btnAddDay);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.listWorkouts);
            this.Controls.Add(this.dayofWeek);
            this.Controls.Add(this.shapeWeekday);
            this.Name = "UC_Fitness";
            this.Size = new System.Drawing.Size(800, 351);
            this.Load += new System.EventHandler(this.UC_Fitness_Load);
            this.Click += new System.EventHandler(this.UC_Fitness_Click);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dayofWeek;
        private System.Windows.Forms.ListBox listWorkouts;
        private Guna.UI2.WinForms.Guna2CircleButton btnUp;
        private Guna.UI2.WinForms.Guna2CircleButton btnDown;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2GradientPanel panel;
        private Guna.UI2.WinForms.Guna2CircleButton btnEdit;
        private Guna.UI2.WinForms.Guna2CircleButton btnDetails;
        private Guna.UI2.WinForms.Guna2CircleButton btnHistory;
        private Guna.UI2.WinForms.Guna2CircleButton btnPrev;
        private Guna.UI2.WinForms.Guna2Button btnStart;
        private Guna.UI2.WinForms.Guna2Button btnAddDay;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2ComboBox cbFilter;
        private Guna.UI2.WinForms.Guna2Button btnCancelFilter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblMonday;
        private System.Windows.Forms.Label lblTuesday;
        private System.Windows.Forms.Label lblWed;
        private System.Windows.Forms.Label lblThur;
        private System.Windows.Forms.Label lblFri;
        private System.Windows.Forms.Label lblSat;
        private System.Windows.Forms.Label lblSun;
        private Guna.UI2.WinForms.Guna2Shapes shapeWeekday;
        private System.Windows.Forms.Label lblMonName;
        private System.Windows.Forms.Label lblTuesName;
        private System.Windows.Forms.Label lblWedName;
        private System.Windows.Forms.Label lblThurName;
        private System.Windows.Forms.Label lblFriName;
        private System.Windows.Forms.Label lblSatName;
        private System.Windows.Forms.Label lblSunName;
        private Guna.UI2.WinForms.Guna2Button monDelete;
        private Guna.UI2.WinForms.Guna2Button tuesDelete;
        private Guna.UI2.WinForms.Guna2Button wedDelete;
        private Guna.UI2.WinForms.Guna2Button thurDelete;
        private Guna.UI2.WinForms.Guna2Button friDelete;
        private Guna.UI2.WinForms.Guna2Button satDelete;
        private Guna.UI2.WinForms.Guna2Button sunDelete;
    }
}
