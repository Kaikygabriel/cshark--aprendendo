using System;
using System.IO;
using PlataformaCursosAvaliaçõesCertificados.Entities;

namespace PlataformaCursosAvaliaçõesCertificados.Service
{
    internal sealed class CertificadoTexto : IGeradorCertificado
    {
        public void Gerar(Aluno aluno,Curso curso)
        {
            try
            {
                string folder = @"C:\Users\kaiky\Downloads\Certificados\" + aluno.Nome + ".txt";
                using (StreamWriter rw = File.AppendText(folder))
                {
                    rw.WriteLine($"O aluno :\n{aluno}\n Passou no curso {curso.Titulo}\n esta Certificado!!");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("ERROR ao enviar certificado "+e.Message+" na linha "+e.StackTrace);
            }
        }
    }
}
