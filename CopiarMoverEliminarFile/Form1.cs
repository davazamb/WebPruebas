using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace CopiarMoverEliminarFile
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();

            btnCopiar.Click += new EventHandler(btnCopiar_Click);
            btnMover.Click += new EventHandler(btnMover_Click);
            btnEliminar.Click += new EventHandler(btnEliminar_Click);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCopiar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdc = new OpenFileDialog();
            ofdc.ShowDialog();
            string sourcepath = ofdc.FileName;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            string destpath = fbd.SelectedPath;

            try
            {
                System.IO.File.Copy(sourcepath, destpath + "!!" + ofdc.SafeFileName);
                MessageBox.Show("Archivo copiado exitosamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdm = new OpenFileDialog();
            ofdm.ShowDialog();
            string sourcepath = ofdm.FileName;

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowDialog();

            string destpath = fbd.SelectedPath;

            try
            {
                System.IO.File.Move(sourcepath, destpath + "!!" + ofdm.SafeFileName);
                MessageBox.Show("Archivo Movido exitosamente.");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            string filename = ofd.FileName;

            try
            {
                System.IO.File.Delete(filename);
                MessageBox.Show("Seleccione archivo :" + filename + "Eliminado exitosamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());  
            }
        }
    }
}
