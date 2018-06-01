using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceStationWebData
{
	public class Pozornik : Policajac
	{
		public virtual IList<Ulica> Ulice { get; set; }
		public Pozornik()
		{
			Ulice = new List<Ulica>();
		}
	}
}
