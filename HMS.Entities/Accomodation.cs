using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Entities
{
    public class Accomodation
    {
        public int ID { get; set; }

        public int AccomodationPackageId { get; set; }
        public AccomodationPackage AccomodationPackage { get; set; }


        /// <summary>
        /// Accomodation Name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Accomodation Desciption
        /// </summary>
        public string Description { get; set; }
    }
}
