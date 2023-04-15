﻿using ChayBiShop94.ViewModels.Common;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers.Components
{
    public class PagerViewComponent : ViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(PagedResultBase result)
        {
            return Task.FromResult((IViewComponentResult)View("Default", result));
        }
    }
}