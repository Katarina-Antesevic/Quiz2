
namespace Kviz
{
    partial class popKulturaForma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popKulturaForma));
            this.pbSlika = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbPitanje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSlika)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbSlika
            // 
            this.pbSlika.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbSlika.Location = new System.Drawing.Point(101, 3);
            this.pbSlika.Name = "pbSlika";
            this.pbSlika.Size = new System.Drawing.Size(408, 249);
            this.pbSlika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSlika.TabIndex = 0;
            this.pbSlika.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(79, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 1;
            this.button1.Tag = "1";
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 44);
            this.button2.TabIndex = 2;
            this.button2.Tag = "2";
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(79, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 44);
            this.button3.TabIndex = 3;
            this.button3.Tag = "3";
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(372, 365);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 44);
            this.button4.TabIndex = 4;
            this.button4.Tag = "4";
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.checkAnswerEvent);
            // 
            // btnPomoc
            // 
            this.btnPomoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPomoc.Location = new System.Drawing.Point(546, 3);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(88, 29);
            this.btnPomoc.TabIndex = 5;
            this.btnPomoc.Text = "Pomoc";
            this.btnPomoc.UseVisualStyleBackColor = false;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(101, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 32);
            this.label1.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 417);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 24);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Maximum = 8;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            this.toolStripProgressBar1.Step = 1;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(515, 19);
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPitanje
            // 
            this.lbPitanje.Location = new System.Drawing.Point(101, 267);
            this.lbPitanje.Name = "lbPitanje";
            this.lbPitanje.Size = new System.Drawing.Size(408, 32);
            this.lbPitanje.TabIndex = 8;
            this.lbPitanje.Text = "label2";
            this.lbPitanje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // popKulturaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kviz.Properties.Resources.dd5469431fdf0d22aa1ce86b4a50232f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.lbPitanje);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbSlika);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(650, 480);
            this.Name = "popKulturaForma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.popKulturaForma_FormClosing);
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
        private System.Windows.Forms.Button btnPomoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lbPitanje;
    }
}