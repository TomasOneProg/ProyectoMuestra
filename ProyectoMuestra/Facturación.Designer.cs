namespace ProyectoMuestra
{
    partial class Facturación
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnFac = new System.Windows.Forms.Button();
            this.btnNue = new System.Windows.Forms.Button();
            this.btnPro = new System.Windows.Forms.Button();
            this.btnCli = new System.Windows.Forms.Button();
            this.btnEli = new System.Windows.Forms.Button();
            this.btnCol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColCod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.a = new System.Windows.Forms.TextBox();
            this.v = new System.Windows.Forms.TextBox();
            this.vb = new System.Windows.Forms.TextBox();
            this.b = new System.Windows.Forms.TextBox();
            this.n = new System.Windows.Forms.TextBox();
            this.m = new System.Windows.Forms.TextBox();
            this.lblAtiende = new System.Windows.Forms.Label();
            this.txtCodbus = new MiLibreria.ErrorBox();
            this.txtCli = new MiLibreria.ErrorBox();
            this.txtCod = new MiLibreria.ErrorBox();
            this.txtDes = new MiLibreria.ErrorBox();
            this.txtPre = new MiLibreria.ErrorBox();
            this.txtCan = new MiLibreria.ErrorBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(605, 342);
            this.btnSalir.Size = new System.Drawing.Size(183, 23);
            // 
            // btnFac
            // 
            this.btnFac.Location = new System.Drawing.Point(605, 313);
            this.btnFac.Name = "btnFac";
            this.btnFac.Size = new System.Drawing.Size(183, 23);
            this.btnFac.TabIndex = 1;
            this.btnFac.Text = "Facturar";
            this.btnFac.UseVisualStyleBackColor = true;
            this.btnFac.Click += new System.EventHandler(this.btnFac_Click);
            // 
            // btnNue
            // 
            this.btnNue.Location = new System.Drawing.Point(605, 284);
            this.btnNue.Name = "btnNue";
            this.btnNue.Size = new System.Drawing.Size(183, 23);
            this.btnNue.TabIndex = 2;
            this.btnNue.Text = "Nuevo";
            this.btnNue.UseVisualStyleBackColor = true;
            this.btnNue.Click += new System.EventHandler(this.btnNue_Click);
            // 
            // btnPro
            // 
            this.btnPro.Location = new System.Drawing.Point(605, 255);
            this.btnPro.Name = "btnPro";
            this.btnPro.Size = new System.Drawing.Size(183, 23);
            this.btnPro.TabIndex = 3;
            this.btnPro.Text = "Productos";
            this.btnPro.UseVisualStyleBackColor = true;
            this.btnPro.Click += new System.EventHandler(this.btnPro_Click);
            // 
            // btnCli
            // 
            this.btnCli.Location = new System.Drawing.Point(605, 226);
            this.btnCli.Name = "btnCli";
            this.btnCli.Size = new System.Drawing.Size(183, 23);
            this.btnCli.TabIndex = 4;
            this.btnCli.Text = "Clientes";
            this.btnCli.UseVisualStyleBackColor = true;
            this.btnCli.Click += new System.EventHandler(this.btnCli_Click);
            // 
            // btnEli
            // 
            this.btnEli.Location = new System.Drawing.Point(605, 197);
            this.btnEli.Name = "btnEli";
            this.btnEli.Size = new System.Drawing.Size(183, 23);
            this.btnEli.TabIndex = 5;
            this.btnEli.Text = "Eliminar";
            this.btnEli.UseVisualStyleBackColor = true;
            this.btnEli.Click += new System.EventHandler(this.btnEli_Click);
            // 
            // btnCol
            // 
            this.btnCol.Location = new System.Drawing.Point(605, 168);
            this.btnCol.Name = "btnCol";
            this.btnCol.Size = new System.Drawing.Size(183, 23);
            this.btnCol.TabIndex = 6;
            this.btnCol.Text = "Colocar";
            this.btnCol.UseVisualStyleBackColor = true;
            this.btnCol.Click += new System.EventHandler(this.btnCol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(488, 403);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 8;
            this.lblTotal.Text = " ";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColCod,
            this.ColDes,
            this.ColPre,
            this.ColCan,
            this.ColImp});
            this.dataGridView1.Location = new System.Drawing.Point(46, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(542, 197);
            this.dataGridView1.TabIndex = 9;
            // 
            // ColCod
            // 
            this.ColCod.HeaderText = "Código";
            this.ColCod.Name = "ColCod";
            this.ColCod.ReadOnly = true;
            this.ColCod.Width = 90;
            // 
            // ColDes
            // 
            this.ColDes.HeaderText = "Descripción";
            this.ColDes.Name = "ColDes";
            this.ColDes.ReadOnly = true;
            this.ColDes.Width = 150;
            // 
            // ColPre
            // 
            this.ColPre.HeaderText = "Precio";
            this.ColPre.Name = "ColPre";
            this.ColPre.ReadOnly = true;
            // 
            // ColCan
            // 
            this.ColCan.HeaderText = "Cantidad";
            this.ColCan.Name = "ColCan";
            this.ColCan.ReadOnly = true;
            // 
            // ColImp
            // 
            this.ColImp.HeaderText = "Importe";
            this.ColImp.Name = "ColImp";
            this.ColImp.ReadOnly = true;
            this.ColImp.Width = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Le atiende:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Código:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Cliente:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(199, 55);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // a
            // 
            this.a.Location = new System.Drawing.Point(46, 449);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(100, 20);
            this.a.TabIndex = 14;
            // 
            // v
            // 
            this.v.Location = new System.Drawing.Point(46, 475);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(181, 20);
            this.v.TabIndex = 15;
            // 
            // vb
            // 
            this.vb.Location = new System.Drawing.Point(46, 501);
            this.vb.Name = "vb";
            this.vb.Size = new System.Drawing.Size(100, 20);
            this.vb.TabIndex = 16;
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(174, 501);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(100, 20);
            this.b.TabIndex = 17;
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(297, 501);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 20);
            this.n.TabIndex = 18;
            // 
            // m
            // 
            this.m.Location = new System.Drawing.Point(420, 501);
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(100, 20);
            this.m.TabIndex = 19;
            // 
            // lblAtiende
            // 
            this.lblAtiende.AutoSize = true;
            this.lblAtiende.Location = new System.Drawing.Point(110, 28);
            this.lblAtiende.Name = "lblAtiende";
            this.lblAtiende.Size = new System.Drawing.Size(13, 13);
            this.lblAtiende.TabIndex = 20;
            this.lblAtiende.Text = " -";
            // 
            // txtCodbus
            // 
            this.txtCodbus.Location = new System.Drawing.Point(93, 57);
            this.txtCodbus.Name = "txtCodbus";
            this.txtCodbus.Numeros = false;
            this.txtCodbus.Size = new System.Drawing.Size(100, 20);
            this.txtCodbus.TabIndex = 21;
            this.txtCodbus.Validar = true;
            // 
            // txtCli
            // 
            this.txtCli.Location = new System.Drawing.Point(93, 91);
            this.txtCli.Name = "txtCli";
            this.txtCli.Numeros = false;
            this.txtCli.Size = new System.Drawing.Size(181, 20);
            this.txtCli.TabIndex = 22;
            this.txtCli.Validar = true;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(46, 130);
            this.txtCod.Name = "txtCod";
            this.txtCod.Numeros = false;
            this.txtCod.Size = new System.Drawing.Size(100, 20);
            this.txtCod.TabIndex = 23;
            this.txtCod.Validar = true;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(174, 130);
            this.txtDes.Name = "txtDes";
            this.txtDes.Numeros = false;
            this.txtDes.Size = new System.Drawing.Size(100, 20);
            this.txtDes.TabIndex = 24;
            this.txtDes.Validar = true;
            // 
            // txtPre
            // 
            this.txtPre.Location = new System.Drawing.Point(297, 129);
            this.txtPre.Name = "txtPre";
            this.txtPre.Numeros = false;
            this.txtPre.Size = new System.Drawing.Size(100, 20);
            this.txtPre.TabIndex = 25;
            this.txtPre.Validar = true;
            // 
            // txtCan
            // 
            this.txtCan.Location = new System.Drawing.Point(420, 129);
            this.txtCan.Name = "txtCan";
            this.txtCan.Numeros = false;
            this.txtCan.Size = new System.Drawing.Size(100, 20);
            this.txtCan.TabIndex = 26;
            this.txtCan.Validar = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Facturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 533);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.txtPre);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.txtCli);
            this.Controls.Add(this.txtCodbus);
            this.Controls.Add(this.lblAtiende);
            this.Controls.Add(this.m);
            this.Controls.Add(this.n);
            this.Controls.Add(this.b);
            this.Controls.Add(this.vb);
            this.Controls.Add(this.v);
            this.Controls.Add(this.a);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCol);
            this.Controls.Add(this.btnEli);
            this.Controls.Add(this.btnCli);
            this.Controls.Add(this.btnPro);
            this.Controls.Add(this.btnNue);
            this.Controls.Add(this.btnFac);
            this.Name = "Facturación";
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Facturación_Load);
            this.Controls.SetChildIndex(this.btnSalir, 0);
            this.Controls.SetChildIndex(this.btnFac, 0);
            this.Controls.SetChildIndex(this.btnNue, 0);
            this.Controls.SetChildIndex(this.btnPro, 0);
            this.Controls.SetChildIndex(this.btnCli, 0);
            this.Controls.SetChildIndex(this.btnEli, 0);
            this.Controls.SetChildIndex(this.btnCol, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.btnBuscar, 0);
            this.Controls.SetChildIndex(this.a, 0);
            this.Controls.SetChildIndex(this.v, 0);
            this.Controls.SetChildIndex(this.vb, 0);
            this.Controls.SetChildIndex(this.b, 0);
            this.Controls.SetChildIndex(this.n, 0);
            this.Controls.SetChildIndex(this.m, 0);
            this.Controls.SetChildIndex(this.lblAtiende, 0);
            this.Controls.SetChildIndex(this.txtCodbus, 0);
            this.Controls.SetChildIndex(this.txtCli, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.txtDes, 0);
            this.Controls.SetChildIndex(this.txtPre, 0);
            this.Controls.SetChildIndex(this.txtCan, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFac;
        private System.Windows.Forms.Button btnNue;
        private System.Windows.Forms.Button btnPro;
        private System.Windows.Forms.Button btnCli;
        private System.Windows.Forms.Button btnEli;
        private System.Windows.Forms.Button btnCol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox a;
        private System.Windows.Forms.TextBox v;
        private System.Windows.Forms.TextBox vb;
        private System.Windows.Forms.TextBox b;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.TextBox m;
        private System.Windows.Forms.Label lblAtiende;
        private MiLibreria.ErrorBox txtCodbus;
        private MiLibreria.ErrorBox txtCli;
        private MiLibreria.ErrorBox txtCod;
        private MiLibreria.ErrorBox txtDes;
        private MiLibreria.ErrorBox txtPre;
        private MiLibreria.ErrorBox txtCan;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColImp;
    }
}