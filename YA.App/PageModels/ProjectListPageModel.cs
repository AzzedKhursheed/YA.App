#nullable disable
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using YA.App.Data;
using YA.App.Models;
using YA.App.Services;

namespace YA.App.PageModels
{
    public partial class ProjectListPageModel : ObservableObject
    {
        private readonly ProjectRepository _projectRepository;

        [ObservableProperty]
        private List<Project> _projects = [];

        public ProjectListPageModel(ProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [RelayCommand]
        private async Task Appearing()
        {
            Projects = await _projectRepository.ListAsync();
        }

        [RelayCommand]
        Task NavigateToProject(Project project)
            => Shell.Current.GoToAsync($"project?id={project.ID}");

        [RelayCommand]
        async Task AddProject()
        {
            await Shell.Current.GoToAsync($"project");
        }
    }
}