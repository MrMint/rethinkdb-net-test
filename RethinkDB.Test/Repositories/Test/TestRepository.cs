using RethinkDB.Test.Models.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RethinkDB.Test.Repositories.Test
{
	/// <summary>
	/// A Repository for TestModels
	/// </summary>
	public class TestRepository
	{
		private IRepository<TestModel> repository;

		public TestRepository(IRepository<TestModel> repository)
		{
			this.repository = repository;
		}

		public TestModel GetTestByName(string name)
		{
			return repository.Where(x => x.Name == name).SingleOrDefault();
		}
	}
}
