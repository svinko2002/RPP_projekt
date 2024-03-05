namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("dogadaj")]
    public partial class dogadaj
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dogadaj()
        {
            korisnik1 = new HashSet<korisnik>();
            korisnik2 = new HashSet<korisnik>();
        }

        public int ID { get; set; }

        [StringLength(25)]
        public string naziv { get; set; }

        public string opis { get; set; }

        [StringLength(30)]
        public string mjesto { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime datum { get; set; }

        public int ID_korisnik { get; set; }

        public int ID_kategorija { get; set; }

        public int ID_status { get; set; }

        public virtual kategorija kategorija { get; set; }

        public virtual korisnik korisnik { get; set; }

        public virtual status status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<korisnik> korisnik1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<korisnik> korisnik2 { get; set; }
    }
}
