
namespace Tarea2
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtNu1 = new System.Windows.Forms.TextBox();
            this.txtNu2 = new System.Windows.Forms.TextBox();
            this.txtNu3 = new System.Windows.Forms.TextBox();
            this.comboOpc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnCalc.Location = new System.Drawing.Point(116, 214);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(136, 46);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "CALCULAR";
            this.btnCalc.UseVisualStyleBackColor = false;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtNu1
            // 
            this.txtNu1.Location = new System.Drawing.Point(36, 46);
            this.txtNu1.Name = "txtNu1";
            this.txtNu1.Size = new System.Drawing.Size(131, 20);
            this.txtNu1.TabIndex = 1;
            // 
            // txtNu2
            // 
            this.txtNu2.Location = new System.Drawing.Point(165, 98);
            this.txtNu2.Name = "txtNu2";
            this.txtNu2.Size = new System.Drawing.Size(131, 20);
            this.txtNu2.TabIndex = 2;
            // 
            // txtNu3
            // 
            this.txtNu3.Location = new System.Drawing.Point(295, 142);
            this.txtNu3.Name = "txtNu3";
            this.txtNu3.Size = new System.Drawing.Size(131, 20);
            this.txtNu3.TabIndex = 3;
            // 
            // comboOpc
            // 
            this.comboOpc.FormattingEnabled = true;
            this.comboOpc.Items.AddRange(new object[] {
            "Diario",
            "Mensual",
            "Anual"});
            this.comboOpc.Location = new System.Drawing.Point(426, 187);
            this.comboOpc.Name = "comboOpc";
            this.comboOpc.Size = new System.Drawing.Size(146, 21);
            this.comboOpc.TabIndex = 4;
            this.comboOpc.SelectedIndexChanged += new System.EventHandler(this.comboOpc_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Capital";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(191, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tasa de interes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tiempo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(456, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Periodo de tiempo";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(666, 348);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboOpc);
            this.Controls.Add(this.txtNu3);
            this.Controls.Add(this.txtNu2);
            this.Controls.Add(this.txtNu1);
            this.Controls.Add(this.btnCalc);
            this.Name = "Form1";
            this.Text = "CALCULO DE INTERES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox comboOpciones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ComboBox comboOpcion;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum3;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtNu1;
        private System.Windows.Forms.TextBox txtNu2;
        private System.Windows.Forms.TextBox txtNu3;
        private System.Windows.Forms.ComboBox comboOpc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

