using System;
using System.Collections.Generic;

#nullable disable

namespace UshtrimeProvim2.Entities
{
    public partial class Application
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public decimal CreditAmount { get; set; }

        public virtual Person Person { get; set; }
    }
}
