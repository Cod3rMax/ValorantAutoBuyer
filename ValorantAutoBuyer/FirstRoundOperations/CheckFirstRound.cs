using System;
using System.IO;
using System.Reflection;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class CheckFirstRound
{
    
    public static Mat ValorantImage;
    public static Mat ValorantImageToGray = new Mat();
    public static Mat ValorantImageBlurred = new Mat();
    public static Mat ValorantImageSharppened = new Mat();
    public static Mat hsvImage = new Mat();
    public static Mat NeedleImage1 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\800needle.png"));
    
    
    public static void CheckIfFirstRound()
    {
        var hWind = Helper.ValorantWindow.FindWindow(IntPtr.Zero, "VALORANT  ");
        Helper.ValorantWindow.GetWindowRect(hWind, out Helper.ValorantWindow._rect);
        
        ValorantImage = new Mat(new OpenCvSharp.Size(Helper.ValorantScreenShot.TakeValorantScreenShot().Width, Helper.ValorantScreenShot.TakeValorantScreenShot().Height), MatType.CV_8UC3);
        
        while (true)
        {
            BitmapConverter.ToMat(Helper.ValorantScreenShot.TakeValorantScreenShot(), ValorantImage);
            // Cv2.CvtColor(ValorantImage, ValorantImageToGray, ColorConversionCodes.BGR2GRAY);
            // Cv2.GaussianBlur(ValorantImageToGray, ValorantImageBlurred, new OpenCvSharp.Size(3,3),1, 1, 0);
            // Cv2.Laplacian(ValorantImageBlurred, ValorantImageSharppened, MatType.CV_8UC1, 3);
                
            Cv2.CvtColor(ValorantImage, hsvImage, ColorConversionCodes.BGR2HSV);

            Mat mask = new Mat();
            Scalar lowerBound = new Scalar(0,0,160);
            Scalar upperBound = new Scalar(40,25,255);
                
            Cv2.InRange(hsvImage, lowerBound, upperBound, mask);
            Mat maskedImage = new Mat();
            Cv2.BitwiseAnd(ValorantImage, ValorantImage, maskedImage, mask);
                
            Cv2.ImShow("zeadzed", NeedleImage1);

            Cv2.WaitKey(10);
               
               
            GC.Collect();
        }
        
        
    }
}