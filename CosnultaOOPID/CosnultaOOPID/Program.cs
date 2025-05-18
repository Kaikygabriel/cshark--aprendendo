using System;
using CosnultaOOPID.Entity;
using CosnultaOOPID.Entity.Enum;
using CosnultaOOPID.Service;

namespace CosnultaOOPID
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doutor  = new Doctor("fernando",EnumDoctor.Pediatra);
            Paciente paciente = new Paciente("Gabriel", "Gripado e com garganta inflamada");
            INotification notification =new EmailNotification(paciente.Descricao);
            AppointmentService consulta = new AppointmentService(doutor,paciente,notification);
            consulta.scheduleAppointment();
        }
    }
}
