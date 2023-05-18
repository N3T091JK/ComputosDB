using ComputosDB.BusinessLogic;
using ComputosDB.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputosDB.View
{
    public partial class FrmComputadoras : Form
    {
        private List<Computadoras> _listado;
        public FrmComputadoras()
        {
            InitializeComponent();
        }

        private void FrmComputadoras_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Computadoras entity = new Computadoras()
            {
                Nombre = textBox1.Text.Trim(),
            };

            if (ComputadorasBL.Instance.Insert(entity))
            {
                MessageBox.Show("Se agrego con exito!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateGrid();
                textBox1.Text = "";
            }
        }

        private void UpdateGrid()
        {
            _listado = ComputadorasBL.Instance.SellecALL();
            var query = from x in _listado
                        select new
                        {
                            Id = x.idComputadora,
                            Nombres = x.Nombre

                        };
            dataGridView1.DataSource = query.ToList();
        }




    }
}
