using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL
{
    public class VaccinationDAL
    {

        public static int Add(DAL.Vaccination vaccination)
        {
            using (PharmEntities db = new PharmEntities())
            {
                Vaccination vaccination1 = db.Vaccinations.Where(t => t.Id == vaccination.Id).FirstOrDefault();
                if (vaccination1 == null)
                {
                    db.Vaccinations.Add(vaccination);
                    vaccination.Id = vaccination.Id;
                    db.Vaccinations.Add(vaccination);
                    db.SaveChanges();

                    return db.Vaccinations.Count();
                }
                return -1;
            }

        }

        public static bool UpdateVaccination(DAL.Vaccination vaccinations)
        {
            using (PharmEntities db = new PharmEntities())
            {

                DAL.Vaccination vaccination = db.Vaccinations.Where(a => a.Id == vaccinations.Id).FirstOrDefault();
                if (vaccination.Id == null)
                    return false;
                vaccination.RecivingVaccine = vaccinations.RecivingVaccine;
                vaccination.Manufacturer = vaccinations.Manufacturer;


                db.SaveChanges();
                return true;

            }

        }

        public static List<DAL.Vaccination> GetAllVaccinations()
        {
            List<DAL.Vaccination> vaccination = new List<DAL.Vaccination>();
            using (PharmEntities DB = new PharmEntities())
            {
                foreach (DAL.Vaccination a in DB.Vaccinations)

                    vaccination.Add(a);

            }
            return vaccination;
        }

        public static DAL.Vaccination GetVaccinationId(int id)
        {
            using (PharmEntities DB = new PharmEntities())
            {
                foreach (DAL.Vaccination p in DB.Vaccinations)
                    if (p.Id.Equals(id))
                    {
                        return p;
                    }
            }
            return null;
        }
        public static int DeleteVaccination(int id)
        {
            using (PharmEntities DB = new PharmEntities())
            {
               
                DAL.Treated user = DB.Treateds.FirstOrDefault(u => u.Id == id);

              
                if (user != null)
                {
                 
                    DB.Treateds.Remove(user);
                    DB.SaveChanges();

                    return 0; 
                }

              
                return 1; 
            }
        }

        

    }
}
