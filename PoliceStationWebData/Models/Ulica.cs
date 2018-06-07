using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceStationWebData
{
	public class Ulica
	{
        [ForeignKey("Policajac")]
        public virtual int ID_Policajca { get; set; }

        [Key]
		public virtual string Ulica_naziv { get; set; }

        [NotMapped]
		public virtual Policajac PozornikUlice { get; set; }

		public Ulica()
		{

		}
	}
}
