﻿namespace prySandrinLog
{
    partial class mainform
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
            this.statusPrincipal = new System.Windows.Forms.StatusStrip();
            this.lblEstadoConexion = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnConectarBase = new System.Windows.Forms.Button();
            this.DataGridViewLOG = new System.Windows.Forms.DataGridView();
            this.btnTraerDatos = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.statusPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOG)).BeginInit();
            this.SuspendLayout();
            // 
            // statusPrincipal
            // 
            this.statusPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstadoConexion});
            this.statusPrincipal.Location = new System.Drawing.Point(0, 532);
            this.statusPrincipal.Name = "statusPrincipal";
            this.statusPrincipal.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusPrincipal.Size = new System.Drawing.Size(881, 22);
            this.statusPrincipal.TabIndex = 0;
            this.statusPrincipal.Text = "statusStrip1";
            // 
            // lblEstadoConexion
            // 
            this.lblEstadoConexion.Name = "lblEstadoConexion";
            this.lblEstadoConexion.Size = new System.Drawing.Size(111, 17);
            this.lblEstadoConexion.Text = "Estado de Conexion";
            // 
            // btnConectarBase
            // 
            this.btnConectarBase.BackColor = System.Drawing.Color.Brown;
            this.btnConectarBase.Location = new System.Drawing.Point(18, 44);
            this.btnConectarBase.Margin = new System.Windows.Forms.Padding(4);
            this.btnConectarBase.Name = "btnConectarBase";
            this.btnConectarBase.Size = new System.Drawing.Size(195, 43);
            this.btnConectarBase.TabIndex = 1;
            this.btnConectarBase.Text = "Conectar Base";
            this.btnConectarBase.UseVisualStyleBackColor = false;
            this.btnConectarBase.Click += new System.EventHandler(this.button1_Click);
            // 
            // DataGridViewLOG
            // 
            this.DataGridViewLOG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLOG.Location = new System.Drawing.Point(234, 44);
            this.DataGridViewLOG.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewLOG.Name = "DataGridViewLOG";
            this.DataGridViewLOG.Size = new System.Drawing.Size(620, 357);
            this.DataGridViewLOG.TabIndex = 2;
            this.DataGridViewLOG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewLOG_CellContentClick);
            // 
            // btnTraerDatos
            // 
            this.btnTraerDatos.BackColor = System.Drawing.Color.Brown;
            this.btnTraerDatos.Location = new System.Drawing.Point(18, 129);
            this.btnTraerDatos.Margin = new System.Windows.Forms.Padding(4);
            this.btnTraerDatos.Name = "btnTraerDatos";
            this.btnTraerDatos.Size = new System.Drawing.Size(195, 47);
            this.btnTraerDatos.TabIndex = 3;
            this.btnTraerDatos.Text = "Traer Datos";
            this.btnTraerDatos.UseVisualStyleBackColor = false;
            this.btnTraerDatos.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Brown;
            this.btnRegistrar.Location = new System.Drawing.Point(18, 213);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(195, 55);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Listar y registrar informacion";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 354);
            this.lblID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(22, 16);
            this.lblID.TabIndex = 5;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(54, 348);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 6;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(881, 554);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnTraerDatos);
            this.Controls.Add(this.DataGridViewLOG);
            this.Controls.Add(this.btnConectarBase);
            this.Controls.Add(this.statusPrincipal);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainform";
            this.Text = "FORMULARIO PRINCIPAL";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusPrincipal.ResumeLayout(false);
            this.statusPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLOG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoConexion;
        private System.Windows.Forms.Button btnConectarBase;
        private System.Windows.Forms.DataGridView DataGridViewLOG;
        private System.Windows.Forms.Button btnTraerDatos;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
    }
}

