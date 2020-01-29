using System.Collections.Generic;
using hnd.api.instagram.Models;

namespace hnd.api.instagram.Repositories

{
    public interface ITargetRepository
    {
        IEnumerable<Target> Get();
    }
}