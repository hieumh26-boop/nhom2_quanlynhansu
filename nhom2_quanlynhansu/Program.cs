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

            if (fLogin.ShowDialog() == DialogResult.OK)
            {
                // 2. Nếu đăng nhập thành công (fLogin trả về DialogResult.OK)
                // Thì hệ thống sẽ mở tiếp fMain của bạn lên làm Form chính
                Application.Run(new fMain_orion());
            }
        }
    }
}