using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ImageDetectionDemo
{
    class ImageFilters
    {
        CascadeClassifier faceCasacdeClassifier = new CascadeClassifier("haarcascade_frontalface_alt.xml");
        public String facesDetection(Mat img)
        {

            //Convert from Bgr to Gray Image
            Mat grayImage = new Mat();
            CvInvoke.CvtColor(img, grayImage, ColorConversion.Bgr2Gray);
            //Enhance the image to get better result
            CvInvoke.EqualizeHist(grayImage, grayImage);

            Rectangle[] faces = faceCasacdeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
            //If faces detected
            if (faces.Length > 0)
            {
                // Console.Write("Face:detected");
                return "Yes";
            }
            else
            {
                // Console.Write("Face:no face detected");
                return "No";
            }
        }
        public float contrastOfImage(Mat image)
        {
            Mat yccImage = new Mat(); //Define the yccImage variable and store the transformed graph
            CvInvoke.CvtColor(image, yccImage, ColorConversion.Bgr2YCrCb); //Color space conversion
            //[3] Separate yccImage to apply histogram equalization to its luma channel (Y channel)
            VectorOfMat channels = new VectorOfMat(); //Define the channel image after the channels store the split
            CvInvoke.Split(yccImage, channels); //Invoke the Split function to separate the yccImage color channel
            var contrast = channels[0].GetValueRange();//low(0)-High(1)
                                                       // Console.Write("Contrast is " + (contrast.Max - contrast.Min) / (contrast.Max + contrast.Min) + "\n");
            return (contrast.Max - contrast.Min) / (contrast.Max + contrast.Min);
        }
        public string isImageBlurry(Mat image)
        {
            var laplacian = new Mat();
            var yccImage = new Mat();
            //load the image, convert it to grayscale, and compute the
            //focus measure of the image using the Variance of Laplacian
            //method
            CvInvoke.CvtColor(image, yccImage, ColorConversion.Bgr2Gray);
            CvInvoke.Laplacian(yccImage, laplacian, DepthType.Cv64F);
            string text = "Not Blurry";
            //if the focus measure is less than the supplied threshold,
            //then the image should be considered "blurry"
            var sngMean = new Mat();
            var sngStDev = new Mat();
            CvInvoke.MeanStdDev(laplacian, sngMean, sngStDev);
            // Console.Write(sngStDev.GetData().GetValue(0,0));
            var variance = Math.Pow(Convert.ToDouble(sngStDev.GetData().GetValue(0, 0)), 2);
            //laplacian = sngStDev * sngStDev;

            if (variance < 100.0)
            {
                text = "Blurry";
                return "Yes";

            }
            return "No";
          //  Console.Write(text+'\n');
        }
    }
}
