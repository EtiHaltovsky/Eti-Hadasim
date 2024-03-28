//using DAL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BL
//{
//    public class CityBL
//    {
//        //הוספה
//        public static int AddNewCity(DTO.City city)
//        {
//            DAL.City sDAL = DTO.City.ConvertCityToDAL(city);
//            return DAL.CityDAL.Add(sDAL);

//        }
//        public static bool UpdateCity(DTO.City city)
//        {
//            DAL.City cDAL = DTO.City.ConvertCityToDAL(city);
//            return CityDAL.UpdateCity(cDAL);

//            //send to dal and return index;

//        }
     

//        public static DTO.City GetCityById(int id)
//        {
//            DAL.City city = CityDAL.GetCityId(id);
//            if (city != null)
//                return DTO.City.ConvertCityToDTO(city);
//            return null;
//        }

//        public static int GetDeleteCity(int id)
//        {

//            return CityDAL.DeleteCity(id);
//        }

//        public static List<DTO.City> GetCities()
//        {
//            List<DAL.City> allCitiesDal = CityDAL.GetAllCities();
//            List<DTO.City> allCities = new List<DTO.City>();
//            foreach (DAL.City s in allCitiesDal)
//            {

//                allCities.Add(DTO.City.ConvertCityToDTO(s));
//            }
//            return allCities;


//        }
        
//    }
//}
