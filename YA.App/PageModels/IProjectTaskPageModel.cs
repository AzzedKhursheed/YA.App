using CommunityToolkit.Mvvm.Input;
using YA.App.Models;

namespace YA.App.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}