namespace AkcakocaGym.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Olcum")]
    public partial class Olcum
    {
        public int olcumID { get; set; }

        public int? musteriID { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? tarih { get; set; }

        public int? boy { get; set; }

        public double? kilo { get; set; }

        public double? omuz { get; set; }

        public double? kol { get; set; }

        public double? bel { get; set; }

        public double? gogus { get; set; }

        public double? boyun { get; set; }

        public double? ustBacak { get; set; }

        public double? altBacak { get; set; }

        public double? kalca { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
