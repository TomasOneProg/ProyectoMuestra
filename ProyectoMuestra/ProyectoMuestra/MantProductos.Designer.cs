namespace ProyectoMuestra
{
    partial class MantProductos
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
            this.labProd = new System.Windows.Forms.Label();
            this.labNom = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.a = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.c = new System.Windows.Forms.TextBox();
            this.txtIdPro = new MiLibreria.ErrorBox();
            this.txtNomPro = new MiLibreria.ErrorBox();
            this.txtPrePro = new MiLibreria.ErrorBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labProd
            // 
            this.labProd.AutoSize = true;
            this.labProd.Location = new System.Drawing.Point(65, 42);
            this.labProd.Name = "labProd";
            this.labProd.Size = new System.Drawing.Size(67, 13);
            this.labProd.TabIndex = 5;
            this.labProd.Text = "ID_Producto";
            // 
            // labNom
            // 
            this.labNom.AutoSize = true;
            this.labNom.Location = new System.Drawing.Point(65, 103);
            this.labNom.Name = "labNom";
            this.labNom.Size = new System.Drawing.Size(44, 13);
            this.labNom.TabIndex = 6;
            this.labNom.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(127, 271);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 8;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(339, 271);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 9;
            // 
            // c
            // 
            this.c.Location = new System.Drawing.Point(233, 271);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(100, 20);
            this.c.TabIndex = 10;
            // 
            // txtIdPro
            // 
            this.txtIdPro.Location = new System.Drawing.Point(144, 42);
            this.txtIdPro.Name = "txtIdPro";
            this.txtIdPro.Numeros = false;
            this.txtIdPro.Size = new System.Drawing.Size(100, 20);
            this.txtIdPro.TabIndex = 11;
            this.txtIdPro.Validar = true;
            this.txtIdPro.TextChanged += new System.EventHandler(this.txtIdPro_TextChanged);
            // 
            // txtNomPro
            // 
            this.txtNomPro.Location = new System.Drawing.Point(144, 102);
            this.txtNomPro.Name = "txtNomPro";
            this.txtNomPro.Numeros = false;
            this.txtNomPro.Size = new System.Drawing.Size(100, 20);
            this.txtNomPro.TabIndex = 12;
            this.txtNomPro.Validar = true;
            // 
            // txtPrePro
            // 
            this.txtPrePro.Location = new System.Drawing.Point(156, 170);
            this.txtPrePro.Name = "txtPrePro";
            this.txtPrePro.Numeros = false;
            this.txtPrePro.Size = new System.Drawing.Size(100, 20);
            this.txtPrePro.TabIndex = 13;
            this.txtPrePro.Validar = true;
            // 
            // MantProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 303);
            this.Controls.Add(this.txtPrePro);
            this.Controls.Add(this.txtNomPro);
            this.Controls.Add(this.txtIdPro);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labNom);
            this.Controls.Add(this.labProd);
            this.Name = "MantProductos";
            this.Text = "MantProductos";
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button4, 0);
            this.Controls.SetChildIndex(this.labProd, 0);
            this.Controls.SetChildIndex(this.labNom, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.a, 0);
            this.Controls.SetChildIndex(this.b, 0);
            this.Controls.SetChildIndex(this.c, 0);
            this.Controls.SetChildIndex(this.txtIdPro, 0);
            this.Controls.SetChildIndex(this.txtNomPro, 0);
            this.Controls.SetChildIndex(this.txtPrePro, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labProd;
        private System.Windows.Forms.Label labNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox c;
        private MiLibreria.ErrorBox txtIdPro;
        private MiLibreria.ErrorBox txtNomPro;
        private MiLibreria.ErrorBox txtPrePro;
    }
}