using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fmArrastrarSoltar
{
    public partial class Form1 : Form
    {
        fmPapelera VentanaPapelera = new fmPapelera();
        fmAcercade VentanaAcercade = new fmAcercade();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VentanaPapelera.milb1 = lb1;
            VentanaPapelera.milb2 = lb2;
            VentanaPapelera.ShowDialog();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAcercade_Click(object sender, EventArgs e)
        {
            VentanaAcercade.ShowDialog();
        }
        private void borralistbox(ListBox lbBorra)
        {
            int i = 0;
            while (i < lbBorra.Items.Count)
            {
                if (lbBorra.GetSelected(i)) // Matriz con los elementos seleccionados
                {
                    lbBorra.Items.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
        }


        private void btBorra1_Click(object sender, EventArgs e)
        {
            if (sender == btBorra1)
                borralistbox(lb1);
            else
                borralistbox(lb2);
        }

        private void btBorraTodo2_Click(object sender, EventArgs e)
        {
            if (sender == btBorraTodo1)
                lb1.Items.Clear();
            else
                lb2.Items.Clear();
        }

        private void cbOrdena1_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == cbOrdena1)
                lb1.Sorted = cbOrdena1.Checked;
            else
                lb2.Sorted = cbOrdena2.Checked;

        }

        private void lb1_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb1.SelectedIndex >= 0)
            {
                lb2.DoDragDrop(lb1.SelectedItem, DragDropEffects.All);//Inicia operación
            }
        }

        private void lb2_MouseDown(object sender, MouseEventArgs e)
        {
            if (lb2.SelectedIndex >= 0)
            {
                lb1.DoDragDrop(lb2.SelectedItem, DragDropEffects.All);//Inicia operación
            }
        }

        private void anyadelistbox(ListBox lbAcopla, ListBox lbArrastra)
        {
            for (int i = 0; i < lbArrastra.Items.Count; i++)
            {
                if (lbArrastra.GetSelected(i))
                {
                    lbAcopla.Items.Add(lbArrastra.Items[i]);
                }
            }
        }

        private void anyadelistbox2(ListBox milistbox, int numlisBox)
        {
            for (int i = 0; i < milistbox.Items.Count; i++)
            {
                if (milistbox.GetSelected(i))
                {
                    VentanaPapelera.lbPapelera.Items.Add(milistbox.Items[i] + "-" + numlisBox);
                } // Añadimos ítem del listbox con un 1 o 2 que identificará el origen
            }
        }


        private void lb1_DragDrop(object sender, DragEventArgs e)
        {
            ListBox milistbox = (ListBox)sender;
            if (e.Data.GetDataPresent(DataFormats.FileDrop))//true si objeto arrastrado
            { // es un archivo
                string[] ficheros = (string[])e.Data.GetData(DataFormats.FileDrop,
                false); //Obtiene lista ficheros arrastrados
                foreach (var fichero in ficheros) //Por cada archivo en la lista
                { //Leemos archivo como se explicó en anterior proyecto
                    StreamReader miarchivo = new StreamReader(fichero, Encoding.Default);
                    while (miarchivo.Peek() >= 0) //Comprobamos siguiente línea archivo
                    { //Añadimos línea al ListBox
                        milistbox.Items.Add(Convert.ToString(miarchivo.ReadLine()));
                    }
                    miarchivo.Close();
                }
            }
            else
            {
                if (e.Data.GetDataPresent(DataFormats.Text))//true si es texto arrastrado
                {
                    if (sender == lb1 && lb2.SelectedIndex > -1) //Identifica origen y
                    { // si hay elementos seleccionados
                        anyadelistbox(lb1, lb2); // Añadimos destino
                        borralistbox(lb2); //Eliminamos origen
                    }
                    if (sender == lb2 && lb1.SelectedIndex > -1)//Repetimos para otro Listbox
                    {
                        anyadelistbox(lb2, lb1);
                        borralistbox(lb1);
                    }
                }
            }
        }

        private void lb1_KeyDown(object sender, KeyEventArgs e)
        {
            ListBox milistbox = (ListBox)sender;
            if ((e.Shift) && (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete))
            {
                borralistbox(milistbox); // Borrado definitivo
            }

            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete)
            { // Enviamos Papelera
                anyadelistbox2(milistbox, Convert.ToInt32(milistbox.Tag));
                borralistbox(milistbox);
            }

        }

        private void lb1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop) ||
                e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        { // misma clase del otro formulario
            VentanaPapelera.ShowDialog(); //.Show();
                                          //Se puede elegir entre dejar la ventana como flotante ó que sea modal
        }

        private void vaciarPapeleraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VentanaPapelera.lbPapelera.Items.Clear();

        }

        private void btPapelera_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text)) // Devuelve true si es un
            { //texto lo arrastrado
                if (lb1.SelectedIndex > -1)
                {
                    anyadelistbox2(lb1, 1); // Añadimos con un 1 por lb1
                    borralistbox(lb1);
                }

                if (lb2.SelectedIndex > -1)
                {
                    anyadelistbox2(lb2, 2); // Añadimos con un 2 por lb2
                    borralistbox(lb2);
                }
            }

        }
    }
}


