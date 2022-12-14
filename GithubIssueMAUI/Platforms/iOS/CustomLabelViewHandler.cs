using System;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;

namespace GithubIssueMAUI.Platforms.iOS
{
    public partial class CustomLabelViewHandler : LabelHandler
    {
        protected override MauiLabel CreatePlatformView()
        {
            var label = base.CreatePlatformView();
            label.Lines = 0;
            return label;
        }
    }
}

