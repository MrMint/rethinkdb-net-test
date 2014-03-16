using RethinkDb;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RethinkDB.Test.Tests
{
	/// <summary>
	/// Used to ensure rethinkdb has the needed tables 
	/// </summary>
	public class BaseTest
	{
		protected BaseTest()
		{
			//Setup RethinkDB
			var conn = RethinkDb.Newtonsoft
					.Configuration.ConfigurationAssembler
					.CreateConnectionFactory("Bane").Get();

			var dbName = "testDB";
			var tableName = "testTable";

			if (!conn.Run(Query.DbList()).Contains(dbName))
			{
				conn.Run(Query.DbCreate(dbName));

				IDatabaseQuery db = Query.Db(dbName);

				// Create table if needed
				if (!conn.Run(db.TableList()).Contains(tableName))
				{
					conn.Run(db.TableCreate(tableName));
				}
			}
		}
	}
}
