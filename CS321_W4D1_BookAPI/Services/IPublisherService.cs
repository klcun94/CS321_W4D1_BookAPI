using System;
using System.Collections.Generic;
using CS321_W4D1_BookAPI.Models;

namespace CS321_W4D1_BookAPI.Services
{
    public interface IPublisherService
    {
        Publisher Add(Publisher publisher);
        Publisher Get(int id);
        Publisher Update(Publisher updatedPublisher);
        void Remove(Publisher publisher);
        IEnumerable<Publisher> GetAll();
    }
}
