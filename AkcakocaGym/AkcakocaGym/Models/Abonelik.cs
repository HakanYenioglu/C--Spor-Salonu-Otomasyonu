namespace AkcakocaGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Abonelik")]
    public partial class Abonelik
    {
        public int abonelikID { get; set; }

        public int? paketID { get; set; }

        public int? musteriID { get; set; }

        public int? kullaniciID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? alinmaTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        public string aciklama { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? bitisTarihi { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual Paket Paket { get; set; }
    }
}
