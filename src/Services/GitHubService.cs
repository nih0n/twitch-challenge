using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;

using TwitchChallenge.Web.Models;

namespace TwitchChallenge.Web.Services
{
    public class GitHubService : IGitHubService
    {
        private readonly HttpClient _client;

        public GitHubService(HttpClient client)
        {
            client.BaseAddress = new Uri("https://api.github.com/");
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (PlayStation 5/SmartTV) AppleWebKit/605.1.15 (KHTML, like Gecko)");

            _client = client;
        }

        public async Task<List<Contributor>> GetRepositoryContributorsAsync(string owner, string repository)
        {
            var stream = await _client.GetStreamAsync($"repos/{owner}/{repository}/contributors");
            var contributors = await JsonSerializer.DeserializeAsync<List<Contributor>>(stream);

            return contributors;
        }
    }
}