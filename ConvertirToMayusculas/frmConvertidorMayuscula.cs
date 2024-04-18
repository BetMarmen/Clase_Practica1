using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertirToMayusculas
{
    public partial class frmConvertidorMayuscula : Form
    {
        private readonly ProcessorTexto _processor;
        public frmConvertidorMayuscula()
        {
            InitializeComponent();
            _processor = new ProcessorTexto(new TextFileRepository());
        }
        private async Task btnConvertir_Click(object sender, EventArgs e)
        {
            
            try
            {

            }
        }
    }
}
