
namespace Kviz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbIme = new System.Windows.Forms.Label();
            this.tbIme = new System.Windows.Forms.TextBox();
            this.btnNapustiKviz = new System.Windows.Forms.Button();
            this.btnZapocniIgru = new System.Windows.Forms.Button();
            this.msHelp = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.About = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.pbKviz = new System.Windows.Forms.PictureBox();
            this.msHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKviz)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIme
            // 
            this.lbIme.AutoSize = true;
            this.lbIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIme.Location = new System.Drawing.Point(220, 246);
            this.lbIme.Name = "lbIme";
            this.lbIme.Size = new System.Drawing.Size(102, 24);
            this.lbIme.TabIndex = 1;
            this.lbIme.Text = "Ime igraca:";
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(210, 273);
            this.tbIme.MaxLength = 12;
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(179, 20);
            this.tbIme.TabIndex = 2;
            this.tbIme.TextChanged += new System.EventHandler(this.tbIme_TextChanged);
            // 
            // btnNapustiKviz
            // 
            this.btnNapustiKviz.BackColor = System.Drawing.Color.Fuchsia;
            this.btnNapustiKviz.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNapustiKviz.Location = new System.Drawing.Point(66, 313);
            this.btnNapustiKviz.Name = "btnNapustiKviz";
            this.btnNapustiKviz.Size = new System.Drawing.Size(155, 44);
            this.btnNapustiKviz.TabIndex = 3;
            this.btnNapustiKviz.Text = "Napusti kviz";
            this.btnNapustiKviz.UseVisualStyleBackColor = false;
            this.btnNapustiKviz.Click += new System.EventHandler(this.btnNapustiKviz_Click);
            // 
            // btnZapocniIgru
            // 
            this.btnZapocniIgru.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnZapocniIgru.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZapocniIgru.Location = new System.Drawing.Point(401, 313);
            this.btnZapocniIgru.Name = "btnZapocniIgru";
            this.btnZapocniIgru.Size = new System.Drawing.Size(155, 44);
            this.btnZapocniIgru.TabIndex = 4;
            this.btnZapocniIgru.Text = "Zapocni igru";
            this.btnZapocniIgru.UseVisualStyleBackColor = false;
            this.btnZapocniIgru.Click += new System.EventHandler(this.btnZapocniIgru_Click);
            // 
            // msHelp
            // 
            this.msHelp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemHelp});
            this.msHelp.Location = new System.Drawing.Point(0, 0);
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(614, 24);
            this.msHelp.TabIndex = 0;
            this.msHelp.Text = "menuStrip1";
            // 
            // toolStripMenuItemHelp
            // 
            this.toolStripMenuItemHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.About});
            this.toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            this.toolStripMenuItemHelp.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItemHelp.Text = "Help";
            // 
            // About
            // 
            this.About.Name = "About";
            this.About.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.About.Size = new System.Drawing.Size(149, 22);
            this.About.Text = "About";
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.Color.White;
            this.progressBar2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.progressBar2.Location = new System.Drawing.Point(0, 372);
            this.progressBar2.Maximum = 200;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(614, 22);
            this.progressBar2.Step = 1;
            this.progressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar2.TabIndex = 5;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // pbKviz
            // 
            this.pbKviz.Image = global::Kviz.Properties.Resources._2384073;
            this.pbKviz.Location = new System.Drawing.Point(109, 36);
            this.pbKviz.Name = "pbKviz";
            this.pbKviz.Size = new System.Drawing.Size(397, 207);
            this.pbKviz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKviz.TabIndex = 0;
            this.pbKviz.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kviz.Properties.Resources.upitnici;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(614, 394);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.btnZapocniIgru);
            this.Controls.Add(this.btnNapustiKviz);
            this.Controls.Add(this.tbIme);
            this.Controls.Add(this.lbIme);
            this.Controls.Add(this.pbKviz);
            this.Controls.Add(this.msHelp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msHelp;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(630, 433);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.msHelp.ResumeLayout(false);
            this.msHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbKviz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKviz;
        private System.Windows.Forms.Label lbIme;
        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.Button btnNapustiKviz;
        private System.Windows.Forms.Button btnZapocniIgru;
        private System.Windows.Forms.MenuStrip msHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripMenuItem About;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar2;
    }
}

