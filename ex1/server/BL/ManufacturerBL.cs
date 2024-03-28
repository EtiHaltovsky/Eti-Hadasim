using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ManufacturerBL
    {

        public static int AddNewManufacturer(DTO.Manufacturer manufacturer)
        {
            DAL.Manufacturer sDAL = DTO.Manufacturer.ConvertManufacturerToDAL(manufacturer);
            return ManufacturerDAL.Add(sDAL);

        }

        //עדכון 
        public static bool UpdateManufacturer(DTO.Manufacturer manufacturer)
        {
            DAL.Manufacturer changeDAL = DTO.Manufacturer.ConvertManufacturerToDAL(manufacturer);
            return ManufacturerDAL.UpdateManufacturer(changeDAL);

            //send to dal and return index;

        }

   
        public static DTO.Manufacturer GetManufacturerById(int id)
        {
            DAL.Manufacturer manufacturer = ManufacturerDAL.GetManufacturerId(id);
            if (manufacturer != null)
                return DTO.Manufacturer.ConvertManufacturerToDTO(manufacturer);
            return null;
        }

        public static int GetDeleteManufacturer(int id)
        {

            return ManufacturerDAL.DeleteManufacturer(id);
        }

        public static List<DTO.Manufacturer> GetManufacturers()
        {
            List<DAL.Manufacturer> allManufacturersDal = ManufacturerDAL.GetAllManufacturers();
            List<DTO.Manufacturer> allManufacturers = new List<DTO.Manufacturer>();
            foreach (DAL.Manufacturer s in allManufacturersDal)
            {

                allManufacturers.Add(DTO.Manufacturer.ConvertManufacturerToDTO(s));
            }
            return allManufacturers;


        }

        
    }
}
