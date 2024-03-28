using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Sick
    {
        public Sick()
        {
        }

        public Sick(int Id, DateTime RecivingPositive, DateTime TimeOfRecovery)
        {
            id = Id;
            recivingPositive = RecivingPositive;
            timeOfRecovery = TimeOfRecovery;
        }

        public static int Id { get; set; }
        public static DateTime? RecivingPositive { get; set; }
        public static DateTime? TimeOfRecovery { get; set; }
        public int id { get; set; }
        public DateTime? recivingPositive { get; set; }
        public DateTime? timeOfRecovery { get; set; }

        public static DAL.Sick ConvertSickToDAL(DTO.Sick sick)
        {
            return new DAL.Sick()
            {

                Id = sick.id,
                RecivingPositive = sick.recivingPositive,
                TimeOfRecovery=sick.timeOfRecovery


            };
        }

        public static DTO.Sick ConvertSickToDTO(DAL.Sick sick)
        {
            return new DTO.Sick()
            {

                id = (int)sick.Id,
                recivingPositive = sick.RecivingPositive,
                timeOfRecovery=sick.TimeOfRecovery

            };
        }

    }
}
