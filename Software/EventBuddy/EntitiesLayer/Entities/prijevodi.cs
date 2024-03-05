namespace EntitiesLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("prijevodi")]
    public partial class prijevodi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(80)]
        public string ID_atributa { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(5)]
        public string ID_jezika { get; set; }

        [Required]
        public string prijevod { get; set; }

        public virtual jezik jezik { get; set; }
    }
}
