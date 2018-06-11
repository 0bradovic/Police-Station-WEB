using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PoliceStationWebData;

namespace PoliceStationWebServices
{
    public class PoliceStationWebDataPolicajacService : IPoliceStationWebPolicajac
    {
        private PoliceStationWebDataContext _context;
        
        //Policajac

        public PoliceStationWebDataPolicajacService(PoliceStationWebDataContext context)
        {
            _context = context;
        }

        public void add(Policajac noviPolicajac)
        {
            _context.Add(noviPolicajac);
            _context.SaveChanges();
        }

        public IEnumerable<Policajac> GetAll()
        {
            return
                _context.Policajac_
                .Include(a => a.Licno_ime)
                .Include(a => a.Prezime)
                .Include(a => a.JMBG);
                //.Include(a => a.Pol)
                //.Include(a => a.Datum_rodj)
                //.Include(a => a.Oblast)
                //.Include(a => a.Adresa)
                //.Include(a => a.ID_Uprave);
        }

        public Policajac GetById(int ID)
        {
            return
                GetAll()
                .FirstOrDefault(Policajac => Policajac.ID == ID);
        }
        
        public string GetIme(int ID)
        {
            return _context.Policajac_.First(a => a.ID == ID).Licno_ime;
        }

        public string GetPrezime(int ID)
        {
            return _context.Policajac_.First(a => a.ID == ID).Prezime;
        }
        /*
        public string GetTip(int ID) //Discriminator
        {
            var skolski = _context.Policajac_
                .OfType<Skolski>().SingleOrDefault(a => a.ID == ID);
            var ostali = _context.Policajac_
                .OfType<Ostali>().SingleOrDefault(a => a.ID == ID);

            if (skolski != null)
            {
                return "Skolski";
            }
            else if (ostali != null)
            {
                return "Ostali";
            }
            else { return "VanredneSituacije"; }
        }
        
        public Ustanova GetPripadaUstanovi(int ID)
        {
            return _context.Policajac_.First(a => a.ID == ID).PripadaUstanovi;
        }
        
        public Cin GetImaCin(int ID)
        {
            return _context.Policajac_.First(a => a.ID == ID).ImaCin;
        }






        //Ostali
        public int GetRedni_br_patrole(int ID)
        {
            if (GetTip(ID) != "Ostali") return 0;
            var ostali = (Ostali)GetById(ID);
            return ostali.Redni_br_patrole;
        }

        public Patrola GetPatrolaVodje(int ID)
        {
            if (GetTip(ID) != "Ostali") return null;
            var ostali = (Ostali)GetById(ID);
            return ostali.PatrolaVodje;
        }

        public Patrola GetRadiU(int ID)
        {
            if (GetTip(ID) != "Ostali") return null;
            var ostali = (Ostali)GetById(ID);
            return ostali.RadiU;
        }




        //Skolski
        public int GetID_Skole(int ID)
        {
            if (GetTip(ID) != "Skolski") return 0;
            var skolski = (Skolski)GetById(ID);
            return skolski.ID_Skole;
        }

        public Skola GetRadiUSkoli(int ID)
        {
            if (GetTip(ID) != "Skolski") return null;
            var skolski = (Skolski)GetById(ID);
            return skolski.RadiUSkoli;
        }




        //VanredneSituacije
        public string GetNaziv_vestine(int ID)
        {
            if (GetTip(ID) != "VanredneSituacije") return "N/A";
            var VanredneSituacije = (VanredneSituacije)GetById(ID);
            return VanredneSituacije.Naziv_vestine;
        }

        public string GetKurs(int ID)
        {
            if (GetTip(ID) != "VanredneSituacije") return "N/A";
            var VanredneSituacije = (VanredneSituacije)GetById(ID);
            return VanredneSituacije.Kurs;
        }
        */
    }
}
