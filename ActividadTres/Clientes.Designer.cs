﻿namespace ActividadTres
{
    partial class Clientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreCompleto = new System.Windows.Forms.TextBox();
            this.txtCorreoEletronico = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textIDActualizar = new System.Windows.Forms.TextBox();
            this.txtNombreCompletoActualizar = new System.Windows.Forms.TextBox();
            this.txtTelefonoActualizar = new System.Windows.Forms.TextBox();
            this.txtCorreoelectronicoActualizar = new System.Windows.Forms.TextBox();
            this.txtDireccionActualizar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo Electronico";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.Location = new System.Drawing.Point(37, 117);
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.Size = new System.Drawing.Size(170, 26);
            this.txtNombreCompleto.TabIndex = 4;
            // 
            // txtCorreoEletronico
            // 
            this.txtCorreoEletronico.Location = new System.Drawing.Point(37, 197);
            this.txtCorreoEletronico.Name = "txtCorreoEletronico";
            this.txtCorreoEletronico.Size = new System.Drawing.Size(170, 26);
            this.txtCorreoEletronico.TabIndex = 5;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(262, 117);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(170, 26);
            this.txtTelefono.TabIndex = 6;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(262, 197);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(170, 26);
            this.txtDireccion.TabIndex = 7;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.DarkGreen;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(25, 268);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(407, 45);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClienteID);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtCorreoEletronico);
            this.groupBox1.Controls.Add(this.txtNombreCompleto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 360);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar";
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(37, 48);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(170, 26);
            this.txtClienteID.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID";
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminar.Location = new System.Drawing.Point(53, 100);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(233, 42);
            this.btnEliminar.TabIndex = 11;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(53, 45);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(233, 26);
            this.txtEliminar.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtEliminar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(504, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 304);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nombre Completo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Telefono";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 20);
            this.label9.TabIndex = 17;
            this.label9.Text = "Correo Electronico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(271, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Dirección";
            // 
            // textIDActualizar
            // 
            this.textIDActualizar.Location = new System.Drawing.Point(40, 45);
            this.textIDActualizar.Name = "textIDActualizar";
            this.textIDActualizar.Size = new System.Drawing.Size(233, 26);
            this.textIDActualizar.TabIndex = 19;
            // 
            // txtNombreCompletoActualizar
            // 
            this.txtNombreCompletoActualizar.Location = new System.Drawing.Point(40, 120);
            this.txtNombreCompletoActualizar.Name = "txtNombreCompletoActualizar";
            this.txtNombreCompletoActualizar.Size = new System.Drawing.Size(179, 26);
            this.txtNombreCompletoActualizar.TabIndex = 20;
            // 
            // txtTelefonoActualizar
            // 
            this.txtTelefonoActualizar.Location = new System.Drawing.Point(275, 120);
            this.txtTelefonoActualizar.Name = "txtTelefonoActualizar";
            this.txtTelefonoActualizar.Size = new System.Drawing.Size(179, 26);
            this.txtTelefonoActualizar.TabIndex = 21;
            // 
            // txtCorreoelectronicoActualizar
            // 
            this.txtCorreoelectronicoActualizar.Location = new System.Drawing.Point(40, 194);
            this.txtCorreoelectronicoActualizar.Name = "txtCorreoelectronicoActualizar";
            this.txtCorreoelectronicoActualizar.Size = new System.Drawing.Size(179, 26);
            this.txtCorreoelectronicoActualizar.TabIndex = 22;
            // 
            // txtDireccionActualizar
            // 
            this.txtDireccionActualizar.Location = new System.Drawing.Point(275, 194);
            this.txtDireccionActualizar.Name = "txtDireccionActualizar";
            this.txtDireccionActualizar.Size = new System.Drawing.Size(179, 26);
            this.txtDireccionActualizar.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(40, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(414, 45);
            this.button1.TabIndex = 24;
            this.button1.Text = "Actualizar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtDireccionActualizar);
            this.groupBox3.Controls.Add(this.txtCorreoelectronicoActualizar);
            this.groupBox3.Controls.Add(this.txtTelefonoActualizar);
            this.groupBox3.Controls.Add(this.txtNombreCompletoActualizar);
            this.groupBox3.Controls.Add(this.textIDActualizar);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(853, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(495, 304);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actualizar";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCargar.Location = new System.Drawing.Point(37, 50);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(1209, 55);
            this.btnCargar.TabIndex = 26;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click_1);
            // 
            // dgClientes
            // 
            this.dgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(37, 111);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 62;
            this.dgClientes.RowTemplate.Height = 28;
            this.dgClientes.Size = new System.Drawing.Size(1209, 233);
            this.dgClientes.TabIndex = 27;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgClientes);
            this.groupBox4.Controls.Add(this.btnCargar);
            this.groupBox4.Location = new System.Drawing.Point(27, 420);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1320, 363);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mostrar";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 801);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreCompleto;
        private System.Windows.Forms.TextBox txtCorreoEletronico;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textIDActualizar;
        private System.Windows.Forms.TextBox txtNombreCompletoActualizar;
        private System.Windows.Forms.TextBox txtTelefonoActualizar;
        private System.Windows.Forms.TextBox txtCorreoelectronicoActualizar;
        private System.Windows.Forms.TextBox txtDireccionActualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label label11;
    }
}

