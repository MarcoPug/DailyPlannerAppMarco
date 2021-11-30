
namespace DailyPlannerAppMarco.AddItemForms
{
    partial class AddFitnessItem
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNameWorkout = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSetsReps = new System.Windows.Forms.CheckBox();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.txtSets = new System.Windows.Forms.TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.workoutDay = new System.Windows.Forms.ComboBox();
            this.onWhatWeekday = new System.Windows.Forms.ComboBox();
            this.shape = new Guna.UI2.WinForms.Guna2Shapes();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "on what Workout Day?";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(225, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 20);
            this.label1.TabIndex = 36;
            this.label1.Text = "Name of Workout?";
            // 
            // txtNameWorkout
            // 
            this.txtNameWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameWorkout.Location = new System.Drawing.Point(225, 202);
            this.txtNameWorkout.Name = "txtNameWorkout";
            this.txtNameWorkout.Size = new System.Drawing.Size(100, 26);
            this.txtNameWorkout.TabIndex = 45;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "on what Weekday?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 20);
            this.label3.TabIndex = 46;
            this.label3.Text = "Name of Workout Day";
            // 
            // cbSetsReps
            // 
            this.cbSetsReps.AutoSize = true;
            this.cbSetsReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSetsReps.Location = new System.Drawing.Point(33, 135);
            this.cbSetsReps.Name = "cbSetsReps";
            this.cbSetsReps.Size = new System.Drawing.Size(157, 24);
            this.cbSetsReps.TabIndex = 50;
            this.cbSetsReps.Text = "Sets and Reps?";
            this.cbSetsReps.UseVisualStyleBackColor = true;
            this.cbSetsReps.CheckedChanged += new System.EventHandler(this.cbSetsReps_CheckedChanged);
            // 
            // txtReps
            // 
            this.txtReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReps.Location = new System.Drawing.Point(282, 133);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(51, 26);
            this.txtReps.TabIndex = 51;
            // 
            // txtSets
            // 
            this.txtSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSets.Location = new System.Drawing.Point(225, 133);
            this.txtSets.Name = "txtSets";
            this.txtSets.Size = new System.Drawing.Size(51, 26);
            this.txtSets.TabIndex = 52;
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
            this.btnAdd.Location = new System.Drawing.Point(69, 304);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ShadowDecoration.Parent = this.btnAdd;
            this.btnAdd.Size = new System.Drawing.Size(237, 45);
            this.btnAdd.TabIndex = 53;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // workoutDay
            // 
            this.workoutDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workoutDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workoutDay.FormattingEnabled = true;
            this.workoutDay.Location = new System.Drawing.Point(225, 84);
            this.workoutDay.Name = "workoutDay";
            this.workoutDay.Size = new System.Drawing.Size(121, 28);
            this.workoutDay.TabIndex = 43;
            // 
            // onWhatWeekday
            // 
            this.onWhatWeekday.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.onWhatWeekday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onWhatWeekday.FormattingEnabled = true;
            this.onWhatWeekday.Items.AddRange(new object[] {
            "Sunday",
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday"});
            this.onWhatWeekday.Location = new System.Drawing.Point(225, 261);
            this.onWhatWeekday.Name = "onWhatWeekday";
            this.onWhatWeekday.Size = new System.Drawing.Size(100, 28);
            this.onWhatWeekday.TabIndex = 44;
            // 
            // shape
            // 
            this.shape.FillColor = System.Drawing.Color.DarkGray;
            this.shape.Location = new System.Drawing.Point(-47, -47);
            this.shape.Name = "shape";
            this.shape.PolygonSkip = 1;
            this.shape.Rotate = 0F;
            this.shape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.shape.Size = new System.Drawing.Size(468, 466);
            this.shape.TabIndex = 58;
            this.shape.Text = "guna2Shapes1";
            this.shape.Zoom = 80;
            // 
            // AddFitnessItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 372);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSets);
            this.Controls.Add(this.txtReps);
            this.Controls.Add(this.cbSetsReps);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameWorkout);
            this.Controls.Add(this.onWhatWeekday);
            this.Controls.Add(this.workoutDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddFitnessItem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Workout";
            this.Load += new System.EventHandler(this.AddFitnessItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNameWorkout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbSetsReps;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.TextBox txtSets;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private System.Windows.Forms.ComboBox workoutDay;
        private System.Windows.Forms.ComboBox onWhatWeekday;
        private Guna.UI2.WinForms.Guna2Shapes shape;
    }
}