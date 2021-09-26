using WebApplication29.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace WebApplication29.Client.Repository
{
    public interface IGenreRepository
    {
        Task CreateGenre(Online genre);
    }
}
