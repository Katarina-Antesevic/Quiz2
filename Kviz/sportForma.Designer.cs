
namespace Kviz
{
    partial class sportForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sportForma));
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.progresBar = new System.Windows.Forms.ToolStripProgressBar();
            this.stripStatusLabela = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.lbPitanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSlika
            // 
            this.pbSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSlika.Location = new System.Drawing.Point(101, 2);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(408, 249);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 2;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 44);
            this.button2.TabIndex = 3;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(88, 370);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 44);
            this.button3.TabIndex = 4;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(374, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 44);
            this.button4.TabIndex = 5;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progresBar,
            this.stripStatusLabela});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 24);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // progresBar
            // 
            this.progresBar.AutoSize = false;
            this.progresBar.Maximum = 8;
            this.progresBar.Name = "progresBar";
            this.progresBar.Size = new System.Drawing.Size(100, 18);
            this.progresBar.Step = 1;
            // 
            // stripStatusLabela
            // 
            this.stripStatusLabela.AutoSize = false;
            this.stripStatusLabela.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stripStatusLabela.Name = "stripStatusLabela";
            this.stripStatusLabela.Size = new System.Drawing.Size(515, 19);
            this.stripStatusLabela.Text = "toolStripStatusLabel1";
            this.stripStatusLabela.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPomoc
            // 
            this.btnPomoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPomoc.Location = new System.Drawing.Point(546, 2);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(88, 29);
            this.btnPomoc.TabIndex = 0;
            this.btnPomoc.Text = "Pomoc";
            this.btnPomoc.UseVisualStyleBackColor = false;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // lbPitanje
            // 
            this.lbPitanje.Location = new System.Drawing.Point(101, 269);
            this.lbPitanje.Name = "lbPitanje";
            this.lbPitanje.Size = new System.Drawing.Size(408, 32);
            this.lbPitanje.TabIndex = 1;
            this.lbPitanje.Text = "label1";
            this.lbPitanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sportForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kviz.Properties.Resources.H63jGL;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.lbPitanje);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbSlika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 480);
            this.Name = "sportForma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sportForma_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbSlika;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar progresBar;
        private System.Windows.Forms.ToolStripStatusLabel stripStatusLabela;
        private System.Windows.Forms.Button btnPomoc;
        private System.Windows.Forms.Label lbPitanje;
    }
}