using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReganDufort.Models.Interfaces
{
    public interface IContact
    {
        Task SaveContact(Contact contact);

    }
}
