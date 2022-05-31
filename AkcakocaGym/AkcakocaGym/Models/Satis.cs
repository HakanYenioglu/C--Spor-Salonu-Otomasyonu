namespace AkcakocaGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satis
    {
        public int satisID { get; set; }

        public int? musteriID { get; set; }

        public int? urunID { get; set; }

        [Column(TypeName = "money")]
        public decimal? ucret { get; set; }

        public bool? odendiMi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? alinmaTarihi { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? odemeTarihi { get; set; }

        public int? kullaniciID { get; set; }

        public virtual Kullanici Kullanici { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
