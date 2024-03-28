//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
////using System.Data.Sql;
//namespace DAL
//{
//    public class CityDAL
//    {
//        public string NameOfCity { get;  set; }
//        public int Id { get; set; }
     
//        public static int Add(DAL.City city)
//        {
//            using (PharmEntities db = new PharmEntities())
//            {
//                City city1 = db.Cities.Where(t => t.Id == city.Id).FirstOrDefault();
//                if (city1 == null)
//                {
//                    db.Cities.Add(city);
//                    city1.Id = city.Id;
//                    db.Cities.Add(city);
//                    db.SaveChanges();

//                    return db.Cities.Count();
//                }
//                return -1;
//            }

//        }
     
//        public static bool UpdateCity(DAL.City cities)
//        {
//            using (PharmEntities db = new PharmEntities())
//            {

//                DAL.City city = db.Cities.Where(a => a.Id == cities.Id).FirstOrDefault();
//                if (city.Id == null)
//                    return false;
//                city.NameOfCity = cities.NameOfCity;

//                db.SaveChanges();
//                return true;

//            }

//        }
      
//        public static List<DAL.City> GetAllCities()
//        {
//            List<DAL.City> city = new List<DAL.City>();
//            using (PharmEntities DB = new PharmEntities())
//            {
//                foreach (DAL.City a in DB.Cities)

//                    city.Add(a);

//            }
//            return city;
//        }
       

//        public static int DeleteCity(int id)
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

//        public static DAL.City GetCityId(int id)
//        {
//            using (PharmEntities DB = new PharmEntities())
//            {
//                foreach (DAL.City p in DB.Cities)
//                    if (p.Id.Equals(id))
//                    {
//                        return p;
//                    }
//            }
//            return null;
//        }

        
//    }
//}
