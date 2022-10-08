namespace perimeter
{
    partial class frmCylinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCylinder));
            this.label16 = new System.Windows.Forms.Label();
            this.txtVolCyl = new System.Windows.Forms.TextBox();
            this.txtAreaCyl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClearCyl = new System.Windows.Forms.Button();
            this.txtRadCyl = new System.Windows.Forms.TextBox();
            this.txtHghtCyl = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnCalcCyl = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(201, 23);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(14, 3, 10, 6);
            this.label16.Size = new System.Drawing.Size(186, 50);
            this.label16.TabIndex = 54;
            this.label16.Text = "CYLINDER";
            // 
            // txtVolCyl
            // 
            this.txtVolCyl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtVolCyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVolCyl.Location = new System.Drawing.Point(337, 295);
            this.txtVolCyl.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolCyl.Multiline = true;
            this.txtVolCyl.Name = "txtVolCyl";
            this.txtVolCyl.Size = new System.Drawing.Size(199, 34);
            this.txtVolCyl.TabIndex = 53;
            this.txtVolCyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAreaCyl
            // 
            this.txtAreaCyl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAreaCyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAreaCyl.Location = new System.Drawing.Point(337, 216);
            this.txtAreaCyl.Margin = new System.Windows.Forms.Padding(4);
            this.txtAreaCyl.Multiline = true;
            this.txtAreaCyl.Name = "txtAreaCyl";
            this.txtAreaCyl.Size = new System.Drawing.Size(199, 34);
            this.txtAreaCyl.TabIndex = 52;
            this.txtAreaCyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label8.Location = new System.Drawing.Point(201, 295);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(31, 7, 31, 7);
            this.label8.Size = new System.Drawing.Size(128, 34);
            this.label8.TabIndex = 51;
            this.label8.Text = "Volume:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label11.Location = new System.Drawing.Point(201, 216);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.label11.Size = new System.Drawing.Size(128, 34);
            this.label11.TabIndex = 50;
            this.label11.Text = "Surface Area:";
            // 
            // btnClearCyl
            // 
            this.btnClearCyl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearCyl.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClearCyl.Location = new System.Drawing.Point(24, 213);
            this.btnClearCyl.Name = "btnClearCyl";
            this.btnClearCyl.Size = new System.Drawing.Size(159, 51);
            this.btnClearCyl.TabIndex = 49;
            this.btnClearCyl.Text = "Clear";
            this.btnClearCyl.UseVisualStyleBackColor = true;
            this.btnClearCyl.Click += new System.EventHandler(this.btnClearCyl_Click);
            // 
            // txtRadCyl
            // 
            this.txtRadCyl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRadCyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRadCyl.Location = new System.Drawing.Point(241, 150);
            this.txtRadCyl.Margin = new System.Windows.Forms.Padding(4);
            this.txtRadCyl.Multiline = true;
            this.txtRadCyl.Name = "txtRadCyl";
            this.txtRadCyl.Size = new System.Drawing.Size(295, 42);
            this.txtRadCyl.TabIndex = 48;
            this.txtRadCyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHghtCyl
            // 
            this.txtHghtCyl.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHghtCyl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHghtCyl.Location = new System.Drawing.Point(241, 77);
            this.txtHghtCyl.Margin = new System.Windows.Forms.Padding(4);
            this.txtHghtCyl.Multiline = true;
            this.txtHghtCyl.Name = "txtHghtCyl";
            this.txtHghtCyl.Size = new System.Drawing.Size(295, 42);
            this.txtHghtCyl.TabIndex = 47;
            this.txtHghtCyl.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label12.Location = new System.Drawing.Point(24, 150);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(5, 11, 9, 11);
            this.label12.Size = new System.Drawing.Size(223, 42);
            this.label12.TabIndex = 46;
            this.label12.Text = "Enter the Radius of Cylinder:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label13.Location = new System.Drawing.Point(24, 77);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(5, 11, 3, 11);
            this.label13.Size = new System.Drawing.Size(217, 42);
            this.label13.TabIndex = 45;
            this.label13.Text = "Enter the Height of Cylinder:";
            // 
            // btnCalcCyl
            // 
            this.btnCalcCyl.BackColor = System.Drawing.Color.Teal;
            this.btnCalcCyl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcCyl.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcCyl.Location = new System.Drawing.Point(24, 281);
            this.btnCalcCyl.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcCyl.Name = "btnCalcCyl";
            this.btnCalcCyl.Size = new System.Drawing.Size(159, 49);
            this.btnCalcCyl.TabIndex = 44;
            this.btnCalcCyl.Text = "Calculate";
            this.btnCalcCyl.UseVisualStyleBackColor = false;
            this.btnCalcCyl.Click += new System.EventHandler(this.btnCalcCyl_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.Location = new System.Drawing.Point(24, 31);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(116, 39);
            this.btnClose.TabIndex = 55;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCylinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(553, 356);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtVolCyl);
            this.Controls.Add(this.txtAreaCyl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnClearCyl);
            this.Controls.Add(this.txtRadCyl);
            this.Controls.Add(this.txtHghtCyl);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnCalcCyl);
            this.Name = "frmCylinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cylinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label16;
        private TextBox txtVolCyl;
        private TextBox txtAreaCyl;
        private Label label8;
        private Label label11;
        private Button btnClearCyl;
        private TextBox txtRadCyl;
        private TextBox txtHghtCyl;
        private Label label12;
        private Label label13;
        private Button btnCalcCyl;
        private Button btnClose;
    }
}