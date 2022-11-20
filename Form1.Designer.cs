namespace ChaserFOVTool
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.TB_ResX = new System.Windows.Forms.TextBox();
			this.TB_ResY = new System.Windows.Forms.TextBox();
			this.TB_DesiredFOV = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.B_WriteToAFile = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.LL_PCGW_link = new System.Windows.Forms.LinkLabel();
			this.L_FOV_VAL = new System.Windows.Forms.Label();
			this.L_FOVSTR = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Resolution:";
			// 
			// TB_ResX
			// 
			this.TB_ResX.Location = new System.Drawing.Point(3, 19);
			this.TB_ResX.Name = "TB_ResX";
			this.TB_ResX.Size = new System.Drawing.Size(84, 20);
			this.TB_ResX.TabIndex = 1;
			this.TB_ResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TB_ResX.TextChanged += new System.EventHandler(this.TB_ResX_TextChanged);
			// 
			// TB_ResY
			// 
			this.TB_ResY.Location = new System.Drawing.Point(109, 19);
			this.TB_ResY.Name = "TB_ResY";
			this.TB_ResY.Size = new System.Drawing.Size(84, 20);
			this.TB_ResY.TabIndex = 2;
			this.TB_ResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TB_ResY.TextChanged += new System.EventHandler(this.TB_ResY_TextChanged);
			// 
			// TB_DesiredFOV
			// 
			this.TB_DesiredFOV.Location = new System.Drawing.Point(3, 58);
			this.TB_DesiredFOV.Name = "TB_DesiredFOV";
			this.TB_DesiredFOV.Size = new System.Drawing.Size(190, 20);
			this.TB_DesiredFOV.TabIndex = 3;
			this.TB_DesiredFOV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.TB_DesiredFOV.TextChanged += new System.EventHandler(this.TB_DesiredFOV_TextChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 42);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(31, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "FOV:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(91, 22);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(12, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "x";
			// 
			// B_WriteToAFile
			// 
			this.B_WriteToAFile.Location = new System.Drawing.Point(91, 98);
			this.B_WriteToAFile.Name = "B_WriteToAFile";
			this.B_WriteToAFile.Size = new System.Drawing.Size(100, 23);
			this.B_WriteToAFile.TabIndex = 7;
			this.B_WriteToAFile.Text = "Write to a file";
			this.B_WriteToAFile.UseVisualStyleBackColor = true;
			this.B_WriteToAFile.Click += new System.EventHandler(this.B_WriteToAFile_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.LL_PCGW_link);
			this.panel1.Controls.Add(this.L_FOV_VAL);
			this.panel1.Controls.Add(this.L_FOVSTR);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.B_WriteToAFile);
			this.panel1.Controls.Add(this.TB_ResX);
			this.panel1.Controls.Add(this.TB_ResY);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.TB_DesiredFOV);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Location = new System.Drawing.Point(2, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(196, 266);
			this.panel1.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(183, 120);
			this.label4.TabIndex = 14;
			this.label4.Text = resources.GetString("label4.Text");
			// 
			// LL_PCGW_link
			// 
			this.LL_PCGW_link.AutoSize = true;
			this.LL_PCGW_link.Location = new System.Drawing.Point(3, 103);
			this.LL_PCGW_link.Name = "LL_PCGW_link";
			this.LL_PCGW_link.Size = new System.Drawing.Size(78, 13);
			this.LL_PCGW_link.TabIndex = 12;
			this.LL_PCGW_link.TabStop = true;
			this.LL_PCGW_link.Text = "PCGamingWiki";
			this.LL_PCGW_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_PCGW_link_LinkClicked);
			// 
			// L_FOV_VAL
			// 
			this.L_FOV_VAL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.L_FOV_VAL.Location = new System.Drawing.Point(125, 81);
			this.L_FOV_VAL.Name = "L_FOV_VAL";
			this.L_FOV_VAL.Size = new System.Drawing.Size(68, 13);
			this.L_FOV_VAL.TabIndex = 11;
			this.L_FOV_VAL.Text = "90.0";
			this.L_FOV_VAL.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// L_FOVSTR
			// 
			this.L_FOVSTR.AutoSize = true;
			this.L_FOVSTR.Location = new System.Drawing.Point(3, 81);
			this.L_FOVSTR.Name = "L_FOVSTR";
			this.L_FOVSTR.Size = new System.Drawing.Size(116, 13);
			this.L_FOVSTR.TabIndex = 8;
			this.L_FOVSTR.Text = "Written horizontal FOV:";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(202, 257);
			this.Controls.Add(this.panel1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Chaser FOV Tool";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ResX;
        private System.Windows.Forms.TextBox TB_ResY;
        private System.Windows.Forms.TextBox TB_DesiredFOV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button B_WriteToAFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label L_FOV_VAL;
        private System.Windows.Forms.LinkLabel LL_PCGW_link;
        private System.Windows.Forms.Label L_FOVSTR;
        private System.Windows.Forms.Label label4;
    }
}

