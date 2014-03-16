using RethinkDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RethinkDB.Test.Repositories
{
	public class RethinkDBRepository<T> :IRepository<T>
	{
		#region RethinkDB Connection Helpers

		private static IConnectionFactory connFactory = RethinkDb.Newtonsoft
			.Configuration.ConfigurationAssembler
			.CreateConnectionFactory("Bane");

		private IConnection dbConnection
		{
			get
			{
				return connFactory.Get();
			}
		}

		private ITableQuery<T> DatabaseTable
		{
			get
			{
				IDatabaseQuery db = Query.Db("testDB");
				return db.Table<T>("testTable");
			}
		}

		#endregion

		public IEnumerable<T> All()
		{
			return dbConnection.Run(DatabaseTable);
		}

		public IEnumerable<T> Where(Expression<Func<T, bool>> predicate)
		{
			return dbConnection.Run(DatabaseTable.Where<T>(predicate));
		}
	}
}
