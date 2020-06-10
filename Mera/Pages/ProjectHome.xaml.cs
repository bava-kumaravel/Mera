using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Mera.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ProjectHome : Page
    {
        public ProjectHome()
        {
            this.InitializeComponent();
            UpdateProjectCount();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        private void UpdateProjectGrid()
        {
            
        }
        
        private void HoverEvent(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            button.Background = new SolidColorBrush(Windows.UI.Colors.Blue);
        }

        private void UpdateProjectCount()
        {
            ProjectCount.Text = ProjectDetails.projectsList.Count.ToString();
        }

        private void AddProject(object sender, RoutedEventArgs e)
        {
            
            //Get number of projects
            int numOfProjects = ProjectDetails.numOfProjects;

            //Create new project
            Classes.Project newProj = new Classes.Project("Rice Store",numOfProjects);

            //Add project to the projects list
            ProjectDetails.projectsList.Add(newProj);

            //Call Grid Update
            UpdateProjectCount();
        }
    }
}
