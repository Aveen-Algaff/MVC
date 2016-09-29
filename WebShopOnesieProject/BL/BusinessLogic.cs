using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.ConnectionLayer;

namespace BL
{
    public class BusinessLogic
    {
        private ProductLayer _productLayer;

        public BusinessLogic()
        {
            _productLayer = new ProductLayer();
        }

        public List<string> GetCategories()
        {
            return _productLayer.GetCategories();
        }

    }
}
