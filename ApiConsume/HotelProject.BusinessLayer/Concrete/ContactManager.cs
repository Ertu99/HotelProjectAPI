using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class ContactManager : IContactService
{
    private readonly IContactDal _contactDal;

    public ContactManager(IContactDal contactDal)
    {
        _contactDal = contactDal;
    }

    public void TInsert(Contact t)
    {
        _contactDal.Insert(t);
    }

    public void TDelete(Contact t)
    {
        _contactDal.Delete(t);
    }

    public void TUpdate(Contact t)
    {
        _contactDal.Update(t);
    }

    public List<Contact> TGetList()
    {
        return _contactDal.GetList();
    }

    public Contact TGetByID(int id)
    {
        return _contactDal.GetByID(id);
    }
}