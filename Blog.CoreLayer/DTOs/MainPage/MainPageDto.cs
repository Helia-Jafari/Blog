using System.Collections.Generic;
using Blog.CoreLayer.DTOs.Posts;
using Blog.CoreLayer.DTOs.Categories;

namespace Blog.CoreLayer.DTOs.MainPage
{
    public class MainPageDto
    {
        public List<PostDto> LatestPosts { get; set; }
        public List<PostDto> SpecialPosts { get; set; }
        public List<MainPageCategoryDto> Categories { get; set; }
    }

}