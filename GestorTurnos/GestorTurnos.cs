using System;

namespace Gestor
{
    public class GestorTurnos
    {
        public void ProcesarTurno(string nombrePaciente, string dni, string tipoTurno, string email)
        {
            if (string.IsNullOrWhiteSpace(nombrePaciente))
            {
                Console.WriteLine("Error: el nombre del paciente es obligatorio.");
                return;
            }

            if (string.IsNullOrWhiteSpace(dni) || dni.Length < 7)
            {
                Console.WriteLine("Error: el DNI ingresado no es válido.");
                return;
            }

            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@"))
            {
                Console.WriteLine("Error: el email ingresado no es válido.");
                return;
            }

            var paciente = new Pacientes();
            paciente.DatosPacientes(nombrePaciente, dni, tipoTurno, email, precio);
        }

        public decimal precio = 0;
        public decimal Precio(string tipoTurno)
        {

                switch (tipoTurno)
                {
                    case "Normal":
                        precio = 5000;
                        break;
                    case "Urgente":
                        precio = 7500;
                        break;
                    case "Seguimiento":
                        precio = 3000;
                        break;
                    default:
                        Console.WriteLine("Error: tipo de turno desconocido.");
                        return precio;
                }
                // Ensure a decimal value is returned for all code paths
                return precio;
        }

        internal void DatosPacientes(string nombrePaciente, string dni, string tipoTurno, string email, decimal precio)
        {
        }
    }
}
