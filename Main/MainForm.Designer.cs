namespace Main
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnExcitatioCoil = new System.Windows.Forms.Button();
            this.btnPlunger = new System.Windows.Forms.Button();
            this.btnHorseShoe = new System.Windows.Forms.Button();
            this.btnFlatArmature = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer1.Panel1.Controls.Add(this.btnHome);
            this.splitContainer1.Panel1.Controls.Add(this.btnExcitatioCoil);
            this.splitContainer1.Panel1.Controls.Add(this.btnPlunger);
            this.splitContainer1.Panel1.Controls.Add(this.btnHorseShoe);
            this.splitContainer1.Panel1.Controls.Add(this.btnFlatArmature);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.splitContainer1.Size = new System.Drawing.Size(1184, 561);
            this.splitContainer1.SplitterDistance = 267;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnHome.Image = global::Main.Properties.Resources.download_32;
            this.btnHome.Location = new System.Drawing.Point(33, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(166, 52);
            this.btnHome.TabIndex = 4;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnExcitatioCoil
            // 
            this.btnExcitatioCoil.Location = new System.Drawing.Point(33, 335);
            this.btnExcitatioCoil.Name = "btnExcitatioCoil";
            this.btnExcitatioCoil.Size = new System.Drawing.Size(166, 56);
            this.btnExcitatioCoil.TabIndex = 3;
            this.btnExcitatioCoil.Text = "Excitation Coil";
            this.btnExcitatioCoil.UseVisualStyleBackColor = true;
            this.btnExcitatioCoil.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPlunger
            // 
            this.btnPlunger.Image = global::Main.Properties.Resources.Inkedplunger_LI_32;
            this.btnPlunger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlunger.Location = new System.Drawing.Point(33, 252);
            this.btnPlunger.Name = "btnPlunger";
            this.btnPlunger.Size = new System.Drawing.Size(166, 46);
            this.btnPlunger.TabIndex = 2;
            this.btnPlunger.Text = "Plunger";
            this.btnPlunger.UseVisualStyleBackColor = true;
            this.btnPlunger.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHorseShoe
            // 
            this.btnHorseShoe.Image = global::Main.Properties.Resources.horse_shoe_32;
            this.btnHorseShoe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHorseShoe.Location = new System.Drawing.Point(33, 170);
            this.btnHorseShoe.Name = "btnHorseShoe";
            this.btnHorseShoe.Size = new System.Drawing.Size(166, 46);
            this.btnHorseShoe.TabIndex = 1;
            this.btnHorseShoe.Text = "Horse Shoe";
            this.btnHorseShoe.UseVisualStyleBackColor = true;
            this.btnHorseShoe.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnFlatArmature
            // 
            this.btnFlatArmature.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnFlatArmature.Image = global::Main.Properties.Resources.flat_armature_32;
            this.btnFlatArmature.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlatArmature.Location = new System.Drawing.Point(33, 89);
            this.btnFlatArmature.Name = "btnFlatArmature";
            this.btnFlatArmature.Size = new System.Drawing.Size(166, 52);
            this.btnFlatArmature.TabIndex = 0;
            this.btnFlatArmature.Text = "Flat Armature";
            this.btnFlatArmature.UseVisualStyleBackColor = true;
            this.btnFlatArmature.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnExcitatioCoil;
        private Button btnPlunger;
        private Button btnHorseShoe;
        private Button btnFlatArmature;
        private Button btnHome;
    }
}