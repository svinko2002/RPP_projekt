namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class zahtjev_kategorija
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string naslov { get; set; }

        [Required]
        [StringLength(10)]
        public string opis { get; set; }

        public int ID_korisnik { get; set; }

        public virtual korisnik korisnik { get; set; }
    }
}
