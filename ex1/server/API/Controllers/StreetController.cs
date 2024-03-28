//using BL;
//using DTO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//using System.Net;
//using System.Net.Http;
//using System.Web.Http;
//using System.Web.Http.Cors;

//namespace API.Controllers
//{
//    [EnableCors("*", "*", "*")]
//    [RoutePrefix("api/street")]
//    public class StreetController : ApiController
//    {

//        [Route("GetAddNewStreet/{Id}/{NameOfStreet}")]
//        public string GetAddNewStreet(int id, string NameOfStreet)

//        {
//            return "new Street " + StreetBL.AddNewStreet(new Street(id, NameOfStreet));
//        }


//        //עדכון 
//        [Route("GetUpdateStreet/{Id}/{NameOfStreet}")]
//        public string GetUpdateStreet(int id, string NameOfStreet)
//        {
//            return "change Street " + StreetBL.UpdateStreet(new Street(id, NameOfStreet));

//        }

//        //עובד
//        //לשליפת תלמידה לפי תעודת זהות
//        [Route("GetStreet/{Id}")]
//        public Street GetStreet(int id)
//        {
//            return StreetBL.GetStreetById(id);
//        }

//        //עובד
//        //מחיקת תלמידה
//        [Route("GetDelete/{Id}")]
//        public int GetDelete(int id)
//        {
//            return StreetBL.GetDeleteStreet(id);
//        }

//        [Route("GetAllStreets")]
//        public List<Street> GetAllStreets()
//        {
//            List<Street> Streets = StreetBL.GetStreets();
//            return Streets;
//        }
//    }
//}
