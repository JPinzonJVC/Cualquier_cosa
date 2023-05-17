namespace Entrega_Final_ED
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lvDatos = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.btnregis = new System.Windows.Forms.Button();
            this.txtTR = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.lblTR = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.btnprestados = new System.Windows.Forms.Button();
            this.btntodos = new System.Windows.Forms.Button();
            this.txtbuscar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnprestar = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblcod = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.lbldoc = new System.Windows.Forms.Label();
            this.txtdoc = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btnAR = new System.Windows.Forms.Button();
            this.btnCR = new System.Windows.Forms.Button();
            this.btnCP = new System.Windows.Forms.Button();
            this.btnAP = new System.Windows.Forms.Button();
            this.lvPrestados = new System.Windows.Forms.ListView();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader9 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader10 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // lvDatos
            // 
            this.lvDatos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvDatos.FullRowSelect = true;
            this.lvDatos.GridLines = true;
            this.lvDatos.Location = new System.Drawing.Point(25, 235);
            this.lvDatos.Name = "lvDatos";
            this.lvDatos.Size = new System.Drawing.Size(829, 202);
            this.lvDatos.TabIndex = 0;
            this.lvDatos.UseCompatibleStateImageBehavior = false;
            this.lvDatos.UseWaitCursor = true;
            this.lvDatos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Codigo";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Titulo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Autor";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Disponibilidad";
            // 
            // btnregis
            // 
            this.btnregis.BackColor = System.Drawing.Color.DarkGray;
            this.btnregis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregis.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnregis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnregis.Location = new System.Drawing.Point(161, 24);
            this.btnregis.Name = "btnregis";
            this.btnregis.Size = new System.Drawing.Size(120, 35);
            this.btnregis.TabIndex = 1;
            this.btnregis.Text = "REGISTRAR";
            this.btnregis.UseVisualStyleBackColor = false;
            this.btnregis.Click += new System.EventHandler(this.btnregis_Click);
            // 
            // txtTR
            // 
            this.txtTR.Location = new System.Drawing.Point(287, 36);
            this.txtTR.Name = "txtTR";
            this.txtTR.Size = new System.Drawing.Size(152, 23);
            this.txtTR.TabIndex = 2;
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(445, 36);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(161, 23);
            this.txtautor.TabIndex = 3;
            // 
            // lblTR
            // 
            this.lblTR.AutoSize = true;
            this.lblTR.BackColor = System.Drawing.Color.Transparent;
            this.lblTR.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTR.Location = new System.Drawing.Point(287, 9);
            this.lblTR.Name = "lblTR";
            this.lblTR.Size = new System.Drawing.Size(51, 24);
            this.lblTR.TabIndex = 4;
            this.lblTR.Text = "Título";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.BackColor = System.Drawing.Color.Transparent;
            this.lblAutor.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAutor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAutor.Location = new System.Drawing.Point(445, 12);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(52, 24);
            this.lblAutor.TabIndex = 5;
            this.lblAutor.Text = "Autor";
            // 
            // btnprestados
            // 
            this.btnprestados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnprestados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprestados.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnprestados.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnprestados.Location = new System.Drawing.Point(104, 202);
            this.btnprestados.Name = "btnprestados";
            this.btnprestados.Size = new System.Drawing.Size(83, 27);
            this.btnprestados.TabIndex = 6;
            this.btnprestados.Text = "Prestados";
            this.btnprestados.UseVisualStyleBackColor = false;
            this.btnprestados.Click += new System.EventHandler(this.btnprestados_Click);
            // 
            // btntodos
            // 
            this.btntodos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btntodos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btntodos.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btntodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btntodos.Location = new System.Drawing.Point(25, 202);
            this.btntodos.Name = "btntodos";
            this.btntodos.Size = new System.Drawing.Size(67, 27);
            this.btntodos.TabIndex = 7;
            this.btntodos.Text = "Todos";
            this.btntodos.UseVisualStyleBackColor = false;
            this.btntodos.Click += new System.EventHandler(this.btntodos_Click);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(705, 206);
            this.txtbuscar.Name = "txtbuscar";
            this.txtbuscar.Size = new System.Drawing.Size(118, 23);
            this.txtbuscar.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(649, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Título :";
            // 
            // btnprestar
            // 
            this.btnprestar.BackColor = System.Drawing.Color.DarkGray;
            this.btnprestar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnprestar.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnprestar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnprestar.Location = new System.Drawing.Point(161, 93);
            this.btnprestar.Name = "btnprestar";
            this.btnprestar.Size = new System.Drawing.Size(120, 35);
            this.btnprestar.TabIndex = 11;
            this.btnprestar.Text = "PRESTAR";
            this.btnprestar.UseVisualStyleBackColor = false;
            this.btnprestar.Click += new System.EventHandler(this.btnprestar_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.Color.Transparent;
            this.lblnombre.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblnombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblnombre.Location = new System.Drawing.Point(445, 81);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(65, 24);
            this.lblnombre.TabIndex = 15;
            this.lblnombre.Text = "Nombre";
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.BackColor = System.Drawing.Color.Transparent;
            this.lblcod.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcod.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblcod.Location = new System.Drawing.Point(287, 78);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(57, 24);
            this.lblcod.TabIndex = 14;
            this.lblcod.Text = "Codigo";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(445, 105);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(161, 23);
            this.txtnombre.TabIndex = 13;
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(287, 105);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(152, 23);
            this.txtcod.TabIndex = 12;
            // 
            // lbldoc
            // 
            this.lbldoc.AutoSize = true;
            this.lbldoc.BackColor = System.Drawing.Color.Transparent;
            this.lbldoc.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldoc.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbldoc.Location = new System.Drawing.Point(612, 81);
            this.lbldoc.Name = "lbldoc";
            this.lbldoc.Size = new System.Drawing.Size(90, 24);
            this.lbldoc.TabIndex = 17;
            this.lbldoc.Text = "Documento";
            // 
            // txtdoc
            // 
            this.txtdoc.Location = new System.Drawing.Point(612, 105);
            this.txtdoc.Name = "txtdoc";
            this.txtdoc.Size = new System.Drawing.Size(161, 23);
            this.txtdoc.TabIndex = 16;
            // 
            // btnbuscar
            // 
            this.btnbuscar.BackColor = System.Drawing.Color.DarkGray;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnbuscar.Image")));
            this.btnbuscar.Location = new System.Drawing.Point(829, 206);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(25, 23);
            this.btnbuscar.TabIndex = 18;
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.UseWaitCursor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btnAR
            // 
            this.btnAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnAR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAR.Image = ((System.Drawing.Image)(resources.GetObject("btnAR.Image")));
            this.btnAR.Location = new System.Drawing.Point(612, 36);
            this.btnAR.Name = "btnAR";
            this.btnAR.Size = new System.Drawing.Size(25, 23);
            this.btnAR.TabIndex = 19;
            this.btnAR.UseVisualStyleBackColor = false;
            this.btnAR.Click += new System.EventHandler(this.btnAR_Click);
            // 
            // btnCR
            // 
            this.btnCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnCR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCR.Image = ((System.Drawing.Image)(resources.GetObject("btnCR.Image")));
            this.btnCR.Location = new System.Drawing.Point(643, 36);
            this.btnCR.Name = "btnCR";
            this.btnCR.Size = new System.Drawing.Size(25, 23);
            this.btnCR.TabIndex = 20;
            this.btnCR.UseVisualStyleBackColor = false;
            this.btnCR.Click += new System.EventHandler(this.btnCR_Click);
            // 
            // btnCP
            // 
            this.btnCP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnCP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCP.Image = ((System.Drawing.Image)(resources.GetObject("btnCP.Image")));
            this.btnCP.Location = new System.Drawing.Point(810, 105);
            this.btnCP.Name = "btnCP";
            this.btnCP.Size = new System.Drawing.Size(25, 23);
            this.btnCP.TabIndex = 22;
            this.btnCP.UseVisualStyleBackColor = false;
            this.btnCP.Click += new System.EventHandler(this.btnCP_Click);
            // 
            // btnAP
            // 
            this.btnAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.btnAP.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAP.Image = ((System.Drawing.Image)(resources.GetObject("btnAP.Image")));
            this.btnAP.Location = new System.Drawing.Point(779, 105);
            this.btnAP.Name = "btnAP";
            this.btnAP.Size = new System.Drawing.Size(25, 23);
            this.btnAP.TabIndex = 21;
            this.btnAP.UseVisualStyleBackColor = false;
            this.btnAP.Click += new System.EventHandler(this.btnAP_Click);
            // 
            // lvPrestados
            // 
            this.lvPrestados.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvPrestados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvPrestados.FullRowSelect = true;
            this.lvPrestados.GridLines = true;
            this.lvPrestados.Location = new System.Drawing.Point(25, 235);
            this.lvPrestados.Name = "lvPrestados";
            this.lvPrestados.Size = new System.Drawing.Size(829, 202);
            this.lvPrestados.TabIndex = 23;
            this.lvPrestados.UseCompatibleStateImageBehavior = false;
            this.lvPrestados.UseWaitCursor = true;
            this.lvPrestados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Codigo";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Titulo";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Autor";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Disponibilidad";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Prestado por";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Documento";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lvPrestados);
            this.Controls.Add(this.btnCP);
            this.Controls.Add(this.btnAP);
            this.Controls.Add(this.btnCR);
            this.Controls.Add(this.btnAR);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.lbldoc);
            this.Controls.Add(this.txtdoc);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.btnprestar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbuscar);
            this.Controls.Add(this.btntodos);
            this.Controls.Add(this.btnprestados);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTR);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txtTR);
            this.Controls.Add(this.btnregis);
            this.Controls.Add(this.lvDatos);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Neboola";
            this.UseWaitCursor = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lvDatos;
        private Button btnregis;
        private TextBox txtTR;
        private TextBox txtautor;
        private Label lblTR;
        private Label lblAutor;
        private Button btnprestados;
        private Button btntodos;
        private TextBox txtbuscar;
        private Label label3;
        private Button btnprestar;
        private Label lblnombre;
        private Label lblcod;
        private TextBox txtnombre;
        private TextBox txtcod;
        private Label lbldoc;
        private TextBox txtdoc;
        private Button btnbuscar;
        private Button btnAR;
        private Button btnCR;
        private Button btnCP;
        private Button btnAP;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ListView lvPrestados;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
    }
}