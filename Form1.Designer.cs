namespace Ejercicio9
{
    partial class Ejercicio9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ejercicio9));
            this.label1 = new System.Windows.Forms.Label();
            this.TX_DADO_1 = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.BTN_Tirar = new System.Windows.Forms.Button();
            this.TX_DADO_2 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BTN_Resultado = new System.Windows.Forms.Button();
            this.LBR_1 = new System.Windows.Forms.Label();
            this.LBR_2 = new System.Windows.Forms.Label();
            this.LBR_3 = new System.Windows.Forms.Label();
            this.LBR_4 = new System.Windows.Forms.Label();
            this.LBR_5 = new System.Windows.Forms.Label();
            this.LBR_6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // TX_DADO_1
            // 
            this.TX_DADO_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_DADO_1.Location = new System.Drawing.Point(126, 95);
            this.TX_DADO_1.Multiline = true;
            this.TX_DADO_1.Name = "TX_DADO_1";
            this.TX_DADO_1.Size = new System.Drawing.Size(43, 54);
            this.TX_DADO_1.TabIndex = 1;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(127, 79);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(42, 13);
            this.lb_1.TabIndex = 3;
            this.lb_1.Text = "Dado 1";
            this.lb_1.Click += new System.EventHandler(this.label2_Click);
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.lb_2.Location = new System.Drawing.Point(290, 79);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(42, 13);
            this.lb_2.TabIndex = 4;
            this.lb_2.Text = "Dado 2";
            // 
            // BTN_Tirar
            // 
            this.BTN_Tirar.Location = new System.Drawing.Point(190, 108);
            this.BTN_Tirar.Name = "BTN_Tirar";
            this.BTN_Tirar.Size = new System.Drawing.Size(75, 23);
            this.BTN_Tirar.TabIndex = 5;
            this.BTN_Tirar.Text = "Tirar";
            this.BTN_Tirar.UseVisualStyleBackColor = true;
            this.BTN_Tirar.Click += new System.EventHandler(this.BTN_Tirar_Click);
            // 
            // TX_DADO_2
            // 
            this.TX_DADO_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TX_DADO_2.Location = new System.Drawing.Point(291, 95);
            this.TX_DADO_2.Multiline = true;
            this.TX_DADO_2.Name = "TX_DADO_2";
            this.TX_DADO_2.Size = new System.Drawing.Size(41, 54);
            this.TX_DADO_2.TabIndex = 2;
            // 
            // BTN_Resultado
            // 
            this.BTN_Resultado.Location = new System.Drawing.Point(190, 158);
            this.BTN_Resultado.Name = "BTN_Resultado";
            this.BTN_Resultado.Size = new System.Drawing.Size(75, 23);
            this.BTN_Resultado.TabIndex = 6;
            this.BTN_Resultado.Text = "Resultado";
            this.BTN_Resultado.UseVisualStyleBackColor = true;
            this.BTN_Resultado.Click += new System.EventHandler(this.BTN_Resultado_Click);
            // 
            // LBR_1
            // 
            this.LBR_1.AutoSize = true;
            this.LBR_1.Location = new System.Drawing.Point(57, 189);
            this.LBR_1.Name = "LBR_1";
            this.LBR_1.Size = new System.Drawing.Size(35, 13);
            this.LBR_1.TabIndex = 7;
            this.LBR_1.Text = "label2";
            // 
            // LBR_2
            // 
            this.LBR_2.AutoSize = true;
            this.LBR_2.Location = new System.Drawing.Point(57, 215);
            this.LBR_2.Name = "LBR_2";
            this.LBR_2.Size = new System.Drawing.Size(35, 13);
            this.LBR_2.TabIndex = 8;
            this.LBR_2.Text = "label2";
            // 
            // LBR_3
            // 
            this.LBR_3.AutoSize = true;
            this.LBR_3.Location = new System.Drawing.Point(230, 189);
            this.LBR_3.Name = "LBR_3";
            this.LBR_3.Size = new System.Drawing.Size(35, 13);
            this.LBR_3.TabIndex = 9;
            this.LBR_3.Text = "label2";
            // 
            // LBR_4
            // 
            this.LBR_4.AutoSize = true;
            this.LBR_4.Location = new System.Drawing.Point(230, 215);
            this.LBR_4.Name = "LBR_4";
            this.LBR_4.Size = new System.Drawing.Size(35, 13);
            this.LBR_4.TabIndex = 10;
            this.LBR_4.Text = "label2";
            // 
            // LBR_5
            // 
            this.LBR_5.AutoSize = true;
            this.LBR_5.Location = new System.Drawing.Point(400, 189);
            this.LBR_5.Name = "LBR_5";
            this.LBR_5.Size = new System.Drawing.Size(35, 13);
            this.LBR_5.TabIndex = 11;
            this.LBR_5.Text = "label2";
            // 
            // LBR_6
            // 
            this.LBR_6.AutoSize = true;
            this.LBR_6.Location = new System.Drawing.Point(400, 215);
            this.LBR_6.Name = "LBR_6";
            this.LBR_6.Size = new System.Drawing.Size(35, 13);
            this.LBR_6.TabIndex = 12;
            this.LBR_6.Text = "label2";
            // 
            // Ejercicio9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(537, 361);
            this.Controls.Add(this.LBR_6);
            this.Controls.Add(this.LBR_5);
            this.Controls.Add(this.LBR_4);
            this.Controls.Add(this.LBR_3);
            this.Controls.Add(this.LBR_2);
            this.Controls.Add(this.LBR_1);
            this.Controls.Add(this.BTN_Resultado);
            this.Controls.Add(this.BTN_Tirar);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.TX_DADO_2);
            this.Controls.Add(this.TX_DADO_1);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio9";
            this.Text = "Ejercicio 9";
            this.Load += new System.EventHandler(this.Ejercicio9_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TX_DADO_1;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Button BTN_Tirar;
        private System.Windows.Forms.TextBox TX_DADO_2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BTN_Resultado;
        private System.Windows.Forms.Label LBR_1;
        private System.Windows.Forms.Label LBR_2;
        private System.Windows.Forms.Label LBR_3;
        private System.Windows.Forms.Label LBR_4;
        private System.Windows.Forms.Label LBR_5;
        private System.Windows.Forms.Label LBR_6;
    }
}

