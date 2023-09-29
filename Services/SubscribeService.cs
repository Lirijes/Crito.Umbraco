using Crito.Contexts;
using Crito.Models;
using Crito.Models.Entity;

namespace Crito.Services
{
    public class SubscribeService
    {
        private readonly DatabaseContext _databaseContext;

        public SubscribeService(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task AddSubscriberAsync(NewsletterForm newsletterform)
        {
            _databaseContext.NewsletterForms.Add(new NewsletterFormEntity { Email = newsletterform.Email });
            await _databaseContext.SaveChangesAsync();
        }
    }
}
