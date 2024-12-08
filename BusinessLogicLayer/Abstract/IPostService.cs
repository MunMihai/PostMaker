using DataContract;

namespace BusinessLogicLayer.Abstract
{
    public interface IPostService
    {
        IList<PostDto> GetPosts();
        void CreatePost(PostDto dto);
    }
}
