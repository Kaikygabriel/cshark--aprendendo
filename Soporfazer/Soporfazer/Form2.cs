using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soporfazer
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Produto> lista = new List<Produto>();
            Aparecer.Items.Clear();
            string nome = NomeP.Text;
            string marca = MarcaP.Text;
            lista.Add(new Produto(nome, marca));


            if (nome != null && nome.Length > 0 && marca != null && marca.Length > 0)
            {
                foreach (Produto produto in lista)
                {
                    Aparecer.Items.Add($" O produto {produto.nome} tem a marca {produto.marca}");
                }
                NomeP.Clear();
                MarcaP.Clear();
                Sair.Visible = true;
                StreamWriter escrever = File.AppendText("estoque.txt");
                List<string> lista2 = new List<string>();
                foreach(Produto produto in lista)
                {
                    lista2.Add(produto.nome);
                }
                foreach (string a in lista2)
                {
                    escrever.WriteLine(a);
                }
                escrever.Close();
            }
            else
            {
                Aparecer.Items.Add("error");
                NomeP.Clear();
                MarcaP.Clear();
            }
        }
                
          

        private void Sair_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 form1 = new Form1();
            
            form1.Visible = true;
        }
    }
}
