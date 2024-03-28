//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DTO
//{
//    public class City
//    {
//        public City()
//        {
//        }
//        public City(int id, string NameOfCity)
//        {
//            Id = id;
//            NameOfCity = NameOfCity;
//        }

//        public int Id { get; set; }
//        public string NameOfCity { get; set; }
      
//        public static DAL.City ConvertCityToDAL(DTO.City cities)
//        {
//            return new DAL.City()
//            {

//                Id = cities.Id,
//                NameOfCity = cities.NameOfCity
               

//            };
//        }

//        public static DTO.City ConvertCityToDTO(DAL.City cities)
//        {
//            return new DTO.City()
//            {

//                Id = cities.Id,
//                NameOfCity = cities.NameOfCity
               
//            };
//        }
//    }
//}
