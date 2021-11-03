using AnthillCommon.DataContext;
using AnthillCommon.Models;
using Project.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data.Repositories
{
    public class RefreshTokenRepository : IRefreshTokenRepository
    {
        public RefreshTokenRepository()
        {
            _context = new CommonContext();
            
        }

        protected CommonContext _context { get; private set; }


        public async Task Add(RefreshToken token)
        {
            _context.Set<RefreshToken>();
            await _context.AddAsync(token);
            await _context.SaveChangesAsync();
        }

        public RefreshToken GetByToken(string token)
        {
            var storedToken = _context.Set<RefreshToken>().FirstOrDefault(x => x.Token == token);
            return  storedToken;
        }

        public async void Update(RefreshToken token)
        {
            _context.Set<RefreshToken>().Update(token);
            await _context.SaveChangesAsync();

        }
    }
}
