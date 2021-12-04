using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NFL.Models
{
    public class Match
    {
        private const string positive = "Pozitív számot adj meg!";
        private const string week = "Hétnek 1-15 között kell lennie!";
        private const string year = "Évnek 2011-2020 között kell lennie!";
        private const string required = "Töltsd ki ezt a mezőt";

        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = required)]
        [Display(Prompt = "New England Patriots")]
        [DisplayName("Hazai csapat")]
        public string HomeClubName { get; set; }

        [Required(ErrorMessage = required)]
        [Display(Prompt = "Las Vegas Raiders")]
        [DisplayName("Vendég csapat")]
        public string AwayClubName { get; set; }

        [Required(ErrorMessage = required)]
        [Display(Prompt = "24")]
        [DisplayName("Hazai csapat pont")]
        [Range(1, int.MaxValue, ErrorMessage = positive)]
        public int HomeFinalScore { get; set; }

        [Required(ErrorMessage = required)]
        [Display(Prompt = "22")]
        [DisplayName("Vendég csapat pont")]
        [Range(1, int.MaxValue, ErrorMessage = positive)]
        public int AwayFinalScore { get; set; }

        [Required(ErrorMessage = required)]
        [Display(Prompt = "3")]
        [DisplayName("Hazai csapat TD száma")]
        [Range(1, int.MaxValue, ErrorMessage = positive)]
        public int HomeNumberOfTD { get; set; }

        [Required(ErrorMessage = required)]
        [Display(Prompt = "2")]
        [DisplayName("Vendég csapat TD száma")]
        [Range(1, int.MaxValue, ErrorMessage = positive)]
        public int AwayNumberOfTD { get; set; }

        [Required(ErrorMessage = required)]
        [Display(Prompt = "1")]
        [DisplayName("Hét")]
        [Range(1, 15, ErrorMessage = week)]
        public int Week { get; set; }

        [Required(ErrorMessage = required)]
        [Display(Prompt = "2011")]
        [DisplayName("Év")]
        [Range(2011, 2020, ErrorMessage = year)]
        public int Year { get; set; }
    }
}
