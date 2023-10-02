using Crito.Models;
using Crito.Services;
using Microsoft.AspNetCore.Mvc;
using Umbraco.Cms.Core.Cache;
using Umbraco.Cms.Core.Logging;
using Umbraco.Cms.Core.Routing;
using Umbraco.Cms.Core.Services;
using Umbraco.Cms.Core.Web;
using Umbraco.Cms.Infrastructure.Persistence;
using Umbraco.Cms.Web.Website.Controllers;

namespace Crito.Controllers
{
    public class ContactController : SurfaceController
    {
        private readonly MailService _mailService;
        private readonly SubscribeService _subscribeService;
        public ContactController(IUmbracoContextAccessor umbracoContextAccessor, IUmbracoDatabaseFactory databaseFactory, ServiceContext services, AppCaches appCaches, IProfilingLogger profilingLogger, IPublishedUrlProvider publishedUrlProvider, MailService mailService, SubscribeService subscribeService) : base(umbracoContextAccessor, databaseFactory, services, appCaches, profilingLogger, publishedUrlProvider)
        {
            _mailService = mailService;
            _subscribeService = subscribeService;
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactForm contactform)
        {
            if (ModelState.IsValid)
            {
                await _mailService.AddMailAsync(contactform);
                return CurrentUmbracoPage();
            }

            using var mail = new MailService("no-reply@crito.com", "smtp.crito.com", 587, "contactform@umbraco.com", "Hejhej123.");

            // to sender
            mail.SendAsync(contactform.Email, "Your contact request was received.", "Hi your request was received and we will be in contact with you as soon as possible.").ConfigureAwait(false);

            // to receiver
            mail.SendAsync("umbraco@crito.com", $"{contactform.Name} sent a contact request.", contactform.Message).ConfigureAwait(false);


            return LocalRedirect(contactform.RedirectUrl ?? "/");
        }

        [HttpPost]
        public async Task<IActionResult> SubscribeIndex(NewsletterForm newsletterform)
        {
            if (ModelState.IsValid)
            {
                await _subscribeService.AddSubscriberAsync(newsletterform);
                return CurrentUmbracoPage();
            }

            return RedirectToCurrentUmbracoPage();
        }
    }
}
