using System.ComponentModel.DataAnnotations;

namespace HotelProject.DtoLayer.Dtos.RoomDto;

public class UpdateRoomDto
{
    public int RoomID { get; set; }
    [Required(ErrorMessage = "Lutfen oda numarasini giriniz")]
    public string RoomNumber { get; set; }
    [Required(ErrorMessage = "Lutfen oda gorseli giriniz")]
    public string RoomCoverImage { get; set; }
    [Required(ErrorMessage = "Lutfen oda fiyati giriniz")]
    public int Price { get; set; }
    [Required(ErrorMessage = "Lutfen oda basligi giriniz")]
    [StringLength(100,ErrorMessage = "lutfen en fazla 100 karakter giriniz")]
    public string Title { get; set; }
    [Required(ErrorMessage = "Lutfen yatak sayisi giriniz")]
    public string BedCount { get; set; }
    [Required(ErrorMessage = "Lutfen banyo sayisi giriniz")]
    public string BathCount { get; set; }
    public string Wifi { get; set; }
    [Required(ErrorMessage = "Lutfen aciklama giriniz")]
    public string Description { get; set; }
}