using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkMarriedName
{
    public class Person
    {
        public static bool IsSameSexAllowed = false;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Sex Sex { get; set; }
        public bool IsMarried { get; set; }

        public void Marry(Person spouse, LastNameChangeType changeType)
        {
            if (this.IsMarried)
                throw new Exception("I'm already married");
            if (spouse.IsMarried)
                throw new Exception("Spouse is already married");

            if ((!IsSameSexAllowed) && (this.Sex == spouse.Sex))
                throw new Exception("Same sex marriage is not allowed");

            this.IsMarried = true;
            spouse.IsMarried = true;

            switch (Sex)
            {
                case Sex.Male:
                    switch (spouse.Sex)
                    {
                        case Sex.Male:
                            switch (changeType)
                            {
                                case LastNameChangeType.Keep:
                                    return;
                                case LastNameChangeType.Append:
                                    this.LastName = string.Format("{0}-{1}", this.LastName, spouse.LastName);
                                    return;
                                case LastNameChangeType.Change:
                                    this.LastName = spouse.LastName;
                                    return;
                            }
                            break;
                        case Sex.Female:
                            switch (changeType)
                            {
                                case LastNameChangeType.Keep:
                                    return;
                                case LastNameChangeType.Append:
                                    this.LastName = string.Format("{0}-{1}", this.LastName, FemaleToMale(spouse.LastName));
                                    return;
                                case LastNameChangeType.Change:
                                    this.LastName = FemaleToMale(spouse.LastName);
                                    return;
                            }
                            break;
                    }
                    break;
                case Sex.Female:
                    switch (spouse.Sex)
                    {
                        case Sex.Male:
                            switch (changeType)
                            {
                                case LastNameChangeType.Keep:
                                    return;
                                case LastNameChangeType.Append:
                                    this.LastName = string.Format("{0}-{1}", this.LastName, MaleToFemale(spouse.LastName));
                                    return;
                                case LastNameChangeType.Change:
                                    this.LastName = MaleToFemale(spouse.LastName);
                                    return;
                            }
                            break;
                        case Sex.Female:
                            switch (changeType)
                            {
                                case LastNameChangeType.Keep:
                                    return;
                                case LastNameChangeType.Append:
                                    this.LastName = string.Format("{0}-{1}", this.LastName, spouse.LastName);
                                    return;
                                case LastNameChangeType.Change:
                                    this.LastName = spouse.LastName;
                                    return;
                            }
                            break;
                    }
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string FemaleToMale(string femaleLastName)
        {
            if (femaleLastName.EndsWith("va"))
                return femaleLastName.Substring(0, femaleLastName.Length - 1);

            if (femaleLastName.EndsWith("ska"))
                return femaleLastName.Substring(0, femaleLastName.Length - 1)+"i";

            return femaleLastName;
        }

        public static string MaleToFemale(string maleLastName)
        {
            if (maleLastName.EndsWith("v"))
                return maleLastName+"a";

            if (maleLastName.EndsWith("ski"))
                return maleLastName.Substring(0, maleLastName.Length - 1) + "a";

            return maleLastName;
        }
    }
}
