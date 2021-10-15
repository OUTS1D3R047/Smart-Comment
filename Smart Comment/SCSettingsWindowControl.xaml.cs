using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;


namespace Smart_Comment
{
    /// <summary>
    /// Interaction logic for SCSettingsWindowControl.
    /// </summary>
    public partial class SCSettingsWindowControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SCSettingsWindowControl"/> class.
        /// </summary>

        public NecessaryFunctions NecessaryFunctions = new NecessaryFunctions();

        string todayDate = "";

        public SCSettingsWindowControl()
        {
            this.InitializeComponent();
            todayDate = NecessaryFunctions.TodayDatefun();
            TodayDate.Text = todayDate;
        }


        /// <summary>
        /// Handles click on the button by displaying a message box.
        /// </summary>
        /// <param name="sender">The event sender.</param>
        /// <param name="e">The event args.</param>
        [SuppressMessage("Microsoft.Globalization", "CA1300:SpecifyMessageBoxOptions", Justification = "Sample code")]
        [SuppressMessage("StyleCop.CSharp.NamingRules", "SA1300:ElementMustBeginWithUpperCaseLetter", Justification = "Default event handler naming pattern")]

        
        private void GenerateComment_Click(object sender, RoutedEventArgs e)
        {
            string projName = NecessaryFunctions.ProjectNamefun();
            ProjectName.Text = projName;
            string output = "// " + projName + ", " + todayDate;
            Output.Text = output;
        }
    }
}