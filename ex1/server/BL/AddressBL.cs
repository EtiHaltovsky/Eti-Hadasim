//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DAL;
//using DTO;

//namespace BL
//{
//    public class AddressBL
//    {
//        //הוספה
//        public static int AddNewAddress(DTO.Address address)
//        {
//            DAL.Address sDAL = DTO.Address.ConvertAddressToDAL(address);
//            return AddressDAL.Add(sDAL);

//        }
     
//        //עדכון 
//        public static bool UpdateAddress(DTO.Address address)
//        {
//            DAL.Address changeDAL = DTO.Address.ConvertAddressToDAL(address);
//            return AddressDAL.UpdateAddress(changeDAL);

//            //send to dal and return index;

//        }
//        public static int GetDeleteAddress(int id)
//        {

//            return AddressDAL.DeleteAddress(id);
//        }

//        public static DTO.Address GetAddressById(int id)
//        {
//            DAL.Address address = AddressDAL.GetAddressId(id);
//            if (address != null)
//                return DTO.Address.ConvertAddressToDTO(address);
//            return null;
//        }

//        public static List<DTO.Address> GetAddresses()
//        {
//            List<DAL.Address> allAddressesDal = AddressDAL.GetAllAddresses();
//            List<DTO.Address> allAddresses = new List<DTO.Address>();
//            foreach (DAL.Address s in allAddressesDal)
//            {

//                allAddresses.Add(DTO.Address.ConvertAddressToDTO(s));
//            }
//            return allAddresses;


//        }

//    }
//}
