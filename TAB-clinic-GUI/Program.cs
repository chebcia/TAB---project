using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace TAB_clinic_GUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Trace enables simple console-like output in the Output window
            // 
            // Tools -> Options -> Debugging -> Output Window -> Module Load Messages -> Off
            // ^ makes it easier to read Trace output
            Trace.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Trace.AutoFlush = true;
            Trace.Indent();
            Trace.WriteLine("Entering Main");
            Trace.Indent();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            Trace.Unindent();
            Trace.WriteLine("Exiting Main");
            Trace.Unindent();
        }
    }
}

// ENTITY FRAMEWORK GUIDE:
// Tools -> NuGet Package Manager -> Manage NuGet Packages for Solution
// Find and install:
//      Microsoft.EntityFrameworkCore.SqlServer
//      Microsoft.EntityFrameworkCore.Tools
// Tools -> NuGet Package Manager -> Package Manager Console
// Run command to generate classes from an existing DB:
//      Scaffold-DbContext "Server=localhost;Database=ClinicDB;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Database
//
// "Build failed"? Make sure your project compiles without errors before running.