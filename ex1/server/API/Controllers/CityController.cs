//using BL;
//using DTO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web.Http.Cors;
//using System.Net;
//using System.Net.Http;
//using System.Web.Http;


//namespace API.Controllers
//{ 
//        [EnableCors("*", "*", "*")]
//        [RoutePrefix("api/city")]

//    public class CityController : ApiController
//    {
        
//        [Route("GetAddNewCity/{id}/{NameOfCity}")]
//        public int GetAddNewCity(int id, string NameOfCity)

//        {
//            return  CityBL.AddNewCity(new City(id, NameOfCity));
//        }

//        //מה קרה לטלפון?
//        //עדכון 
//        [Route("GetUpdateCity/{Id}/{NameOfCity}")]
//        public string GetUpdateCity(int id, string NameOfCity)
//        {
//            return "change City " + CityBL.UpdateCity(new City(id, NameOfCity));

//        }


//        [Route("GetCity/{Id}")]
//        public City GetCity(int id)
//        {
//            return CityBL.GetCityById(id);
//        }

    
//        [Route("GetDelete/{Id}")]
//        public int GetDelete(int id)
//        {
//            return CityBL.GetDeleteCity(id);
//        }


//        [Route("GetAllCities")]
//        public List<City> GetAllCities()
//        {
//            //העברה לגורם המטפל
//            List<City> Cities = CityBL.GetCities();
//            //החזרת התשובה למשתשמש
//            return Cities;
//        }
//    }
//}
