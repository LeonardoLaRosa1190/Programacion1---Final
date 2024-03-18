namespace sys_LeonardoLaRosa
{
    partial class frmTrabajadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTrabajadores));
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblHoras = new System.Windows.Forms.Label();
            this.lblTarifa = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblPagobruto = new System.Windows.Forms.Label();
            this.lblRetenidos = new System.Windows.Forms.Label();
            this.lblPagoneto = new System.Windows.Forms.Label();
            this.lblOtraoperacion = new System.Windows.Forms.Label();
            this.lblOtraoperacionguardado = new System.Windows.Forms.Label();
            this.txtpagoNeto = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtpagoBruto = new System.Windows.Forms.TextBox();
            this.txtimpuestosRetenidos = new System.Windows.Forms.TextBox();
            this.txtTarifa = new System.Windows.Forms.TextBox();
            this.txthorasTrabajadas = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnotraOperacion = new System.Windows.Forms.Button();
            this.btnoperacionGuardado = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTrabajadores = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInstituto = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btnMinimize.Location = new System.Drawing.Point(1132, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancelar.BackgroundImage")));
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowText;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(1163, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(25, 25);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblHoras.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoras.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblHoras.Location = new System.Drawing.Point(130, 150);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(214, 18);
            this.lblHoras.TabIndex = 1;
            this.lblHoras.Text = "Ingrese horas trabajadas:";
            // 
            // lblTarifa
            // 
            this.lblTarifa.AutoSize = true;
            this.lblTarifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTarifa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTarifa.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTarifa.Location = new System.Drawing.Point(148, 277);
            this.lblTarifa.Name = "lblTarifa";
            this.lblTarifa.Size = new System.Drawing.Size(196, 18);
            this.lblTarifa.TabIndex = 1;
            this.lblTarifa.Text = "Ingrese tarifa aplicable:";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPorcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentaje.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPorcentaje.Location = new System.Drawing.Point(66, 410);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(278, 18);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "Ingrese % de impúestos aplicable:";
            // 
            // lblPagobruto
            // 
            this.lblPagobruto.AutoSize = true;
            this.lblPagobruto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPagobruto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPagobruto.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPagobruto.Location = new System.Drawing.Point(856, 150);
            this.lblPagobruto.Name = "lblPagobruto";
            this.lblPagobruto.Size = new System.Drawing.Size(139, 18);
            this.lblPagobruto.TabIndex = 1;
            this.lblPagobruto.Text = "Sueldo en bruto:";
            // 
            // lblRetenidos
            // 
            this.lblRetenidos.AutoSize = true;
            this.lblRetenidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRetenidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRetenidos.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRetenidos.Location = new System.Drawing.Point(856, 277);
            this.lblRetenidos.Name = "lblRetenidos";
            this.lblRetenidos.Size = new System.Drawing.Size(176, 18);
            this.lblRetenidos.TabIndex = 1;
            this.lblRetenidos.Text = "Impuestos retenidos:";
            // 
            // lblPagoneto
            // 
            this.lblPagoneto.AutoSize = true;
            this.lblPagoneto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPagoneto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPagoneto.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPagoneto.Location = new System.Drawing.Point(856, 410);
            this.lblPagoneto.Name = "lblPagoneto";
            this.lblPagoneto.Size = new System.Drawing.Size(108, 18);
            this.lblPagoneto.TabIndex = 1;
            this.lblPagoneto.Text = "Sueldo neto:";
            // 
            // lblOtraoperacion
            // 
            this.lblOtraoperacion.AutoSize = true;
            this.lblOtraoperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOtraoperacion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOtraoperacion.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOtraoperacion.Location = new System.Drawing.Point(350, 497);
            this.lblOtraoperacion.Name = "lblOtraoperacion";
            this.lblOtraoperacion.Size = new System.Drawing.Size(195, 18);
            this.lblOtraoperacion.TabIndex = 1;
            this.lblOtraoperacion.Text = "Realizar otra operación";
            // 
            // lblOtraoperacionguardado
            // 
            this.lblOtraoperacionguardado.AutoSize = true;
            this.lblOtraoperacionguardado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblOtraoperacionguardado.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOtraoperacionguardado.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblOtraoperacionguardado.Location = new System.Drawing.Point(646, 497);
            this.lblOtraoperacionguardado.Name = "lblOtraoperacionguardado";
            this.lblOtraoperacionguardado.Size = new System.Drawing.Size(195, 18);
            this.lblOtraoperacionguardado.TabIndex = 1;
            this.lblOtraoperacionguardado.Text = "Guardar los resultados ";
            // 
            // txtpagoNeto
            // 
            this.txtpagoNeto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtpagoNeto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpagoNeto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpagoNeto.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtpagoNeto.Location = new System.Drawing.Point(856, 431);
            this.txtpagoNeto.Name = "txtpagoNeto";
            this.txtpagoNeto.ReadOnly = true;
            this.txtpagoNeto.Size = new System.Drawing.Size(150, 19);
            this.txtpagoNeto.TabIndex = 2;
            this.txtpagoNeto.TabStop = false;
            this.txtpagoNeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPorcentaje.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPorcentaje.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPorcentaje.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtPorcentaje.Location = new System.Drawing.Point(194, 431);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(150, 19);
            this.txtPorcentaje.TabIndex = 3;
            this.txtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtpagoBruto
            // 
            this.txtpagoBruto.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtpagoBruto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpagoBruto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtpagoBruto.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtpagoBruto.Location = new System.Drawing.Point(856, 171);
            this.txtpagoBruto.Name = "txtpagoBruto";
            this.txtpagoBruto.ReadOnly = true;
            this.txtpagoBruto.Size = new System.Drawing.Size(150, 19);
            this.txtpagoBruto.TabIndex = 2;
            this.txtpagoBruto.TabStop = false;
            this.txtpagoBruto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtimpuestosRetenidos
            // 
            this.txtimpuestosRetenidos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtimpuestosRetenidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtimpuestosRetenidos.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtimpuestosRetenidos.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtimpuestosRetenidos.Location = new System.Drawing.Point(856, 298);
            this.txtimpuestosRetenidos.Name = "txtimpuestosRetenidos";
            this.txtimpuestosRetenidos.ReadOnly = true;
            this.txtimpuestosRetenidos.Size = new System.Drawing.Size(150, 19);
            this.txtimpuestosRetenidos.TabIndex = 2;
            this.txtimpuestosRetenidos.TabStop = false;
            this.txtimpuestosRetenidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTarifa
            // 
            this.txtTarifa.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTarifa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTarifa.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTarifa.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTarifa.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtTarifa.Location = new System.Drawing.Point(194, 298);
            this.txtTarifa.Name = "txtTarifa";
            this.txtTarifa.Size = new System.Drawing.Size(150, 19);
            this.txtTarifa.TabIndex = 2;
            this.txtTarifa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txthorasTrabajadas
            // 
            this.txthorasTrabajadas.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.txthorasTrabajadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txthorasTrabajadas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txthorasTrabajadas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txthorasTrabajadas.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txthorasTrabajadas.Location = new System.Drawing.Point(194, 171);
            this.txthorasTrabajadas.Name = "txthorasTrabajadas";
            this.txthorasTrabajadas.Size = new System.Drawing.Size(150, 19);
            this.txthorasTrabajadas.TabIndex = 1;
            this.txthorasTrabajadas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowText;
            this.btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalcular.Location = new System.Drawing.Point(500, 84);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 50);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnotraOperacion
            // 
            this.btnotraOperacion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnotraOperacion.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnotraOperacion.BackgroundImage")));
            this.btnotraOperacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnotraOperacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnotraOperacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnotraOperacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowText;
            this.btnotraOperacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnotraOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnotraOperacion.Location = new System.Drawing.Point(415, 524);
            this.btnotraOperacion.Name = "btnotraOperacion";
            this.btnotraOperacion.Size = new System.Drawing.Size(50, 30);
            this.btnotraOperacion.TabIndex = 5;
            this.btnotraOperacion.UseVisualStyleBackColor = false;
            this.btnotraOperacion.Click += new System.EventHandler(this.btnotraOperacion_Click);
            // 
            // btnoperacionGuardado
            // 
            this.btnoperacionGuardado.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnoperacionGuardado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnoperacionGuardado.BackgroundImage")));
            this.btnoperacionGuardado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnoperacionGuardado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnoperacionGuardado.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnoperacionGuardado.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.WindowText;
            this.btnoperacionGuardado.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnoperacionGuardado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnoperacionGuardado.Location = new System.Drawing.Point(715, 524);
            this.btnoperacionGuardado.Name = "btnoperacionGuardado";
            this.btnoperacionGuardado.Size = new System.Drawing.Size(50, 30);
            this.btnoperacionGuardado.TabIndex = 6;
            this.btnoperacionGuardado.UseVisualStyleBackColor = false;
            this.btnoperacionGuardado.Click += new System.EventHandler(this.btnoperacionGuardado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 575);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 25);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 300);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel3.Location = new System.Drawing.Point(1175, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(25, 300);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.lblTrabajadores);
            this.panel4.Location = new System.Drawing.Point(350, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 40);
            this.panel4.TabIndex = 6;
            // 
            // lblTrabajadores
            // 
            this.lblTrabajadores.AutoSize = true;
            this.lblTrabajadores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTrabajadores.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTrabajadores.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblTrabajadores.Location = new System.Drawing.Point(185, 11);
            this.lblTrabajadores.Name = "lblTrabajadores";
            this.lblTrabajadores.Size = new System.Drawing.Size(132, 22);
            this.lblTrabajadores.TabIndex = 7;
            this.lblTrabajadores.Text = "Trabajadores";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(350, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // lblInstituto
            // 
            this.lblInstituto.AutoSize = true;
            this.lblInstituto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblInstituto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInstituto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblInstituto.Location = new System.Drawing.Point(365, 453);
            this.lblInstituto.Name = "lblInstituto";
            this.lblInstituto.Size = new System.Drawing.Size(466, 18);
            this.lblInstituto.TabIndex = 8;
            this.lblInstituto.Text = "Instituto Zona Oeste - Tec. Sup. en Desarollo de Software ";
            // 
            // frmTrabajadores
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.lblInstituto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnoperacionGuardado);
            this.Controls.Add(this.btnotraOperacion);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtimpuestosRetenidos);
            this.Controls.Add(this.txtpagoBruto);
            this.Controls.Add(this.txthorasTrabajadas);
            this.Controls.Add(this.txtTarifa);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.txtpagoNeto);
            this.Controls.Add(this.lblOtraoperacionguardado);
            this.Controls.Add(this.lblOtraoperacion);
            this.Controls.Add(this.lblPagoneto);
            this.Controls.Add(this.lblRetenidos);
            this.Controls.Add(this.lblPagobruto);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblTarifa);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnMinimize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTrabajadores";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trabajadores";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnMinimize;
        private Button btnCancelar;
        private Label lblHoras;
        private Label lblTarifa;
        private Label lblPorcentaje;
        private Label lblPagobruto;
        private Label lblRetenidos;
        private Label lblPagoneto;
        private Label lblOtraoperacion;
        private Label lblOtraoperacionguardado;
        private TextBox txtpagoNeto;
        private TextBox txtPorcentaje;
        private TextBox txtpagoBruto;
        private TextBox txtimpuestosRetenidos;
        private TextBox txtTarifa;
        private TextBox txthorasTrabajadas;
        private Button btnCalcular;
        private Button btnotraOperacion;
        private Button btnoperacionGuardado;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label lblTrabajadores;
        private PictureBox pictureBox1;
        private Label lblInstituto;
    }
}