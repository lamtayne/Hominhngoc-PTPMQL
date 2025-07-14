using System.ComponentModel.DataAnnotations;

namespace Demo_Mvc.Models;

public class HeThongPhanPhoi
{
    [Key]//
    public int MaHTPP { get; set; }
    public string? TenHTPP { get; set; }
    public class DaiLy : HeThongPhanPhoi
    {
        public string? MaDaiLy { get; set; }
        public string? TenDaiLy { get; set; }
        public string? DiaChi { get; set; }
        public string? NguoiDaiDien { get; set; }
        public string? DienThoai { get; set; }
}
}