namespace AkcakocaGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteri")]
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            Abonelik = new HashSet<Abonelik>();
            Olcum = new HashSet<Olcum>();
            Satis = new HashSet<Satis>();
        }

        public int musteriID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(50)]
        public string adres { get; set; }

        [StringLength(20)]
        public string telefon { get; set; }

        [StringLength(10)]
        public string cinsiyet { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? dogumTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? kayitTarihi { get; set; }

        public string aciklama { get; set; }

        [StringLength(50)]
        public string paket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonelik> Abonelik { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Olcum> Olcum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
