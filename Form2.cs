using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_Final_ED
{
    public partial class Form2 : Form
    {
        List<Libropres> libros_p = new List<Libropres>();
        List<Libro> libros = new List<Libro>();
        int i=0;
        int lim = 999;
        string cod;

        public void leer()
        {
            lvDatos.Items.Clear();
            foreach (Libro l in libros)
            {
                ListViewItem item = new ListViewItem();
                item = lvDatos.Items.Add(l.cod);
                item.SubItems.Add(l.titulo);
                item.SubItems.Add(l.autor);
                item.SubItems.Add(l.disponible);
            }
        }

        public void leer_p()
        {
            lvPrestados.Items.Clear();
            foreach (Libropres lp in libros_p)
            {
                ListViewItem item_p = new ListViewItem();
                item_p = lvPrestados.Items.Add(lp.cod);
                item_p.SubItems.Add(lp.titulo);
                item_p.SubItems.Add(lp.autor);
                item_p.SubItems.Add(lp.disponible);
                item_p.SubItems.Add(lp.nombre);
                item_p.SubItems.Add(lp.doc);
            }
        }
        public Form2()
        {
            InitializeComponent();

            lvPrestados.Hide();
            
            lblTR.Hide();
            lblAutor.Hide();
            btnAR.Hide();
            btnCR.Hide();
            txtTR.Hide();
            txtautor.Hide();
           
            lblcod.Hide();
            lblnombre.Hide();
            lbldoc.Hide();
            txtcod.Hide();
            txtnombre.Hide();
            txtdoc.Hide();
            btnAP.Hide();
            btnCP.Hide();
        }

        private void btnregis_Click(object sender, EventArgs e)
        {
            lblTR.Show();
            lblAutor.Show();
            btnAR.Show();
            btnCR.Show();
            txtTR.Show();
            txtautor.Show();
        }

        private void btnAR_Click(object sender, EventArgs e)
        {
            bool reg = false;
            if (i <= lim)
            {
                if (txtTR.Text != "" && txtautor.Text != "")
                {
                    if (i < 9)
                    {
                        cod = "00" + i;
                    }
                    if (i > 9)
                    {
                        cod = "0" + i;
                    }
                    if (i > 99)
                    {
                        cod = "" + i;
                    }
                    foreach (Libro libro in libros)
                    {
                        if (txtTR.Text == libro.titulo && txtautor.Text == libro.autor)
                        {
                            reg = true;
                            break;
                        }
                    }
                    if (reg == false)
                    {
                        libros.Add(new Libro(cod, txtTR.Text, txtautor.Text));
                        leer();
                        i += 1;
                    }
                    else
                    {
                      MessageBox.Show("Este libro ya ha sido registrado!");
                    }
                }
                else
                {
                    MessageBox.Show("Los campos no pueden estar vacios!");
                }
            }
            else
            {
                MessageBox.Show("Ya ha alcanzado su limite de registros!");
            }
            txtTR.Clear();
            txtautor.Clear();
        }

        private void btnCR_Click(object sender, EventArgs e)
        {
            lblTR.Hide();
            lblAutor.Hide();
            btnAR.Hide();
            btnCR.Hide();
            txtTR.Hide();
            txtautor.Hide();
            txtTR.Clear();
            txtautor.Clear();
        }

        private void btnprestar_Click(object sender, EventArgs e)
        {
            lblcod.Show();
            lblnombre.Show();
            lbldoc.Show();
            txtcod.Show(); 
            txtnombre.Show();
            txtdoc.Show();
            btnAP.Show();
            btnCP.Show();
        }

        private void btnAP_Click(object sender, EventArgs e)
        {
            bool find = false;
            bool prest = false;
            if (txtcod.Text != "")
            {
                if (txtnombre.Text != "" && txtdoc.Text != "")
                {
                    foreach (Libro l in libros)
                    {

                        if (txtcod.Text == l.cod)
                        {
                            if (l.disponible == "Disponible")
                            {
                                find = true;
                                l.disponible = "Prestado";
                                libros_p.Add(new Libropres(l.cod, l.titulo, l.autor, txtnombre.Text, txtdoc.Text));

                                MessageBox.Show("Libro prestado!");

                                txtcod.Clear();
                                txtnombre.Clear();
                                txtdoc.Clear();

                                leer();
                                leer_p();
                                break;
                            }
                            else
                            {
                                prest = true;
                                break;
                            }
                        }
                    }
                    if (find == false)
                    {
                      MessageBox.Show("Libro no encontrado!");
                    }
                    if (prest == true)
                    {
                      MessageBox.Show("Este libro ya está prestado!");
                    }
                }
                else
                {
                    MessageBox.Show("Nombre y/o documento del solicitante vacíos");
                }
            }
            else
            {
                MessageBox.Show("Ingrese el codigo del libro que desea prestar!");
            }
        }

        private void btntodos_Click(object sender, EventArgs e)
        {
            lvPrestados.Hide();
            lvDatos.Show();
            leer();
        }

        private void btnprestados_Click(object sender, EventArgs e)
        {
            lvDatos.Hide();
            lvPrestados.Show();
            leer_p();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            bool find = false;

            if (txtbuscar.Text != "")
            {
                foreach (Libro l in libros)
                {
                    if(txtbuscar.Text == l.titulo)
                    {
                        find = true;
                        MessageBox.Show(l.cod + " | " + l.titulo + " | " + l.autor + " | " + l.disponible);
                        txtbuscar.Clear();
                        
                    }
                }
                if (find==false)
                {
                    MessageBox.Show("Libro no encontrado!");
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese el titulo del libro que desea buscar.");
            }
        }

        private void btnCP_Click(object sender, EventArgs e)
        {
            lblcod.Hide();
            lblnombre.Hide();
            lbldoc.Hide();
            txtcod.Hide();
            txtnombre.Hide();
            txtdoc.Hide();
            btnAP.Hide();
            btnCP.Hide();
            txtcod.Clear();
            txtnombre.Clear();
            txtdoc.Clear();
        }
    }
}
