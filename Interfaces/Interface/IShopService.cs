using System;
using System.Collections.Generic;
using System.Text;
using ModelsLibrary;

namespace Interfaces
{
    public interface IShopService
    {
        Shop GetShop(int? id);
        void MakeShop(Shop materialDto);
        IEnumerable<Shop> GetAllShop();
    }
}
