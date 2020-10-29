namespace CalculadoraVisual
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TituloInSimple = new System.Windows.Forms.Label();
            this.comBoxInSimple = new System.Windows.Forms.ComboBox();
            this.TituloInCompuesto = new System.Windows.Forms.Label();
            this.comBoxInCompuesto = new System.Windows.Forms.ComboBox();
            this.TituloDesSimple = new System.Windows.Forms.Label();
            this.comBoxDesSimple = new System.Windows.Forms.ComboBox();
            this.labValor1 = new System.Windows.Forms.Label();
            this.labValor2 = new System.Windows.Forms.Label();
            this.labValor = new System.Windows.Forms.Label();
            this.ingresVal1 = new System.Windows.Forms.TextBox();
            this.ingresVal2 = new System.Windows.Forms.TextBox();
            this.ingresVal3 = new System.Windows.Forms.TextBox();
            this.btSeleccionar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.muestraFormula = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.muestraResultado = new System.Windows.Forms.Label();
            this.labFormula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TituloInSimple
            // 
            this.TituloInSimple.AutoSize = true;
            this.TituloInSimple.BackColor = System.Drawing.Color.Transparent;
            this.TituloInSimple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TituloInSimple.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloInSimple.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloInSimple.Location = new System.Drawing.Point(21, 9);
            this.TituloInSimple.Name = "TituloInSimple";
            this.TituloInSimple.Size = new System.Drawing.Size(114, 16);
            this.TituloInSimple.TabIndex = 0;
            this.TituloInSimple.Text = "Interes Simple";
            // 
            // comBoxInSimple
            // 
            this.comBoxInSimple.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comBoxInSimple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBoxInSimple.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxInSimple.FormattingEnabled = true;
            this.comBoxInSimple.Items.AddRange(new object[] {
            "Formula 1: Valor Futuro ",
            "Formula 2: Valor Futuro ",
            "Formula 3: Valor Futuro",
            "Formula: Valor Actual",
            "Formula 1: Interes",
            "Formula 2: Interes",
            "Formula 1: Tasa Interes",
            "Formula 2: Tasa Interes",
            "Formula 1: Periodo de Capitalizacion",
            "Formula 2: Periodo de Capitalizacion"});
            this.comBoxInSimple.Location = new System.Drawing.Point(24, 37);
            this.comBoxInSimple.Name = "comBoxInSimple";
            this.comBoxInSimple.Size = new System.Drawing.Size(193, 26);
            this.comBoxInSimple.TabIndex = 1;
            this.comBoxInSimple.SelectedIndexChanged += new System.EventHandler(this.comBoxInSimple_SelectedIndexChanged);
            // 
            // TituloInCompuesto
            // 
            this.TituloInCompuesto.AutoSize = true;
            this.TituloInCompuesto.BackColor = System.Drawing.Color.Transparent;
            this.TituloInCompuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TituloInCompuesto.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloInCompuesto.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloInCompuesto.Location = new System.Drawing.Point(21, 73);
            this.TituloInCompuesto.Name = "TituloInCompuesto";
            this.TituloInCompuesto.Size = new System.Drawing.Size(148, 16);
            this.TituloInCompuesto.TabIndex = 2;
            this.TituloInCompuesto.Text = "Interes Compuesto";
            // 
            // comBoxInCompuesto
            // 
            this.comBoxInCompuesto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comBoxInCompuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBoxInCompuesto.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxInCompuesto.FormattingEnabled = true;
            this.comBoxInCompuesto.Items.AddRange(new object[] {
            "Formula: Valor Futuro",
            "Formula: Interes",
            "Formula 1: Valor Actual",
            "Formula 2: Valor Actual",
            "Formula: Tasa Interes",
            "Formula: Periodo de Capitilizacion"});
            this.comBoxInCompuesto.Location = new System.Drawing.Point(24, 103);
            this.comBoxInCompuesto.Name = "comBoxInCompuesto";
            this.comBoxInCompuesto.Size = new System.Drawing.Size(193, 26);
            this.comBoxInCompuesto.TabIndex = 3;
            this.comBoxInCompuesto.SelectedIndexChanged += new System.EventHandler(this.comBoxInCompuesto_SelectedIndexChanged);
            // 
            // TituloDesSimple
            // 
            this.TituloDesSimple.AutoSize = true;
            this.TituloDesSimple.BackColor = System.Drawing.Color.Transparent;
            this.TituloDesSimple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TituloDesSimple.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TituloDesSimple.ForeColor = System.Drawing.SystemColors.Control;
            this.TituloDesSimple.Location = new System.Drawing.Point(21, 140);
            this.TituloDesSimple.Name = "TituloDesSimple";
            this.TituloDesSimple.Size = new System.Drawing.Size(138, 16);
            this.TituloDesSimple.TabIndex = 4;
            this.TituloDesSimple.Text = "Descuento Simple";
            // 
            // comBoxDesSimple
            // 
            this.comBoxDesSimple.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comBoxDesSimple.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comBoxDesSimple.Font = new System.Drawing.Font("Dubai", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comBoxDesSimple.FormattingEnabled = true;
            this.comBoxDesSimple.Items.AddRange(new object[] {
            "Formula 1",
            "Formula 2"});
            this.comBoxDesSimple.Location = new System.Drawing.Point(24, 173);
            this.comBoxDesSimple.Name = "comBoxDesSimple";
            this.comBoxDesSimple.Size = new System.Drawing.Size(193, 26);
            this.comBoxDesSimple.TabIndex = 5;
            this.comBoxDesSimple.SelectedIndexChanged += new System.EventHandler(this.comBoxDesSimple_SelectedIndexChanged);
            // 
            // labValor1
            // 
            this.labValor1.AutoSize = true;
            this.labValor1.BackColor = System.Drawing.Color.Transparent;
            this.labValor1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValor1.ForeColor = System.Drawing.SystemColors.Control;
            this.labValor1.Location = new System.Drawing.Point(21, 232);
            this.labValor1.Name = "labValor1";
            this.labValor1.Size = new System.Drawing.Size(60, 13);
            this.labValor1.TabIndex = 6;
            this.labValor1.Text = "Valor 1 =";
            // 
            // labValor2
            // 
            this.labValor2.AutoSize = true;
            this.labValor2.BackColor = System.Drawing.Color.Transparent;
            this.labValor2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValor2.ForeColor = System.Drawing.SystemColors.Control;
            this.labValor2.Location = new System.Drawing.Point(21, 261);
            this.labValor2.Name = "labValor2";
            this.labValor2.Size = new System.Drawing.Size(60, 13);
            this.labValor2.TabIndex = 7;
            this.labValor2.Text = "Valor 2 =";
            // 
            // labValor
            // 
            this.labValor.AutoSize = true;
            this.labValor.BackColor = System.Drawing.Color.Transparent;
            this.labValor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labValor.ForeColor = System.Drawing.SystemColors.Control;
            this.labValor.Location = new System.Drawing.Point(21, 288);
            this.labValor.Name = "labValor";
            this.labValor.Size = new System.Drawing.Size(60, 13);
            this.labValor.TabIndex = 8;
            this.labValor.Text = "Valor 3 =";
            // 
            // ingresVal1
            // 
            this.ingresVal1.BackColor = System.Drawing.Color.Silver;
            this.ingresVal1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresVal1.Location = new System.Drawing.Point(80, 229);
            this.ingresVal1.Name = "ingresVal1";
            this.ingresVal1.Size = new System.Drawing.Size(55, 21);
            this.ingresVal1.TabIndex = 9;
            this.ingresVal1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ingresVal1_TextChanged);
            // 
            // ingresVal2
            // 
            this.ingresVal2.BackColor = System.Drawing.Color.Silver;
            this.ingresVal2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresVal2.Location = new System.Drawing.Point(80, 258);
            this.ingresVal2.Name = "ingresVal2";
            this.ingresVal2.Size = new System.Drawing.Size(55, 21);
            this.ingresVal2.TabIndex = 10;
            this.ingresVal2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ingresVal2_TextChanged);
            // 
            // ingresVal3
            // 
            this.ingresVal3.BackColor = System.Drawing.Color.Silver;
            this.ingresVal3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingresVal3.Location = new System.Drawing.Point(80, 285);
            this.ingresVal3.Name = "ingresVal3";
            this.ingresVal3.Size = new System.Drawing.Size(55, 21);
            this.ingresVal3.TabIndex = 11;
            this.ingresVal3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ingresVal3_TextChanged);
            // 
            // btSeleccionar
            // 
            this.btSeleccionar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSeleccionar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSeleccionar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSeleccionar.Location = new System.Drawing.Point(27, 327);
            this.btSeleccionar.Name = "btSeleccionar";
            this.btSeleccionar.Size = new System.Drawing.Size(98, 23);
            this.btSeleccionar.TabIndex = 12;
            this.btSeleccionar.Text = "Seleccionar";
            this.btSeleccionar.UseVisualStyleBackColor = false;
            this.btSeleccionar.Click += new System.EventHandler(this.btSeleccionar_Click);
            // 
            // btSalir
            // 
            this.btSalir.BackColor = System.Drawing.Color.MidnightBlue;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSalir.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSalir.Location = new System.Drawing.Point(233, 327);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(98, 23);
            this.btSalir.TabIndex = 13;
            this.btSalir.Text = "Cambiar";
            this.btSalir.UseVisualStyleBackColor = false;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // muestraFormula
            // 
            this.muestraFormula.AutoSize = true;
            this.muestraFormula.BackColor = System.Drawing.Color.Transparent;
            this.muestraFormula.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestraFormula.ForeColor = System.Drawing.SystemColors.Control;
            this.muestraFormula.Location = new System.Drawing.Point(168, 258);
            this.muestraFormula.Name = "muestraFormula";
            this.muestraFormula.Size = new System.Drawing.Size(0, 13);
            this.muestraFormula.TabIndex = 14;
            this.muestraFormula.Click += new System.EventHandler(this.muestraInFSimple_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(262, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Resultado";
            // 
            // muestraResultado
            // 
            this.muestraResultado.AutoSize = true;
            this.muestraResultado.BackColor = System.Drawing.Color.Transparent;
            this.muestraResultado.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muestraResultado.ForeColor = System.Drawing.Color.White;
            this.muestraResultado.Location = new System.Drawing.Point(262, 73);
            this.muestraResultado.Name = "muestraResultado";
            this.muestraResultado.Size = new System.Drawing.Size(0, 13);
            this.muestraResultado.TabIndex = 18;
            this.muestraResultado.Click += new System.EventHandler(this.muestraResultado_Click);
            // 
            // labFormula
            // 
            this.labFormula.AutoSize = true;
            this.labFormula.BackColor = System.Drawing.Color.Transparent;
            this.labFormula.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labFormula.Font = new System.Drawing.Font("Verdana", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labFormula.ForeColor = System.Drawing.SystemColors.Control;
            this.labFormula.Location = new System.Drawing.Point(168, 227);
            this.labFormula.Name = "labFormula";
            this.labFormula.Size = new System.Drawing.Size(68, 16);
            this.labFormula.TabIndex = 19;
            this.labFormula.Text = "Formula";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(366, 362);
            this.Controls.Add(this.labFormula);
            this.Controls.Add(this.muestraResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.muestraFormula);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btSeleccionar);
            this.Controls.Add(this.ingresVal3);
            this.Controls.Add(this.ingresVal2);
            this.Controls.Add(this.ingresVal1);
            this.Controls.Add(this.labValor);
            this.Controls.Add(this.labValor2);
            this.Controls.Add(this.labValor1);
            this.Controls.Add(this.comBoxDesSimple);
            this.Controls.Add(this.TituloDesSimple);
            this.Controls.Add(this.comBoxInCompuesto);
            this.Controls.Add(this.TituloInCompuesto);
            this.Controls.Add(this.comBoxInSimple);
            this.Controls.Add(this.TituloInSimple);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Financiera";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TituloInSimple;
        private System.Windows.Forms.ComboBox comBoxInSimple;
        private System.Windows.Forms.Label TituloInCompuesto;
        private System.Windows.Forms.ComboBox comBoxInCompuesto;
        private System.Windows.Forms.Label TituloDesSimple;
        private System.Windows.Forms.ComboBox comBoxDesSimple;
        private System.Windows.Forms.Label labValor1;
        private System.Windows.Forms.Label labValor2;
        private System.Windows.Forms.Label labValor;
        private System.Windows.Forms.TextBox ingresVal1;
        private System.Windows.Forms.TextBox ingresVal2;
        private System.Windows.Forms.TextBox ingresVal3;
        private System.Windows.Forms.Button btSeleccionar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label muestraFormula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label muestraResultado;
        private System.Windows.Forms.Label labFormula;
    }
}

