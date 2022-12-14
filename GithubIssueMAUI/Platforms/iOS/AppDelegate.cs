using Foundation;
using UIKit;

namespace GithubIssueMAUI;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{
	protected override MauiApp CreateMauiApp()
	{
        return MauiProgram.CreateMauiApp();
    }
}

	 