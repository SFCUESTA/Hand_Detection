namespace GUIForms
{
    partial class frmGUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGUI));
            this.imgBox1 = new Emgu.CV.UI.ImageBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.grbPre = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.grbCams = new System.Windows.Forms.GroupBox();
            this.imgBox2 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.imgBox4 = new Emgu.CV.UI.ImageBox();
            this.imgBox3 = new Emgu.CV.UI.ImageBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox1)).BeginInit();
            this.grbPre.SuspendLayout();
            this.grbCams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // imgBox1
            // 
            this.imgBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgBox1.InitialImage")));
            this.imgBox1.Location = new System.Drawing.Point(517, 17);
            this.imgBox1.Name = "imgBox1";
            this.imgBox1.Size = new System.Drawing.Size(487, 369);
            this.imgBox1.TabIndex = 2;
            this.imgBox1.TabStop = false;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.DarkCyan;
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(18, 20);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(145, 55);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Conectar";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // grbPre
            // 
            this.grbPre.Controls.Add(this.btnStop);
            this.grbPre.Controls.Add(this.btnConnect);
            this.grbPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbPre.Location = new System.Drawing.Point(10, 11);
            this.grbPre.Name = "grbPre";
            this.grbPre.Size = new System.Drawing.Size(344, 94);
            this.grbPre.TabIndex = 10;
            this.grbPre.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.DarkCyan;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Eras Medium ITC", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.White;
            this.btnStop.Location = new System.Drawing.Point(169, 20);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(145, 55);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Desconectar";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // grbCams
            // 
            this.grbCams.Controls.Add(this.imgBox1);
            this.grbCams.Controls.Add(this.imgBox2);
            this.grbCams.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbCams.Location = new System.Drawing.Point(4, 115);
            this.grbCams.Name = "grbCams";
            this.grbCams.Size = new System.Drawing.Size(1010, 392);
            this.grbCams.TabIndex = 11;
            this.grbCams.TabStop = false;
            this.grbCams.Text = "Mascara";
            // 
            // imgBox2
            // 
            this.imgBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgBox2.InitialImage")));
            this.imgBox2.Location = new System.Drawing.Point(3, 17);
            this.imgBox2.Name = "imgBox2";
            this.imgBox2.Size = new System.Drawing.Size(490, 369);
            this.imgBox2.TabIndex = 3;
            this.imgBox2.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imgBox4);
            this.groupBox1.Controls.Add(this.imgBox3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(4, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 392);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contorno";
            // 
            // imgBox4
            // 
            this.imgBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgBox4.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgBox4.InitialImage")));
            this.imgBox4.Location = new System.Drawing.Point(517, 17);
            this.imgBox4.Name = "imgBox4";
            this.imgBox4.Size = new System.Drawing.Size(487, 369);
            this.imgBox4.TabIndex = 2;
            this.imgBox4.TabStop = false;
            // 
            // imgBox3
            // 
            this.imgBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.imgBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.imgBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgBox3.InitialImage")));
            this.imgBox3.Location = new System.Drawing.Point(3, 17);
            this.imgBox3.Name = "imgBox3";
            this.imgBox3.Size = new System.Drawing.Size(490, 369);
            this.imgBox3.TabIndex = 3;
            this.imgBox3.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnExit.Location = new System.Drawing.Point(989, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 898);
            this.Controls.Add(this.grbPre);
            this.Controls.Add(this.grbCams);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.imgBox1)).EndInit();
            this.grbPre.ResumeLayout(false);
            this.grbCams.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox imgBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox grbPre;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox grbCams;
        private Emgu.CV.UI.ImageBox imgBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Emgu.CV.UI.ImageBox imgBox4;
        private Emgu.CV.UI.ImageBox imgBox3;
        private System.Windows.Forms.Button btnExit;
    }
}

