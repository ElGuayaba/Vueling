using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Application.Dto
{
	public class AlumnoDto
	{
		public string Id { get; set; }
		public string Nombre { get; set; }
		public string Apellidos { get; set; }
		public string DNI { get; set; }
		public DateTime FechaNacimiento { get; set; }
	}
}
