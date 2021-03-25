using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV.Structure;
using System.Windows.Forms;
using Emgu.CV.CvEnum;

namespace ImageDetectionDemo
{
    public partial class MainForm : Form
    {
        string detected, blurry;
        float contrast;
        VideoCapture _capture = new VideoCapture(0);

        Mat frame;
        ImageFilters imageFilters = new ImageFilters();
        public MainForm()
        {
            InitializeComponent();
        }
        public void setframe(Mat frame)
        {
            imageBox.Image = frame;
            facedetected.Text = imageFilters.facesDetection(frame);
            blurrylabel.Text = imageFilters.isImageBlurry(frame);
            contrastlabel.Text =""+ imageFilters.contrastOfImage(frame);
         
        }

        private void formload(object sender, EventArgs e)
        {
            //  IntelRealSense intel = new IntelRealSense(this);
            _capture.ImageGrabbed += ProcessFrame;
            frame = new Mat();
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

        public void setData(string detected,string blurry,float contrast)
        {
          
            facedetected.Text=detected;
            contrastlabel.Text = ""+contrast;
            blurrylabel.Text = blurry;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            if (_capture != null && _capture.Ptr != IntPtr.Zero)
            {
                _capture.Retrieve(frame);
                //   CvInvoke.Imshow("Capture  using opencv",_frame);
                //    CvInvoke.WaitKey(0);
                imageBox.Image = frame;
                facedetected.Invoke((MethodInvoker)(() => facedetected.Text = imageFilters.facesDetection(frame)));
                blurrylabel.Invoke((MethodInvoker)(() => blurrylabel.Text = imageFilters.isImageBlurry(frame)));
                contrastlabel.Invoke((MethodInvoker)(() => contrastlabel.Text =""+ imageFilters.contrastOfImage(frame)));

                //  facedetected.Text = imageFilters.facesDetection(frame);
              //  blurrylabel.Text = imageFilters.isImageBlurry(frame);
              //  contrastlabel.Text = "" + imageFilters.contrastOfImage(frame);


            }
        }
    }
}
