
namespace _5A_Examen_final_2B_FG
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
            this.btnPpt = new System.Windows.Forms.Button();
            this.btnNumAleat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú y juegos";
            // 
            // btnPpt
            // 
            this.btnPpt.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPpt.Location = new System.Drawing.Point(12, 164);
            this.btnPpt.Name = "btnPpt";
            this.btnPpt.Size = new System.Drawing.Size(423, 75);
            this.btnPpt.TabIndex = 1;
            this.btnPpt.Text = "Piedra, papel o tijera";
            this.btnPpt.UseVisualStyleBackColor = true;
            this.btnPpt.Click += new System.EventHandler(this.btnPpt_Click);
            // 
            // btnNumAleat
            // 
            this.btnNumAleat.Font = new System.Drawing.Font("Impact", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNumAleat.Location = new System.Drawing.Point(12, 69);
            this.btnNumAleat.Name = "btnNumAleat";
            this.btnNumAleat.Size = new System.Drawing.Size(423, 75);
            this.btnNumAleat.TabIndex = 2;
            this.btnNumAleat.Text = "Adivina el numero aleatorio";
            this.btnNumAleat.UseVisualStyleBackColor = true;
            this.btnNumAleat.Click += new System.EventHandler(this.btnNumAleat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 279);
            this.Controls.Add(this.btnNumAleat);
            this.Controls.Add(this.btnPpt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPpt;
        private System.Windows.Forms.Button btnNumAleat;
    }
}

