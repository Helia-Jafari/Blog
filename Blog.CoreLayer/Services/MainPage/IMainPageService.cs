using Blog.CoreLayer.DTOs;
using Blog.CoreLayer.DTOs.MainPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.CoreLayer.Services.MainPage
{
    public interface IMainPageService
    {
        MainPageDto GetData();
    }
}
