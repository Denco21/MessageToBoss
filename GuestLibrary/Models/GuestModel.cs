using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestLibrary.Models
{
    public class GuestModel
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Section { get; set; }

        public string MessageToBoss { get; set; }

        public string DayTime { get; set; }


        public string ShowGuestInfo
        {
            get
            {
                return $"{FirstName} {LastName} har lämnat ett meddelande: {MessageToBoss} Section:{Section} at {DayTime}";
            }
        }
    }
}
