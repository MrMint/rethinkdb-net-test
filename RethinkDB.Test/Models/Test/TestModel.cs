using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RethinkDB.Test.Models.Test
{
	public class TestModel : IPersistable
	{
		//Primary Key
		[JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
		public string PersistId { get; set; }

		public string Name { get; set; }
	}
}
