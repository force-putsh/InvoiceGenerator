namespace InvoiceGenerator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NjI4ODczQDMyMzAyZTMxMmUzMEorMGpIb0VVeS8wQWdQMEpzN2dzSnhmdGFrbi85bkprRytYU1FFdEJOd2c9");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}