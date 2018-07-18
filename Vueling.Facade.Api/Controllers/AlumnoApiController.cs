using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Vueling.Application.Dto;
using Vueling.Application.Services.Contracts;
using Vueling.Application.Services.Service;

namespace Vueling.Facade.Api.Controllers
{
    public class AlumnoApiController : ApiController
    {
		AlumnoService alumnoService = new AlumnoService();
		public readonly IService<AlumnoDto> iService = new AlumnoService();
		public AlumnoApiController() : this(new AlumnoService())
		{

		}
		public AlumnoApiController(AlumnoService alumnoService)
		{
			this.iService = alumnoService;
		}
		// GET: api/AlumnoApi
		public IQueryable<AlumnoDto> Get()
        {
			throw new NotImplementedException();
			//return alumnoService.GetAll();
		}

        // GET: api/AlumnoApi/5
        public IHttpActionResult Get(int id)
        {
			throw new NotImplementedException();
			//return alumnoService.GetByID(id);
			//Rerotna ok alumno
        }

		// POST: api/AlumnoApi
		[ResponseType(typeof(AlumnoDto))]
		public IHttpActionResult Post(AlumnoDto alumno)
        {
			AlumnoDto alumnoDtoInserted = 
				alumnoService.Add(alumno);
			throw new NotImplementedException();
			//alumnoService.Add(alumno);
		}

        // PUT: api/AlumnoApi/5
        public bool Put(AlumnoDto alumno)
        {
			throw new NotImplementedException();
			//alumnoService.Update(alumno);
			//return true;
			//Devuelce status code no content
		}

        // DELETE: api/AlumnoApi/5
        public IHttpActionResult Delete(int id)
        {
			throw new NotImplementedException();
			//return alumnoService.Remove(id);
		}
    }
}
