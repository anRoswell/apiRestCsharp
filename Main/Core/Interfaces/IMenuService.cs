using Core.Entities;
using System.Collections.Generic;

namespace Core.Interfaces
{
    public interface IMenuService
    {
        IEnumerable<Menu> GetMenus();
    }
}
