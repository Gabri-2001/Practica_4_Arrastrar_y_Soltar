namespace fmArrastrarSoltar
{
    partial class fmAcercade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmAcercade));
            this.lAcercade = new System.Windows.Forms.Label();
            this.btAceptar = new System.Windows.Forms.Button();
            this.pbAcercade = new System.Windows.Forms.PictureBox();
            this.lDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAcercade)).BeginInit();
            this.SuspendLayout();
            // 
            // lAcercade
            // 
            this.lAcercade.AutoSize = true;
            this.lAcercade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAcercade.Location = new System.Drawing.Point(367, 116);
            this.lAcercade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lAcercade.Name = "lAcercade";
            this.lAcercade.Size = new System.Drawing.Size(286, 140);
            this.lAcercade.TabIndex = 0;
            this.lAcercade.Text = "Autor: Gabriel Ademar Diaz Arnold\r\n\r\nProyecto: Arrastrar y Soltar\r\n\r\nVersion: 1\r\n" +
    "\r\nFecha: 17 de octubre de 2022";
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(508, 423);
            this.btAceptar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(112, 35);
            this.btAceptar.TabIndex = 1;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // pbAcercade
            // 
            this.pbAcercade.Image = ((System.Drawing.Image)(resources.GetObject("pbAcercade.Image")));
            this.pbAcercade.Location = new System.Drawing.Point(13, 14);
            this.pbAcercade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbAcercade.Name = "pbAcercade";
            this.pbAcercade.Size = new System.Drawing.Size(346, 337);
            this.pbAcercade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAcercade.TabIndex = 2;
            this.pbAcercade.TabStop = false;
            // 
            // lDescripcion
            // 
            this.lDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDescripcion.Location = new System.Drawing.Point(13, 368);
            this.lDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lDescripcion.Name = "lDescripcion";
            this.lDescripcion.Size = new System.Drawing.Size(581, 50);
            this.lDescripcion.TabIndex = 3;
            this.lDescripcion.Text = "Proyecto para aprender a usar la técnica visual que consiste en arrastrar\r\nelemen" +
    "tos con el ratón y soltarlos sobre controles que los aceptan y muestran.";
            // 
            // fmAcercade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 478);
            this.Controls.Add(this.lDescripcion);
            this.Controls.Add(this.pbAcercade);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.lAcercade);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmAcercade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Acerca de";
            ((System.ComponentModel.ISupportInitialize)(this.pbAcercade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lAcercade;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.PictureBox pbAcercade;
        private System.Windows.Forms.Label lDescripcion;
    }
}