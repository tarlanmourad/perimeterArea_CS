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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pyramidCalculator));
            this.btnPyramid = new System.Windows.Forms.Button();
            this.btnCone = new System.Windows.Forms.Button();
            this.btnCylinder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPyramid
            // 
            this.btnPyramid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPyramid.BackgroundImage")));
            this.btnPyramid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPyramid.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPyramid.Location = new System.Drawing.Point(70, 109);
            this.btnPyramid.Name = "btnPyramid";
            this.btnPyramid.Size = new System.Drawing.Size(189, 146);
            this.btnPyramid.TabIndex = 44;
            this.btnPyramid.UseVisualStyleBackColor = true;
            this.btnPyramid.Click += new System.EventHandler(this.btnPyramid_Click);
            // 
            // btnCone
            // 
            this.btnCone.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCone.BackgroundImage")));
            this.btnCone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCone.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCone.Location = new System.Drawing.Point(280, 109);
            this.btnCone.Name = "btnCone";
            this.btnCone.Size = new System.Drawing.Size(189, 146);
            this.btnCone.TabIndex = 45;
            this.btnCone.UseVisualStyleBackColor = true;
            this.btnCone.Click += new System.EventHandler(this.btnCone_Click);
            // 
            // btnCylinder
            // 
            this.btnCylinder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCylinder.BackgroundImage")));
            this.btnCylinder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCylinder.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCylinder.Location = new System.Drawing.Point(486, 109);
            this.btnCylinder.Name = "btnCylinder";
            this.btnCylinder.Size = new System.Drawing.Size(189, 146);
            this.btnCylinder.TabIndex = 46;
            this.btnCylinder.UseVisualStyleBackColor = true;
            this.btnCylinder.Click += new System.EventHandler(this.btnCylinder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(192, 32);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 11);
            this.label1.Size = new System.Drawing.Size(361, 53);
            this.label1.TabIndex = 47;
            this.label1.Text = "Click figures to continue";
            // 
            // pyramidCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(756, 287);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCylinder);
            this.Controls.Add(this.btnCone);
            this.Controls.Add(this.btnPyramid);
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
        private Button btnPyramid;
        private Button btnCone;
        private Button btnCylinder;
        private Label label1;
    }
}