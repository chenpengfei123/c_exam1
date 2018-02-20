using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.IO;
using System.Drawing;
using System.Web;
using System.Net;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace 免监考C语言晋级考试系统
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CameraHelper.IsDisplay = true;
            CameraHelper.SourcePlayer = player;
            CameraHelper.UpdateCameraDevices();
            if (CameraHelper.CameraDevices.Count > 0)
            {
                CameraHelper.SetCameraDevice(0);
            }
            //countdown countdown = new countdown();
        }

        private void btnCapture_Click(object sender, RoutedEventArgs e)
        {
           CameraHelper.CaptureImage(@"E:\1");
            //string fullPath = CameraHelper.CaptureImage(AppDomain.CurrentDomain.BaseDirectory + @"\Capture");
            //byte[] a = CameraHelper.CaptureImage();
            //MemoryStream ms = new MemoryStream(a);
            ////System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            //BitmapImage bit = new BitmapImage();
            ////BitmapImage bit =
            //bit.BeginInit();
            //bit.StreamSource = ms;
            //bit.EndInit();
            //image1.Source = bit;
        }

        private void btnOpenCamera_Click(object sender, RoutedEventArgs e)
        {
            
           
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult result = System.Windows.MessageBox.Show("确定是退出吗？", "询问", MessageBoxButton.YesNo, MessageBoxImage.Question);

            //关闭窗口
            if (result == MessageBoxResult.Yes)
            {
                e.Cancel = false;
                CameraHelper.CloseDevice();
            }
            //不关闭窗口
            if (result == MessageBoxResult.No)
                e.Cancel = true;
            //CameraHelper.CloseDevice();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            CameraHelper.CloseDevice();
        }

     

       
    }
}
