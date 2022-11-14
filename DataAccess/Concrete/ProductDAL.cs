using DataAccess.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class ProductDAL:RepositoryDAL<Product>,IProductDAL
    {
    }
}
