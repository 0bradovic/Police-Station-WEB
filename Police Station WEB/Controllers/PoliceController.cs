using PoliceStationWebData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Police_Station_WEB.Models.Police;
using Microsoft.EntityFrameworkCore;


namespace Police_Station_WEB.Controllers
{
    public class PoliceController:Controller
    {
        private PoliceStationWebDataContext db = new PoliceStationWebDataContext();

        private readonly IPoliceStationWebPolicajac _Policajac;

        public PoliceController(IPoliceStationWebPolicajac Policajac)
        {
            _Policajac = Policajac;
        }

        
        public IActionResult Index()
        {
            IEnumerable<PoliceIndexListingModel> listingResult = db.Set<Policajac>().ToList().Select(b => new PoliceIndexListingModel
            {
                Id = b.ID,
                Ime = _Policajac.GetIme(b.ID),
                Prezime = _Policajac.GetPrezime(b.ID)
            });

            var model = new PoliceIndexModel
            {
                PoliceS = listingResult
            };

            return View("Index", model);

            /*
            var policajacModels = _Policajac.GetAll();
            
            
            var listingResult = policajacModels
            .Select(result => new PoliceIndexListingModel
            {
                Id = result.ID,
                Ime = _Policajac.GetIme(result.ID),
                Prezime = _Policajac.GetPrezime(result.ID)
               //Tip = _Policajac.GetTip(result.ID),
               //PripadaUstanovi = _Policajac.GetPripadaUstanovi(result.ID),
               //ImaCin = _Policajac.GetImaCin(result.ID)
            
            }).ToList();

            var model = new PoliceIndexModel
            {
                PoliceS = listingResult
            };

            return View(model);
            */
        }


    }
}
