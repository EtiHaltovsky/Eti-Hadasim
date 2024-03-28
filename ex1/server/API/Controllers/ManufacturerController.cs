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
    [RoutePrefix("api/manufacturer")]
    public class ManufacturerController : ApiController
    {
        [Route("GetAddNewManufacturer/{Id}/{NameOfManufacturer}")]
        public string GetAddNewManufacturer(int id, string NameOfManufacturer)

        {
            return "new Manufacturer " + ManufacturerBL.AddNewManufacturer(new Manufacturer(id, NameOfManufacturer));
        }


        //עדכון 
        [Route("GetUpdateManufacturer/{Id}/{NameOfManufacturer}")]
        public string GetUpdateManufacturer(int id, string NameOfManufacturer)
        {
            return "change Manufacturer " + ManufacturerBL.UpdateManufacturer(new Manufacturer(id, NameOfManufacturer));

        }

        //עובד
        //לשליפת תלמידה לפי תעודת זהות
        [Route("GetManufacturer/{Id}")]
        public Manufacturer GetManufacturer(int id)
        {
            return ManufacturerBL.GetManufacturerById(id);
        }

        //עובד
        [Route("GetDelete/{Id}")]
        public int GetDelete(int id)
        {
            return ManufacturerBL.GetDeleteManufacturer(id);
        }


        [Route("GetAllManufacturers")]
        public List<Manufacturer> GetAllManufacturers()
        {
            //העברה לגורם המטפל
            List<Manufacturer> Manufacturers = ManufacturerBL.GetManufacturers();
            //החזרת התשובה למשתשמש
            return Manufacturers;
        }
    }
}
