using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Treated
    {
        public Treated()
        {
        }

        public Treated(string name, int id, string City,string Street,int number ,DateTime dateOfBirth, string phone, string phoneNumber)
        {
            Name = name;
            Id = id;
            City = city;
            Street = street;
            number = number;
            DateOfBirth = dateOfBirth;
            Phone = phone;
            PhoneNumber = phoneNumber;
           
            //ImageData = imageData;
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public string city { get; set; }
        public string street { get; set; }
        public int number { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string PhoneNumber { get; set; }
      

        //public byte[] ImageData { get; set; }

        public static DAL.Treated ConvertTreatedToDAL(DTO.Treated Treateds)
        {
            return new DAL.Treated()
            {
                Name = Treateds.Name,
                Id = Treateds.Id,
                City = Treateds.city,
                Street= Treateds.street,
                Number=Treateds.number,
                DateOfBirth = Treateds.DateOfBirth,
                Phone = Treateds.Phone,
                PhoneNumber = Treateds.PhoneNumber
               
,             /*  ImageData=Treateds.ImageData*/

            };
        }

        public static DTO.Treated ConvertTreatedToDTO(DAL.Treated Treateds)
        {
            return new DTO.Treated()
            {

                Name = Treateds.Name,
                Id = Treateds.Id,
                city = Treateds.City,
                street=Treateds.Street,
                number = Treateds.Number.GetValueOrDefault(),

                DateOfBirth = (DateTime)Treateds.DateOfBirth,
                Phone = Treateds.Phone,
                PhoneNumber = Treateds.PhoneNumber
                
                //ImageData = Treateds.ImageData
,

            };
        }
    }
}
