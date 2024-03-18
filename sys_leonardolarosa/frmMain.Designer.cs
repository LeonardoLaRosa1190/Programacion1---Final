namespace sys_LeonardoLaRosa
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrp = new System.Windows.Forms.MenuStrip();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.peajeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblCalculos = new System.Windows.Forms.Label();
            this.lblIzo = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.menuStrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrp
            // 
            this.menuStrp.AutoSize = false;
            this.menuStrp.BackColor = System.Drawing.SystemColors.WindowText;
            this.menuStrp.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrp.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrp.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.menuStrp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpen});
            this.menuStrp.Location = new System.Drawing.Point(0, 0);
            this.menuStrp.Name = "menuStrp";
            this.menuStrp.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrp.Size = new System.Drawing.Size(43, 600);
            this.menuStrp.TabIndex = 0;
            this.menuStrp.Text = "Menu";
            // 
            // menuOpen
            // 
            this.menuOpen.BackColor = System.Drawing.SystemColors.WindowText;
            this.menuOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.menuOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.menuOpen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.peajeToolStripMenuItem,
            this.trabajadoresToolStripMenuItem});
            this.menuOpen.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuOpen.Image")));
            this.menuOpen.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.Size = new System.Drawing.Size(36, 29);
            // 
            // peajeToolStripMenuItem
            // 
            this.peajeToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.peajeToolStripMenuItem.Name = "peajeToolStripMenuItem";
            this.peajeToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.peajeToolStripMenuItem.Text = "Peaje";
            this.peajeToolStripMenuItem.Click += new System.EventHandler(this.peajeToolStripMenuItem_Click);
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText;
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            this.trabajadoresToolStripMenuItem.Click += new System.EventHandler(this.trabajadoresToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Location = new System.Drawing.Point(0, 575);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 25);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 40);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(131, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡Bienvenido!";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMenu.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMenu.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMenu.Location = new System.Drawing.Point(46, 9);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(124, 18);
            this.lblMenu.TabIndex = 0;
            this.lblMenu.Text = "Menú principal";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(776, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 300);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(25, 300);
            this.panel4.TabIndex = 6;
            // 
            // lblCalculos
            // 
            this.lblCalculos.AutoSize = true;
            this.lblCalculos.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblCalculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCalculos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCalculos.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCalculos.Location = new System.Drawing.Point(321, 129);
            this.lblCalculos.Name = "lblCalculos";
            this.lblCalculos.Size = new System.Drawing.Size(158, 18);
            this.lblCalculos.TabIndex = 8;
            this.lblCalculos.Text = "Sistema de cálculo";
            // 
            // lblIzo
            // 
            this.lblIzo.AutoSize = true;
            this.lblIzo.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblIzo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIzo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIzo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblIzo.Location = new System.Drawing.Point(173, 453);
            this.lblIzo.Name = "lblIzo";
            this.lblIzo.Size = new System.Drawing.Size(466, 18);
            this.lblIzo.TabIndex = 9;
            this.lblIzo.Text = "Instituto Zona Oeste - Tec. Sup. en Desarollo de Software ";
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowText;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Location = new System.Drawing.Point(732, 7);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click_1);
            // 
            // btnCancel
            // 
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowText;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(763, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(25, 25);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.lblIzo);
            this.Controls.Add(this.lblCalculos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.menuStrp);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrp.ResumeLayout(false);
            this.menuStrp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrp;
        private ToolStripMenuItem menuOpen;
        private ToolStripMenuItem peajeToolStripMenuItem;
        private ToolStripMenuItem trabajadoresToolStripMenuItem;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Panel panel2;
        private Label lblMenu;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private Label lblCalculos;
        private Label lblIzo;
        private Button btnMinimize;
        private Button btnCancel;
    }
}