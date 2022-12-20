using Grpc.Core;
using Grpc.Net.Client;
using InternalAPI;

namespace LyftClient.Services
{
    public class AccessTokenService : IAccessTokenService
    {
        private readonly Users.UsersClient _client;
        public AccessTokenService(Users.UsersClient client) => _client = client;
        public async Task<string> GetAccessTokenAsync(string SessionToken, string ServiceId)
        {
            var headers = new Metadata
            {
                { "token", $"{SessionToken}" }
            };

            var AccessTokenResponse = await _client.GetUserAccessTokenAsync(new GetUserAccessTokenRequest { ServiceId = ServiceId }, headers);

            if (AccessTokenResponse is null) return null;

            return AccessTokenResponse.AccessToken;
        }
    }
}
