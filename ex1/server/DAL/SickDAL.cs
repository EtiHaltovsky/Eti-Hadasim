using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SickDAL
    {
        public static int Add(DAL.Sick sick)
        {
            using (PharmEntities db = new PharmEntities())
            {
                Sick sick1 = db.Sicks.Where(t => t.Id == sick.Id).FirstOrDefault();
                if (sick1 == null)
                {
                    db.Sicks.Add(sick);
                    //sick1.Id = sick.Id;
                    db.SaveChanges();

                    return db.Sicks.Count();
                }
                return -1;
            }



        }

        public static bool UpdateSick(DAL.Sick sicks)
        {
            using (PharmEntities db = new PharmEntities())
            {

                DAL.Sick sick = db.Sicks.Where(a => a.Id == sicks.Id).FirstOrDefault();
                if (sick.Id == null)
                    return false;
                sick.RecivingPositive = sicks.RecivingPositive;
                sick.TimeOfRecovery = sicks.TimeOfRecovery;


                db.SaveChanges();
                return true;

            }

        }

        public static List<DAL.Sick> GetAllSicks()
        {
            List<DAL.Sick> sick = new List<DAL.Sick>();
            using (PharmEntities DB = new PharmEntities())
            {
                foreach (DAL.Sick a in DB.Sicks)

                    sick.Add(a);

            }
            return sick;
        }

        public static int DeleteSick(int id)
        {
            using (PharmEntities DB = new PharmEntities())
            {

                DAL.Sick sick = DB.Sicks.FirstOrDefault(u => u.Id == id);

                if (sick != null)
                {

                    DB.Sicks.Remove(sick);
                    DB.SaveChanges();

                    return 0;
                }

                return 1;
            }
        }

        public static DAL.Sick GetSickId(int id)
        {
            using (PharmEntities DB = new PharmEntities())
            {
                foreach (DAL.Sick p in DB.Sicks)
                    if (p.Id.Equals(id))
                    {
                        return p;
                    }
            }
            return null;
        }
    }


}
