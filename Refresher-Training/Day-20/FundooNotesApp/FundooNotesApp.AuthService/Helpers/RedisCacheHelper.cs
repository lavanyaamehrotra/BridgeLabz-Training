using StackExchange.Redis;

namespace FundooNotesApp.AuthService.Helpers
{
    public class RedisCacheHelper
    {
        private readonly IDatabase _redisDb;

        public RedisCacheHelper(string connectionString)
        {
            var redis = ConnectionMultiplexer.Connect(connectionString);
            _redisDb = redis.GetDatabase();
        }

        public void StoreToken(string email, string token, TimeSpan expiry)
        {
            _redisDb.StringSet(email, token, expiry);
        }

        public bool IsTokenValid(string email, string token)
        {
            string? storedToken = _redisDb.StringGet(email);
            return storedToken == token;
        }

        public bool ValidateToken(string email, string token)
        {
            return IsTokenValid(email, token);
        }

        public void RemoveToken(string email)
        {
            _redisDb.KeyDelete(email);
        }
    }
}
