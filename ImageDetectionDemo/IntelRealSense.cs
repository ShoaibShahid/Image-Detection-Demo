using Emgu.CV;
using Emgu.CV.CvEnum;
//using Intel.RealSense;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageDetectionDemo
{
    class IntelRealSense
    {
       // Pipeline pipeline = new Pipeline();
        MainForm mainForm;
        VideoCapture _capture = new VideoCapture(1);
      
        Mat _frame;
       
        public IntelRealSense(MainForm form)
        {
            this.mainForm = form;
            _capture.ImageGrabbed += ProcessFrame;
            _frame = new Mat();
            if (_capture != null)
            {
                try
                {
                    _capture.Start();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
      /*  public void findDevices()
        {
            var ctx = new Context();
            var devices = ctx.QueryDevices();
            Console.WriteLine("There are {0} connected RealSense devices.", devices.Count);
            if (devices.Count == 0)
            {
                Console.ReadKey();
                return;
            }
            var dev = devices[0];
            Console.WriteLine("\nUsing device 0, an {0}", dev.Info[CameraInfo.Name]);
            Console.WriteLine("    Serial number: {0}", dev.Info[CameraInfo.SerialNumber]);
            Console.WriteLine("    Firmware version: {0}", dev.Info[CameraInfo.FirmwareVersion]);
            Console.ReadKey();

        }
        public void capture()
        {
            var cfg = new Config();
            cfg.EnableStream(Intel.RealSense.Stream.Depth, 640, 480);
            cfg.EnableStream(Intel.RealSense.Stream.Color, Format.Rgb8);
            pipeline.Start(cfg);

            for (int i = 0; i < 5; i++)
            {
                var sframes = pipeline.WaitForFrames();
            }

            var frames = pipeline.WaitForFrames(3000);//.Take(1).ToArray();
            var frame = frames.ColorFrame;
            var depth = frames.DepthFrame;

            //  Size size = new Size(frame.Height, frame.Width);
            Size size = new Size(640, 480);
            Mat frame1 = new Mat(size, DepthType.Cv16U, 3, frame.Data, 2);
            CvInvoke.Imshow("framecapture", frame1);
            /*  Mat frame2 = new Mat(size, DepthType.Cv16U, 3, frame[1].Data, 0);
              CvInvoke.Imshow("frame2capture", frame2);
            pipeline.Stop();

            CvInvoke.WaitKey(0);
        }*/

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(_frame);
             //   CvInvoke.Imshow("Capture  using opencv",_frame);
             //    CvInvoke.WaitKey(0);
            //    mainForm.setframe(_frame);
               
            }
        }


    }
}
