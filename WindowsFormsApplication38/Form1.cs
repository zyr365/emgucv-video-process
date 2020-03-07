using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;
using Emgu.Util;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.Util.TypeEnum;

namespace WindowsFormsApplication38
{
    public partial class Form1 : Form
    {
        // Capture是Emgu.CV提供的摄像头控制类，里面的ImageGrabbed事件表示的是获取到图片后触发。可以用来实现模拟摄像头视频获取（其实是在picturebox中显示图片，由于很快，就跟视频一样）
        // Capture另一个非常关键的方法是QueryFrame（）这个方法是用来获取当前的摄像头捕捉到的图面。
        VideoCapture _capture;
        Mat frame = new Mat();
        public Form1()
        {
            InitializeComponent();
            _capture = new VideoCapture(@"C:\Users\Administrator\Desktop\video\vtest.avi");
           // _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameHeight, 300);
            //设置捕捉到帧的高度为320。
           // _capture.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.FrameWidth,
            //300);
            //设置捕捉到帧的宽度为240。
           // _capture.FlipHorizontal = true;
            //捕捉到帧数据进行水平翻转。
            _capture.ImageGrabbed += _capture_ImageGrabbed;

            _capture.Start();
           
        }

        void _capture_ImageGrabbed(object sender, EventArgs e)
        {
           

            _capture.Retrieve(frame, 0);

            //var frame1 = _capture.Retrieve(frame,0);
            captureImageBox.Image = frame;




        }
    }
}