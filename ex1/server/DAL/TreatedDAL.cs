using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{

    public class TreatedDAL
    {

        public static int Add(DAL.Treated treated)
        {
            using (PharmEntities db = new PharmEntities())
            {
                Treated treated1 = db.Treateds.Where(t => t.Id == treated.Id).FirstOrDefault();
                if (treated1 == null)
                {
                    db.Treateds.Add(treated);
                    treated.Id = treated.Id;
                    db.Treateds.Add(treated);
                    db.SaveChanges();

                    return db.Treateds.Count();
                }
                return -1;
            }

        }
        //עדכון
        public static bool Update(DAL.Treated treateds)
        {
            using (PharmEntities db = new PharmEntities())
            {

                DAL.Treated treated = db.Treateds.Where(a => a.Id == treateds.Id).FirstOrDefault();
                if (treated.Id == null)
                    return false;
                treated.Name = treateds.Name;
                treated.City = treateds.City;
                treated.Street = treateds.Street;
                treated.Number = treateds.Number;
                treated.DateOfBirth = treateds.DateOfBirth;
                treated.Phone = treateds.Phone;
                treated.PhoneNumber = treateds.PhoneNumber;
              

                db.SaveChanges();
                return true;

            }

        }

        //שליפה-הצגה
        public static List<DAL.Treated> GetAllTreateds()
        {
            List<DAL.Treated> treated = new List<DAL.Treated>();
            using (PharmEntities DB = new PharmEntities())
            {
                foreach (DAL.Treated a in DB.Treateds)

                    treated.Add(a);

            }
            return treated;
        }

        public static int DeleteTreated(int id)
        {
            using (PharmEntities DB = new PharmEntities())
            {
                Treated a1 = DB.Treateds.FirstOrDefault(c1 => c1.Id == id);
                if (a1 != null)
                {
                    Sick t = DB.Sicks.FirstOrDefault(x => x.Id == id);
                    if (t != null)
                        return 2;


                    DB.Treateds.Remove(a1);
                    DB.SaveChanges();
                    //DB.People.Remove(DB.People.Where(c1 => c1.PersonId == id).FirstOrDefault());

                    Treated c = DB.Treateds.Where(c1 => c1.Id == id).FirstOrDefault();

                    if (c == null)
                        return 1;
                }
                return 0;
            }
        }

        //public static int DeleteActivity(int name)
        //{
        //    using (SchoolDBEntities DB = new SchoolDBEntities())
        //    {
        //        Activity a1 = DB.Activities.FirstOrDefault(c1 => c1.ActivityId == name);
        //        if (a1 != null)
        //        {
        //            TeachersToActivity t = DB.TeachersToActivities.FirstOrDefault(a => a.ActivitiesId == a1.ActivityId);
        //            if (t != null)
        //                return 2;
        //            StudentToActivity s = DB.StudentToActivities.FirstOrDefault(a => a.ActivitiesId == a1.ActivityId);
        //            if (s != null)
        //                return 3;
        //            DB.Activities.Remove(a1);
        //            DB.SaveChanges();
        //            //DB.People.Remove(DB.People.Where(c1 => c1.PersonId == id).FirstOrDefault());

        //            Activity c = DB.Activities.Where(c1 => c1.ActivityId == name).FirstOrDefault();

        //            if (c == null)
        //                return 1;
        //        }
        //        return 0;
        //    }
        //}
        public static DAL.Treated GetTreatedId(int id)
        {
            using (PharmEntities DB = new PharmEntities())
            {
                foreach (DAL.Treated p in DB.Treateds)
                    if (p.Id.Equals(id))
                    {
                        return p;
                    }
            }
            return null;
        }

        //שליפה של התלמידות שנרשמו לפעילות מסוימת-מחנה טיול או שבת מחנה
        public static List<Treated> GetVaccinationsOfTreated(int idVaccination)
        {
            using (PharmEntities db = new PharmEntities())
            {
                return db.Treateds.Where(s => s.TreatedToVaccinations.Any(a => a.IdVaccination == idVaccination)).ToList();
            }
        }

        public static string CheckVaccinations(int Id, List<string> vaccinations)
        {
            int maxVaccinations = 4; // מספר החיסונים המרבי
            if (vaccinations.Count > maxVaccinations)
            {
                return $"ללקוח {Id} נמצא כבר מספר חיסונים מקסימלי ({maxVaccinations})";
            }

            return $"מספר החיסונים של ללקוח {Id} נבדק והוא בתוקף";
        }
    }



}



