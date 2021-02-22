using System.Collections.Generic;
using System.Threading.Tasks;
using TwitchChallenge.Web.Models;

namespace TwitchChallenge.Web.Services
{
    public interface IGitHubService
    {
        Task<List<Contributor>> GetRepositoryContributorsAsync(string owner, string repository);
    }
}