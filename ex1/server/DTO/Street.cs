//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DTO
//{
//    public class Street
//    {
//        public Street()
//        {
//        }
//        public Street(int id, string NameOfCity)
//        {
//            Id = id;
//            NameOfCity = NameOfCity;
//        }

//        public int Id { get; set; }
//        public string NameOfStreet { get; set; }

//        public static DAL.Street ConvertStreetToDAL(DTO.Street Streets)
//        {
//            return new DAL.Street()
//            {

//                Id = Streets.Id,
//                NameOfStreet = Streets.NameOfStreet


//            };
//        }

//        public static DTO.Street ConvertStreetToDTO(DAL.Street Streets)
//        {
//            return new DTO.Street()
//            {

//                Id = Streets.Id,
//                NameOfStreet = Streets.NameOfStreet

//            };
//        }
//    }
//}
