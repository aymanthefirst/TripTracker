using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.UI.Services
{
    interface IApiClient
    {
        Task<List<TripTracker.BackService.Models.Trip>> GetTripsAsync();

    }
}
