﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Application.Dto;
using Vueling.Application.Services.Contracts;
using Vueling.Domain.Entities;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Infrastructure.Repository.Repositrory;

namespace Vueling.Application.Services.Service
{
	public class AlumnoService : IService<AlumnoDto>
	{
		private readonly IRepository<AlumnoEntity> irepository;
		public AlumnoService():this(new AlumnoRepository())
		{

		}
		public AlumnoService(AlumnoRepository alumnoRepository)
		{
			this.irepository = alumnoRepository;
		}
		public AlumnoDto Add(AlumnoDto model)
		{
			throw new NotImplementedException();
		}

		public List<AlumnoDto> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<AlumnoDto> GetByID(int id)
		{
			throw new NotImplementedException();
		}

		public int Remove(int id)
		{
			throw new NotImplementedException();
		}

		public AlumnoDto Update(AlumnoDto model)
		{
			throw new NotImplementedException();
		}
	}
}