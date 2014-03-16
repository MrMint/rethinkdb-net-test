using RethinkDB.Test.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RethinkDB.Test.Repositories.Test
{
	/// <summary>
	/// A generic repository for objects that implements IPersistable
	/// </summary>
	/// <typeparam name="T">Implements IPersistable</typeparam>
	public class GenericTestRepository<T> where T : IPersistable
	{
		private IRepository<T> repository;

		public GenericTestRepository(IRepository<T> repository)
		{
			this.repository = repository;
		}

		public T GetTestByName(string name)
		{
			return repository.Where(x => x.Name == name).SingleOrDefault();
		}
	}
}
