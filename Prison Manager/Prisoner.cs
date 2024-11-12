using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prison_Manager
{
    public abstract class Prisoner : IComparable<Prisoner>, IHierarchy
    {
        private string fullname;
        public string Fullname
        {
            get { return fullname; }
            set { fullname = value; }
        }
        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        private string sex;
        public virtual string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        private string article;
        public string Article
        { 
            get { return article; }
            set { article = value; }
        }
        private int imprisonment;
        public int Imprisonment
        {
            get { return imprisonment; }
            set { imprisonment = value; }
        }
        private DateTime dateofArrest;
        public DateTime DateofArrest
        {
            get { return dateofArrest; }
            set { dateofArrest = value; }
        }
        private double chamber;
        public double Chamber
        {
            get { return chamber; }
            set { chamber = value; }
        }
        private string character;
        public string Character
        {
            get { return character; }
            set { character = value; }
        }
        private bool family;
        public bool Family
        {
            get { return family; }
            set { family = value; }
        }

        public Prisoner() : this( "Unknown", 0, "Not specified", "Not specified", 0, DateTime.Now, 0.0, "Unknown", false, 0, "None", 0, false) 
        { 
        }

        public Prisoner(string fullname, int age, string sex, string article, int imprisonment,
            DateTime dateofArrest, double chamber, string character,
            bool family, int olderage, string placeinthehierarchy, int calculateremainingsentence, bool iseligibleforlaterelease)
        {
            Fullname = fullname;
            Age = age;
            Sex = sex;
            Article = article;
            Imprisonment = imprisonment;
            DateofArrest = dateofArrest;
            Chamber = chamber;
            Character = character;
            Family = family;

        }
        public abstract int Olderage { get; }
        public abstract int CalculateRemainingSentence { get; }
        public abstract bool IsEligibleForEarlyRelease { get; }

        public int CompareTo(Prisoner other)
        {
            if (other == null) return 1;
            return Age.CompareTo(other.Age);
        }


        public abstract string PlaceInHierarchy { get; }

    }
}
