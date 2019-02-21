using System.ComponentModel.DataAnnotations;

namespace MVCMusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public string Contents { get; set; }

        [Display(Name = "Album")]
        public int AlbumID { get; set; }
        public virtual Album Album { get; set; }

        [Required, Display(Name = "Email Address"), DataType(DataType.EmailAddress)]
        public string ReviewerEmail { get; set; }
    }
}