using System;

namespace Gestor { 

    public class Persona
    {
	    public string Nombre { get; set; }
	    public string Dni { get; set; }
	    public string Email { get; set; }

        public Persona(string nombre, string dni, string email)
        {
            Nombre = nombre;
            Dni = dni;
            Email = email;
        }

    }
}
