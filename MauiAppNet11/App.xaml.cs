using MauiAppNet11.PageModels;
using Microsoft.Extensions.DependencyInjection;

namespace MauiAppNet11
{
    public partial class App : Application
    {
        private readonly ProjectListPageModel _projectListPageModel;

        public App(ProjectListPageModel projectListPageModel)
        {
            InitializeComponent();
            _projectListPageModel = projectListPageModel;
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell(_projectListPageModel));
        }
    }
}