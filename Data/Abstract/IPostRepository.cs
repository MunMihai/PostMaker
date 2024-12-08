using Domain;

namespace DataAccessLayer.Abstract
{
    public interface IPostRepository
    {
        IList<Post> GetPosts();
        void CreatePost(Post post);
    }
}
