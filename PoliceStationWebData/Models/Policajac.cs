using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoliceStationWebData
{
	public class Policajac
	{
        [Key]
        [Required] public virtual int ID { get; set; }

        [Required] public virtual string Tip { get; set; } //promenjeno iz int u string



        [Required]
        [Display(Name = "Licno Ime")] public virtual string Licno_ime { get; set; }
		public virtual string Ime_roditelja { get; set; }
        [Required]
        [Display(Name = "Prezime")] public virtual string  Prezime { get; set; }
        [Required]
        [Display(Name = "JMBG")] public virtual int JMBG { get; set; }
		public virtual char Pol { get; set; }
		public virtual string Adresa { get; set; }


		public virtual DateTime Datum_diplomiranja { get; set; }
		public virtual DateTime Datum_unapredjenja { get; set; }
        public virtual DateTime Datum_rodj { get; set; }

        public virtual int Oblast { get; set; }

        public virtual int ID_Ustanove { get; set; }
		public virtual int ID_Cina { get; set; }
		public virtual int ID_Uprave { get; set; }
		public virtual int ID_Stanice { get; set; }

        [NotMapped]
        public virtual Uprava JeZamenikUprave { get; set; }
        [NotMapped]
        public virtual Ustanova PripadaUstanovi { get; set; }
        [NotMapped]
        public virtual Uprava JeNacelnikUprave { get; set;  }
        [NotMapped]
        public virtual PolicijskaStanica RadiUStanici { get; set; }
        [NotMapped]
        public virtual PolicijskaStanica PolicijskaStanicaZamenika { get; set; }
        [NotMapped]
        public virtual PolicijskaStanica PolicijskaStanicaSefa { get; set; }

        [NotMapped]
        public virtual Cin ImaCin { get; set; }



        public Policajac()
		{

		}
        
    }
}
