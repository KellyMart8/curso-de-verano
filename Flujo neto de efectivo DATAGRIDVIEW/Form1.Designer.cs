namespace Flujo_neto_de_efectivo_DATAGRIDVIEW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUtAntImp = new System.Windows.Forms.TextBox();
            this.txtImp = new System.Windows.Forms.TextBox();
            this.txtDep = new System.Windows.Forms.TextBox();
            this.txtUtDesp = new System.Windows.Forms.TextBox();
            this.MTInversionI = new System.Windows.Forms.MaskedTextBox();
            this.MTEgreso = new System.Windows.Forms.MaskedTextBox();
            this.MTIngreso = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBorrarElem = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblInformacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(257, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flujo neto de efectivo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inversion inicial";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingreso";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Egreso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Depreciacion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "utilidad despues de impuestos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(477, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 15);
            this.label7.TabIndex = 4;
            this.label7.Text = "Utilidad antes de impuestos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(477, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Impuesto";
            // 
            // txtUtAntImp
            // 
            this.txtUtAntImp.Enabled = false;
            this.txtUtAntImp.Location = new System.Drawing.Point(655, 71);
            this.txtUtAntImp.Name = "txtUtAntImp";
            this.txtUtAntImp.Size = new System.Drawing.Size(100, 23);
            this.txtUtAntImp.TabIndex = 8;
            // 
            // txtImp
            // 
            this.txtImp.Enabled = false;
            this.txtImp.Location = new System.Drawing.Point(655, 175);
            this.txtImp.Name = "txtImp";
            this.txtImp.Size = new System.Drawing.Size(100, 23);
            this.txtImp.TabIndex = 9;
            // 
            // txtDep
            // 
            this.txtDep.Enabled = false;
            this.txtDep.Location = new System.Drawing.Point(655, 138);
            this.txtDep.Name = "txtDep";
            this.txtDep.Size = new System.Drawing.Size(100, 23);
            this.txtDep.TabIndex = 10;
            // 
            // txtUtDesp
            // 
            this.txtUtDesp.Enabled = false;
            this.txtUtDesp.Location = new System.Drawing.Point(655, 104);
            this.txtUtDesp.Name = "txtUtDesp";
            this.txtUtDesp.Size = new System.Drawing.Size(100, 23);
            this.txtUtDesp.TabIndex = 11;
            // 
            // MTInversionI
            // 
            this.MTInversionI.Location = new System.Drawing.Point(114, 82);
            this.MTInversionI.Mask = "999990000000000000";
            this.MTInversionI.Name = "MTInversionI";
            this.MTInversionI.Size = new System.Drawing.Size(100, 23);
            this.MTInversionI.TabIndex = 12;
            this.MTInversionI.ValidatingType = typeof(int);
            // 
            // MTEgreso
            // 
            this.MTEgreso.Location = new System.Drawing.Point(114, 148);
            this.MTEgreso.Mask = "999990000000000000";
            this.MTEgreso.Name = "MTEgreso";
            this.MTEgreso.Size = new System.Drawing.Size(100, 23);
            this.MTEgreso.TabIndex = 13;
            this.MTEgreso.ValidatingType = typeof(int);
            // 
            // MTIngreso
            // 
            this.MTIngreso.Location = new System.Drawing.Point(114, 114);
            this.MTIngreso.Mask = "999990000000000000";
            this.MTIngreso.Name = "MTIngreso";
            this.MTIngreso.Size = new System.Drawing.Size(100, 23);
            this.MTIngreso.TabIndex = 14;
            this.MTIngreso.ValidatingType = typeof(int);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(743, 180);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Inversion Inicial";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ingreso";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Egreso";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Utilidad antes de imp.";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Utilidad desp imp";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Depreciacion";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Impuesto";
            this.Column7.Name = "Column7";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(26, 215);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 16;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(266, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Limpiar";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(139, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(680, 215);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBorrarElem
            // 
            this.btnBorrarElem.Location = new System.Drawing.Point(394, 215);
            this.btnBorrarElem.Name = "btnBorrarElem";
            this.btnBorrarElem.Size = new System.Drawing.Size(111, 23);
            this.btnBorrarElem.TabIndex = 20;
            this.btnBorrarElem.Text = "Borrar elemento";
            this.btnBorrarElem.UseVisualStyleBackColor = true;
            this.btnBorrarElem.Click += new System.EventHandler(this.btnBorrarElem_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(379, 218);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 15);
            this.lblInfo.TabIndex = 21;
            // 
            // lblInformacion
            // 
            this.lblInformacion.AutoSize = true;
            this.lblInformacion.Location = new System.Drawing.Point(548, 218);
            this.lblInformacion.Name = "lblInformacion";
            this.lblInformacion.Size = new System.Drawing.Size(38, 15);
            this.lblInformacion.TabIndex = 22;
            this.lblInformacion.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInformacion);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnBorrarElem);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.MTIngreso);
            this.Controls.Add(this.MTEgreso);
            this.Controls.Add(this.MTInversionI);
            this.Controls.Add(this.txtUtDesp);
            this.Controls.Add(this.txtDep);
            this.Controls.Add(this.txtImp);
            this.Controls.Add(this.txtUtAntImp);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtUtAntImp;
        private TextBox txtImp;
        private TextBox txtDep;
        private TextBox txtUtDesp;
        private MaskedTextBox MTInversionI;
        private MaskedTextBox MTEgreso;
        private MaskedTextBox MTIngreso;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private Button btnCalc;
        private Button btnClear;
        private Button btnAdd;
        private Button btnExit;
        private Button btnBorrarElem;
        private Label lblInfo;
        private Label lblInformacion;
    }
}