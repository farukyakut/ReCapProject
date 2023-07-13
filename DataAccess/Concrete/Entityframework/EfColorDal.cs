using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Entityframework;

public class EfColorDal : IColorDal
{
    public void Add(Color entity)
    {
        throw new NotImplementedException();
    }

    public void Delete(Color entity)
    {
        throw new NotImplementedException();
    }

    public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
    {
        throw new NotImplementedException();
    }

    public void Update(Color entity)
    {
        throw new NotImplementedException();
    }
}
