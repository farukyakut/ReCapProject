using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Linq.Expressions;

namespace DataAccess.Concrete.Entityframework;

public class EfColorDal : EfEntityRepositoryBase<Color,CarRentalContext>, IColorDal
{
    
}
