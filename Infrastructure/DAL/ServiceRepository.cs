using ApplicationCore.Abstractions.Repository;
using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.DAL
{
    public class ServiceRepository : IServiceRepository
    {
        public IEnumerable<ServiceModel> GetServices()
        {
            throw new NotImplementedException();
        }
    }
}
