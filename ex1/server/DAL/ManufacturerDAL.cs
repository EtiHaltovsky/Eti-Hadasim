using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ManufacturerDAL
    {

        public static int Add(DAL.Manufacturer manufacturer)
        {
            using (PharmEntities db = new PharmEntities())
            {
                Manufacturer manufacturer1 = db.Manufacturers.Where(t => t.Id == manufacturer.Id).FirstOrDefault();
                if (manufacturer1 == null)
                {
                    db.Manufacturers.Add(manufacturer);
                    manufacturer.Id = manufacturer.Id;
                    db.Manufacturers.Add(manufacturer);
                    db.SaveChanges();

                    return db.Manufacturers.Count();
                }
                return -1;
            }

        }

        public static bool UpdateManufacturer(DAL.Manufacturer manufacturers)
        {
            using (PharmEntities db = new PharmEntities())
            {

                DAL.Manufacturer manufacturer = db.Manufacturers.Where(a => a.Id == manufacturers.Id).FirstOrDefault();
                if (manufacturer.Id == null)
                    return false;
                manufacturer.NameOfManufacturer = manufacturers.NameOfManufacturer;
               


                db.SaveChanges();
                return true;

            }

        }

        public static List<DAL.Manufacturer> GetAllManufacturers()
        {
            List<DAL.Manufacturer> manufacturer = new List<DAL.Manufacturer>();
            using (PharmEntities DB = new PharmEntities())
            {
                foreach (DAL.Manufacturer a in DB.Manufacturers)

                    manufacturer.Add(a);

            }
            return manufacturer;
        }

        public static int DeleteManufacturer(int id)
        {
            using (PharmEntities DB = new PharmEntities())
            {

                DAL.Manufacturer manufacturer = DB.Manufacturers.FirstOrDefault(u => u.Id == id);

                if (manufacturer != null)
                {

                    DB.Manufacturers.Remove(manufacturer);
                    DB.SaveChanges();

                    return 0;
                }

                return 1;
            }
        }

        public static DAL.Manufacturer GetManufacturerId(int id)
        {
            using (PharmEntities DB = new PharmEntities())
            {
                foreach (DAL.Manufacturer p in DB.Manufacturers)
                    if (p.Id.Equals(id))
                    {
                        return p;
                    }
            }
            return null;
        }

    }
}
