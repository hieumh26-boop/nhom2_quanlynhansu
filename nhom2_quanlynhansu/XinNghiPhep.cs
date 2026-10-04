namespace nhom2_quanlynhansu
{
    public partial class fXinNghiPhep : Form
    {
        public fXinNghiPhep()
        {
            InitializeComponent();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void fXinNghiPhep_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void fXinNghiPhep_Load(object sender, EventArgs e)
        {
            // 2. Lấy toàn bộ kích thước màn hình làm việc của Laptop (trừ thanh Taskbar)
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // 3. Ép vị trí và trạng thái bung tối đa
            this.StartPosition = FormStartPosition.Manual;
            this.Location = Screen.FromHandle(this.Handle).WorkingArea.Location;
            this.WindowState = FormWindowState.Maximized;
        }

  
    }
}
