namespace prime_r
{
    partial class FrmMainWindow
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.rTxtResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(56, 30);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 0;
            this.txtNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumber_KeyDown);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(162, 30);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 20);
            this.btnCalc.TabIndex = 1;
            this.btnCalc.Text = "calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Location = new System.Drawing.Point(12, 33);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(38, 13);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "prime?";
            // 
            // rTxtResult
            // 
            this.rTxtResult.Location = new System.Drawing.Point(12, 59);
            this.rTxtResult.Name = "rTxtResult";
            this.rTxtResult.ReadOnly = true;
            this.rTxtResult.Size = new System.Drawing.Size(222, 166);
            this.rTxtResult.TabIndex = 3;
            this.rTxtResult.Text = "";
            // 
            // FrmMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 260);
            this.Controls.Add(this.rTxtResult);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtNumber);
            this.Name = "FrmMainWindow";
            this.Text = "Prime:R";
            this.Load += new System.EventHandler(this.FrmMainWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.RichTextBox rTxtResult;
    }
}

