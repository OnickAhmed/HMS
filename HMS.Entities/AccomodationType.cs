using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class AccomodationType
    {
        public int ID { get; set; }

        /// <summary>
        /// Accomodation Type Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Accomodation Type Description
        /// </summary>
        public string Description { get; set; }
    }
}
