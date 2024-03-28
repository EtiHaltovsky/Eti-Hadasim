//using DAL;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BL
//{
//    public class StreetBL
//    {

//        public static int AddNewStreet(DTO.Street street)
//        {
//            DAL.Street sDAL = DTO.Street.ConvertStreetToDAL(street);
//            return StreetDAL.Add(sDAL);

//        }

//        //עדכון 
//        public static bool UpdateStreet(DTO.Street street)
//        {
//            DAL.Street changeDAL = DTO.Street.ConvertStreetToDAL(street);
//            return StreetDAL.Update(changeDAL);

//            //send to dal and return index;

//        }

//        public static DTO.Street GetStreetById(int id)
//        {
//            DAL.Street street = StreetDAL.GetStreetId(id);
//            if (street != null)
//                return DTO.Street.ConvertStreetToDTO(street);
//            return null;
//        }

//        public static int GetDeleteStreet(int id)
//        {

//            return StreetDAL.DeleteStreet(id);
//        }

//        public static List<DTO.Street> GetStreets()
//        {
//            List<DAL.Street> allStreetsDal = StreetDAL.GetAllStreets();
//            List<DTO.Street> allStreets = new List<DTO.Street>();
//            foreach (DAL.Street s in allStreetsDal)
//            {

//                allStreets.Add(DTO.Street.ConvertStreetToDTO(s));
//            }
//            return allStreets;


//        }

        
//    }
//}
