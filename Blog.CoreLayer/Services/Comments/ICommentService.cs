using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.CoreLayer.DTOs.Comments;
using Blog.CoreLayer.Utilities;
using Blog.CoreLayer.DTOs.Comments;
using Blog.CoreLayer.Utilities;
using Blog.DataLayer.Context;
using Blog.DataLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Blog.CoreLayer.Services.Comments
{
    public interface ICommentService
    {
        OperationResult CreateComment(CreateCommentDto command);
        List<CommentDto> GetPostComments(int postId);
    }

}