using System;
using System.Collections.Generic;

#nullable disable

namespace UshtrimeProvim2.Entities
{
    public partial class Person
    {
        public Person()
        {
            Applications = new HashSet<Application>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PersonalId { get; set; }
        public DateTime Birthday { get; set; }
        public string AccountNumber { get; set; }

        public virtual ICollection<Application> Applications { get; set; }
    }
}
