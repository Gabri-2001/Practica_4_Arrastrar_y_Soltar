namespace fmArrastrarSoltar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbOrdena1 = new System.Windows.Forms.CheckBox();
            this.cbOrdena2 = new System.Windows.Forms.CheckBox();
            this.btAcercade = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btBorra1 = new System.Windows.Forms.Button();
            this.btBorraTodo2 = new System.Windows.Forms.Button();
            this.btBorra2 = new System.Windows.Forms.Button();
            this.btBorraTodo1 = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btPapelera = new System.Windows.Forms.Button();
            this.cmnPapelera = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.vaciarPapeleraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmnPapelera.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbOrdena1
            // 
            this.cbOrdena1.AutoSize = true;
            this.cbOrdena1.Location = new System.Drawing.Point(225, 503);
            this.cbOrdena1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbOrdena1.Name = "cbOrdena1";
            this.cbOrdena1.Size = new System.Drawing.Size(81, 24);
            this.cbOrdena1.TabIndex = 2;
            this.cbOrdena1.Text = "Ordena";
            this.cbOrdena1.UseVisualStyleBackColor = true;
            this.cbOrdena1.CheckedChanged += new System.EventHandler(this.cbOrdena1_CheckedChanged);
            // 
            // cbOrdena2
            // 
            this.cbOrdena2.AutoSize = true;
            this.cbOrdena2.Location = new System.Drawing.Point(586, 503);
            this.cbOrdena2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbOrdena2.Name = "cbOrdena2";
            this.cbOrdena2.Size = new System.Drawing.Size(81, 24);
            this.cbOrdena2.TabIndex = 3;
            this.cbOrdena2.Text = "Ordena";
            this.cbOrdena2.UseVisualStyleBackColor = true;
            this.cbOrdena2.CheckedChanged += new System.EventHandler(this.cbOrdena1_CheckedChanged);
            // 
            // btAcercade
            // 
            this.btAcercade.Location = new System.Drawing.Point(660, 615);
            this.btAcercade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAcercade.Name = "btAcercade";
            this.btAcercade.Size = new System.Drawing.Size(112, 35);
            this.btAcercade.TabIndex = 5;
            this.btAcercade.Text = "Acerca de ..";
            this.btAcercade.UseVisualStyleBackColor = true;
            this.btAcercade.Click += new System.EventHandler(this.btAcercade_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(808, 615);
            this.btSalir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(112, 35);
            this.btSalir.TabIndex = 6;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btBorra1
            // 
            this.btBorra1.Image = ((System.Drawing.Image)(resources.GetObject("btBorra1.Image")));
            this.btBorra1.Location = new System.Drawing.Point(206, 119);
            this.btBorra1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBorra1.Name = "btBorra1";
            this.btBorra1.Size = new System.Drawing.Size(40, 40);
            this.btBorra1.TabIndex = 7;
            this.btBorra1.UseVisualStyleBackColor = true;
            this.btBorra1.Click += new System.EventHandler(this.btBorra1_Click);
            // 
            // btBorraTodo2
            // 
            this.btBorraTodo2.Image = ((System.Drawing.Image)(resources.GetObject("btBorraTodo2.Image")));
            this.btBorraTodo2.Location = new System.Drawing.Point(651, 119);
            this.btBorraTodo2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBorraTodo2.Name = "btBorraTodo2";
            this.btBorraTodo2.Size = new System.Drawing.Size(40, 40);
            this.btBorraTodo2.TabIndex = 8;
            this.btBorraTodo2.UseVisualStyleBackColor = true;
            this.btBorraTodo2.Click += new System.EventHandler(this.btBorraTodo2_Click);
            // 
            // btBorra2
            // 
            this.btBorra2.AutoSize = true;
            this.btBorra2.Image = ((System.Drawing.Image)(resources.GetObject("btBorra2.Image")));
            this.btBorra2.Location = new System.Drawing.Point(601, 119);
            this.btBorra2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBorra2.Name = "btBorra2";
            this.btBorra2.Size = new System.Drawing.Size(42, 40);
            this.btBorra2.TabIndex = 9;
            this.btBorra2.UseVisualStyleBackColor = true;
            this.btBorra2.Click += new System.EventHandler(this.btBorra1_Click);
            // 
            // btBorraTodo1
            // 
            this.btBorraTodo1.AutoSize = true;
            this.btBorraTodo1.Image = ((System.Drawing.Image)(resources.GetObject("btBorraTodo1.Image")));
            this.btBorraTodo1.Location = new System.Drawing.Point(254, 119);
            this.btBorraTodo1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btBorraTodo1.Name = "btBorraTodo1";
            this.btBorraTodo1.Size = new System.Drawing.Size(42, 40);
            this.btBorraTodo1.TabIndex = 10;
            this.btBorraTodo1.UseVisualStyleBackColor = true;
            this.btBorraTodo1.Click += new System.EventHandler(this.btBorraTodo2_Click);
            // 
            // lb1
            // 
            this.lb1.AllowDrop = true;
            this.lb1.FormattingEnabled = true;
            this.lb1.ItemHeight = 20;
            this.lb1.Location = new System.Drawing.Point(112, 169);
            this.lb1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb1.Name = "lb1";
            this.lb1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lb1.Size = new System.Drawing.Size(217, 324);
            this.lb1.TabIndex = 11;
            this.lb1.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb1.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb1_DragEnter);
            this.lb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb1_KeyDown);
            this.lb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb1_MouseDown);
            // 
            // lb2
            // 
            this.lb2.AllowDrop = true;
            this.lb2.FormattingEnabled = true;
            this.lb2.ItemHeight = 20;
            this.lb2.Location = new System.Drawing.Point(567, 169);
            this.lb2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(217, 324);
            this.lb2.TabIndex = 12;
            this.lb2.DragDrop += new System.Windows.Forms.DragEventHandler(this.lb1_DragDrop);
            this.lb2.DragEnter += new System.Windows.Forms.DragEventHandler(this.lb1_DragEnter);
            this.lb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lb1_KeyDown);
            this.lb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lb2_MouseDown);
            // 
            // btPapelera
            // 
            this.btPapelera.AllowDrop = true;
            this.btPapelera.ContextMenuStrip = this.cmnPapelera;
            this.btPapelera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPapelera.Image = ((System.Drawing.Image)(resources.GetObject("btPapelera.Image")));
            this.btPapelera.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btPapelera.Location = new System.Drawing.Point(384, 525);
            this.btPapelera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btPapelera.Name = "btPapelera";
            this.btPapelera.Size = new System.Drawing.Size(112, 121);
            this.btPapelera.TabIndex = 13;
            this.btPapelera.Text = "Papelera de Reciclaje";
            this.btPapelera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPapelera.UseVisualStyleBackColor = true;
            this.btPapelera.Click += new System.EventHandler(this.button1_Click);
            this.btPapelera.DragEnter += new System.Windows.Forms.DragEventHandler(this.btPapelera_DragEnter);
            // 
            // cmnPapelera
            // 
            this.cmnPapelera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.vaciarPapeleraToolStripMenuItem});
            this.cmnPapelera.Name = "cmnPapelera";
            this.cmnPapelera.Size = new System.Drawing.Size(154, 54);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // vaciarPapeleraToolStripMenuItem
            // 
            this.vaciarPapeleraToolStripMenuItem.Name = "vaciarPapeleraToolStripMenuItem";
            this.vaciarPapeleraToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.vaciarPapeleraToolStripMenuItem.Text = "Vaciar Papelera";
            this.vaciarPapeleraToolStripMenuItem.Click += new System.EventHandler(this.vaciarPapeleraToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Botones para eliminacion Definitiva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 40);
            this.label2.TabIndex = 15;
            this.label2.Text = "Pulsa <SUPR>o<BACK>\r\npara enviar a Papelera.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 60);
            this.label3.TabIndex = 16;
            this.label3.Text = "Para eliminacion definitiva\r\npulsa <SHIFT>y<SUPR>\r\no<SHIFT>y<BACK>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(237, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(464, 50);
            this.label4.TabIndex = 17;
            this.label4.Text = "Arrastra Un/os Archivo/s de Texto a los ListBox\r\nIntercambia los Elementos entre " +
    "ellos";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 669);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPapelera);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btBorraTodo1);
            this.Controls.Add(this.btBorra2);
            this.Controls.Add(this.btBorraTodo2);
            this.Controls.Add(this.btBorra1);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAcercade);
            this.Controls.Add(this.cbOrdena2);
            this.Controls.Add(this.cbOrdena1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Arrastar y Soltar";
            this.cmnPapelera.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbOrdena1;
        private System.Windows.Forms.CheckBox cbOrdena2;
        private System.Windows.Forms.Button btAcercade;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btBorra1;
        private System.Windows.Forms.Button btBorraTodo2;
        private System.Windows.Forms.Button btBorra2;
        private System.Windows.Forms.Button btBorraTodo1;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btPapelera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip cmnPapelera;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vaciarPapeleraToolStripMenuItem;
    }
}

