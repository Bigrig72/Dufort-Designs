using ReganDufort.Data;
using ReganDufort.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReganDufort.Models.Services
{
    public class ContactService : IContact
    {
        private readonly PortfolioDBContext _context;

        public ContactService(PortfolioDBContext context)
        {
            _context = context;
        }
        
        public async Task SaveContact(Contact contact)
        {
             _context.Contact.Add(contact);

            await _context.SaveChangesAsync();
        }
    }
}
