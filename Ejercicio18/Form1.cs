using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio18
{
    public partial class Form1 : Form
    {
        private FontFamily[] fuentes;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fuentes = new InstalledFontCollection().Families;

            foreach (FontFamily x in fuentes)
            {
                listBoxFuentes.Items.Add(x.Name);
            }

        }

        private void listBoxFuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            labelTexto.Font = new Font(fuentes[listBoxFuentes.SelectedIndex].Name, labelTexto.Font.Size);
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btnRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnColorTextoVerde_Click(object sender, EventArgs e)
        {
            labelTexto.ForeColor = Color.Green;
        }

        private void btnColorTextoVioleta_Click(object sender, EventArgs e)
        {
            labelTexto.ForeColor = Color.Blue;
        }

        private void btnColorTextoRojo_Click(object sender, EventArgs e)
        {
            labelTexto.ForeColor = Color.Red;
        }

        private void numericUpDownTamanyoTexto_ValueChanged(object sender, EventArgs e)
        {
             
        }

        private void checkBoxNegrita_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxNegrita.Checked)
            {
                labelTexto.Font = new Font(labelTexto.Font, labelTexto.Font.Style | FontStyle.Bold);
            }
            else
            {
                labelTexto.Font = new Font(labelTexto.Font, labelTexto.Font.Style ^ FontStyle.Bold);
            }
        }

        private void checkBoxCursiva_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCursiva.Checked)
            {
                labelTexto.Font = new Font(labelTexto.Font, labelTexto.Font.Style | FontStyle.Italic);
            }
            else
            {
                labelTexto.Font = new Font(labelTexto.Font, labelTexto.Font.Style ^ FontStyle.Italic);
            }
        }

        private void checkBoxSubrayado_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCursiva.Checked)
            {
                labelTexto.Font = new Font(labelTexto.Font, labelTexto.Font.Style | FontStyle.Underline);
            }
            else
            {
                labelTexto.Font = new Font(labelTexto.Font, labelTexto.Font.Style ^ FontStyle.Underline);
            }
        }

        private void buttonOcultarTexto_Click(object sender, EventArgs e)
        {
            labelTexto.Visible = false;
        }

        private void buttonMostrarTexto_Click(object sender, EventArgs e)
        {
            labelTexto.Visible = true;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
