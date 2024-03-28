//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace DAL
//{
//    public class StreetDAL
//    {
//        public static int Add(DAL.Street street)
//        {
//            using (PharmEntities db = new PharmEntities())
//            {
//                Street street1 = db.Streets.Where(t => t.Id == street.Id).FirstOrDefault();
//                if (street1 == null)
//                {
//                    db.Streets.Add(street);
//                    street.Id = street.Id;
//                    db.Streets.Add(street);
//                    db.SaveChanges();

//                    return db.Streets.Count();
//                }
//                return -1;
//            }

//        }

//        public static bool Update(DAL.Street streets)
//        {
//            using (PharmEntities db = new PharmEntities())
//            {

//                DAL.Street street = db.Streets.Where(a => a.Id == streets.Id).FirstOrDefault();
//                if (street.Id == null)
//                    return false;
//                street.NameOfStreet = streets.NameOfStreet;   

//                db.SaveChanges();
//                return true;

//            }

//        }

//        public static List<DAL.Street> GetAllStreets()
//        {
//            List<DAL.Street> streets = new List<DAL.Street>();
//            using (PharmEntities DB = new PharmEntities())
//            {
//                foreach (DAL.Street a in DB.Streets)

//                    streets.Add(a);

//            }
//            return streets;
//        }

//        public static int DeleteStreet(int id)
//        {
//            using (PharmEntities DB = new PharmEntities())
//            {
               
//                DAL.Street street = DB.Streets.FirstOrDefault(u => u.Id == id);

//                if (street != null)
//                {
       
//                    DB.Streets.Remove(street);
//                    DB.SaveChanges();

//                    return 0; 
//                }

//                return 1; 
//            }
//        }

//        public static DAL.Street GetStreetId(int id)
//        {
//            using (PharmEntities DB = new PharmEntities())
//            {
//                foreach (DAL.Street p in DB.Streets)
//                    if (p.Id.Equals(id))
//                    {
//                        return p;
//                    }
//            }
//            return null;
//        }

        
//    }
//}
