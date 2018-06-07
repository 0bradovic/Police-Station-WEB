using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceStationWebData
{
	public class Ostali : Policajac
	{
	
		public virtual int Redni_br_patrole { get; set; }

        [NotMapped]
        public virtual Patrola PatrolaVodje { get; set; }

        [NotMapped]
        public virtual Patrola RadiU { get; set; }

        


        public Ostali()
		{

		}



        //public List<PatrolaOstali> PatrolaOstali_ { get; set; }

    }
}
