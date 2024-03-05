namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("korisnik")]
    public partial class korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public korisnik()
        {
            dogadaj = new HashSet<dogadaj>();
            zahtjev_kategorija = new HashSet<zahtjev_kategorija>();
            zahtjev_organizator = new HashSet<zahtjev_organizator>();
            jezik = new HashSet<jezik>();
            dogadaj1 = new HashSet<dogadaj>();
            dogadaj2 = new HashSet<dogadaj>();
            uloga = new HashSet<uloga>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string korime { get; set; }

        [Required]
        [StringLength(25)]
        public string ime { get; set; }

        [Required]
        [StringLength(30)]
        public string prezime { get; set; }

        [Required]
        [StringLength(10)]
        public string lozinka { get; set; }

        public int upozorenja { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dogadaj> dogadaj { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zahtjev_kategorija> zahtjev_kategorija { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<zahtjev_organizator> zahtjev_organizator { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<jezik> jezik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dogadaj> dogadaj1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dogadaj> dogadaj2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<uloga> uloga { get; set; }
    }
}
