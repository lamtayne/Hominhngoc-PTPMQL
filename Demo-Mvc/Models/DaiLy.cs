using System.ComponentModel.DataAnnotations;
using Demo_Mvc.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoMVC.Models
{
    public class DaiLy
    {
        [Key] //
        public string MaDaiLy { get; set; }       
        public string TenDaiLy { get; set; }
        public string DiaChi { get; set; }
        public string NguoiDaiDien { get; set; }
        public string DienThoai { get; set; }

        // Khóa ngoại
        public string MaHTPP { get; set; }

        // Navigation property (liên kết)
        public HeThongPhanPhoi HeThongPhanPhoi { get; set; }
    }
}
