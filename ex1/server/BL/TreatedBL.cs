
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL
{
    public class TreatedBL
    {
        //עובד
       //הוספה
        public static int AddNewTreated(DTO.Treated treated)
        {
            DAL.Treated sDAL = DTO.Treated.ConvertTreatedToDAL(treated);
            return TreatedDAL.Add(sDAL);

        }

        //עדכון 
        public static bool UpdateTreated(DTO.Treated treated)
        {
            DAL.Treated changeDAL = DTO.Treated.ConvertTreatedToDAL(treated);
            return TreatedDAL.Update(changeDAL);

            //send to dal and return index;

        }

        public static List<DTO.Treated> GetTreateds()
        {
            List<DAL.Treated> allTreatedsDal = TreatedDAL.GetAllTreateds();
            List<DTO.Treated> allTreateds = new List<DTO.Treated>();
            foreach (DAL.Treated s in allTreatedsDal)
            {

                allTreateds.Add(DTO.Treated.ConvertTreatedToDTO(s));
            }
            return allTreateds;


        }


        public static DTO.Treated GetTreatedById(int id)
        {
            DAL.Treated treated = TreatedDAL.GetTreatedId(id);
            if (treated != null)
                return DTO.Treated.ConvertTreatedToDTO(treated);
            return null;
        }

       

        public static int GetDeleteTreated(int id)
        {

            return TreatedDAL.DeleteTreated(id);
        }


        //שליפה של התלמידות שנרשמו לפעילות מסוימת-מחנה טיול או שבת מחנה
        public static List<DTO.Treated> GetVaccinationsOfTreated(int idVaccination)
        {
            List<DAL.Treated> treateds = TreatedDAL.GetVaccinationsOfTreated(idVaccination);

            List<DTO.Treated> s = new List<DTO.Treated>();
            for (int i = 0; i < treateds.Count(); i++)
            {
                //DAL.Person person = TreatedDAL.GetUserPersonId(student[i].Id);
                s.Add(DTO.Treated.ConvertTreatedToDTO(treateds[i]));
            }
            return s;

        }
        public static string CheckVaccinations(int Id, List<string> vaccinations)
        {
            return TreatedDAL.CheckVaccinations(Id, vaccinations);
        }

    }
}
