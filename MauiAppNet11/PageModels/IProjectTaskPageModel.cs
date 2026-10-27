using CommunityToolkit.Mvvm.Input;
using MauiAppNet11.Models;

namespace MauiAppNet11.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}