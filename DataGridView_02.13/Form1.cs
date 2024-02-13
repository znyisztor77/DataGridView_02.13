using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView_02._13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tablazatBeallitasai();
            //tablazatFrissitese();
        }

        private void tablazatFrissitese()
        {
            throw new NotImplementedException();
        }

        private void tablazatBeallitasai()
        {
            // -- egésztáblázatra ható
            dataGridView_Tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //-- fejléc beállításai
            dataGridView_Tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
            dataGridView_Tabla.ColumnHeadersDefaultCellStyle.BackColor = Color.White;
            dataGridView_Tabla.ColumnHeadersDefaultCellStyle.Font = new Font(this.Font, FontStyle.Italic);

            //-- oszlopk létrehozása és tulajdonságai 
            DataGridViewColumn column_orszag = new DataGridViewColumn();
            {
                column_orszag.Name = "orszag";
                column_orszag.HeaderText = "Ország neve";
                column_orszag.CellTemplate = new DataGridViewTextBoxCell(); 
            }

            dataGridView_Tabla.Columns.Add(column_orszag);
            //-- főváros

            DataGridViewColumn column_fovaros = new DataGridViewColumn();
            {
                column_fovaros.Name = "fovaros";
                column_fovaros.HeaderText = "Főváros";
                column_fovaros.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Tabla.Columns.Add(column_fovaros);
            //-- terület
            DataGridViewColumn column_terulet = new DataGridViewColumn();
            {
                column_terulet.Name = "terulte";
                column_terulet.HeaderText = "Terulet";
                column_terulet.CellTemplate = new DataGridViewTextBoxCell();
            }
            dataGridView_Tabla.Columns.Add(column_terulet);



        }
    }
}
