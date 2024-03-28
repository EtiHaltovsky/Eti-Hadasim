using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class SickBL
    {

        public static int AddNewSick(DTO.Sick sick)
        {
            DAL.Sick sDAL = DTO.Sick.ConvertSickToDAL(sick);
            return SickDAL.Add(sDAL);

        }

        public static bool UpdateSick(DTO.Sick sick)
        {
            DAL.Sick changeDAL = DTO.Sick.ConvertSickToDAL(sick);
            return SickDAL.UpdateSick(changeDAL);

            //send to dal and return index;

        }

        public static DTO.Sick GetSickById(int id)
        {
            DAL.Sick sick = SickDAL.GetSickId(id);
            if (sick != null)
                return DTO.Sick.ConvertSickToDTO(sick);
            return null;
        }

  
        public static int GetDeleteSick(int id)
        {

            return SickDAL.DeleteSick(id);
        }

        public static List<DTO.Sick> GetSicks()
        {
            List<DAL.Sick> allSicksDal = SickDAL.GetAllSicks();
            List<DTO.Sick> allSicks = new List<DTO.Sick>();
            foreach (DAL.Sick s in allSicksDal)
            {

                allSicks.Add(DTO.Sick.ConvertSickToDTO(s));
            }
            return allSicks;


        }
        

    }
}
