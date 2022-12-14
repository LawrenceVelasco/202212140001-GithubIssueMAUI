using Microsoft.Extensions.Logging;

namespace GithubIssueMAUI;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UsePrism(prism =>
            {
                prism.RegisterTypes(container =>
                {
                    container.RegisterForNavigation<MainPage, MainPageViewModel>();
                });

                prism.OnAppStart(navigation =>
                    navigation.NavigateAsync("/NavigationPage/MainPage"));
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

