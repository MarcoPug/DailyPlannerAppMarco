
namespace DailyPlannerAppMarco.UserControls
{
    partial class StartWorkout
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
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.txtWorkout = new System.Windows.Forms.TextBox();
            this.totalSets = new System.Windows.Forms.Label();
            this.currSets = new System.Windows.Forms.Label();
            this.totalReps = new System.Windows.Forms.Label();
            this.currReps = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNextSet = new System.Windows.Forms.Button();
            this.shape = new Guna.UI2.WinForms.Guna2Shapes();
            this.shape2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.SuspendLayout();
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtResult.Location = new System.Drawing.Point(122, 198);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(145, 31);
            this.txtResult.TabIndex = 1;
            this.txtResult.Text = "00:00:00";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(20, 234);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(172, 47);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnStop.Location = new System.Drawing.Point(198, 234);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(172, 47);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(20, 287);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(172, 47);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Next Rep";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtWorkout
            // 
            this.txtWorkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.txtWorkout.Location = new System.Drawing.Point(122, 163);
            this.txtWorkout.Name = "txtWorkout";
            this.txtWorkout.ReadOnly = true;
            this.txtWorkout.Size = new System.Drawing.Size(145, 31);
            this.txtWorkout.TabIndex = 5;
            this.txtWorkout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalSets
            // 
            this.totalSets.AutoSize = true;
            this.totalSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSets.Location = new System.Drawing.Point(276, 21);
            this.totalSets.Name = "totalSets";
            this.totalSets.Size = new System.Drawing.Size(84, 37);
            this.totalSets.TabIndex = 6;
            this.totalSets.Text = "Sets";
            // 
            // currSets
            // 
            this.currSets.AutoSize = true;
            this.currSets.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currSets.Location = new System.Drawing.Point(29, 21);
            this.currSets.Name = "currSets";
            this.currSets.Size = new System.Drawing.Size(34, 37);
            this.currSets.TabIndex = 7;
            this.currSets.Text = "s";
            // 
            // totalReps
            // 
            this.totalReps.AutoSize = true;
            this.totalReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalReps.Location = new System.Drawing.Point(276, 67);
            this.totalReps.Name = "totalReps";
            this.totalReps.Size = new System.Drawing.Size(94, 37);
            this.totalReps.TabIndex = 8;
            this.totalReps.Text = "Reps";
            // 
            // currReps
            // 
            this.currReps.AutoSize = true;
            this.currReps.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currReps.Location = new System.Drawing.Point(29, 67);
            this.currReps.Name = "currReps";
            this.currReps.Size = new System.Drawing.Size(29, 37);
            this.currReps.TabIndex = 9;
            this.currReps.Text = "r";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(67, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Reps remaining of";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(67, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sets remaining of";
            // 
            // btnNextSet
            // 
            this.btnNextSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNextSet.Location = new System.Drawing.Point(198, 287);
            this.btnNextSet.Name = "btnNextSet";
            this.btnNextSet.Size = new System.Drawing.Size(172, 47);
            this.btnNextSet.TabIndex = 14;
            this.btnNextSet.Text = "Next Set";
            this.btnNextSet.UseVisualStyleBackColor = true;
            this.btnNextSet.Click += new System.EventHandler(this.btnNextSet_Click);
            // 
            // shape
            // 
            this.shape.Location = new System.Drawing.Point(-49, 130);
            this.shape.Name = "shape";
            this.shape.PolygonSkip = 1;
            this.shape.Rotate = 0F;
            this.shape.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.shape.Size = new System.Drawing.Size(486, 239);
            this.shape.TabIndex = 41;
            this.shape.Text = "guna2Shapes1";
            this.shape.Zoom = 80;
            // 
            // shape2
            // 
            this.shape2.Location = new System.Drawing.Point(-49, -16);
            this.shape2.Name = "shape2";
            this.shape2.PolygonSkip = 1;
            this.shape2.Rotate = 0F;
            this.shape2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rounded;
            this.shape2.Size = new System.Drawing.Size(485, 159);
            this.shape2.TabIndex = 42;
            this.shape2.Text = "guna2Shapes1";
            this.shape2.Zoom = 80;
            // 
            // StartWorkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 345);
            this.Controls.Add(this.btnNextSet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.currReps);
            this.Controls.Add(this.totalReps);
            this.Controls.Add(this.currSets);
            this.Controls.Add(this.totalSets);
            this.Controls.Add(this.txtWorkout);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.shape);
            this.Controls.Add(this.shape2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartWorkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workout";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StartWorkout_FormClosing);
            this.Load += new System.EventHandler(this.StartWorkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.TextBox txtWorkout;
        private System.Windows.Forms.Label totalSets;
        private System.Windows.Forms.Label currSets;
        private System.Windows.Forms.Label totalReps;
        private System.Windows.Forms.Label currReps;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNextSet;
        private Guna.UI2.WinForms.Guna2Shapes shape;
        private Guna.UI2.WinForms.Guna2Shapes shape2;
    }
}