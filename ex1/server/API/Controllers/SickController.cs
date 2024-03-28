using BL;
//using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/sick")]
    public class SickController : ApiController
    {
        //Function to add a sick
        [Route("GetAddNewSick/{Id}/{RecivingPositive}/{TimeOfRecovery}")]
        public int GetAddNewSick(int id, DateTime RecivingPositive, DateTime TimeOfRecovery)

        {
            return SickBL.AddNewSick(new Sick(id, RecivingPositive, TimeOfRecovery));
        }


        //Function to update a sick
        [Route("GetUpdateSick/{Id}/{RecivingVaccine}/{Manufacturer}")]
        public string GetUpdateSick(int id, DateTime RecivingVaccine, DateTime Manufacturer)
        {
            return "change Sick " + SickBL.UpdateSick(new Sick(id, RecivingVaccine, Manufacturer));

        }

        //A function for retrieving a sick by id
        [Route("GetSick/{Id}")]
        public Sick GetSick(int id)
        {
            return SickBL.GetSickById(id);
        }

        //Function to delete a sick
        [Route("GetDelete/{Id}")]
        public int GetDelete(int id)
        {
            return SickBL.GetDeleteSick(id);
        }

        //A function to retrieve all sicks
        [Route("GetAllSicks")]
        public List<Sick> GetAllSicks()
        {
           
            List<Sick> Sicks = SickBL.GetSicks(); 
            return Sicks;
        }

    }
}
