using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceStationWebData
{
	public class Patrola
	{
        // id ili redni_br?
        [Key]
        public virtual int Redni_br { get; set; }
		public virtual int ID_Vodje { get; set; }
        [NotMapped]
        public virtual Ostali Vodja { get; set; }
		public virtual int Reg_oznaka_vozila { get; set; }
        [NotMapped]
        public virtual Vozilo VoziloPatrole { get; set; }
		public virtual int ID_Objekta { get; set; }
		public virtual DateTime Vreme { get; set; }
		public virtual string Opis { get; set; }

        [NotMapped]
        public virtual Objekat InterveniseObjekat { get; set; }

        [NotMapped]
        public virtual IList<Ostali> Radnici { get; set; }


        public Patrola()
		{

		}
        



        //public List<PatrolaOstali> PatrolaOstali_ { get; set; }
        
    }
}
