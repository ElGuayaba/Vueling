using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vueling.Infrastructure.Repository.Contracts;
using Vueling.Domain.Entities;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;

namespace Vueling.Infrastructure.Repository.Repositrory
{
	public class AlumnoRepository : IRepository<AlumnoEntity>
	{
		public AlumnoEntity Add(AlumnoEntity model)
		{
			try
			{
				throw new NotImplementedException();
			}
			catch (DbUpdateConcurrencyException ex)
			{
				throw new VuelingException("Error en la actualización", ex);
			}
			catch (DbUpdateException ex)
			{
				throw new VuelingException("Error en la actualización", ex);
			}
			catch (DbEntityValidationException ex)
			{
				throw new VuelingException("Error en la actualización", ex);
			}
			catch (NotSupportedException ex)
			{
				throw new VuelingException("Error en la actualización", ex);
			}
			catch (ObjectDisposedException ex)
			{
				throw new VuelingException("Error en la actualización", ex);
			}
			catch (InvalidOperationException ex)
			{
				throw new VuelingException("Error en la actualización", ex);
			}
		}

		public List<AlumnoEntity> GetAll()
		{
			throw new NotImplementedException();
		}

		public List<AlumnoEntity> GetByID()
		{
			throw new NotImplementedException();
		}

		public int Remove(int id)
		{
			throw new NotImplementedException();
		}

		public AlumnoEntity Update(AlumnoEntity model)
		{
			throw new NotImplementedException();
		}
	}
}
