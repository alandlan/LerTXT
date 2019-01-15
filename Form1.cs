using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LerArquivoTxt
{
    public partial class LerArquivoTXT : Form
    {
        public LerArquivoTXT()
        {
            InitializeComponent();
        }

        private void lerButton_Click(object sender, EventArgs e)
        {

            dadosListBox.Items.Clear();

            string endereco = @"C:\Dados\ArquivoClientes.txt";
            try
            {
                if (!System.IO.File.Exists(endereco))
                {
                    throw new Exception("ArquivoClientes.txt não foi localizado!!");                      
                }

                string[] dados = new string[4];

                System.IO.StreamReader leitor = new System.IO.StreamReader(endereco, System.Text.Encoding.UTF7);

                // Definir o cabeçalho na ListBox
                dadosListBox.Items.Add
                (
                "CÓDIGO".PadRight(7) +
                "CLIENTE".PadRight(40) +
                "CIDADE".PadRight(20) +
                "PAÍS"
                );

                dadosListBox.Items.Add(new string('-', 80));

                while (!leitor.EndOfStream)
                {
                    dados = leitor.ReadLine().Split(';');

                    dadosListBox.Items.Add
                        (
                        dados[0].PadRight(7) +
                        dados[1].PadRight(40) +
                        dados[2].PadRight(20) +
                        dados[3]
                        );
                }

                leitor.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Alerta de Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }
    }
}
