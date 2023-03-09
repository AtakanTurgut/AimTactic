namespace AimTactic
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.picAim = new System.Windows.Forms.PictureBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblScoreValue = new System.Windows.Forms.Label();
            this.lblFailValue = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblFail = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFail = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAim)).BeginInit();
            this.SuspendLayout();
            // 
            // picAim
            // 
            this.picAim.BackColor = System.Drawing.Color.Aqua;
            this.picAim.Location = new System.Drawing.Point(398, 234);
            this.picAim.Name = "picAim";
            this.picAim.Size = new System.Drawing.Size(50, 50);
            this.picAim.TabIndex = 0;
            this.picAim.TabStop = false;
            this.picAim.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAim_MouseDown);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTime.Location = new System.Drawing.Point(30, 41);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(79, 44);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "60";
            // 
            // lblScoreValue
            // 
            this.lblScoreValue.AutoSize = true;
            this.lblScoreValue.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreValue.Location = new System.Drawing.Point(781, 24);
            this.lblScoreValue.Name = "lblScoreValue";
            this.lblScoreValue.Size = new System.Drawing.Size(33, 30);
            this.lblScoreValue.TabIndex = 2;
            this.lblScoreValue.Text = "0";
            // 
            // lblFailValue
            // 
            this.lblFailValue.AutoSize = true;
            this.lblFailValue.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFailValue.ForeColor = System.Drawing.Color.Red;
            this.lblFailValue.Location = new System.Drawing.Point(781, 54);
            this.lblFailValue.Name = "lblFailValue";
            this.lblFailValue.Size = new System.Drawing.Size(30, 27);
            this.lblFailValue.TabIndex = 3;
            this.lblFailValue.Text = "5";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Snap ITC", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(672, 24);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(103, 30);
            this.lblScore.TabIndex = 4;
            this.lblScore.Text = "Score:";
            // 
            // lblFail
            // 
            this.lblFail.AutoSize = true;
            this.lblFail.Font = new System.Drawing.Font("Snap ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFail.ForeColor = System.Drawing.Color.Red;
            this.lblFail.Location = new System.Drawing.Point(705, 54);
            this.lblFail.Name = "lblFail";
            this.lblFail.Size = new System.Drawing.Size(70, 27);
            this.lblFail.TabIndex = 5;
            this.lblFail.Text = "Fail:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time:";
            // 
            // pnlFail
            // 
            this.pnlFail.Enabled = false;
            this.pnlFail.Location = new System.Drawing.Point(0, 0);
            this.pnlFail.Name = "pnlFail";
            this.pnlFail.Size = new System.Drawing.Size(890, 500);
            this.pnlFail.TabIndex = 7;
            this.pnlFail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlFail_MouseDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.ClientSize = new System.Drawing.Size(890, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFail);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblFailValue);
            this.Controls.Add(this.lblScoreValue);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.picAim);
            this.Controls.Add(this.pnlFail);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picAim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAim;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblScoreValue;
        private System.Windows.Forms.Label lblFailValue;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblFail;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlFail;
    }
}

