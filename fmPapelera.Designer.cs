namespace fmArrastrarSoltar
{
    partial class fmPapelera
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSeleccion = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btVaciar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbPapelera = new System.Windows.Forms.ListBox();
            this.mncPapelera = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miVaciar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miTodo = new System.Windows.Forms.ToolStripMenuItem();
            this.miSeleccion = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mncPapelera.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btSeleccion);
            this.panel1.Controls.Add(this.btTodos);
            this.panel1.Controls.Add(this.btVaciar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(533, 154);
            this.panel1.TabIndex = 0;
            // 
            // btSeleccion
            // 
            this.btSeleccion.Location = new System.Drawing.Point(374, 37);
            this.btSeleccion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSeleccion.Name = "btSeleccion";
            this.btSeleccion.Size = new System.Drawing.Size(130, 89);
            this.btSeleccion.TabIndex = 2;
            this.btSeleccion.Text = "Restaurar Elementos Seleccionados";
            this.btSeleccion.UseVisualStyleBackColor = true;
            this.btSeleccion.Click += new System.EventHandler(this.btSeleccion_Click);
            // 
            // btTodos
            // 
            this.btTodos.Location = new System.Drawing.Point(196, 37);
            this.btTodos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(112, 89);
            this.btTodos.TabIndex = 1;
            this.btTodos.Text = "Restaurar Todos los Elementos";
            this.btTodos.UseVisualStyleBackColor = true;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btVaciar
            // 
            this.btVaciar.Location = new System.Drawing.Point(18, 37);
            this.btVaciar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btVaciar.Name = "btVaciar";
            this.btVaciar.Size = new System.Drawing.Size(112, 89);
            this.btVaciar.TabIndex = 0;
            this.btVaciar.Text = "Vaciar Papelera";
            this.btVaciar.UseVisualStyleBackColor = true;
            this.btVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbPapelera);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 154);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 538);
            this.panel2.TabIndex = 1;
            // 
            // lbPapelera
            // 
            this.lbPapelera.ContextMenuStrip = this.mncPapelera;
            this.lbPapelera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbPapelera.FormattingEnabled = true;
            this.lbPapelera.HorizontalScrollbar = true;
            this.lbPapelera.ItemHeight = 20;
            this.lbPapelera.Location = new System.Drawing.Point(0, 0);
            this.lbPapelera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbPapelera.Name = "lbPapelera";
            this.lbPapelera.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPapelera.Size = new System.Drawing.Size(533, 538);
            this.lbPapelera.TabIndex = 0;
            // 
            // mncPapelera
            // 
            this.mncPapelera.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miVaciar,
            this.toolStripMenuItem1,
            this.miTodo,
            this.miSeleccion});
            this.mncPapelera.Name = "mncPapelera";
            this.mncPapelera.Size = new System.Drawing.Size(181, 98);
            // 
            // miVaciar
            // 
            this.miVaciar.Name = "miVaciar";
            this.miVaciar.Size = new System.Drawing.Size(180, 22);
            this.miVaciar.Text = "Vaciar Papelera";
            this.miVaciar.Click += new System.EventHandler(this.btVaciar_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // miTodo
            // 
            this.miTodo.Name = "miTodo";
            this.miTodo.Size = new System.Drawing.Size(180, 22);
            this.miTodo.Text = "Restaurar Todo";
            this.miTodo.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // miSeleccion
            // 
            this.miSeleccion.Name = "miSeleccion";
            this.miSeleccion.Size = new System.Drawing.Size(180, 22);
            this.miSeleccion.Text = "Restaurar Seleccion";
            this.miSeleccion.Click += new System.EventHandler(this.btSeleccion_Click);
            // 
            // fmPapelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fmPapelera";
            this.Text = "Papelera de Reciclaje";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.mncPapelera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSeleccion;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btVaciar;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListBox lbPapelera;
        private System.Windows.Forms.ContextMenuStrip mncPapelera;
        private System.Windows.Forms.ToolStripMenuItem miVaciar;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miTodo;
        private System.Windows.Forms.ToolStripMenuItem miSeleccion;
    }
}