using System;
using System.Collections.Generic;

namespace EDMEntities.BlueprintBuilder.Models
{
    public partial class User
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool NewToBC { get; set; }
        public bool Female { get; set; }
        public bool Male { get; set; }
        public bool Aboriginal { get; set; }
        public bool Disability { get; set; }
        public int? Region { get; set; }
        public int? Stage { get; set; }
        public string RegisterToken { get; set; }
        public string PasswordToken { get; set; }
        public Guid Salt { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastVisited { get; set; }
        public int FailedLoginAttempts { get; set; }
        public bool IsEmailNotification { get; set; }
        public bool IsNotificationNotLoginWithinDurationSent { get; set; }

        /// <summary>
        /// True if this is an anonymous user, false otherwise.
        /// This property does not get saved to the database and, as such, should not be included in the map file.
        /// An anonymous profile is one that is only persisted via the Session and not the database.
        /// </summary>
        public bool IsAnonymous { get; set; }

        public virtual Blueprint Blueprint { get; set; }

        /// <summary>
        /// This method updates all the boolean properties that translate to simple attributes
        /// or "characteristics" that a user might possess. Ideally, this could be stored as
        /// a list of integers rather than a series of boolean properties, but we did not have
        /// enough time.
        /// </summary>
        /// <param name="characteristics">A list of characteristics to save</param>
        public void UpdateCharacteristics(List<string> characteristics)
        {
            // First of all, set all relevant properties to false.
            // Only those present in the list are then changed.
            Female = false;
            Male = false;
            Aboriginal = false;
            Disability = false;
            NewToBC = false;

            if (characteristics != null)
            {
                // Map the characteristic from the list to the corresponding properties.
                // FUTURE: Could we use reflection for this, or maybe a list of integers instead?
                foreach (string characteristic in characteristics)
                {
                    switch (characteristic)
                    {
                        case "female":
                            Female = true;
                            break;
                        case "male":
                            Male = true;
                            break;
                        case "aboriginal":
                            Aboriginal = true;
                            break;
                        case "disability":
                            Disability = true;
                            break;
                        case "newtobc":
                            NewToBC = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }

    }
}
