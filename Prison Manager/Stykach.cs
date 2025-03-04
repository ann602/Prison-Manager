﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Manager
{
    public class Stykach : Prisoner
    {
        public Stykach() : base()
        {
        }

        public Stykach(string fullname, int age, string sex, string article, int imprisonment,
            DateTime dateofArrest, double chamber, string character,
            bool family, int olderage, string placeinthehierarchy, int calculateremainingsentence, bool iseligibleforlaterelease) : base(fullname, age, sex, article, imprisonment,
            dateofArrest, chamber, character,
            family, olderage, placeinthehierarchy, calculateremainingsentence, iseligibleforlaterelease)
        {
        }

        public override int Olderage
        {
            get { return Age + Imprisonment; }
        }

        public override string PlaceInHierarchy
        {
           get { return "Stykach"; }
        }

        public override int CalculateRemainingSentence
        {
            get
            {
                DateTime releaseDate = DateofArrest.AddYears(Imprisonment);
                return (releaseDate - DateTime.Now).Days / 365;
            }
        }

        public override bool IsEligibleForEarlyRelease
        {
            get
            {
                return Family && CalculateRemainingSentence <= 3;
            }
        }
    }
}
