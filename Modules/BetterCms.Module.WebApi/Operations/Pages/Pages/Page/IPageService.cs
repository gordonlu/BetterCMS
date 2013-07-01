﻿using BetterCms.Module.Api.Operations.Pages.Pages.Page.Contents;
using BetterCms.Module.Api.Operations.Pages.Pages.Page.Exists;
using BetterCms.Module.Api.Operations.Pages.Pages.Page.Properties;
using BetterCms.Module.Api.Operations.Pages.Pages.Page.RenderedHtml;

namespace BetterCms.Module.Api.Operations.Pages.Pages.Page
{
    public interface IPageService
    {
        GetPageResponse Get(GetPageRequest request);

        IPagePropertiesService Properties { get; }

        IPageRenderedHtmlService Html { get; }

        PageExistsResponse Exists(PageExistsRequest request);

        IPageContentsService Contents { get; }
    }
}