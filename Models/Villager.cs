using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GeekseatWitch.Models
{
    public class Villager
    {
        private int ageofDeath;
        public int AgeofDeath
        {
            get { return ageofDeath; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Only positive values are allowed");
                ageofDeath = value;
            }
        }

        private int yearofDeath;
        public int YearofDeath
        {
            get { return yearofDeath; }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Only positive values are allowed");
                yearofDeath = value;
            }
        }
        public int YearofBirth {
            get
            {
                if (AgeofDeath >= YearofDeath)
                {
                    throw new ArgumentException("Year of Death must be greater than the age");
                }
                return YearofDeath - AgeofDeath;
            }
        }
    };

    public class VillagerModel
    {
        public int AgeofDeath { get; set; }
        public int YearofDeath { get; set; }
    }
}
