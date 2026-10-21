namespace nhom2_quanlynhansu
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Formdangnhap fLogin = new Formdangnhap();



             Application.Run(new FormChinh());
            //Application.Run(new FormPhanQuyen());



        }
    }
}