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

        string GetIme(int ID);
        string GetPrezime(int ID);

        //string GetTip(int ID);
        //Ustanova GetPripadaUstanovi(int ID);
        //Cin GetImaCin(int ID);
        


    }
}
