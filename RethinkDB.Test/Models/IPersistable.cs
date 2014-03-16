using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RethinkDB.Test.Models
{
	public interface IPersistable
	{
		string PersistId { get; set; }

		string Name { get; set; }
	}
}
