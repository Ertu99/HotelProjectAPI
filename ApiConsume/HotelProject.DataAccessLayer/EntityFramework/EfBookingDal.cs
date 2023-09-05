using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.Entitylayer.Concrete;

namespace HotelProject.DataAccessLayer.EntityFramework;

public class EfBookingDal : GenericRepository<Booking>, IBookingDal
{
    public EfBookingDal(Context context) : base(context)
    {
        
    }

    public void BookingStatusChangeApproved(Booking booking)
    {
        var context = new Context();
        var values = context.Bookings.Where(x => x.BookingID == booking.BookingID).FirstOrDefault();
        values.Status = "onaylandi";
        context.SaveChanges();
    }

    public void BookingStatusChangeApproved(int id)
    {
        var context = new Context();
        var values = context.Bookings.Find(id);
        values.Status = "onaylandi";
        context.SaveChanges();
    }
}