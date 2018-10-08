namespace Vista_Form
{
    partial class Vista
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDivisionCurso = new System.Windows.Forms.Label();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblApellidoProfe = new System.Windows.Forms.Label();
            this.lblNombreProfe = new System.Windows.Forms.Label();
            this.lblAnioCurso = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnCrearCurso = new System.Windows.Forms.Button();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtApellidoProfe = new System.Windows.Forms.TextBox();
            this.txtNombreProfe = new System.Windows.Forms.TextBox();
            this.cmbDivisionCurso = new System.Windows.Forms.ComboBox();
            this.nudAnioCurso = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Division = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.lblLegajo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cmbDivision = new System.Windows.Forms.ComboBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.txtLegajo = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.rtbDatos = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDivisionCurso);
            this.groupBox1.Controls.Add(this.lblFechaIngreso);
            this.groupBox1.Controls.Add(this.lblDni);
            this.groupBox1.Controls.Add(this.lblApellidoProfe);
            this.groupBox1.Controls.Add(this.lblNombreProfe);
            this.groupBox1.Controls.Add(this.lblAnioCurso);
            this.groupBox1.Controls.Add(this.btnMostrar);
            this.groupBox1.Controls.Add(this.btnCrearCurso);
            this.groupBox1.Controls.Add(this.dtpFechaIngreso);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtApellidoProfe);
            this.groupBox1.Controls.Add(this.txtNombreProfe);
            this.groupBox1.Controls.Add(this.cmbDivisionCurso);
            this.groupBox1.Controls.Add(this.nudAnioCurso);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Curso";
            // 
            // lblDivisionCurso
            // 
            this.lblDivisionCurso.AutoSize = true;
            this.lblDivisionCurso.Location = new System.Drawing.Point(7, 74);
            this.lblDivisionCurso.Name = "lblDivisionCurso";
            this.lblDivisionCurso.Size = new System.Drawing.Size(44, 13);
            this.lblDivisionCurso.TabIndex = 13;
            this.lblDivisionCurso.Text = "Division";
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(7, 204);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(90, 13);
            this.lblFechaIngreso.TabIndex = 12;
            this.lblFechaIngreso.Text = "Fecha de Ingreso";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(7, 166);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "Dni";
            // 
            // lblApellidoProfe
            // 
            this.lblApellidoProfe.AutoSize = true;
            this.lblApellidoProfe.Location = new System.Drawing.Point(7, 140);
            this.lblApellidoProfe.Name = "lblApellidoProfe";
            this.lblApellidoProfe.Size = new System.Drawing.Size(44, 13);
            this.lblApellidoProfe.TabIndex = 10;
            this.lblApellidoProfe.Text = "Apellido";
            // 
            // lblNombreProfe
            // 
            this.lblNombreProfe.AutoSize = true;
            this.lblNombreProfe.Location = new System.Drawing.Point(7, 114);
            this.lblNombreProfe.Name = "lblNombreProfe";
            this.lblNombreProfe.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProfe.TabIndex = 9;
            this.lblNombreProfe.Text = "Nombre";
            // 
            // lblAnioCurso
            // 
            this.lblAnioCurso.AutoSize = true;
            this.lblAnioCurso.Location = new System.Drawing.Point(7, 31);
            this.lblAnioCurso.Name = "lblAnioCurso";
            this.lblAnioCurso.Size = new System.Drawing.Size(26, 13);
            this.lblAnioCurso.TabIndex = 8;
            this.lblAnioCurso.Text = "Año";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(208, 248);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 7;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnCrearCurso
            // 
            this.btnCrearCurso.Location = new System.Drawing.Point(127, 248);
            this.btnCrearCurso.Name = "btnCrearCurso";
            this.btnCrearCurso.Size = new System.Drawing.Size(75, 23);
            this.btnCrearCurso.TabIndex = 6;
            this.btnCrearCurso.Text = "Crear Curso";
            this.btnCrearCurso.UseVisualStyleBackColor = true;
            this.btnCrearCurso.Click += new System.EventHandler(this.btnCrearCurso_Click);
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Location = new System.Drawing.Point(127, 198);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaIngreso.TabIndex = 5;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(127, 159);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 4;
            // 
            // txtApellidoProfe
            // 
            this.txtApellidoProfe.Location = new System.Drawing.Point(127, 133);
            this.txtApellidoProfe.Name = "txtApellidoProfe";
            this.txtApellidoProfe.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoProfe.TabIndex = 3;
            // 
            // txtNombreProfe
            // 
            this.txtNombreProfe.Location = new System.Drawing.Point(127, 107);
            this.txtNombreProfe.Name = "txtNombreProfe";
            this.txtNombreProfe.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProfe.TabIndex = 2;
            // 
            // cmbDivisionCurso
            // 
            this.cmbDivisionCurso.FormattingEnabled = true;
            this.cmbDivisionCurso.Location = new System.Drawing.Point(127, 66);
            this.cmbDivisionCurso.Name = "cmbDivisionCurso";
            this.cmbDivisionCurso.Size = new System.Drawing.Size(121, 21);
            this.cmbDivisionCurso.TabIndex = 1;
            // 
            // nudAnioCurso
            // 
            this.nudAnioCurso.Location = new System.Drawing.Point(128, 31);
            this.nudAnioCurso.Name = "nudAnioCurso";
            this.nudAnioCurso.Size = new System.Drawing.Size(120, 20);
            this.nudAnioCurso.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Division);
            this.groupBox2.Controls.Add(this.lblAnio);
            this.groupBox2.Controls.Add(this.lblLegajo);
            this.groupBox2.Controls.Add(this.lblApellido);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.cmbDivision);
            this.groupBox2.Controls.Add(this.nudAnio);
            this.groupBox2.Controls.Add(this.txtLegajo);
            this.groupBox2.Controls.Add(this.txtApellido);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Location = new System.Drawing.Point(353, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Alumno";
            // 
            // Division
            // 
            this.Division.AutoSize = true;
            this.Division.Location = new System.Drawing.Point(23, 174);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(44, 13);
            this.Division.TabIndex = 20;
            this.Division.Text = "Division";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(23, 147);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(26, 13);
            this.lblAnio.TabIndex = 19;
            this.lblAnio.Text = "Año";
            // 
            // lblLegajo
            // 
            this.lblLegajo.AutoSize = true;
            this.lblLegajo.Location = new System.Drawing.Point(23, 103);
            this.lblLegajo.Name = "lblLegajo";
            this.lblLegajo.Size = new System.Drawing.Size(39, 13);
            this.lblLegajo.TabIndex = 18;
            this.lblLegajo.Text = "Legajo";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(23, 69);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 17;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 16;
            this.lblNombre.Text = "Nombre";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(157, 218);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cmbDivision
            // 
            this.cmbDivision.FormattingEnabled = true;
            this.cmbDivision.Location = new System.Drawing.Point(157, 166);
            this.cmbDivision.Name = "cmbDivision";
            this.cmbDivision.Size = new System.Drawing.Size(121, 21);
            this.cmbDivision.TabIndex = 14;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(158, 140);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(120, 20);
            this.nudAnio.TabIndex = 14;
            // 
            // txtLegajo
            // 
            this.txtLegajo.Location = new System.Drawing.Point(158, 96);
            this.txtLegajo.Name = "txtLegajo";
            this.txtLegajo.Size = new System.Drawing.Size(100, 20);
            this.txtLegajo.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(158, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(158, 30);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // rtbDatos
            // 
            this.rtbDatos.Location = new System.Drawing.Point(13, 307);
            this.rtbDatos.Name = "rtbDatos";
            this.rtbDatos.Size = new System.Drawing.Size(675, 141);
            this.rtbDatos.TabIndex = 2;
            this.rtbDatos.Text = "";
            // 
            // Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbDatos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Vista";
            this.Text = "Vista Curso";
            this.Load += new System.EventHandler(this.Vista_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnioCurso)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDivisionCurso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblApellidoProfe;
        private System.Windows.Forms.Label lblNombreProfe;
        private System.Windows.Forms.Label lblAnioCurso;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnCrearCurso;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtApellidoProfe;
        private System.Windows.Forms.TextBox txtNombreProfe;
        private System.Windows.Forms.ComboBox cmbDivisionCurso;
        private System.Windows.Forms.NumericUpDown nudAnioCurso;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Division;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Label lblLegajo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cmbDivision;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.TextBox txtLegajo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.RichTextBox rtbDatos;
    }
}

