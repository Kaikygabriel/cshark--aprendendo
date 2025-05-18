using System;
using CosnultaOOPID.Entity;

namespace CosnultaOOPID.Service
{
    internal class AppointmentService
    {
        public AppointmentService() { }

        public AppointmentService(Doctor doutor, Paciente paciente, INotification notificacao)
        {
            _doutor = doutor;
            _paciente = paciente;
            _notificacao = notificacao;
        }

        private Doctor _doutor;
        private Paciente _paciente;
        private INotification _notificacao;

        public  void scheduleAppointment()
        {
            Console.WriteLine("Dados da consulta");
            Console.WriteLine("Doutor : "+_doutor);
            Console.WriteLine("Paciente : "+_paciente);
            Console.WriteLine("Notificação " + _notificacao.GetNotification());
        }
    }
}
