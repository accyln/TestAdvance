using System;
using System.Collections.Generic;
using System.Text;
using TestAdvance.DataAccess.Interfaces;
using TestAdvance.DataAccess.Repository.Concrete;
using TestAdvance.Entities.Concrete;

namespace TestAdvance.DataAccess.Concrete.Repository
{
    public class EfModulRepository:EfGenericRepository<Modul>,IModulDal
    {
    }
}
