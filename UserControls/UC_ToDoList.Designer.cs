
namespace DailyPlannerAppMarco.UserControls
{
    partial class UC_ToDoList
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
            this.listBox = new System.Windows.Forms.CheckedListBox();
            this.panel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnAdd = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnEdit = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDetails = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnHistory = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnUp = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnDown = new Guna.UI2.WinForms.Guna2CircleButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cGroup = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnCancelFilter = new Guna.UI2.WinForms.Guna2Button();
            this.lbNotifications = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.Window;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(552, 19);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(194, 264);
            this.listBox.TabIndex = 2;
            this.listBox.Leave += new System.EventHandler(this.listBox_Leave);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(111, 329);
            this.panel.Name = "panel";
            this.panel.ShadowDecoration.Parent = this.panel;
            this.panel.Size = new System.Drawing.Size(689, 22);
            this.panel.TabIndex = 14;
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
            this.btnDelete.Location = new System.Drawing.Point(513, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(33, 34);
            this.btnDelete.TabIndex = 23;
            this.toolTip1.SetToolTip(this.btnDelete, "Deletes selected item");
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
            this.btnAdd.Location = new System.Drawing.Point(513, 174);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(33, 34);
            this.btnAdd.TabIndex = 22;
            this.toolTip1.SetToolTip(this.btnAdd, "Adds an item");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnEdit.Location = new System.Drawing.Point(752, 44);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnEdit.ShadowDecoration.Parent = this.btnEdit;
            this.btnEdit.Size = new System.Drawing.Size(33, 34);
            this.btnEdit.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnEdit, "Edits selected item");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
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
            this.btnDetails.Location = new System.Drawing.Point(752, 132);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDetails.ShadowDecoration.Parent = this.btnDetails;
            this.btnDetails.Size = new System.Drawing.Size(36, 34);
            this.btnDetails.TabIndex = 20;
            this.toolTip1.SetToolTip(this.btnDetails, "View selected item");
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
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
            this.btnHistory.Location = new System.Drawing.Point(752, 224);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnHistory.ShadowDecoration.Parent = this.btnHistory;
            this.btnHistory.Size = new System.Drawing.Size(33, 34);
            this.btnHistory.TabIndex = 19;
            this.toolTip1.SetToolTip(this.btnHistory, "View deleted items");
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
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
            this.btnUp.Location = new System.Drawing.Point(513, 44);
            this.btnUp.Name = "btnUp";
            this.btnUp.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnUp.ShadowDecoration.Parent = this.btnUp;
            this.btnUp.Size = new System.Drawing.Size(33, 34);
            this.btnUp.TabIndex = 18;
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
            this.btnDown.Location = new System.Drawing.Point(513, 94);
            this.btnDown.Name = "btnDown";
            this.btnDown.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDown.ShadowDecoration.Parent = this.btnDown;
            this.btnDown.Size = new System.Drawing.Size(33, 34);
            this.btnDown.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btnDown, "Move item down list");
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // cGroup
            // 
            this.cGroup.BackColor = System.Drawing.Color.Transparent;
            this.cGroup.BorderThickness = 3;
            this.cGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cGroup.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cGroup.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cGroup.FocusedState.Parent = this.cGroup;
            this.cGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic);
            this.cGroup.ForeColor = System.Drawing.Color.Black;
            this.cGroup.HoverState.Parent = this.cGroup;
            this.cGroup.ItemHeight = 30;
            this.cGroup.ItemsAppearance.Parent = this.cGroup;
            this.cGroup.Location = new System.Drawing.Point(552, 287);
            this.cGroup.Name = "cGroup";
            this.cGroup.ShadowDecoration.Parent = this.cGroup;
            this.cGroup.Size = new System.Drawing.Size(194, 36);
            this.cGroup.TabIndex = 26;
            this.toolTip1.SetToolTip(this.cGroup, "Filter");
            this.cGroup.SelectedIndexChanged += new System.EventHandler(this.cGroup_SelectedIndexChanged);
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
            this.btnCancelFilter.Location = new System.Drawing.Point(527, 289);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.ShadowDecoration.Parent = this.btnCancelFilter;
            this.btnCancelFilter.Size = new System.Drawing.Size(19, 19);
            this.btnCancelFilter.TabIndex = 27;
            this.btnCancelFilter.Click += new System.EventHandler(this.btnCancelFilter_Click);
            // 
            // lbNotifications
            // 
            this.lbNotifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotifications.FormattingEnabled = true;
            this.lbNotifications.ItemHeight = 16;
            this.lbNotifications.Location = new System.Drawing.Point(17, 19);
            this.lbNotifications.Name = "lbNotifications";
            this.lbNotifications.Size = new System.Drawing.Size(468, 116);
            this.lbNotifications.TabIndex = 28;
            // 
            // UC_ToDoList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbNotifications);
            this.Controls.Add(this.btnCancelFilter);
            this.Controls.Add(this.cGroup);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.listBox);
            this.Name = "UC_ToDoList";
            this.Size = new System.Drawing.Size(800, 351);
            this.Load += new System.EventHandler(this.UC_ToDoList_Load);
            this.Click += new System.EventHandler(this.UC_ToDoList_Click);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckedListBox listBox;
        private Guna.UI2.WinForms.Guna2GradientPanel panel;
        private Guna.UI2.WinForms.Guna2CircleButton btnDown;
        private Guna.UI2.WinForms.Guna2CircleButton btnUp;
        private Guna.UI2.WinForms.Guna2CircleButton btnHistory;
        private Guna.UI2.WinForms.Guna2CircleButton btnDetails;
        private Guna.UI2.WinForms.Guna2CircleButton btnEdit;
        private Guna.UI2.WinForms.Guna2CircleButton btnAdd;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2ComboBox cGroup;
        private Guna.UI2.WinForms.Guna2Button btnCancelFilter;
        private System.Windows.Forms.ListBox lbNotifications;
    }
}
