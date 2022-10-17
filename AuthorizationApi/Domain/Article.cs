using System.ComponentModel.DataAnnotations;

namespace AuthorizationApi.Domain
{
    public class Article
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "Название статьи")]
        public string Title { get; set; }

        [Display(Name = "Содержание статьи")]
        public string Text { get; set; }
    }
}
