using ComputosDB.BusinessLogic;
using ComputosDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputosDB.View
{
    public partial class FrmDetallecomputadora : Form
    {
        private List<Detallecomputadora> _listado;
        public FrmDetallecomputadora()
        {
            InitializeComponent();
        }

        private void FrmDetallecomputadora_Load(object sender, EventArgs e)
        {
            UpdateGrid();
            UpdateCombo();
        }
        private void UpdateGrid()
        {
            _listado = DetallecomputadoraBL.Instance.SellecALL();
            var query2 = from x in _listado
                         select new
                         {
                             id = x.IdDetallecomputadora,
                             Nombres = x.Nombre,
                             Rams = x.Ram,
                             Placa = x.ModeloDePlaca,
                             teclados = x.Teclado,
                             Procesadores = x.Procesador,
                             NumeroRAM = x.Ram,
                             Nucleo = x.Nucleos,
                             Pulgadas = x.PulgadasDepantalla,
                             ratones = x.Raton,
                             Computadora = x.Computadoras.Nombre

                         };
            dataGridView1.DataSource = query2.ToList();
        }
 private void button1_Click(object sender, EventArgs e)
        {
            Detallecomputadora entity = new Detallecomputadora()
            {
                Nombre = textBox1.Text.Trim(),
                Ram = textBox2.Text.Trim(),              
                ModeloDePlaca = textBox3.Text.Trim(),
                Teclado = textBox4.Text.Trim(),
                Procesador = textBox5.Text.Trim(),            
                Nucleos = textBox6.Text.Trim(),
                Raton = textBox8.Text.Trim(),
                NumerodeRAM = Convert.ToInt32(numericUpDown1.Value),
                PulgadasDepantalla = decimal.Parse(textBox7.Text),
                idComputadora = (int)comboBox1.SelectedValue
            };

            if (DetallecomputadoraBL.Instance.Insert(entity))
            {
                MessageBox.Show("Se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateGrid();
               

            }
        }
        private void UpdateCombo()
        {
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "idComputadora";
            comboBox1.DataSource = ComputadorasBL.Instance.SellecALL();
        }

       
    }
}
