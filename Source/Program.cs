

using Source.Views;
using Source.Views.Custommer;

namespace Source
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
            //Application.Run(new MainForm());
            //   Application.Run(new Login());
            //Application.Run(new OrderInvoices());
            //Application.Run(new Cart());
            //Application.Run(new ProductDetails());
            //Application.Run(new ReviewProduct());
            //Application.Run(new WatchReview());
            Application.Run(new Refund());
        }
    }

}