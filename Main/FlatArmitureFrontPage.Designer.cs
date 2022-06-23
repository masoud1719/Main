namespace Main
{
    partial class FlatArmitureFrontPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxForce = new System.Windows.Forms.ComboBox();
            this.txtForce = new System.Windows.Forms.TextBox();
            this.txtStroke = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblForce = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "متن مورد نطر برای فلت ارمیچر اینجا باید اضافه شود";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Main.Properties.Resources.flat_armature;
            this.pictureBox1.Location = new System.Drawing.Point(428, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(418, 304);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxForce
            // 
            this.comboBoxForce.FormattingEnabled = true;
            this.comboBoxForce.Items.AddRange(new object[] {
            "Mass",
            "Force"});
            this.comboBoxForce.Location = new System.Drawing.Point(78, 384);
            this.comboBoxForce.Name = "comboBoxForce";
            this.comboBoxForce.Size = new System.Drawing.Size(121, 23);
            this.comboBoxForce.TabIndex = 2;
            this.comboBoxForce.SelectedIndexChanged += new System.EventHandler(this.comboBoxForce_SelectedIndexChanged);
            // 
            // txtForce
            // 
            this.txtForce.Location = new System.Drawing.Point(234, 384);
            this.txtForce.Name = "txtForce";
            this.txtForce.Size = new System.Drawing.Size(100, 23);
            this.txtForce.TabIndex = 3;
            // 
            // txtStroke
            // 
            this.txtStroke.Location = new System.Drawing.Point(234, 443);
            this.txtStroke.Name = "txtStroke";
            this.txtStroke.Size = new System.Drawing.Size(100, 23);
            this.txtStroke.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stroke (g)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(234, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblForce
            // 
            this.lblForce.AutoSize = true;
            this.lblForce.Location = new System.Drawing.Point(360, 392);
            this.lblForce.Name = "lblForce";
            this.lblForce.Size = new System.Drawing.Size(0, 15);
            this.lblForce.TabIndex = 7;
            // 
            // FlatArmitureFrontPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblForce);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtStroke);
            this.Controls.Add(this.txtForce);
            this.Controls.Add(this.comboBoxForce);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "FlatArmitureFrontPage";
            this.Size = new System.Drawing.Size(889, 543);
            this.Load += new System.EventHandler(this.FlatArmitureFrontPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox comboBoxForce;
        private TextBox txtForce;
        private TextBox txtStroke;
        private Label label2;
        private Button button1;
        private Label lblForce;
    }
}
