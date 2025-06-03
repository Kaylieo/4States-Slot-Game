namespace _4States
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
            this.lblMain = new System.Windows.Forms.Label();
            this.lblSpinOutcome = new System.Windows.Forms.Label();
            this.lblSpinPts = new System.Windows.Forms.Label();
            this.lblSpinPointsOut = new System.Windows.Forms.Label();
            this.btnSpin = new System.Windows.Forms.Button();
            this.lblTotalPointsOut = new System.Windows.Forms.Label();
            this.lblTotalPoints = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbxRight = new System.Windows.Forms.PictureBox();
            this.pbxMiddle = new System.Windows.Forms.PictureBox();
            this.pbxLeft = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Font = new System.Drawing.Font("Poor Richard", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMain.Location = new System.Drawing.Point(209, 25);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(209, 36);
            this.lblMain.TabIndex = 0;
            this.lblMain.Text = "4 States Spinner";
            // 
            // lblSpinOutcome
            // 
            this.lblSpinOutcome.AutoSize = true;
            this.lblSpinOutcome.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpinOutcome.Location = new System.Drawing.Point(276, 107);
            this.lblSpinOutcome.Name = "lblSpinOutcome";
            this.lblSpinOutcome.Size = new System.Drawing.Size(81, 21);
            this.lblSpinOutcome.TabIndex = 1;
            this.lblSpinOutcome.Text = "Outcome";
            // 
            // lblSpinPts
            // 
            this.lblSpinPts.AutoSize = true;
            this.lblSpinPts.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpinPts.Location = new System.Drawing.Point(260, 337);
            this.lblSpinPts.Name = "lblSpinPts";
            this.lblSpinPts.Size = new System.Drawing.Size(115, 25);
            this.lblSpinPts.TabIndex = 5;
            this.lblSpinPts.Text = "Spin Points";
            // 
            // lblSpinPointsOut
            // 
            this.lblSpinPointsOut.AutoSize = true;
            this.lblSpinPointsOut.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpinPointsOut.Location = new System.Drawing.Point(296, 382);
            this.lblSpinPointsOut.Name = "lblSpinPointsOut";
            this.lblSpinPointsOut.Size = new System.Drawing.Size(36, 28);
            this.lblSpinPointsOut.TabIndex = 6;
            this.lblSpinPointsOut.Text = "00";
            // 
            // btnSpin
            // 
            this.btnSpin.Font = new System.Drawing.Font("Poor Richard", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpin.Location = new System.Drawing.Point(265, 429);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(100, 50);
            this.btnSpin.TabIndex = 7;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // lblTotalPointsOut
            // 
            this.lblTotalPointsOut.AutoSize = true;
            this.lblTotalPointsOut.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPointsOut.Location = new System.Drawing.Point(296, 513);
            this.lblTotalPointsOut.Name = "lblTotalPointsOut";
            this.lblTotalPointsOut.Size = new System.Drawing.Size(36, 28);
            this.lblTotalPointsOut.TabIndex = 8;
            this.lblTotalPointsOut.Text = "00";
            // 
            // lblTotalPoints
            // 
            this.lblTotalPoints.AutoSize = true;
            this.lblTotalPoints.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPoints.Location = new System.Drawing.Point(254, 558);
            this.lblTotalPoints.Name = "lblTotalPoints";
            this.lblTotalPoints.Size = new System.Drawing.Size(121, 25);
            this.lblTotalPoints.TabIndex = 9;
            this.lblTotalPoints.Text = "Total Points";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(280, 619);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbxRight
            // 
            this.pbxRight.Image = global::_4States.Properties.Resources.ok;
            this.pbxRight.Location = new System.Drawing.Point(454, 177);
            this.pbxRight.Name = "pbxRight";
            this.pbxRight.Size = new System.Drawing.Size(130, 130);
            this.pbxRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxRight.TabIndex = 4;
            this.pbxRight.TabStop = false;
            // 
            // pbxMiddle
            // 
            this.pbxMiddle.Image = global::_4States.Properties.Resources.tx;
            this.pbxMiddle.Location = new System.Drawing.Point(256, 177);
            this.pbxMiddle.Name = "pbxMiddle";
            this.pbxMiddle.Size = new System.Drawing.Size(130, 130);
            this.pbxMiddle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMiddle.TabIndex = 3;
            this.pbxMiddle.TabStop = false;
            // 
            // pbxLeft
            // 
            this.pbxLeft.Image = global::_4States.Properties.Resources.la;
            this.pbxLeft.Location = new System.Drawing.Point(55, 177);
            this.pbxLeft.Name = "pbxLeft";
            this.pbxLeft.Size = new System.Drawing.Size(130, 130);
            this.pbxLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxLeft.TabIndex = 2;
            this.pbxLeft.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(669, 711);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalPoints);
            this.Controls.Add(this.lblTotalPointsOut);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.lblSpinPointsOut);
            this.Controls.Add(this.lblSpinPts);
            this.Controls.Add(this.pbxRight);
            this.Controls.Add(this.pbxMiddle);
            this.Controls.Add(this.pbxLeft);
            this.Controls.Add(this.lblSpinOutcome);
            this.Controls.Add(this.lblMain);
            this.Name = "Form1";
            this.Text = "4 States Spinner";
            ((System.ComponentModel.ISupportInitialize)(this.pbxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMiddle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblSpinOutcome;
        private System.Windows.Forms.PictureBox pbxLeft;
        private System.Windows.Forms.PictureBox pbxMiddle;
        private System.Windows.Forms.PictureBox pbxRight;
        private System.Windows.Forms.Label lblSpinPts;
        private System.Windows.Forms.Label lblSpinPointsOut;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label lblTotalPointsOut;
        private System.Windows.Forms.Label lblTotalPoints;
        private System.Windows.Forms.Button btnExit;
    }
}

