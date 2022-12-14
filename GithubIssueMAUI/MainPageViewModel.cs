using System;
namespace GithubIssueMAUI
{
	public class MainPageViewModel : ViewModelBase
	{
		public MainPageViewModel(
			INavigationService navigationService) : base(navigationService)
		{
		}

        public override void OnNavigatedTo(INavigationParameters parameters)
        {
            base.OnNavigatedTo(parameters);

			SetData();
        }

        private async void SetData()
		{
			await Task.Delay(TimeSpan.FromSeconds(3));

            StringList = new List<string>
                {
                    "The quick brown fox jumps over the lazy dog twice thrice.", "The quick brown fox jumps over the lazy dog twice thrice.", "The quick brown fox jumps over the lazy dog twice thrice.", "The quick brown fox jumps over the lazy dog twice thrice.", "The quick brown fox jumps over the lazy dog twice thrice.", "The quick brown fox jumps over the lazy dog twice thrice.", "The quick brown fox jumps over the lazy dog twice thrice.", "The quick brown fox jumps over the lazy dog twice thrice.", "The quick brown fox jumps over the lazy dog twice thrice.", "The quick brown fox jumps over the lazy dog twice thrice."
                };

			await Task.Delay(TimeSpan.FromSeconds(2));

			IsHeaderVisible = true;
			MyTitle = "My Title Test Long Text Long Text";
        }

		public List<string> StringList { get; set; }
		public bool IsHeaderVisible { get; set; }
		public string MyTitle { get; set; }
	}
}

