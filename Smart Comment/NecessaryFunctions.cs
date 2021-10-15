using EnvDTE;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Smart_Comment
{
    public class NecessaryFunctions
    {
        string projName = "";

        public string TodayDatefun()
        {
            DateTime dt = DateTime.Now;
            string strdate = dt.ToString("dd/MM/yyyy");
            strdate = strdate.Replace(".", "/");
            return strdate;
        }

        public string ProjectNamefun()
        {
            ThreadHelper.ThrowIfNotOnUIThread();
            DTE dte = Package.GetGlobalService(typeof(SDTE)) as DTE;
            projName = Path.GetFileName(dte.Solution.FullName);
            projName = Regex.Replace(projName, ".sln", "");
            return projName;
        }
    }
}
