
namespace DailyPlannerAppMarco.HistoryForms
{
    partial class HomePrev
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
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblMonthCalTotal = new System.Windows.Forms.Label();
            this.lblAvgSleep = new System.Windows.Forms.Label();
            this.avgWorkoutTime = new System.Windows.Forms.Label();
            this.shape = new Guna.UI2.WinForms.Guna2Shapes();
            this.btnLeft = new Guna.UI2.WinForms.Guna2CircleButton();
            this.btnRight = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.White;
            this.txtDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtDate.Location = new System.Drawing.Point(91, 8);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(244, 31);
            this.txtDate.TabIndex = 12;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMonthCalTotal
            // 
            this.lblMonthCalTotal.AutoSize = true;
            this.lblMonthCalTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthCalTotal.Location = new System.Drawing.Point(12, 62);
            this.lblMonthCalTotal.Name = "lblMonthCalTotal";
            this.lblMonthCalTotal.Size = new System.Drawing.Size(186, 20);
            this.lblMonthCalTotal.TabIndex = 13;
            this.lblMonthCalTotal.Text = "Average cals per day: ";
            // 
            // lblAvgSleep
            // 
            this.lblAvgSleep.AutoSize = true;
            this.lblAvgSleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvgSleep.Location = new System.Drawing.Point(12, 101);
            this.lblAvgSleep.Name = "lblAvgSleep";
            this.lblAvgSleep.Size = new System.Drawing.Size(284, 20);
            this.lblAvgSleep.TabIndex = 14;
            this.lblAvgSleep.Text = "Most common time woken up at is:";
            // 
            // avgWorkoutTime
            // 
            this.avgWorkoutTime.AutoSize = true;
            this.avgWorkoutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgWorkoutTime.Location = new System.Drawing.Point(12, 140);
            this.avgWorkoutTime.Name = "avgWorkoutTime";
            this.avgWorkoutTime.Size = new System.Drawing.Size(293, 20);
            this.avgWorkoutTime.TabIndex = 15;
            this.avgWorkoutTime.Text = "Time spent working out this month: ";
            // 
            // shape
            // 
            this.shape.Location = new System.Drawing.Point(-54, -85);
            this.shape.Name = "shape";
            this.shape.PolygonSkip = 1;
            this.shape.Rotate = 0F;
            this.shape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.shape.Size = new System.Drawing.Size(534, 306);
            this.shape.TabIndex = 44;
            this.shape.Text = "guna2Shapes1";
            this.shape.Zoom = 80;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.Color.Transparent;
            this.btnLeft.BorderColor = System.Drawing.Color.Transparent;
            this.btnLeft.CheckedState.Parent = this.btnLeft;
            this.btnLeft.CustomImages.Parent = this.btnLeft;
            this.btnLeft.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeft.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeft.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeft.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeft.DisabledState.Parent = this.btnLeft;
            this.btnLeft.FillColor = System.Drawing.Color.Transparent;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLeft.ForeColor = System.Drawing.Color.Transparent;
            this.btnLeft.HoverState.Parent = this.btnLeft;
            this.btnLeft.Image = global::DailyPlannerAppMarco.Properties.Resources.directionIcon;
            this.btnLeft.ImageSize = new System.Drawing.Size(34, 34);
            this.btnLeft.Location = new System.Drawing.Point(163, 200);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLeft.ShadowDecoration.Parent = this.btnLeft;
            this.btnLeft.Size = new System.Drawing.Size(33, 34);
            this.btnLeft.TabIndex = 47;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.Transparent;
            this.btnRight.BorderColor = System.Drawing.Color.Transparent;
            this.btnRight.CheckedState.Parent = this.btnRight;
            this.btnRight.CustomImages.Parent = this.btnRight;
            this.btnRight.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRight.DisabledState.Parent = this.btnRight;
            this.btnRight.FillColor = System.Drawing.Color.Transparent;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRight.ForeColor = System.Drawing.Color.Transparent;
            this.btnRight.HoverState.Parent = this.btnRight;
            this.btnRight.Image = global::DailyPlannerAppMarco.Properties.Resources.directionIcon;
            this.btnRight.ImageSize = new System.Drawing.Size(34, 34);
            this.btnRight.Location = new System.Drawing.Point(230, 200);
            this.btnRight.Name = "btnRight";
            this.btnRight.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnRight.ShadowDecoration.Parent = this.btnRight;
            this.btnRight.Size = new System.Drawing.Size(33, 34);
            this.btnRight.TabIndex = 46;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // HomePrev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 248);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.avgWorkoutTime);
            this.Controls.Add(this.lblAvgSleep);
            this.Controls.Add(this.lblMonthCalTotal);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.shape);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HomePrev";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePrev";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblMonthCalTotal;
        private System.Windows.Forms.Label lblAvgSleep;
        private System.Windows.Forms.Label avgWorkoutTime;
        private Guna.UI2.WinForms.Guna2Shapes shape;
        private Guna.UI2.WinForms.Guna2CircleButton btnLeft;
        private Guna.UI2.WinForms.Guna2CircleButton btnRight;
    }
}