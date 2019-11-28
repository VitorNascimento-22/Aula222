using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula222.Models;

namespace Aula222.Services
{
    public class SellerService
    {
        private readonly Aula222Context _context;
    
        public SellerService(Aula222Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    
    }
}
