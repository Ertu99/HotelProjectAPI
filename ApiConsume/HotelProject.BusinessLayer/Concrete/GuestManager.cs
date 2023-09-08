using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class GuestManager : IGuestService
{
    private readonly IGuestDal _guestDal;

    public GuestManager(IGuestDal guestDal)
    {
        _guestDal = guestDal;
    }

    public void TInsert(Guest t)
    {
        _guestDal.Insert(t);
    }

    public void TDelete(Guest t)
    {
        _guestDal.Delete(t);
    }

    public void TUpdate(Guest t)
    {
        _guestDal.Update(t);
    }

    public List<Guest> TGetList()
    {
        return _guestDal.GetList();
    }

    public Guest TGetByID(int id)
    {
        return _guestDal.GetByID(id);
    }
}