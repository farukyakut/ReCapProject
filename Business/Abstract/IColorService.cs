using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IColorService
    {
        Color GetById(int id);
        void Add(Color brand);
        void Update(Color brand);
        void Delete(Color brand);
        List<Color> GetAll();
    }
}
