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
using Microsoft.Ajax.Utilities;


//using System.Data.Entity;

namespace API.Controllers
{
    [EnableCors("*", "*", "*")]
    [RoutePrefix("api/treated")]
    public class TreatedController : ApiController
    {
        //Function to add an Treated
        [HttpGet]
        [Route("GetAddNewTreated/{Name}/{Id}/{City}/{Street}/{Number}/{DateOfBirth}/{Phone}/{PhoneNumber}")]
        public string GetAddNewTreated(string Name, int id, string City,string Street,int Number, DateTime DateOfBirth, string phone, string phoneNumber)

        {
            return "new Treated " + TreatedBL.AddNewTreated(new Treated(Name, id, City,Street,Number, DateOfBirth, phone, phoneNumber));
        }


        // A function to update a Treated
        [Route("GetUpdateTreated/{Name}/{Id}/{Address}/{DateOfBirth}/{Phone}/{PhoneNumber}")]
        //public string GetUpdateTreated(string Name, int id, string Address, DateTime DateOfBirth)
        public string GetUpdateTreated(string Name, int id, string City, string Street, int Number, DateTime DateOfBirth, string phone, string phoneNumber)
        {
            return "change Treated " + TreatedBL.UpdateTreated(new Treated(Name, id, City, Street, Number, DateOfBirth, phone, phoneNumber));
        }


        //[Route("GetUpdateTreated/{Name}")]
        ////[Route("GetUpdateTreated/{Name}/{Id}/{Address}/{DateOfBirth}/{Phone}/{PhoneNumber}/{NumOfVaccination}")]
        //public string GetUpdateTreated(object Name)
        ////public string GetUpdateTreated(string Name, int id, string Address, DateTime DateOfBirth, string phone, string phoneNumber, int NumOfVaccination)
        //{
        //    return "ok!";
        //    //return "change Treated " + TreatedBL.UpdateTreated(new Treated(Name, id, Address, new DateTime(), phone, phoneNumber, NumOfVaccination));

        //}
        //A function for retrieving a Treated by id
        [Route("GetTreated/{Id}")]
        public Treated GetTreated(int id)
        {
            return TreatedBL.GetTreatedById(id);
        }

        // Function to delete a Treated
        [Route("GetDelete/{Id}")]
        public int GetDelete(int id)
        {
            return TreatedBL.GetDeleteTreated(id);
        }

        //A function to retrieve all Treateds
        [Route("GetAllTreateds")]
        public List<Treated> GetAllTreateds()
        {
            
            List<Treated> Treateds = TreatedBL.GetTreateds();
            return Treateds;
        }

        //How many vaccinations does the client have?
        [Route("GetVaccinationsOfTreated/{idVaccination}")]
        public List<Treated> GetVaccinationsOfTreated(int idVaccination)
        {
            return BL.TreatedBL.GetVaccinationsOfTreated(idVaccination);
        }

        //
        public static string CheckVaccinations(int Id, List<string> vaccinations)
        {
            return TreatedBL.CheckVaccinations(Id, vaccinations);
        }

    }
}
