using System;
namespace GithubIssueMAUI
{
    public abstract class ViewModelBase :
        BindableBase,
        INavigationAware,
        INavigatedAware,
        IInitialize,
        IInitializeAsync,
        IDestructible
    {
        protected INavigationService NavigationService { get; private set; }
        protected ViewModelBase(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        public virtual void Destroy()
        {

        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {

        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {

        }

        public virtual void Initialize(INavigationParameters parameters)
        {

        }

        public virtual Task InitializeAsync(INavigationParameters parameters)
        {
            return Task.CompletedTask;
        }

        public INavigationService GetNavigationService() => NavigationService;
    }
}

