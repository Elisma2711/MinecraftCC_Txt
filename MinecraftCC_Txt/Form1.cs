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

namespace MinecraftCC_Txt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LlenarDgv();
            Botones(false);
        }

        private void Btn_Refresh_Click(object sender, EventArgs e)
        {
            LlenarDgv();
            Botones(false);
            Text_Nombre.Text = "";
            Text_X.Text = "";
            Text_Y.Text = "";
            Text_Z.Text = "";
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            // Agreagar una coordenada
            // https://www.c-sharpcorner.com/article/c-sharp-write-to-file/
            // if (File.Exists(textFile)) -- Poner en todos lados
            if (!String.IsNullOrEmpty(Text_Nombre.Text) && !String.IsNullOrEmpty(Text_X.Text) && !String.IsNullOrEmpty(Text_Y.Text) && !String.IsNullOrEmpty(Text_Z.Text))
            {
                string[] coordenadas = File.ReadAllLines("Coordenadas.txt");
                string newCC = Text_Nombre.Text + "|" + Text_X.Text + "|" + Text_Y.Text + "|" + Text_Z.Text;

                string[] newCoorArr = new string[coordenadas.Length + 1];
                for(int i = 0; i < newCoorArr.Length; i++)
                {
                    if (i < coordenadas.Length)
                    {
                        newCoorArr[i] = coordenadas[i];
                    }
                    else
                    {
                        newCoorArr[i] = newCC;
                    }
                }

                File.WriteAllLines("Coordenadas.txt", newCoorArr);
                LlenarDgv();
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos");
            }
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {
            // Modificar una coordenada
            // Seria algo como eliminarla y volver a crearla o algo asi
            var coordenadas = File.ReadAllLines("Coordenadas.txt");
            var nuevasCC = coordenadas.Where(line => !line.Contains(Dgv_Coordenadas.CurrentRow.Cells[0].Value.ToString() + "|"));
            File.WriteAllLines("Coordenadas.txt", nuevasCC);

            if (!String.IsNullOrEmpty(Text_Nombre.Text) && !String.IsNullOrEmpty(Text_X.Text) && !String.IsNullOrEmpty(Text_Y.Text) && !String.IsNullOrEmpty(Text_Z.Text))
            {
                string[] coordenadasa = File.ReadAllLines("Coordenadas.txt");
                string newCC = Text_Nombre.Text + "|" + Text_X.Text + "|" + Text_Y.Text + "|" + Text_Z.Text;

                string[] newCoorArr = new string[coordenadasa.Length + 1];
                for (int i = 0; i < newCoorArr.Length; i++)
                {
                    if (i < coordenadasa.Length)
                    {
                        newCoorArr[i] = coordenadasa[i];
                    }
                    else
                    {
                        newCoorArr[i] = newCC;
                    }
                }

                File.WriteAllLines("Coordenadas.txt", newCoorArr);
                LlenarDgv();
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos");
            }
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            // Eliminar una coordenada
            // https://www.c-sharpcorner.com/blogs/read-write-and-delete-the-text-file-content-using-c-sharp
            // if (File.Exists(textFile))
            var coordenadas = File.ReadAllLines("Coordenadas.txt");
            var nuevasCC = coordenadas.Where(line => !line.Contains(Dgv_Coordenadas.CurrentRow.Cells[0].Value.ToString() + "|"));
            File.WriteAllLines("Coordenadas.txt", nuevasCC);
            LlenarDgv();
        }

        private void Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ',') && (e.KeyChar != '-'))
            {
                // Solo se pueden poner numeros
                e.Handled = true;
            }

            if ((e.KeyChar == '.'))
            {
                e.KeyChar = ',';
            }

            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                // No se puede poner mas de un -
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                // No se puede poner mas de un -
                e.Handled = true;
            }
        }

        private void Dgv_Coordenadas_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Botones(true);
            // Escribirlo en los TextBox
            Text_Nombre.Text = Dgv_Coordenadas.CurrentRow.Cells[0].Value.ToString();
            Text_X.Text = Dgv_Coordenadas.CurrentRow.Cells[1].Value.ToString();
            Text_Y.Text = Dgv_Coordenadas.CurrentRow.Cells[2].Value.ToString();
            Text_Z.Text = Dgv_Coordenadas.CurrentRow.Cells[3].Value.ToString();
        }

        private void LlenarDgv()
        {
            // Leer el txt y separar los strings por |
            Dgv_Coordenadas.DataSource = null;
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Nombre");
            dataTable.Columns.Add("X");
            dataTable.Columns.Add("Y");
            dataTable.Columns.Add("Z");

            string[] lineas = File.ReadAllLines("Coordenadas.txt");
            
            for (int i = 0; i < lineas.Length; i++)
            {
                string line = lineas[i];
                if (!string.IsNullOrEmpty(line))
                {
                    string[] splitted = line.Split('|');
                    dataTable.Rows.Add(splitted[0], splitted[1], splitted[2], splitted[3]);
                    Dgv_Coordenadas.DataSource = dataTable;

                    Dgv_Coordenadas.Columns[0].Width = Dgv_Coordenadas.Width / 2;
                    Dgv_Coordenadas.Columns[1].Width = Dgv_Coordenadas.Width / 6;
                    Dgv_Coordenadas.Columns[2].Width = Dgv_Coordenadas.Width / 6;
                    Dgv_Coordenadas.Columns[3].Width = Dgv_Coordenadas.Width / 6;
                } 
            }
        }

        private void Botones(bool a)
        {
            // Si haces click en una celda del dgv se activan los btns y sino no xd
            if (a)
            {
                Btn_Modificar.Enabled = true;
                Btn_Eliminar.Enabled = true;
                Btn_Modificar.BackColor = Color.Yellow;
                Btn_Eliminar.BackColor = Color.Red;
            }
            else
            {
                Btn_Modificar.Enabled = false;
                Btn_Eliminar.Enabled = false;
                Btn_Modificar.BackColor = Color.Beige;
                Btn_Eliminar.BackColor = Color.LightCoral;
                Dgv_Coordenadas.ClearSelection();
            }
        }
    }
}
