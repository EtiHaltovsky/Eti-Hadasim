//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DAL;
//using DTO;

//namespace DTO
//{
//    public class Address
//    {
//        public Address()
//        {
//        }

//        public Address(int id, string city, string street,int Number)
//        {
//            Id = id;
//            City = city;
//            Street = street;
//            Number = Number;
//        }

//        public int Id { get; set; }
//        public string City { get; set; }
//        public string Street { get; set; }
//        public int Number { get;  set; }

//        public static DAL.Address ConvertAddressToDAL(DTO.Address addresses)
//        {
//            return new DAL.Address()
//            {

//                Id = addresses.Id,
//                City = addresses.City,
//                Street = addresses.Street,
//               Number = addresses.Number
//            };
//        }

//        public static DTO.Address ConvertAddressToDTO(DAL.Address addresses)
//        {
//            return new DTO.Address()
//            {

//                Id = addresses.Id,
//                City = addresses.City,
//                Street = addresses.Street,
//                Number = (int)addresses.Number
//            };
//        }


      
//    }
//}
