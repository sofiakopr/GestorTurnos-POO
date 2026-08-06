using System;

namespace Gestor
{
    public class GestorTurnos
    {
        public void ProcesarTurno(string nombrePaciente, string dni, string tipoTurnoPaciente, string email)
        {
            Persona paciente = new Persona(nombrePaciente, dni, email);
            TurnoTipo turnoTipo;

            if(Turno.ValidarPaciente(paciente) == false)
            {
                Console.WriteLine("Error: no se puede procesar el turno. Datos de paciente inválidos.");
                return;
            }

            switch(tipoTurnoPaciente) {
                case "Normal":
                    turnoTipo = new TurnoNormal();
                    break;
                case "Urgente":
                    turnoTipo = new TurnoUrgente();
                    break;
                case "Seguimiento":
                    turnoTipo = new TurnoSeguimiento();
                    break;
                default:
                    Console.WriteLine("Error: tipo de turno no válido.");
                    return;
            }

            Turno turnito = new Turno(turnoTipo, paciente);
            turnito.Guardar();
            turnito.EnviarEmail();
            turnito.MostrarComprobante();
        }
    }
}
