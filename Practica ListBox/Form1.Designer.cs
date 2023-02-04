namespace Practica_ListBox
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
            this.lbxFrutas = new System.Windows.Forms.ListBox();
            this.txtFrutaAd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblFrutas = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxFrutas
            // 
            this.lbxFrutas.FormattingEnabled = true;
            this.lbxFrutas.ItemHeight = 15;
            this.lbxFrutas.Items.AddRange(new object[] {
            "Manzana",
            "Uva",
            "Pera"});
            this.lbxFrutas.Location = new System.Drawing.Point(35, 127);
            this.lbxFrutas.Name = "lbxFrutas";
            this.lbxFrutas.Size = new System.Drawing.Size(131, 94);
            this.lbxFrutas.TabIndex = 0;
            this.lbxFrutas.SelectedIndexChanged += new System.EventHandler(this.lbxFrutas_SelectedIndexChanged);
            // 
            // txtFrutaAd
            // 
            this.txtFrutaAd.Location = new System.Drawing.Point(35, 23);
            this.txtFrutaAd.Name = "txtFrutaAd";
            this.txtFrutaAd.Size = new System.Drawing.Size(131, 23);
            this.txtFrutaAd.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(196, 22);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Añadir";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblFrutas
            // 
            this.lblFrutas.AutoSize = true;
            this.lblFrutas.Location = new System.Drawing.Point(202, 123);
            this.lblFrutas.Name = "lblFrutas";
            this.lblFrutas.Size = new System.Drawing.Size(38, 15);
            this.lblFrutas.TabIndex = 3;
            this.lblFrutas.Text = "label1";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(304, 23);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 355);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblFrutas);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtFrutaAd);
            this.Controls.Add(this.lbxFrutas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lbxFrutas;
        private TextBox txtFrutaAd;
        private Button btnAdd;
        private Label lblFrutas;
        private Button btnDelete;
    }
}