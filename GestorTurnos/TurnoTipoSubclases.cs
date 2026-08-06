using System;

namespace Gestor { 

	public class TurnoNormal : TurnoTipo
	{
		public override string NombreTipo => "Normal";
		public override decimal Precio => 5000m;
    }

	public class TurnoUrgente : TurnoTipo
	{
		public override string NombreTipo => "Urgente";
		public override decimal Precio => 7500m;
    }

	public class TurnoSeguimiento : TurnoTipo
	{
		public override string NombreTipo => "Seguimiento";
		public override decimal Precio => 3000m;
    }

}
