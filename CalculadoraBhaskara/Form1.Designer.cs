namespace CalculadoraBhaskara
{
    partial class frmBhaskara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBhaskara));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumA = new System.Windows.Forms.TextBox();
            this.txtNumB = new System.Windows.Forms.TextBox();
            this.txtNumC = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDelta = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.pn1 = new System.Windows.Forms.Panel();
            this.Calculadora = new System.Windows.Forms.Label();
            this.pn1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "B:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "C:";
            // 
            // txtNumA
            // 
            this.txtNumA.AccessibleDescription = "Número para valor de A";
            this.txtNumA.Location = new System.Drawing.Point(49, 35);
            this.txtNumA.Name = "txtNumA";
            this.txtNumA.Size = new System.Drawing.Size(38, 20);
            this.txtNumA.TabIndex = 3;
            this.txtNumA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumA_KeyPress);
            // 
            // txtNumB
            // 
            this.txtNumB.Location = new System.Drawing.Point(49, 61);
            this.txtNumB.Name = "txtNumB";
            this.txtNumB.Size = new System.Drawing.Size(38, 20);
            this.txtNumB.TabIndex = 4;
            this.txtNumB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumB_KeyPress);
            // 
            // txtNumC
            // 
            this.txtNumC.Location = new System.Drawing.Point(49, 91);
            this.txtNumC.Name = "txtNumC";
            this.txtNumC.Size = new System.Drawing.Size(38, 20);
            this.txtNumC.TabIndex = 5;
            this.txtNumC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumC_KeyPress);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(26, 117);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(80, 31);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Resultados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Delta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "x\':";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "x\'\':";
            // 
            // txtDelta
            // 
            this.txtDelta.Location = new System.Drawing.Point(83, 36);
            this.txtDelta.Name = "txtDelta";
            this.txtDelta.ReadOnly = true;
            this.txtDelta.Size = new System.Drawing.Size(59, 20);
            this.txtDelta.TabIndex = 11;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(83, 63);
            this.txtX1.Name = "txtX1";
            this.txtX1.ReadOnly = true;
            this.txtX1.Size = new System.Drawing.Size(59, 20);
            this.txtX1.TabIndex = 12;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(83, 94);
            this.txtX2.Name = "txtX2";
            this.txtX2.ReadOnly = true;
            this.txtX2.Size = new System.Drawing.Size(59, 20);
            this.txtX2.TabIndex = 13;
            // 
            // pn1
            // 
            this.pn1.Controls.Add(this.txtDelta);
            this.pn1.Controls.Add(this.txtX2);
            this.pn1.Controls.Add(this.label4);
            this.pn1.Controls.Add(this.txtX1);
            this.pn1.Controls.Add(this.label5);
            this.pn1.Controls.Add(this.label6);
            this.pn1.Controls.Add(this.label7);
            this.pn1.Location = new System.Drawing.Point(123, 33);
            this.pn1.Name = "pn1";
            this.pn1.Size = new System.Drawing.Size(200, 138);
            this.pn1.TabIndex = 14;
            this.pn1.Visible = false;
            // 
            // Calculadora
            // 
            this.Calculadora.AutoSize = true;
            this.Calculadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculadora.Location = new System.Drawing.Point(21, 5);
            this.Calculadora.Name = "Calculadora";
            this.Calculadora.Size = new System.Drawing.Size(277, 25);
            this.Calculadora.TabIndex = 15;
            this.Calculadora.Text = "Calculadora de Bhaskara";
            // 
            // frmBhaskara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 183);
            this.Controls.Add(this.Calculadora);
            this.Controls.Add(this.pn1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtNumC);
            this.Controls.Add(this.txtNumB);
            this.Controls.Add(this.txtNumA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmBhaskara";
            this.Text = "Calculadora Bhaskara";
            this.pn1.ResumeLayout(false);
            this.pn1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumA;
        private System.Windows.Forms.TextBox txtNumB;
        private System.Windows.Forms.TextBox txtNumC;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDelta;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Panel pn1;
        private System.Windows.Forms.Label Calculadora;
    }
}

