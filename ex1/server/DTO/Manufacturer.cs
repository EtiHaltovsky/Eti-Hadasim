using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Manufacturer
    {

        public Manufacturer()
        {
        }
        public Manufacturer(int id, string NameOfManufacturer)
        {
            Id = id;
            NameOfManufacturer = NameOfManufacturer;
        }

        public int Id { get; set; }
        public string NameOfManufacturer { get; set; }

        public static DAL.Manufacturer ConvertManufacturerToDAL(DTO.Manufacturer Manufacturers)
        {
            return new DAL.Manufacturer()
            {

                Id = Manufacturers.Id,
                NameOfManufacturer = Manufacturers.NameOfManufacturer


            };
        }

        public static DTO.Manufacturer ConvertManufacturerToDTO(DAL.Manufacturer Manufacturers)
        {
            return new DTO.Manufacturer()
            {

                Id = Manufacturers.Id,
                NameOfManufacturer = Manufacturers.NameOfManufacturer

            };
        }
    }
}
