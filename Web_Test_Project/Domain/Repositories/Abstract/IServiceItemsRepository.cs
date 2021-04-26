using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Test_Project.Domain.Entities;

namespace Web_Test_Project.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}
