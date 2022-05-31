namespace AkcakocaGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            Abonelik = new HashSet<Abonelik>();
            Satis = new HashSet<Satis>();
        }

        public int kullaniciID { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(50)]
        public string kullaniciAdi { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        public int? yetkiID { get; set; }

        [StringLength(20)]
        public string telefon { get; set; }

        [StringLength(200)]
        public string adres { get; set; }

        [StringLength(50)]
        public string cinsiyet { get; set; }

        [StringLength(50)]
        public string alan { get; set; }

        [StringLength(11)]
        public string TCno { get; set; }

        public bool? aktifMi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonelik> Abonelik { get; set; }

        public virtual Yetki Yetki { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
