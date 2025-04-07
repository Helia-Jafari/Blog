using Blog.CoreLayer.DTOs;
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
