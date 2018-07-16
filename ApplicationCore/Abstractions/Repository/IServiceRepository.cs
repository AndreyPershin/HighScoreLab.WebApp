using ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Abstractions.Repository
{
    public interface IServiceRepository
    {
        IEnumerable<ServiceModel> GetServices();
    }
}
