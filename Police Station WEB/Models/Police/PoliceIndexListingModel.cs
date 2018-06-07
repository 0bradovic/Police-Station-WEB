using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Police_Station_WEB.Models.Police
{
    public class PoliceIndexListingModel
    {
        public int Id { get; set; }
        public string Licno_ime { get; set; }
        public string Prezime { get; set; }
        public int ID_Uprave { get; set; }
        public int ID_Cina { get; set; }

    }
}
