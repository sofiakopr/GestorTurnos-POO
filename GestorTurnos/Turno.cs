using System;
using System.Net;

namespace Gestor { 
	public class Turno
	{
		int TurnoId;
		TurnoTipo turnoTipo;
		Persona paciente;

		public Turno(TurnoTipo turnoTipo, Persona paciente)
		{
			this.turnoTipo = turnoTipo;
			this.paciente = paciente;
		}

		public void Guardar()
		{
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[BASE DE DATOS] Conectando a la base de datos...");
            Console.WriteLine($"[BASE DE DATOS] Insertando turno: Paciente={paciente.Nombre}, DNI={paciente.Dni}, Tipo={turnoTipo.NombreTipo}, Precio=${turnoTipo.Precio}");
            Console.WriteLine("[BASE DE DATOS] Turno guardado correctamente.");
        }
		public void EnviarEmail()
		{
            Console.WriteLine("[EMAIL] Conectando al servidor SMTP...");
            Console.WriteLine($"[EMAIL] Enviando confirmación de turno a {paciente.Email}...");
            Console.WriteLine("[EMAIL] Email enviado correctamente.");
        }

		public void MostrarComprobante()
		{
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("           COMPROBANTE DE TURNO - CLÍNICA           ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Paciente:   {paciente.Nombre}");
            Console.WriteLine($"DNI:        {paciente.Dni}");
            Console.WriteLine($"Email:      {paciente.Email}");
            Console.WriteLine($"Tipo turno: {turnoTipo.NombreTipo}");
            Console.WriteLine($"Precio:     ${turnoTipo.Precio}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }

        public static bool ValidarPaciente(Persona paciente)
        {
            if (string.IsNullOrWhiteSpace(paciente.Nombre))
            {
                Console.WriteLine("Error: el nombre del paciente es obligatorio.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(paciente.Dni) || paciente.Dni.Length < 7)
            {
                Console.WriteLine("Error: el DNI ingresado no es válido.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(paciente.Email) || !paciente.Email.Contains("@"))
            {
                Console.WriteLine("Error: el email ingresado no es válido.");
                return false;
            }
            return true;
        }
    }
}
