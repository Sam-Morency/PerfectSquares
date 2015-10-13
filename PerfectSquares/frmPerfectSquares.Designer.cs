namespace PerfectSquares
{
    partial class frmPerfectSquares
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
            this.lblInstructions = new System.Windows.Forms.Label();
            this.lstAnswers = new System.Windows.Forms.ListBox();
            this.nudSquareRoot = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSquareRoot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.Location = new System.Drawing.Point(2, 21);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(192, 57);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter a number and I will\r\ngive you the perfect squares\r\nbelow it";
            // 
            // lstAnswers
            // 
            this.lstAnswers.FormattingEnabled = true;
            this.lstAnswers.Location = new System.Drawing.Point(38, 117);
            this.lstAnswers.Name = "lstAnswers";
            this.lstAnswers.ScrollAlwaysVisible = true;
            this.lstAnswers.Size = new System.Drawing.Size(120, 121);
            this.lstAnswers.TabIndex = 2;
            // 
            // nudSquareRoot
            // 
            this.nudSquareRoot.Location = new System.Drawing.Point(38, 91);
            this.nudSquareRoot.Name = "nudSquareRoot";
            this.nudSquareRoot.Size = new System.Drawing.Size(120, 20);
            this.nudSquareRoot.TabIndex = 3;
            // 
            // frmPerfectSquares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(197, 261);
            this.Controls.Add(this.nudSquareRoot);
            this.Controls.Add(this.lstAnswers);
            this.Controls.Add(this.lblInstructions);
            this.Name = "frmPerfectSquares";
            this.Text = "Perfect Squares";
            this.Load += new System.EventHandler(this.frmPerfectSquares_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSquareRoot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.ListBox lstAnswers;
        private System.Windows.Forms.NumericUpDown nudSquareRoot;
    }
}

