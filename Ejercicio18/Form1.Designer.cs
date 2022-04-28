
namespace Ejercicio18
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
            this.labelPropiedadesFORM = new System.Windows.Forms.Label();
            this.labelTamanyoTexto = new System.Windows.Forms.Label();
            this.panelPropiedadesFORM = new System.Windows.Forms.Panel();
            this.groupBoxColorFORM = new System.Windows.Forms.GroupBox();
            this.btnRojo = new System.Windows.Forms.Button();
            this.btnAzul = new System.Windows.Forms.Button();
            this.btnVerde = new System.Windows.Forms.Button();
            this.buttonReducirFORM = new System.Windows.Forms.Button();
            this.buttonAumentarFORM = new System.Windows.Forms.Button();
            this.panelTamanyoTexto = new System.Windows.Forms.Panel();
            this.numericUpDownTamanyoTexto = new System.Windows.Forms.NumericUpDown();
            this.groupBoxColorTexto = new System.Windows.Forms.GroupBox();
            this.btnColorTextoRojo = new System.Windows.Forms.Button();
            this.btnColorTextoVioleta = new System.Windows.Forms.Button();
            this.btnColorTextoVerde = new System.Windows.Forms.Button();
            this.panelOcultarMostarTexto = new System.Windows.Forms.Panel();
            this.checkBoxSubrayado = new System.Windows.Forms.CheckBox();
            this.checkBoxCursiva = new System.Windows.Forms.CheckBox();
            this.checkBoxNegrita = new System.Windows.Forms.CheckBox();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonMostrarTexto = new System.Windows.Forms.Button();
            this.buttonOcultarTexto = new System.Windows.Forms.Button();
            this.listBoxFuentes = new System.Windows.Forms.ListBox();
            this.labelTexto = new System.Windows.Forms.Label();
            this.panelPropiedadesFORM.SuspendLayout();
            this.groupBoxColorFORM.SuspendLayout();
            this.panelTamanyoTexto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTamanyoTexto)).BeginInit();
            this.groupBoxColorTexto.SuspendLayout();
            this.panelOcultarMostarTexto.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPropiedadesFORM
            // 
            this.labelPropiedadesFORM.AutoSize = true;
            this.labelPropiedadesFORM.Location = new System.Drawing.Point(23, 17);
            this.labelPropiedadesFORM.Name = "labelPropiedadesFORM";
            this.labelPropiedadesFORM.Size = new System.Drawing.Size(117, 13);
            this.labelPropiedadesFORM.TabIndex = 1;
            this.labelPropiedadesFORM.Text = "Propiedades del FORM";
            // 
            // labelTamanyoTexto
            // 
            this.labelTamanyoTexto.AutoSize = true;
            this.labelTamanyoTexto.Location = new System.Drawing.Point(22, 15);
            this.labelTamanyoTexto.Name = "labelTamanyoTexto";
            this.labelTamanyoTexto.Size = new System.Drawing.Size(89, 13);
            this.labelTamanyoTexto.TabIndex = 2;
            this.labelTamanyoTexto.Text = "Tamaño del texto";
            // 
            // panelPropiedadesFORM
            // 
            this.panelPropiedadesFORM.Controls.Add(this.groupBoxColorFORM);
            this.panelPropiedadesFORM.Controls.Add(this.buttonReducirFORM);
            this.panelPropiedadesFORM.Controls.Add(this.buttonAumentarFORM);
            this.panelPropiedadesFORM.Controls.Add(this.labelPropiedadesFORM);
            this.panelPropiedadesFORM.Location = new System.Drawing.Point(12, 12);
            this.panelPropiedadesFORM.Name = "panelPropiedadesFORM";
            this.panelPropiedadesFORM.Size = new System.Drawing.Size(214, 162);
            this.panelPropiedadesFORM.TabIndex = 3;
            // 
            // groupBoxColorFORM
            // 
            this.groupBoxColorFORM.Controls.Add(this.btnRojo);
            this.groupBoxColorFORM.Controls.Add(this.btnAzul);
            this.groupBoxColorFORM.Controls.Add(this.btnVerde);
            this.groupBoxColorFORM.Location = new System.Drawing.Point(26, 92);
            this.groupBoxColorFORM.Name = "groupBoxColorFORM";
            this.groupBoxColorFORM.Size = new System.Drawing.Size(129, 61);
            this.groupBoxColorFORM.TabIndex = 6;
            this.groupBoxColorFORM.TabStop = false;
            this.groupBoxColorFORM.Text = "Color de formulario";
            // 
            // btnRojo
            // 
            this.btnRojo.BackColor = System.Drawing.Color.Red;
            this.btnRojo.Location = new System.Drawing.Point(82, 19);
            this.btnRojo.Name = "btnRojo";
            this.btnRojo.Size = new System.Drawing.Size(24, 24);
            this.btnRojo.TabIndex = 2;
            this.btnRojo.UseVisualStyleBackColor = false;
            this.btnRojo.Click += new System.EventHandler(this.btnRojo_Click);
            // 
            // btnAzul
            // 
            this.btnAzul.BackColor = System.Drawing.Color.Blue;
            this.btnAzul.Location = new System.Drawing.Point(52, 19);
            this.btnAzul.Name = "btnAzul";
            this.btnAzul.Size = new System.Drawing.Size(24, 24);
            this.btnAzul.TabIndex = 1;
            this.btnAzul.UseVisualStyleBackColor = false;
            this.btnAzul.Click += new System.EventHandler(this.btnAzul_Click);
            // 
            // btnVerde
            // 
            this.btnVerde.BackColor = System.Drawing.Color.Green;
            this.btnVerde.Location = new System.Drawing.Point(21, 19);
            this.btnVerde.Name = "btnVerde";
            this.btnVerde.Size = new System.Drawing.Size(24, 24);
            this.btnVerde.TabIndex = 0;
            this.btnVerde.UseVisualStyleBackColor = false;
            this.btnVerde.Click += new System.EventHandler(this.btnVerde_Click);
            // 
            // buttonReducirFORM
            // 
            this.buttonReducirFORM.Location = new System.Drawing.Point(122, 45);
            this.buttonReducirFORM.Name = "buttonReducirFORM";
            this.buttonReducirFORM.Size = new System.Drawing.Size(75, 23);
            this.buttonReducirFORM.TabIndex = 5;
            this.buttonReducirFORM.Text = "Reducir";
            this.buttonReducirFORM.UseVisualStyleBackColor = true;
            // 
            // buttonAumentarFORM
            // 
            this.buttonAumentarFORM.Location = new System.Drawing.Point(26, 45);
            this.buttonAumentarFORM.Name = "buttonAumentarFORM";
            this.buttonAumentarFORM.Size = new System.Drawing.Size(75, 23);
            this.buttonAumentarFORM.TabIndex = 4;
            this.buttonAumentarFORM.Text = "Aumentar";
            this.buttonAumentarFORM.UseVisualStyleBackColor = true;
            // 
            // panelTamanyoTexto
            // 
            this.panelTamanyoTexto.Controls.Add(this.numericUpDownTamanyoTexto);
            this.panelTamanyoTexto.Controls.Add(this.groupBoxColorTexto);
            this.panelTamanyoTexto.Controls.Add(this.labelTamanyoTexto);
            this.panelTamanyoTexto.Location = new System.Drawing.Point(13, 196);
            this.panelTamanyoTexto.Name = "panelTamanyoTexto";
            this.panelTamanyoTexto.Size = new System.Drawing.Size(196, 162);
            this.panelTamanyoTexto.TabIndex = 4;
            // 
            // numericUpDownTamanyoTexto
            // 
            this.numericUpDownTamanyoTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownTamanyoTexto.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownTamanyoTexto.Location = new System.Drawing.Point(25, 46);
            this.numericUpDownTamanyoTexto.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownTamanyoTexto.Name = "numericUpDownTamanyoTexto";
            this.numericUpDownTamanyoTexto.Size = new System.Drawing.Size(153, 20);
            this.numericUpDownTamanyoTexto.TabIndex = 8;
            this.numericUpDownTamanyoTexto.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownTamanyoTexto.ValueChanged += new System.EventHandler(this.numericUpDownTamanyoTexto_ValueChanged);
            // 
            // groupBoxColorTexto
            // 
            this.groupBoxColorTexto.Controls.Add(this.btnColorTextoRojo);
            this.groupBoxColorTexto.Controls.Add(this.btnColorTextoVioleta);
            this.groupBoxColorTexto.Controls.Add(this.btnColorTextoVerde);
            this.groupBoxColorTexto.Location = new System.Drawing.Point(25, 84);
            this.groupBoxColorTexto.Name = "groupBoxColorTexto";
            this.groupBoxColorTexto.Size = new System.Drawing.Size(129, 61);
            this.groupBoxColorTexto.TabIndex = 7;
            this.groupBoxColorTexto.TabStop = false;
            this.groupBoxColorTexto.Text = "Color de texto";
            // 
            // btnColorTextoRojo
            // 
            this.btnColorTextoRojo.BackColor = System.Drawing.Color.Red;
            this.btnColorTextoRojo.Location = new System.Drawing.Point(82, 19);
            this.btnColorTextoRojo.Name = "btnColorTextoRojo";
            this.btnColorTextoRojo.Size = new System.Drawing.Size(24, 24);
            this.btnColorTextoRojo.TabIndex = 2;
            this.btnColorTextoRojo.UseVisualStyleBackColor = false;
            this.btnColorTextoRojo.Click += new System.EventHandler(this.btnColorTextoRojo_Click);
            // 
            // btnColorTextoVioleta
            // 
            this.btnColorTextoVioleta.BackColor = System.Drawing.Color.Blue;
            this.btnColorTextoVioleta.Location = new System.Drawing.Point(52, 19);
            this.btnColorTextoVioleta.Name = "btnColorTextoVioleta";
            this.btnColorTextoVioleta.Size = new System.Drawing.Size(24, 24);
            this.btnColorTextoVioleta.TabIndex = 1;
            this.btnColorTextoVioleta.UseVisualStyleBackColor = false;
            this.btnColorTextoVioleta.Click += new System.EventHandler(this.btnColorTextoVioleta_Click);
            // 
            // btnColorTextoVerde
            // 
            this.btnColorTextoVerde.BackColor = System.Drawing.Color.Green;
            this.btnColorTextoVerde.Location = new System.Drawing.Point(21, 19);
            this.btnColorTextoVerde.Name = "btnColorTextoVerde";
            this.btnColorTextoVerde.Size = new System.Drawing.Size(24, 24);
            this.btnColorTextoVerde.TabIndex = 0;
            this.btnColorTextoVerde.UseVisualStyleBackColor = false;
            this.btnColorTextoVerde.Click += new System.EventHandler(this.btnColorTextoVerde_Click);
            // 
            // panelOcultarMostarTexto
            // 
            this.panelOcultarMostarTexto.Controls.Add(this.checkBoxSubrayado);
            this.panelOcultarMostarTexto.Controls.Add(this.checkBoxCursiva);
            this.panelOcultarMostarTexto.Controls.Add(this.checkBoxNegrita);
            this.panelOcultarMostarTexto.Controls.Add(this.buttonCerrar);
            this.panelOcultarMostarTexto.Controls.Add(this.buttonMostrarTexto);
            this.panelOcultarMostarTexto.Controls.Add(this.buttonOcultarTexto);
            this.panelOcultarMostarTexto.Location = new System.Drawing.Point(13, 379);
            this.panelOcultarMostarTexto.Name = "panelOcultarMostarTexto";
            this.panelOcultarMostarTexto.Size = new System.Drawing.Size(439, 106);
            this.panelOcultarMostarTexto.TabIndex = 5;
            // 
            // checkBoxSubrayado
            // 
            this.checkBoxSubrayado.AutoSize = true;
            this.checkBoxSubrayado.Location = new System.Drawing.Point(312, 67);
            this.checkBoxSubrayado.Name = "checkBoxSubrayado";
            this.checkBoxSubrayado.Size = new System.Drawing.Size(77, 17);
            this.checkBoxSubrayado.TabIndex = 5;
            this.checkBoxSubrayado.Text = "Subrayado";
            this.checkBoxSubrayado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxSubrayado.UseVisualStyleBackColor = true;
            this.checkBoxSubrayado.CheckedChanged += new System.EventHandler(this.checkBoxSubrayado_CheckedChanged);
            // 
            // checkBoxCursiva
            // 
            this.checkBoxCursiva.AutoSize = true;
            this.checkBoxCursiva.Location = new System.Drawing.Point(178, 67);
            this.checkBoxCursiva.Name = "checkBoxCursiva";
            this.checkBoxCursiva.Size = new System.Drawing.Size(61, 17);
            this.checkBoxCursiva.TabIndex = 4;
            this.checkBoxCursiva.Text = "Cursiva";
            this.checkBoxCursiva.UseVisualStyleBackColor = true;
            this.checkBoxCursiva.CheckedChanged += new System.EventHandler(this.checkBoxCursiva_CheckedChanged);
            // 
            // checkBoxNegrita
            // 
            this.checkBoxNegrita.AutoSize = true;
            this.checkBoxNegrita.Location = new System.Drawing.Point(40, 67);
            this.checkBoxNegrita.Name = "checkBoxNegrita";
            this.checkBoxNegrita.Size = new System.Drawing.Size(60, 17);
            this.checkBoxNegrita.TabIndex = 3;
            this.checkBoxNegrita.Text = "Negrita";
            this.checkBoxNegrita.UseVisualStyleBackColor = true;
            this.checkBoxNegrita.CheckedChanged += new System.EventHandler(this.checkBoxNegrita_CheckedChanged);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(302, 24);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(97, 23);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonMostrarTexto
            // 
            this.buttonMostrarTexto.Location = new System.Drawing.Point(158, 24);
            this.buttonMostrarTexto.Name = "buttonMostrarTexto";
            this.buttonMostrarTexto.Size = new System.Drawing.Size(97, 23);
            this.buttonMostrarTexto.TabIndex = 1;
            this.buttonMostrarTexto.Text = "Mostrar Texto";
            this.buttonMostrarTexto.UseVisualStyleBackColor = true;
            this.buttonMostrarTexto.Click += new System.EventHandler(this.buttonMostrarTexto_Click);
            // 
            // buttonOcultarTexto
            // 
            this.buttonOcultarTexto.Location = new System.Drawing.Point(14, 24);
            this.buttonOcultarTexto.Name = "buttonOcultarTexto";
            this.buttonOcultarTexto.Size = new System.Drawing.Size(97, 23);
            this.buttonOcultarTexto.TabIndex = 0;
            this.buttonOcultarTexto.Text = "Ocultar Texto";
            this.buttonOcultarTexto.UseVisualStyleBackColor = true;
            this.buttonOcultarTexto.Click += new System.EventHandler(this.buttonOcultarTexto_Click);
            // 
            // listBoxFuentes
            // 
            this.listBoxFuentes.FormattingEnabled = true;
            this.listBoxFuentes.Location = new System.Drawing.Point(472, 13);
            this.listBoxFuentes.Name = "listBoxFuentes";
            this.listBoxFuentes.Size = new System.Drawing.Size(205, 472);
            this.listBoxFuentes.TabIndex = 6;
            this.listBoxFuentes.SelectedIndexChanged += new System.EventHandler(this.listBoxFuentes_SelectedIndexChanged);
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(325, 268);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(43, 13);
            this.labelTexto.TabIndex = 7;
            this.labelTexto.Text = "TEXTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 523);
            this.Controls.Add(this.labelTexto);
            this.Controls.Add(this.listBoxFuentes);
            this.Controls.Add(this.panelOcultarMostarTexto);
            this.Controls.Add(this.panelTamanyoTexto);
            this.Controls.Add(this.panelPropiedadesFORM);
            this.MaximumSize = new System.Drawing.Size(1440, 1100);
            this.MinimumSize = new System.Drawing.Size(720, 550);
            this.Name = "Form1";
            this.Text = "Formatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelPropiedadesFORM.ResumeLayout(false);
            this.panelPropiedadesFORM.PerformLayout();
            this.groupBoxColorFORM.ResumeLayout(false);
            this.panelTamanyoTexto.ResumeLayout(false);
            this.panelTamanyoTexto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTamanyoTexto)).EndInit();
            this.groupBoxColorTexto.ResumeLayout(false);
            this.panelOcultarMostarTexto.ResumeLayout(false);
            this.panelOcultarMostarTexto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPropiedadesFORM;
        private System.Windows.Forms.Label labelTamanyoTexto;
        private System.Windows.Forms.Panel panelPropiedadesFORM;
        private System.Windows.Forms.Button buttonReducirFORM;
        private System.Windows.Forms.Button buttonAumentarFORM;
        private System.Windows.Forms.GroupBox groupBoxColorFORM;
        private System.Windows.Forms.Button btnRojo;
        private System.Windows.Forms.Button btnAzul;
        private System.Windows.Forms.Button btnVerde;
        private System.Windows.Forms.Panel panelTamanyoTexto;
        private System.Windows.Forms.GroupBox groupBoxColorTexto;
        private System.Windows.Forms.Button btnColorTextoRojo;
        private System.Windows.Forms.Button btnColorTextoVioleta;
        private System.Windows.Forms.Button btnColorTextoVerde;
        private System.Windows.Forms.NumericUpDown numericUpDownTamanyoTexto;
        private System.Windows.Forms.Panel panelOcultarMostarTexto;
        private System.Windows.Forms.CheckBox checkBoxSubrayado;
        private System.Windows.Forms.CheckBox checkBoxCursiva;
        private System.Windows.Forms.CheckBox checkBoxNegrita;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonMostrarTexto;
        private System.Windows.Forms.Button buttonOcultarTexto;
        private System.Windows.Forms.ListBox listBoxFuentes;
        private System.Windows.Forms.Label labelTexto;
    }
}

