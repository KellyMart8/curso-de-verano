namespace Solicitud_de_prestamo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoIng = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCuota = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.mtIng = new System.Windows.Forms.MaskedTextBox();
            this.mtMontoR = new System.Windows.Forms.MaskedTextBox();
            this.mtEgr = new System.Windows.Forms.MaskedTextBox();
            this.cboPlazo = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnCLear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAprob = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // cboTipoIng
            // 
            this.cboTipoIng.FormattingEnabled = true;
            this.cboTipoIng.Items.AddRange(new object[] {
            "Asalariado",
            "Jubilado",
            "Ingreso Propio"});
            this.cboTipoIng.Location = new System.Drawing.Point(680, 20);
            this.cboTipoIng.Name = "cboTipoIng";
            this.cboTipoIng.Size = new System.Drawing.Size(121, 26);
            this.cboTipoIng.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(89, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Ingreso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Egreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ingreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(289, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Monto Requerido";
            // 
            // txtCuota
            // 
            this.txtCuota.Location = new System.Drawing.Point(362, 128);
            this.txtCuota.Name = "txtCuota";
            this.txtCuota.Size = new System.Drawing.Size(121, 22);
            this.txtCuota.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(289, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Cuota";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(289, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Plazo";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // mtIng
            // 
            this.mtIng.Location = new System.Drawing.Point(89, 81);
            this.mtIng.Mask = "999990000";
            this.mtIng.Name = "mtIng";
            this.mtIng.Size = new System.Drawing.Size(69, 22);
            this.mtIng.TabIndex = 14;
            this.mtIng.ValidatingType = typeof(int);
            // 
            // mtMontoR
            // 
            this.mtMontoR.Location = new System.Drawing.Point(414, 20);
            this.mtMontoR.Mask = "999990000";
            this.mtMontoR.Name = "mtMontoR";
            this.mtMontoR.Size = new System.Drawing.Size(69, 22);
            this.mtMontoR.TabIndex = 15;
            this.mtMontoR.ValidatingType = typeof(int);
            // 
            // mtEgr
            // 
            this.mtEgr.Location = new System.Drawing.Point(89, 128);
            this.mtEgr.Mask = "999990000";
            this.mtEgr.Name = "mtEgr";
            this.mtEgr.Size = new System.Drawing.Size(69, 22);
            this.mtEgr.TabIndex = 16;
            this.mtEgr.ValidatingType = typeof(int);
            // 
            // cboPlazo
            // 
            this.cboPlazo.FormattingEnabled = true;
            this.cboPlazo.Items.AddRange(new object[] {
            "6",
            "9",
            "12",
            "19",
            "24",
            "36"});
            this.cboPlazo.Location = new System.Drawing.Point(362, 69);
            this.cboPlazo.Name = "cboPlazo";
            this.cboPlazo.Size = new System.Drawing.Size(121, 26);
            this.cboPlazo.TabIndex = 17;
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSalir.Location = new System.Drawing.Point(724, 517);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(77, 29);
            this.btnSalir.TabIndex = 18;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCalc.Location = new System.Drawing.Point(27, 274);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(77, 29);
            this.btnCalc.TabIndex = 19;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnCLear
            // 
            this.btnCLear.ForeColor = System.Drawing.Color.IndianRed;
            this.btnCLear.Location = new System.Drawing.Point(282, 274);
            this.btnCLear.Name = "btnCLear";
            this.btnCLear.Size = new System.Drawing.Size(77, 29);
            this.btnCLear.TabIndex = 20;
            this.btnCLear.Text = "Limpiar";
            this.btnCLear.UseVisualStyleBackColor = true;
            this.btnCLear.Click += new System.EventHandler(this.btnCLear_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(27, 335);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 226);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.IndianRed;
            this.btnAdd.Location = new System.Drawing.Point(153, 274);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(77, 29);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAprob
            // 
            this.txtAprob.Location = new System.Drawing.Point(663, 276);
            this.txtAprob.Multiline = true;
            this.txtAprob.Name = "txtAprob";
            this.txtAprob.Size = new System.Drawing.Size(138, 20);
            this.txtAprob.TabIndex = 23;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nº";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Primer Cuota";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Interes";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cuota";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Saldo";
            this.Column5.Name = "Column5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(833, 573);
            this.Controls.Add(this.txtAprob);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCLear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.cboPlazo);
            this.Controls.Add(this.mtEgr);
            this.Controls.Add(this.mtMontoR);
            this.Controls.Add(this.mtIng);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCuota);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cboTipoIng);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoIng;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCuota;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox mtIng;
        private System.Windows.Forms.MaskedTextBox mtMontoR;
        private System.Windows.Forms.MaskedTextBox mtEgr;
        private System.Windows.Forms.ComboBox cboPlazo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnCLear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAprob;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}

