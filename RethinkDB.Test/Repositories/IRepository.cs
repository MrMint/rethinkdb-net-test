using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RethinkDB.Test.Repositories
{
	/// <summary>
	/// Repository interface
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface IRepository<T>
	{
		IEnumerable<T> All();
		IEnumerable<T> Where(Expression<Func<T, bool>> predicate);
	}
}
