namespace BasicCalculators
{
    partial class FrmBasicCalculators
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstNumber = new System.Windows.Forms.TextBox();
            this.txtSecondNumber = new System.Windows.Forms.TextBox();
            this.cmbOperator = new System.Windows.Forms.ComboBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Basic Calculator";
            // 
            // txtFirstNumber
            // 
            this.txtFirstNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstNumber.Location = new System.Drawing.Point(44, 79);
            this.txtFirstNumber.Multiline = true;
            this.txtFirstNumber.Name = "txtFirstNumber";
            this.txtFirstNumber.Size = new System.Drawing.Size(159, 54);
            this.txtFirstNumber.TabIndex = 1;
            // 
            // txtSecondNumber
            // 
            this.txtSecondNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondNumber.Location = new System.Drawing.Point(273, 79);
            this.txtSecondNumber.Multiline = true;
            this.txtSecondNumber.Name = "txtSecondNumber";
            this.txtSecondNumber.Size = new System.Drawing.Size(159, 54);
            this.txtSecondNumber.TabIndex = 2;
            // 
            // cmbOperator
            // 
            this.cmbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbOperator.FormattingEnabled = true;
            this.cmbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "x",
            "÷"});
            this.cmbOperator.Location = new System.Drawing.Point(209, 89);
            this.cmbOperator.Name = "cmbOperator";
            this.cmbOperator.Size = new System.Drawing.Size(58, 28);
            this.cmbOperator.TabIndex = 3;
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(179, 270);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(115, 35);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // lblResult
            // 
            this.lblResult.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.Lime;
            this.lblResult.Location = new System.Drawing.Point(106, 203);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(278, 46);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "000000";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(197, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 46);
            this.label2.TabIndex = 8;
            this.label2.Text = "Total :";
            // 
            // FrmBasicCalculators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 317);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.cmbOperator);
            this.Controls.Add(this.txtSecondNumber);
            this.Controls.Add(this.txtFirstNumber);
            this.Controls.Add(this.label1);
            this.Name = "FrmBasicCalculators";
            this.Text = "FrmBasicCalculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstNumber;
        private System.Windows.Forms.TextBox txtSecondNumber;
        private System.Windows.Forms.ComboBox cmbOperator;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
    }
}
