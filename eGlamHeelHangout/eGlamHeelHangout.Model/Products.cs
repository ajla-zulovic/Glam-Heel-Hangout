using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eGlamHeelHangout.Model
{
  public partial class Products
  {
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryID { get; set; }
    public string Size { get; set; }
    public string Color { get; set; }
    public decimal? HeelHeight { get; set; } // ne mora svaka obuca imati petu 
    public int Stock { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    public bool IsActive { get; set; } = true;
  }
}
