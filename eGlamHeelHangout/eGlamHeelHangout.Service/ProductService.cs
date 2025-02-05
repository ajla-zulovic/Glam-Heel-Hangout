using eGlamHeelHangout.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGlamHeelHangout.Service
{
  public class ProductService:IProductService
  {
    List<Products> products = new List<Products>() {
      new Products(){
        ProductID=1,
        Name="Royal Glam Heels"
      }
    };
    public IList<Products> Get()
    {
      return products;
    }
  }
}
