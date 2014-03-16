using RethinkDB.Test.Models.Test;
using RethinkDB.Test.Repositories;
using RethinkDB.Test.Repositories.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RethinkDB.Test.Tests.RepositoryTests
{
	public class RepositoryTests : BaseTest
	{
		/// <summary>
		/// Check if the non-generic test repository throws exceptions when calling GetTestByName()
		/// </summary>
		[Fact]
		public void GetByNameTestRepository()
		{
			Assert.DoesNotThrow(
				delegate()
				{
					new TestRepository(new RethinkDBRepository<TestModel>()).GetTestByName("test");
				}
			);
		}

		/// <summary>
		/// Check if the generic test repository throws exceptions when calling GetTestByName()
		/// </summary>
		[Fact]
		public void GetByNameGenericTestRepository()
		{
			Assert.DoesNotThrow(
				delegate()
				{
					new GenericTestRepository<TestModel>(new RethinkDBRepository<TestModel>()).GetTestByName("test");
				}
			);
		}
	}
}
