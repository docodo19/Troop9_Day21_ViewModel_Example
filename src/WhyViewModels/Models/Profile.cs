using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhyViewModels.Models
{
    public class Profile
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string SSN { get; set; }
        public string CreditCardInfo { get; set; }

    }
}
