using CorelLASERBot.Properties;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CorelLASERBot
{
    public partial class FormMain : Form
    {
        CancellationTokenSource source;
        CancellationToken token;
        bool AUTO_CLOSE = false;

        string APP_NAME = "CorelDRW";
        //string APP_NAME = "notepad";

        bool IS_FIRST_DATA = true;
        Stopwatch clock = new Stopwatch();
        long WAIT_TIME = 60 * 1000; //milisecond
        Size SOFTWARE_SIZE_MIN = new Size(418, 43);
        Size SOFTWARE_SIZE_MAX = new Size(418, 176);

        public FormMain()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        static extern bool SetForegroundWindow(IntPtr hWnd);


        //This is a replacement for Cursor.Position in WinForms
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

        //This simulates a left mouse click
        public static void LeftMouseClick(int xpos, int ypos)
        {
            var x = MousePosition.X;
            var y = MousePosition.Y;
            SetCursorPos(xpos, ypos);
            mouse_event(MOUSEEVENTF_LEFTDOWN, xpos, ypos, 0, 0);
            Thread.Sleep(100);
            mouse_event(MOUSEEVENTF_LEFTUP, xpos, ypos, 0, 0);
            Thread.Sleep(100);
            SetCursorPos(x, y);

        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //var task = Task.Run(() => tracker());
            buttonMore.Tag = "more";
            buttonRun.Tag = "run";
            buttonRun.Text = "RUN!";
            Location = new Point(Convert.ToInt32(Screen.PrimaryScreen.Bounds.Width * 0.5), 0);
            Size = SOFTWARE_SIZE_MIN;
            labelStatus.Focus();
            Run_AutoClose();

            numericUpDownX.Value = Settings.Default.CURSOR_X;
            numericUpDownY.Value = Settings.Default.CURSOR_Y;
            //Settings.Default.Reset();
            RefreshPort();

        }

        private void tracker()
        {
            while (true)
            {
                Invoke((MethodInvoker)delegate ()
                {
                    //labelMousePosition.Text = "{X: " + MousePosition.X + "; Y:" + MousePosition.Y + ";}";
                });
                Thread.Sleep(500);
            }
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void labelMousePosition_Click(object sender, EventArgs e)
        {

        }

        private void labelStatus_Click(object sender, EventArgs e)
        {

        }

        private async void buttonCapture_Click(object sender, EventArgs e)
        {

        }

        string status_last = "";
        private async void Run_AutoClose()
        {

            Process[] p = Process.GetProcessesByName(APP_NAME);

            // Activate the first application we find with this name
            if (p.Count() > 0)
            {
                if (!AUTO_CLOSE)
                {
                    AUTO_CLOSE = true;
                    status_last = labelStatus.Text;
                    labelStatus.Text = "Autoclose Enabled!";
                    await Task.Run(() => { Thread.Sleep(1000); });
                    labelStatus.Text = status_last;
                    panelIndicator1.BackColor = Color.Lime;
                }
            }
            else
            {
                if (AUTO_CLOSE)
                    Application.Exit();
            }
        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            Run_AutoClose();
            if (IS_FIRST_DATA || clock.ElapsedMilliseconds > WAIT_TIME)
            {
                panelIndicator2.BackColor = Color.Lime;
            }
            else
            {
                panelIndicator2.BackColor = Color.Orange;
            }
            if (!STATUS_LOCK)
            {
                labelStatus.Text = "Idle...";
            }
        }

        private void buttonMore_Click(object sender, EventArgs e)
        {
            labelStatus.Focus();

            if (buttonMore.Tag.ToString() == "more")
            {
                Size = SOFTWARE_SIZE_MAX;
                buttonMore.Tag = "less";
            }
            else
            {
                buttonMore.Tag = "more";
                Size = SOFTWARE_SIZE_MIN;

            }

        }

        private void RefreshPort()
        {
            ComboBox[] _cbs = { comboBoxCOMPort };
            string[] _ports = SerialPort.GetPortNames();
            foreach (var _cb in _cbs)
            {
                _cb.Items.Clear();
                _cb.Items.Add($"-- Found {_ports.Length}! --");
                foreach (string _port in _ports)
                {
                    _cb.Items.Add(_port);
                }
                try
                {
                    _cb.SelectedIndex = Settings.Default.PORT;
                    if (_cb.Text != Settings.Default.PORT_NAME)
                    {
                        _cb.SelectedIndex = 0;
                    }
                }
                catch
                {
                    _cb.SelectedIndex = 0;
                }

            }
        }

        private async void linkLabelRefresh_Click(object sender, EventArgs e)
        {
            comboBoxCOMPort.Items.Clear();
            comboBoxCOMPort.Items.Add("Wait...");
            comboBoxCOMPort.SelectedIndex = 0;


            await Task.Run(() => { Thread.Sleep(1000); });
            RefreshPort();
        }

        private bool FI_Port_Open()
        {
            try
            {
                serialPortMain.PortName = comboBoxCOMPort.Text;
                serialPortMain.BaudRate = 115200;
                serialPortMain.DataBits = 8;
                serialPortMain.StopBits = StopBits.One;
                serialPortMain.Parity = Parity.None;

                serialPortMain.Open();

                return true;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }

        private bool FI_Port_Close()
        {
            try
            {
                if (serialPortMain.IsOpen)
                {
                    serialPortMain.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;
        }


        private async void buttonRun_Click(object sender, EventArgs e)
        {
            labelStatus.Focus();

            if (!comboBoxCOMPort.Text.Contains("COM"))
            {
                MessageBox.Show("Please select valid COM Port");
            }
            else
            {
                buttonRun.Enabled = false;

                if (buttonRun.Tag.ToString() == "run")
                {
                    if (FI_Port_Open())
                    {
                        buttonRun.Tag = "stop";
                        buttonRun.Text = "STOP!";
                        buttonMore.Tag = "less";
                        buttonMore.PerformClick();
                        buttonMore.Enabled = false;
                        await Task.Run(() => { Thread.Sleep(1000); });
                        buttonRun.Enabled = true;
                        IS_FIRST_DATA = true;
                    }
                }
                else
                {
                    if (FI_Port_Close())
                    {
                        buttonRun.Tag = "run";
                        buttonRun.Text = "RUN!";

                        buttonRun.Enabled = true;
                        buttonMore.Enabled = true;
                    }
                }
            }
        }
        bool IS_EXECUTED = false;
        bool STATUS_LOCK = false;
        private void serialPortMain_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            Console.WriteLine("Data Received: " + indata);
            if (!IS_EXECUTED && indata.Contains("A"))
            {
                IS_EXECUTED = true;
                STATUS_LOCK = true;
                if (IS_FIRST_DATA || clock.ElapsedMilliseconds > WAIT_TIME)
                {
                    IS_FIRST_DATA = false;
                    clock.Reset();
                    clock.Start();
                    _ = Task.Run(() =>
                      {
                          Invoke((MethodInvoker)delegate ()
                          {
                              labelStatus.Text = "Data Available!";
                          });
                        //Process[] p = Process.GetProcessesByName(app);
                        Process[] p = Process.GetProcessesByName(APP_NAME);

                        // Activate the first application we find with this name
                        if (p.Count() > 0)
                          {
                              Invoke((MethodInvoker)delegate ()
                              {
                                  labelStatus.Text = "Found!";
                              });
                            //SetForegroundWindow(p[0].MainWindowHandle);
                            Thread.Sleep(10 * 1000);
                              LeftMouseClick(Settings.Default.CURSOR_X, Settings.Default.CURSOR_Y);
                            //SendKeys.SendWait("{ENTER}");
                            //var task = Task.Run(() => DoSomething(token), token);
                            //return;
                        }
                          else
                          {
                              Invoke((MethodInvoker)delegate ()
                              {
                                  labelStatus.Text = "No " + APP_NAME + "!";
                              });
                              Thread.Sleep(1000);
                          }
                          Invoke((MethodInvoker)delegate ()
                          {
                              labelStatus.Text = "Continue...";
                          });
                          STATUS_LOCK = false;
                          IS_EXECUTED = false;

                      });
                }
                else
                {
                    _ = Task.Run(() =>
                      {
                          Invoke((MethodInvoker)delegate ()
                          {
                              labelStatus.Text = "Skipped...";
                          });
                          STATUS_LOCK = false;
                          IS_EXECUTED = false;
                      });
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelStatus.Focus();

            if (MessageBox.Show("Reset ke nilai default?", "Cursor Location Capture", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Settings.Default.CURSOR_X = Convert.ToInt32(Settings.Default.Properties["CURSOR_X"].DefaultValue);
                Settings.Default.CURSOR_Y = Convert.ToInt32(Settings.Default.Properties["CURSOR_Y"].DefaultValue);
                Settings.Default.Save();
                MessageBox.Show("Lokasi {X: " + Settings.Default.CURSOR_X + "; Y:" + Settings.Default.CURSOR_Y + ";} berhasil direset ke default!", "Cursor Location Capture", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            numericUpDownX.Value = Settings.Default.CURSOR_X;
            numericUpDownY.Value = Settings.Default.CURSOR_Y;
        }

        private async void buttonGet_Click(object sender, EventArgs e)
        {
            labelStatus.Focus();
            if (MessageBox.Show("Posisikan cursor pada lokasi yang akan di click. Software akan menunggu selama 5 detik kemudian menyimpan posisinya.\n\nTekan \"OK\" untuk mengubah posisi\nTekan \"Cancel\" untuk kembali", "Cursor Location Capture", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                await Task.Run(() => { Thread.Sleep(5000); });
                Settings.Default.CURSOR_X = MousePosition.X;
                Settings.Default.CURSOR_Y = MousePosition.Y;
                Settings.Default.Save();
                MessageBox.Show("Lokasi {X: " + Settings.Default.CURSOR_X + "; Y:" + Settings.Default.CURSOR_Y + ";} berhasil disimpan!", "Cursor Location Capture", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            numericUpDownX.Value = Settings.Default.CURSOR_X;
            numericUpDownY.Value = Settings.Default.CURSOR_Y;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            LeftMouseClick(Settings.Default.CURSOR_X, Settings.Default.CURSOR_Y);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://triqada.fi/");
        }
    }

}

