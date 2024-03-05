namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class zahtjev_organizator
    {
        public int ID { get; set; }

        [Required]
        public string opis { get; set; }

        public bool prihvacen { get; set; }

        public int ID_korisnik { get; set; }

        public virtual korisnik korisnik { get; set; }
    }
}
