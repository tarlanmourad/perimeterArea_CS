namespace perimeter
{
    partial class frmCone
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCone));
            this.label15 = new System.Windows.Forms.Label();
            this.btnClearCone = new System.Windows.Forms.Button();
            this.txtVolCone = new System.Windows.Forms.TextBox();
            this.txtAreaCone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRadCone = new System.Windows.Forms.TextBox();
            this.txtHghtCone = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalcCone = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(239, 37);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(40, 3, 36, 6);
            this.label15.Size = new System.Drawing.Size(176, 50);
            this.label15.TabIndex = 53;
            this.label15.Text = "CONE";
            // 
            // btnClearCone
            // 
            this.btnClearCone.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClearCone.ForeColor = System.Drawing.Color.IndianRed;
            this.btnClearCone.Location = new System.Drawing.Point(27, 235);
            this.btnClearCone.Name = "btnClearCone";
            this.btnClearCone.Size = new System.Drawing.Size(159, 51);
            this.btnClearCone.TabIndex = 52;
            this.btnClearCone.Text = "Clear";
            this.btnClearCone.UseVisualStyleBackColor = true;
            this.btnClearCone.Click += new System.EventHandler(this.btnClearCone_Click);
            // 
            // txtVolCone
            // 
            this.txtVolCone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtVolCone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtVolCone.Location = new System.Drawing.Point(340, 314);
            this.txtVolCone.Margin = new System.Windows.Forms.Padding(4);
            this.txtVolCone.Multiline = true;
            this.txtVolCone.Name = "txtVolCone";
            this.txtVolCone.Size = new System.Drawing.Size(211, 34);
            this.txtVolCone.TabIndex = 51;
            this.txtVolCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAreaCone
            // 
            this.txtAreaCone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAreaCone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAreaCone.Location = new System.Drawing.Point(340, 235);
            this.txtAreaCone.Margin = new System.Windows.Forms.Padding(4);
            this.txtAreaCone.Multiline = true;
            this.txtAreaCone.Name = "txtAreaCone";
            this.txtAreaCone.Size = new System.Drawing.Size(211, 34);
            this.txtAreaCone.TabIndex = 50;
            this.txtAreaCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(204, 314);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(31, 7, 31, 7);
            this.label6.Size = new System.Drawing.Size(128, 34);
            this.label6.TabIndex = 49;
            this.label6.Text = "Volume:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(204, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(13, 7, 13, 7);
            this.label7.Size = new System.Drawing.Size(128, 34);
            this.label7.TabIndex = 48;
            this.label7.Text = "Surface Area:";
            // 
            // txtRadCone
            // 
            this.txtRadCone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtRadCone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRadCone.Location = new System.Drawing.Point(219, 165);
            this.txtRadCone.Margin = new System.Windows.Forms.Padding(4);
            this.txtRadCone.Multiline = true;
            this.txtRadCone.Name = "txtRadCone";
            this.txtRadCone.Size = new System.Drawing.Size(332, 42);
            this.txtRadCone.TabIndex = 47;
            this.txtRadCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHghtCone
            // 
            this.txtHghtCone.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtHghtCone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtHghtCone.Location = new System.Drawing.Point(219, 91);
            this.txtHghtCone.Margin = new System.Windows.Forms.Padding(4);
            this.txtHghtCone.Multiline = true;
            this.txtHghtCone.Name = "txtHghtCone";
            this.txtHghtCone.Size = new System.Drawing.Size(332, 42);
            this.txtHghtCone.TabIndex = 46;
            this.txtHghtCone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label9.Location = new System.Drawing.Point(27, 165);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5, 11, 9, 11);
            this.label9.Size = new System.Drawing.Size(200, 42);
            this.label9.TabIndex = 45;
            this.label9.Text = "Enter the Radius of Cone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(27, 91);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(5, 11, 3, 11);
            this.label10.Size = new System.Drawing.Size(194, 42);
            this.label10.TabIndex = 44;
            this.label10.Text = "Enter the Height of Cone:";
            // 
            // btnCalcCone
            // 
            this.btnCalcCone.BackColor = System.Drawing.Color.Teal;
            this.btnCalcCone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalcCone.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalcCone.Location = new System.Drawing.Point(27, 303);
            this.btnCalcCone.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcCone.Name = "btnCalcCone";
            this.btnCalcCone.Size = new System.Drawing.Size(159, 49);
            this.btnCalcCone.TabIndex = 43;
            this.btnCalcCone.Text = "Calculate";
            this.btnCalcCone.UseVisualStyleBackColor = false;
            this.btnCalcCone.Click += new System.EventHandler(this.btnCalcCone_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(27, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 54;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmCone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 377);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.btnClearCone);
            this.Controls.Add(this.txtVolCone);
            this.Controls.Add(this.txtAreaCone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRadCone);
            this.Controls.Add(this.txtHghtCone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnCalcCone);
            this.Name = "frmCone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label15;
        private Button btnClearCone;
        private TextBox txtVolCone;
        private TextBox txtAreaCone;
        private Label label6;
        private Label label7;
        private TextBox txtRadCone;
        private TextBox txtHghtCone;
        private Label label9;
        private Label label10;
        private Button btnCalcCone;
        private Button button1;
    }
}