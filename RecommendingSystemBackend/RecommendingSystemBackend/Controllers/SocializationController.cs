using RecommendingSystemBackend.Models;
using System.Web.Http;

namespace RecommendingSystemBackend.Controllers
{
    public class SocializationController : ApiController
    {
        [HttpGet]
        [Route("user/{userId}/matches")]
        public MatchedUser[] MatchUsersFor(int userId)
        {
            return new[]
            {
                new MatchedUser(userId, 3),
                new MatchedUser(userId, 13)
            };
        }
    }
}
