using BL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/vaccination")]
    public class VaccinationController : ApiController
    {
        //Function to add a Vaccination
        [Route("GetAddNewVaccination/{Id}/{RecivingVaccine}/{Manufacturer}")]
        public int GetAddNewVaccination(int id, DateTime RecivingVaccine, string Manufacturer)

        {
            return VaccinationBL.AddNewVaccination(new Vaccination( id, RecivingVaccine, Manufacturer));
        }


        //Function to update a Vaccination
        [Route("GetUpdateVaccination/{Id}/{RecivingVaccine}/{Manufacturer}")]
        public string GetUpdateVaccination(int id, DateTime RecivingVaccine, string Manufacturer)
        {
            return "change Vaccination " + VaccinationBL.UpdateVaccination(new Vaccination(id, RecivingVaccine, Manufacturer));

        }
        //A function for retrieving an Vaccination by id
        [Route("GetVaccination/{Id}")]
        public Vaccination GetVaccination(int id)
        {
            return VaccinationBL.GetVaccinationById(id);
        }

        //Function to delete a Vaccination
        [Route("GetDelete/{Id}")]
        public int GetDelete(int id)
        {
            return VaccinationBL.GetDeleteVaccination(id);
        }

        //A function to retrieve all Vaccinations
        [Route("GetAllVaccinations")]
        public List<Vaccination> GetAllVaccinations()
        {
            //העברה לגורם המטפל
            List<Vaccination> Vaccinations = VaccinationBL.GetVaccinations();
            //החזרת התשובה למשתשמש
            return Vaccinations;
        }

      
    }
}
