using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Entities
{
    /// <summary>
    /// <author>Dominik Josipović</author>
    /// </summary>
    public partial class korisnik
    {
        public override string ToString()
        {
            return ime + " " + prezime;
        }
    }
}
