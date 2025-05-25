using System;
using PlataformaCursosAvaliaçõesCertificados.Entities;

namespace PlataformaCursosAvaliaçõesCertificados.Service
{
    internal interface IGeradorCertificado
    {
        void Gerar(Aluno aluno, Curso curso);
    }
}
