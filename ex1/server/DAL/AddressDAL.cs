//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL
//{
//    public class AddressDAL
//    {

//        public static int Add(DAL.Address address)
//        {
//            using (PharmEntities db = new PharmEntities())
//            {
//                Address address1 = db.Addresses.Where(t => t.Id == address.Id).FirstOrDefault();
//                if (address1 == null)
//                {
//                    db.Addresses.Add(address);
//                    //address1.Id = address.Id;
//                    db.Addresses.Add(address);
//                    db.SaveChanges();

//                    return db.Addresses.Count();
//                }
//                return -1;
//            }

//        }

//        public static bool UpdateAddress(DAL.Address addresses)
//        {
//            using (PharmEntities db = new PharmEntities())
//            {

//                DAL.Address address = db.Addresses.Where(a => a.Id == addresses.Id).FirstOrDefault();
//                if (address.Id == null)
//                    return false;
//                address.City = addresses.City;
//                address.Street = addresses.Street;
//                address.Number= addresses.Number;


//                db.SaveChanges();
//                return true;

//            }

//        }
//        public static List<DAL.Address> GetAllAddresses()
//        {
//            List<DAL.Address> address = new List<DAL.Address>();
//            using (PharmEntities DB = new PharmEntities())
//            {
//                foreach (DAL.Address a in DB.Addresses)

//                    address.Add(a);

//            }
//            return address;
//        }
    
//        public static int DeleteAddress(int id)
//        {
//            using (PharmEntities DB = new PharmEntities())
//            {

//                DAL.Address address = DB.Addresses.FirstOrDefault(u => u.Id == id);

//                if (address != null)
//                {

//                    DB.Addresses.Remove(address);
//                    DB.SaveChanges();

//                    return 0;
//                }

//                return 1;
//            }
//        }

//        public static DAL.Address GetAddressId(int id)
//        {
//            using (PharmEntities DB = new PharmEntities())
//            {
//                foreach (DAL.Address p in DB.Addresses)
//                    if (p.Id.Equals(id))
//                    {
//                        return p;
//                    }
//            }
//            return null;
//        }
//    }
//}
