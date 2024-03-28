using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;

namespace BL
{
    public class VaccinationBL
    {

        public static int AddNewVaccination(DTO.Vaccination vaccination)
        {
            DAL.Vaccination sDAL = DTO.Vaccination.ConvertVaccinationToDAL(vaccination);
            return VaccinationDAL.Add(sDAL);

        }

        //עדכון 
        public static bool UpdateVaccination(DTO.Vaccination vaccination)
        {
            DAL.Vaccination changeDAL = DTO.Vaccination.ConvertVaccinationToDAL(vaccination);
            return VaccinationDAL.UpdateVaccination(changeDAL);

            //send to dal and return index;

        }


        public static List<DTO.Vaccination> GetVaccinations()
        {
            List<DAL.Vaccination> allVaccinationsDal = VaccinationDAL.GetAllVaccinations();
            List<DTO.Vaccination> allActivities = new List<DTO.Vaccination>();
            foreach (DAL.Vaccination s in allVaccinationsDal)
            {

                allActivities.Add(DTO.Vaccination.ConvertVaccinationsToDTO(s));
            }
            return allActivities;


        }


        public static DTO.Vaccination GetVaccinationById(int id)
        {
            DAL.Vaccination vaccination = VaccinationDAL.GetVaccinationId(id);
            if (vaccination != null)
                return DTO.Vaccination.ConvertVaccinationsToDTO(vaccination);
            return null;
        }
        
         public static int GetDeleteVaccination(int id)
         {

            return VaccinationDAL.DeleteVaccination(id);
         }

    }
}
