namespace practicafin
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
            this.Temlim = new System.Windows.Forms.TextBox();
            this.con = new System.Windows.Forms.Label();
            this.btncon = new System.Windows.Forms.Button();
            this.btndes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Temlim
            // 
            this.Temlim.Location = new System.Drawing.Point(96, 107);
            this.Temlim.Name = "Temlim";
            this.Temlim.Size = new System.Drawing.Size(100, 22);
            this.Temlim.TabIndex = 0;
            // 
            // con
            // 
            this.con.AutoSize = true;
            this.con.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.con.Location = new System.Drawing.Point(272, 367);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(31, 29);
            this.con.TabIndex = 1;
            this.con.Text = "...";
            // 
            // btncon
            // 
            this.btncon.Location = new System.Drawing.Point(168, 288);
            this.btncon.Name = "btncon";
            this.btncon.Size = new System.Drawing.Size(109, 48);
            this.btncon.TabIndex = 2;
            this.btncon.Text = "CONECTAR";
            this.btncon.UseVisualStyleBackColor = true;
            this.btncon.Click += new System.EventHandler(this.btncon_Click_1);
            // 
            // btndes
            // 
            this.btndes.Location = new System.Drawing.Point(319, 288);
            this.btndes.Name = "btndes";
            this.btndes.Size = new System.Drawing.Size(153, 48);
            this.btndes.TabIndex = 3;
            this.btndes.Text = "DESCONECTAR";
            this.btndes.UseVisualStyleBackColor = true;
            this.btndes.Click += new System.EventHandler(this.btndes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "TEMPERATURA LIMITE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "TEMPERATURA";
            // 
            // temp
            // 
            this.temp.AutoEllipsis = true;
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.Location = new System.Drawing.Point(393, 107);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(31, 29);
            this.temp.TabIndex = 4;
            this.temp.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.btndes);
            this.Controls.Add(this.btncon);
            this.Controls.Add(this.con);
            this.Controls.Add(this.Temlim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Temlim;
        private System.Windows.Forms.Label con;
        private System.Windows.Forms.Button btncon;
        private System.Windows.Forms.Button btndes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label temp;
    }
}

