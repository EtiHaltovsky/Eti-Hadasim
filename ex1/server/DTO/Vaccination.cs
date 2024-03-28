using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Vaccination
    {
        public Vaccination()
        {
        }
        public Vaccination(int id, DateTime RecivingVaccine,string Manufacturer)
        {
                id = id;
                RecivingVaccine = RecivingVaccine;
                Manufacturer = Manufacturer;
        }


        public int Id { get; set; }
        public DateTime RecivingVaccine { get; set; }

        public string Manufacturer { get; set; }

        public static DAL.Vaccination ConvertVaccinationToDAL(DTO.Vaccination Vaccinations)
        {
            return new DAL.Vaccination()
            {
               
                Id = Vaccinations.Id,
                RecivingVaccine = Vaccinations.RecivingVaccine,
                Manufacturer = Vaccinations.Manufacturer

            };
        }

        public static DTO.Vaccination ConvertVaccinationsToDTO(DAL.Vaccination Vaccinations)
        {
            return new DTO.Vaccination()
            {
                Id = Vaccinations.Id,
                RecivingVaccine = (DateTime)Vaccinations.RecivingVaccine,
                Manufacturer = Vaccinations.Manufacturer
,

            };
        }
    }
}
