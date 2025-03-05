using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soporfazer
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

        }

        private void Ver_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            form1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ver_Click(object sender, EventArgs e)
        {
            //List<string> lista = new List<string>();
            //if (File.Exists("estoque.txt"))
            //{
            //    StreamReader ler = new StreamReader("estoque.txt");
            //    string linha = "";
            //    while (linha != null)
            //    {
            //        if (linha != null)
            //        {
            //            linha = ler.ReadLine();
            //            lista.Add(linha);
            //        }
            //    }

            //    foreach (string line in lista)
            //    {
            //        Ver2.Items.Add(line);
            //        Ver2.Items.Add("==");
            //    }

            //    ler.Close();
            //}
            //else
            //{
            //    Ver2.Items.Add("Erro ");
            //}
            List<string> lista = new List<string>();

            // Verifica se o arquivo existe
            if (File.Exists("estoque.txt"))
            {
                try
                {
                    // Usando 'using' para garantir o fechamento correto do StreamReader
                    using (StreamReader ler = new StreamReader("estoque.txt"))
                    {
                        string linha;
                        // Lê as linhas até o fim do arquivo
                        while ((linha = ler.ReadLine()) != null)
                        {
                            // Verifica se a linha não está vazia antes de adicionar à lista
                            if (!string.IsNullOrWhiteSpace(linha))
                            {
                                lista.Add(linha);
                            }
                        }
                    }

                    // Verifica se a lista tem itens
                    if (lista.Count == 0)
                    {
                        Ver2.Items.Add("Arquivo está vazio ou só contém linhas em branco.");
                    }
                    else
                    {
                        // Exibe o conteúdo da lista na ListBox
                        foreach (string line in lista)
                        {
                            Ver2.Items.Add("apareça"+line);
                            Ver2.Items.Add("==");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Em caso de erro ao ler o arquivo, exibe a mensagem
                    Ver2.Items.Add("Erro ao ler o arquivo: " + ex.Message);
                }
            }
            else
            {
                Ver2.Items.Add("Erro: O arquivo 'estoque.txt' não foi encontrado.");
            }
        }
    }
}
