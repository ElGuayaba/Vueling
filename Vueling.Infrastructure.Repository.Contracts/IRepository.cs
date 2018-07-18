using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vueling.Infrastructure.Repository.Contracts
{
	public interface IRepository<T>
	{
		T Add(T model);
		T Update(T model);
		List<T> GetAll();
		List<T> GetByID();
		int Remove(int id);
	}
}
