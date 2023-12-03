using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace MVCBook105.Models
{
    public class BorrowISBNViewModel
    {
        public List<Borrow>? Borrows { get; set; }
        public SelectList? ISBNs { get; set; }
        public string? BorrowISBN { get; set; }
        public string? SearchString { get; set; }
    }

    public class Borrow
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "流水号")]
        public string? serialNumber { get; set; }       // 流水号

        [Required]
        [MaxLength(8)]
        public string? ISBN { get; set; }       // 国际标准书号

        [Required]
        [MaxLength(8)]
        [Display(Name = "读者号")]
        public string? readerNumber { get; set; }     // 读者号

        [Display(Name = "借出日期")]
        [DataType(DataType.Date)]
        public DateTime loanDate { get; set; }      // 借出日期

        [Display(Name = "归还日期")]
        [DataType(DataType.Date)]
        public DateTime? returnDate { get; set; }        // 归还日期    
    }
}
