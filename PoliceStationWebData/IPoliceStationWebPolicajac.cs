using System;
using System.Collections.Generic;
using System.Text;
using PoliceStationWebData;

namespace PoliceStationWebData
{
    public interface IPoliceStationWebPolicajac
    {
        IEnumerable<Policajac> GetAll();
        Policajac GetById(int ID);
        void add(Policajac noviPolicajac);
        
        string GetTip(int ID);

        /*
        string GetLicno_ime(int ID);
        string GetPrezime(int ID);
        int GetJMBG(int ID);
        char GetPol(int ID);
        
        DateTime GetDatum_rodj(int ID);

        int GetOblast(int ID);
        
        int GetID_Uprave(int ID);
        */


        //Nemapirano trenutno
        Ustanova GetPripadaUstanovi(int ID);
        Cin GetImaCin(int ID);





        //Ostali
        int GetRedni_br_patrole(int ID);
        Patrola GetPatrolaVodje(int ID);
        Patrola GetRadiU(int ID);

        //Skolski
        int GetID_Skole(int ID);
        Skola GetRadiUSkoli(int ID);

        //VanredneSituacije
        string GetNaziv_vestine(int ID);
        string GetKurs(int ID);


    }
}
