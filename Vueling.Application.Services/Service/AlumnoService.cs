using AutoMapper;
using System;
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
		private readonly IRepository<AlumnoEntity> iRepository;
		public AlumnoService():this(new AlumnoRepository())
		{

		}
		public AlumnoService(AlumnoRepository alumnoRepository)
		{
			this.iRepository = alumnoRepository;
		}
		public AlumnoDto Add(AlumnoDto alumno)
		{
			AlumnoEntity alumnoEntity = new AlumnoEntity();

			var config = new MapperConfiguration(cfg => cfg.CreateMap<AlumnoDto, AlumnoEntity>()
			.ForMember(dest => dest.Edad, sou => sou.ResolveUsing(entity => DateTime.Today.AddTicks(-entity.FechaNacimiento.Ticks).Year - 1)));

			IMapper iMapper = config.CreateMapper();

			alumnoEntity = iMapper.Map<AlumnoDto, AlumnoEntity>(alumno);
			try
			{
				iRepository.Add(alumnoEntity);
			}
			catch (Exception ex)
			{
				//log
				throw;
			}

			return alumno;
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
