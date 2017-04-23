using System.ComponentModel.DataAnnotations;

namespace ThaiVietSmileTravel.Models.Framework
{
    public partial class tbl_Menu
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục tiếng thái")]
        [Display(Name = "Tên danh mục tiếng thái")]
        [StringLength(50)]
        public string NameTL { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục tiếng việt")]
        [Display(Name = "Tên danh mục tiếng việt")]
        [StringLength(50)]
        public string NameVN { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục tiếng anh")]
        [Display(Name = "Tên danh mục tiếng anh")]
        [StringLength(50)]
        public string NameEN { get; set; }

        [StringLength(2)]
        public string LanguageID { get; set; }
    }
}