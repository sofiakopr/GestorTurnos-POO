using System;

namespace Gestor
{
    public class Pacientes
    {
        public void DatosPacientes(string nombrePaciente, string dni, string tipoTurno, string email, decimal precio)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("[BASE DE DATOS] Conectando a la base de datos...");
            Console.WriteLine($"[BASE DE DATOS] Insertando turno: Paciente={nombrePaciente}, DNI={dni}, Tipo={tipoTurno}, Precio=${precio}");
            Console.WriteLine("[BASE DE DATOS] Turno guardado correctamente.");

            Console.WriteLine("[EMAIL] Conectando al servidor SMTP...");
            Console.WriteLine($"[EMAIL] Enviando confirmación de turno a {email}...");
            Console.WriteLine("[EMAIL] Email enviado correctamente.");

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("           COMPROBANTE DE TURNO - CLÍNICA           ");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine($"Paciente:   {nombrePaciente}");
            Console.WriteLine($"DNI:        {dni}");
            Console.WriteLine($"Email:      {email}");
            Console.WriteLine($"Tipo turno: {tipoTurno}");
            Console.WriteLine($"Precio:     ${precio}");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
        }
    }
}


