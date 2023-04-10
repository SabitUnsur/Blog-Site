﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents.Blog
{
    public class BlogListDashboard:ViewComponent
    {
        BlogManager _blogManager = new BlogManager(new EfBlogRepository());

        public IViewComponentResult Invoke()
        {
            var values = _blogManager.GetBlogListWithCategory();
            return View(values);
        }
    }
}
