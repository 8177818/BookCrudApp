using System.ComponentModel.DataAnnotations;

namespace BookCrudApp.Models
{
    public class Book
    {
        public int Id { get; set; } // 主鍵

        [Required]
        [StringLength(100)]
        public string Title { get; set; } // 書名

        [StringLength(50)]
        public string Author { get; set; } // 作者

        [Range(0, 9999)]
        public int Pages { get; set; } // 頁數

        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; } // 出版日期
    }
}

