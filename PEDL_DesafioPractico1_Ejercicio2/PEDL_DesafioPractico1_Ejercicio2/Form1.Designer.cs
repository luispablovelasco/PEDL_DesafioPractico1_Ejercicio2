namespace PEDL_DesafioPractico1_Ejercicio2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGVdatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.masckcod = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.cbtipo = new System.Windows.Forms.ComboBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtbrowser = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.txtautor);
            this.groupBox1.Controls.Add(this.cbtipo);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.masckcod);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 312);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Datos:";
            // 
            // DGVdatos
            // 
            this.DGVdatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVdatos.Location = new System.Drawing.Point(23, 409);
            this.DGVdatos.Name = "DGVdatos";
            this.DGVdatos.Size = new System.Drawing.Size(756, 258);
            this.DGVdatos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // masckcod
            // 
            this.masckcod.Location = new System.Drawing.Point(74, 57);
            this.masckcod.Name = "masckcod";
            this.masckcod.Size = new System.Drawing.Size(283, 20);
            this.masckcod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Autor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(74, 107);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(283, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // cbtipo
            // 
            this.cbtipo.FormattingEnabled = true;
            this.cbtipo.Items.AddRange(new object[] {
            "Película",
            "Documental",
            "Disco Musical"});
            this.cbtipo.Location = new System.Drawing.Point(74, 152);
            this.cbtipo.Name = "cbtipo";
            this.cbtipo.Size = new System.Drawing.Size(283, 21);
            this.cbtipo.TabIndex = 7;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(74, 204);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(283, 20);
            this.txtautor.TabIndex = 8;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(13, 37);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(187, 46);
            this.btnregistrar.TabIndex = 2;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(13, 132);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(187, 46);
            this.btnmodificar.TabIndex = 3;
            this.btnmodificar.Text = "MODIFICAR";
            this.btnmodificar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(13, 232);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(187, 46);
            this.btneliminar.TabIndex = 4;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(11, 26);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(104, 31);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // txtbrowser
            // 
            this.txtbrowser.Location = new System.Drawing.Point(121, 32);
            this.txtbrowser.Name = "txtbrowser";
            this.txtbrowser.Size = new System.Drawing.Size(646, 20);
            this.txtbrowser.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btneliminar);
            this.groupBox2.Controls.Add(this.btnregistrar);
            this.groupBox2.Controls.Add(this.btnmodificar);
            this.groupBox2.Location = new System.Drawing.Point(579, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 306);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtbrowser);
            this.groupBox3.Controls.Add(this.btnbuscar);
            this.groupBox3.Location = new System.Drawing.Point(12, 341);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 332);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(74, 252);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(283, 20);
            this.txtprecio.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 685);
            this.Controls.Add(this.DGVdatos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVdatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.ComboBox cbtipo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox masckcod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGVdatos;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtbrowser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

