namespace TREEVIEW_inss
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
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Inss laboral");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Inss patronal");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("IR");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Deduccion de ley", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.mtIngresos = new System.Windows.Forms.MaskedTextBox();
            this.mtNinss = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtInssCobrado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(15, 25);
            this.treeView1.Name = "treeView1";
            treeNode5.Name = "Nodo1";
            treeNode5.Text = "Inss laboral";
            treeNode6.Name = "Nodo2";
            treeNode6.Text = "Inss patronal";
            treeNode7.Name = "Nodo3";
            treeNode7.Text = "IR";
            treeNode8.Name = "Nodo0";
            treeNode8.Text = "Deduccion de ley";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(158, 97);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresos";
            // 
            // mtIngresos
            // 
            this.mtIngresos.Location = new System.Drawing.Point(373, 99);
            this.mtIngresos.Mask = "99999999999999999";
            this.mtIngresos.Name = "mtIngresos";
            this.mtIngresos.Size = new System.Drawing.Size(100, 23);
            this.mtIngresos.TabIndex = 2;
            this.mtIngresos.ValidatingType = typeof(int);
            // 
            // mtNinss
            // 
            this.mtNinss.Location = new System.Drawing.Point(373, 37);
            this.mtNinss.Mask = "99999999999999999";
            this.mtNinss.Name = "mtNinss";
            this.mtNinss.Size = new System.Drawing.Size(100, 23);
            this.mtNinss.TabIndex = 4;
            this.mtNinss.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº INSS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(109, 273);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(122, 23);
            this.txtTotal.TabIndex = 6;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(398, 275);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 7;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtInssCobrado
            // 
            this.txtInssCobrado.Location = new System.Drawing.Point(109, 232);
            this.txtInssCobrado.Name = "txtInssCobrado";
            this.txtInssCobrado.Size = new System.Drawing.Size(122, 23);
            this.txtInssCobrado.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "INSS cobrado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 338);
            this.Controls.Add(this.txtInssCobrado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mtNinss);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mtIngresos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private MaskedTextBox mtIngresos;
        private MaskedTextBox mtNinss;
        private Label label2;
        private Label label3;
        private TextBox txtTotal;
        private Button btnCalc;
        private TextBox txtInssCobrado;
        private Label label4;
    }
}