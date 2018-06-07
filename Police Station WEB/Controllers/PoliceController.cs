using PoliceStationWebData;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Police_Station_WEB.Models.Police;

namespace Police_Station_WEB.Controllers
{
    public class PoliceController:Controller
    {
        private IPoliceStationWebPolicajac _Policajac;

        public PoliceController(IPoliceStationWebPolicajac Policajac)
        {
            _Policajac = Policajac;
        }

        public IActionResult Index()
        {
            var policajacModels = _Policajac.GetAll();

            var listingResult = policajacModels
            .Select(result => new PoliceIndexListingModel
            {
                Id = result.ID,
                Licno_ime = result.Licno_ime,
                Prezime = result.Prezime,
                ID_Uprave = result.ID_Uprave,
                ID_Cina = result.ID_Cina
            });

            var model = new PoliceIndexModel()
            {
                PoliceS = listingResult
            };

            return View(model);
        }


    }
}
