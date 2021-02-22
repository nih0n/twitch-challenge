using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

using TwitchChallenge.Web.Models;
using TwitchChallenge.Web.Services;

namespace TwitchChallenge.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IGitHubService _githubService;

        public IEnumerable<Contributor> Contributors { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            IGitHubService gitHubService)
        {
            _logger = logger;
            _githubService = gitHubService;
        }

        public void OnGet()
        {

        }

        public async Task OnPostAsync(string owner, string repository)
        {
            Contributors = await _githubService.GetRepositoryContributorsAsync(owner, repository);
        }
    }
}
