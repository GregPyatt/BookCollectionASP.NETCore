using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookCollection.Model
{
    public partial class ScannedBooks
    {
        [Key]
        [Column("BookID")]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Authors { get; set; }
        [StringLength(50)]
        public string Categories { get; set; }
        [Column(TypeName = "smalldatetime")]
        public DateTime? PublishedDate { get; set; }
        [StringLength(50)]
        public string Publisher { get; set; }
        public int? Pages { get; set; }
        [Required]
        [Column("ISBN")]
        [StringLength(50)]
        public string Isbn { get; set; }
        public bool? IsRead { get; set; }
        [StringLength(50)]
        public string ReadingPeriods { get; set; }
        public string Comments { get; set; }
        public string Summary { get; set; }
        public string CoverPath { get; set; }
        public bool? IsAudioBook { get; set; }
    }
}
