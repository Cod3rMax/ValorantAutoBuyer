using System.IO;
using System.Reflection;
using OpenCvSharp;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class ImageVariables
{
    public static Mat ValorantImage;
    public static Mat ValorantImageToGray = new Mat();
    public static Mat ValorantImageBlurred = new Mat();
    public static Mat ValorantImageSharppened = new Mat();
    public static Mat HsvValorantImage = new Mat();
    public static Mat MaskValorantImage = new Mat();
    public static Mat MaskValorantImageBitOperationResult = new Mat();
    
    
    public static Mat NeedleImage1 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\800needle.png"));
    public static Mat NeedleImageToGray = new Mat();
    
    
    
    
    
    
    
    
}