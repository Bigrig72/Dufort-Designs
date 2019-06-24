using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using ReganDufort.Models;
using ReganDufort.Models.Interfaces;
using System.Threading.Tasks;

namespace ReganDufort.Pages.ContactInfo
{
    public class ContactModel : PageModel
    {
        private readonly IContact _Contact;

        [FromRoute]
        public int? ID { get; set; }

        [BindProperty]
        public Contact Contact { get; set; }


        public ContactModel(IContact contactInformation, IConfiguration configuration)
        {
            _Contact = contactInformation;
        }

        public void OnGet()
        {

        }
        public async Task<IActionResult> OnPost()
        {
            var customer = Contact;
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _Contact.SaveContact(customer);
            return RedirectToPage("/Index");
        }
    }
}