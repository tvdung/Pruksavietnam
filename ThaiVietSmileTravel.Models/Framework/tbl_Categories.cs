using System.ComponentModel.DataAnnotations;

namespace ThaiVietSmileTravel.Models.Framework
{
    public partial class tbl_Categories
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục tiếng thái")]
        [Display(Name = "Tên menu tiếng thái")]
        [StringLength(50)]
        public string TenTL { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục tiếng việt")]
        [Display(Name = "Tên menu tiếng việt")]
        [StringLength(50)]
        public string TenVN { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên danh mục tiếng anh")]
        [Display(Name = "Tên menu tiếng anh")]
        [StringLength(50)]
        public string TenEN { get; set; }

        [Display(Name = "Hình đại diện")]
        [StringLength(255)]
        public string HinhAnh { get; set; }

        [Display(Name = "Trạng thái")]
        public bool IsActive { get; set; }
    }
}