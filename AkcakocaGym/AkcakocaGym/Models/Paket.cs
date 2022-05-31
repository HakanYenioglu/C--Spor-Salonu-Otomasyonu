namespace AkcakocaGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Paket")]
    public partial class Paket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Paket()
        {
            Abonelik = new HashSet<Abonelik>();
        }

        public int paketID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        public int? ay { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        public int? kontenjan { get; set; }

        public bool? aktifMi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tarih { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonelik> Abonelik { get; set; }
    }
}
