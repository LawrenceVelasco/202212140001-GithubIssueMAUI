using System;
namespace GithubIssueMAUI
{
	public partial class App
	{
		private void SetUp()
		{
            Microsoft.Maui.Handlers.LabelHandler.Mapper.AppendToMapping("Test", (h, v) =>
            {
                (h.PlatformView).Lines = 0;
            });
        }
	}
}

