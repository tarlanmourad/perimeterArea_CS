namespace perimeter
{
    partial class pyramidCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPrm = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.Color.Teal;
            this.btnCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalc.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalc.Location = new System.Drawing.Point(19, 285);
            this.btnCalc.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(1064, 71);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 11, 3, 11);
            this.label1.Size = new System.Drawing.Size(347, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the Height of Right Rectangular Pyramid:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Silver;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(19, 140);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5, 11, 9, 11);
            this.label2.Size = new System.Drawing.Size(349, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter the Width of Right Rectangular Pyramid:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5, 11, 1, 11);
            this.label3.Size = new System.Drawing.Size(347, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter the Length of Right Rectangular Pyramid:";
            // 
            // txtHeight
            // 
            this.txtHeight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHeight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHeight.Location = new System.Drawing.Point(366, 67);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHeight.Multiline = true;
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(165, 42);
            this.txtHeight.TabIndex = 4;
            this.txtHeight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLength
            // 
            this.txtLength.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtLength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtLength.Location = new System.Drawing.Point(366, 211);
            this.txtLength.Margin = new System.Windows.Forms.Padding(4);
            this.txtLength.Multiline = true;
            this.txtLength.Name = "txtLength";
            this.txtLength.Size = new System.Drawing.Size(165, 42);
            this.txtLength.TabIndex = 5;
            this.txtLength.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWidth
            // 
            this.txtWidth.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtWidth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtWidth.Location = new System.Drawing.Point(366, 140);
            this.txtWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtWidth.Multiline = true;
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(165, 42);
            this.txtWidth.TabIndex = 6;
            this.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(565, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(43, 7, 43, 7);
            this.label4.Size = new System.Drawing.Size(132, 34);
            this.label4.TabIndex = 7;
            this.label4.Text = "Area:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(565, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(7);
            this.label5.Size = new System.Drawing.Size(134, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Base Perimeter:";
            // 
            // txtArea
            // 
            this.txtArea.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtArea.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtArea.Location = new System.Drawing.Point(707, 101);
            this.txtArea.Margin = new System.Windows.Forms.Padding(4);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(165, 34);
            this.txtArea.TabIndex = 9;
            this.txtArea.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPrm
            // 
            this.txtPrm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtPrm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrm.Location = new System.Drawing.Point(707, 180);
            this.txtPrm.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrm.Multiline = true;
            this.txtPrm.Name = "txtPrm";
            this.txtPrm.Size = new System.Drawing.Size(165, 34);
            this.txtPrm.TabIndex = 10;
            this.txtPrm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClear.Location = new System.Drawing.Point(924, 130);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(159, 54);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pyramidCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::perimeter.Properties.Resources._202205081250245024;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 442);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtPrm);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "pyramidCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pyramid Perimeter and Area Calclator";
            this.Load += new System.EventHandler(this.pyramidCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalc;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtHeight;
        private TextBox txtLength;
        private TextBox txtWidth;
        private Label label4;
        private Label label5;
        private TextBox txtArea;
        private TextBox txtPrm;
        private Button btnClear;
    }
}