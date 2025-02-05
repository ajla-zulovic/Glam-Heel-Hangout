using eGlamHeelHangout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGlamHeelHangout.Service
{
  public  interface IProductService
  {
    IList<Products> Get();
  }
}
