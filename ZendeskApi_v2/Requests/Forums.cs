using ZenDeskApi_v2.Models.Forums;
using ZenDeskApi_v2.Models.Tags;

namespace ZenDeskApi_v2.Requests
{
    public class Forums : Core
    {
        public Forums(string yourZenDeskUrl, string user, string password)
            : base(yourZenDeskUrl, user, password)
        {
        }

        public GroupForumResponse GetForums()
        {
            return GenericGet<GroupForumResponse>("forums.json");
        }

        public IndividualForumResponse GetForumById(long forumId)
        {
            return GenericGet<IndividualForumResponse>(string.Format("forums/{0}.json", forumId));
        }

        public GroupForumResponse GetForumsByCategory(long categoryId)
        {
            return GenericGet<GroupForumResponse>(string.Format("categories/{0}/forums.json", categoryId));
        }

        public IndividualForumResponse CreateForum(Forum forum)
        {
            var body = new { forum };
            return GenericPost<IndividualForumResponse>("forums.json", body);
        }

        public IndividualForumResponse UpdateForum(Forum forum)
        {
            var body = new { forum };
            return GenericPut<IndividualForumResponse>(string.Format("forums/{0}.json", forum.Id), body);
        }

        public bool DeleteForum(long id)
        {
            return GenericDelete(string.Format("forums/{0}.json", id));
        }
    }
}