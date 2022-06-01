using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NWDotNetCore
{
    public class LinQExample
    {
        public void Test()
        {
			//enum
			var list = new List<string>
			{
				"mike",
				"anna",
				"ralph"
			};

			//wrtten sting which starts with an

			var name = list.FirstOrDefault(x => x.StartsWith("an"));

        }
    }
	public class UsStates
	{
		public usTerritories ID { get; set; }
		public string Name { get; set; }

		public enum usTerritories
		{
			westborough = 01581,
			bellwood = 2221,
			Hillside = 32113
		}
	}
}
