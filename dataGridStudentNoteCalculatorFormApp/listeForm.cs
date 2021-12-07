using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dataGridStudentNoteCalculatorFormApp
{
    public partial class listeForm : Form
    {
        public static int ids = 0;

        public listeForm(decimal not1, decimal not2, decimal not3, decimal ortalama)
        {
            InitializeComponent();
            ids++;
            ids= dataGridView1.Rows.Add();
            dataGridView1.Rows[ids].Cells[0].Value = ids.ToString();
            dataGridView1.Rows[ids].Cells[1].Value = not1.ToString();
            dataGridView1.Rows[ids].Cells[2].Value = not2.ToString();
            dataGridView1.Rows[ids].Cells[3].Value = not3.ToString();
            dataGridView1.Rows[ids].Cells[4].Value = ortalama.ToString();
            if (ortalama>45)
            {
                dataGridView1.Rows[ids].Cells[5].Value = "Geçti";

            }
            else
            {
                dataGridView1.Rows[ids].Cells[5].Value = "Kaldı";

            }
        }
    }
}
