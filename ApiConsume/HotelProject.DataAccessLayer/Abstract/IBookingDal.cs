using HotelProject.Entitylayer.Concrete;

namespace HotelProject.DataAccessLayer.Abstract;

public interface IBookingDal : IGenericDal<Booking>
{
    void BookingStatusChangeApproved(Booking booking);
    void BookingStatusChangeApproved(int id);
}