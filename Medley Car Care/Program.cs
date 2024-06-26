using Syncfusion.Licensing;

namespace Medley_Car_Care
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF1cXmhPYVJzWmFZfVpgd19FZFZURWYuP1ZhSXxXdkNjUX9dc3BQR2FbVkU=");
            SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF1cW2hIfEx1RHxQdld5ZFRHallYTnNWUj0eQnxTdEFjX31ccHBVR2NdVEB1Vg==");
            Application.Run(new Login());
        }
    } 
}


//Ngo9BigBOggjHTQxAR8/V1NCaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXlccXRSQ2FfVU1/XEY=