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

namespace examen_practico_ra2_WilmerOPp
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            btnGuardar.Enabled = false;
            btnAgregar.Enabled = false;
            
            txtMatricula.Enabled = false;
            txtNombre.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
            txtEmail.Enabled = false;
            cboCurso.Enabled = false;
            cboSeccion.Enabled = false;
            cboAreaTecnica.Enabled = false;
            txtMaestroTitular.Enabled = false;
            rbnFemenino.Enabled = false;
            rbnMasculino.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            
            btnCerrar.Enabled = true;
            btnAgregar.Enabled = true;
            btnEliminar.Enabled = false;
            txtMatricula.Enabled = true;
            txtNombre.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
            txtEmail.Enabled = true;
            cboCurso.Enabled = true;
            cboSeccion.Enabled = true;
            cboAreaTecnica.Enabled = true;
            rbnFemenino.Enabled = true;
            rbnMasculino.Enabled = true;
            txtMaestroTitular.Enabled=true;

            //Limpiar campos
            txtMatricula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtMaestroTitular.Text = string.Empty;
            rbnMasculino.Checked = false;
            rbnFemenino.Checked = false;
            cboCurso.SelectedIndex = -1;

            cboSeccion.SelectedIndex = -1;

            cboAreaTecnica.SelectedIndex = -1;



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;

            string path = @"C:\Users\wilme\OneDrive\Desktop\New folder (2)\TextoExamen.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dgvDatos.Rows)
                {
                    if (!row.IsNewRow) // Verificar si la fila no es una fila nueva
                    {
                        string Matricula = row.Cells[0].Value?.ToString() ?? "";
                        string Nombre = row.Cells[1].Value?.ToString() ?? "";
                        string Curso = row.Cells[6].Value?.ToString() ?? "";
                        string Seccion = row.Cells[7].Value?.ToString() ?? "";
                        string AreaTecnica = row.Cells[8].Value?.ToString() ?? "";

                        sw.WriteLine($"{Matricula}\t{Nombre}\t{Curso}\t{Seccion}\t{AreaTecnica}");
                    }
                }
            }

            MessageBox.Show("Datos guardados en archivo.txt");

            btnGuardar.Enabled = false;
            btnEliminar.Enabled = true;

            txtMatricula.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Desea cerrar la aplicaión?",
           "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnEliminar.Enabled = true;
           


            

           


            //
            Estudiantes estudiante = new Estudiantes();

            estudiante.Matricula = Convert.ToInt32(txtMatricula.Text);

            estudiante.Nombre = txtNombre.Text;
            estudiante.Direccion = txtDireccion.Text;
            estudiante.Telefono = Convert.ToInt32(txtTelefono.Text);
            estudiante.Email = txtEmail.Text;
            estudiante.MaestroTitular = txtMaestroTitular.Text;

            estudiante.AreaTecnica = cboAreaTecnica.SelectedItem.ToString();
            estudiante.Curso = cboCurso.SelectedItem.ToString();
            estudiante.Seccion = cboSeccion.SelectedItem.ToString();

            if (rbnFemenino.Checked)
            {
                estudiante.Genero = rbnFemenino.Text;
            }

            else
            {
                estudiante.Genero = rbnMasculino.Text;
            }



            dgvDatos.Rows.Add(estudiante.Matricula, 
                estudiante.Nombre, estudiante.Direccion, 
                estudiante.Telefono, estudiante.Genero, 
                estudiante.Email, estudiante.Curso, 
                estudiante.Seccion, estudiante.AreaTecnica, 
                estudiante.MaestroTitular);
            //



          
                txtMatricula.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtEmail.Text = string.Empty;
            txtMaestroTitular.Text = string.Empty;
            rbnMasculino.Checked = false;
            rbnFemenino.Checked = false;
            cboCurso.SelectedIndex = -1;

            cboSeccion.SelectedIndex = -1;

            cboAreaTecnica.SelectedIndex = -1;






        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
                DialogResult respuesta = MessageBox.Show("Desea eliminar el registro?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int indice = dgvDatos.CurrentRow.Index;
                    dgvDatos.Rows.RemoveAt(indice);
                }

            }

       
    }
    }
    
    

