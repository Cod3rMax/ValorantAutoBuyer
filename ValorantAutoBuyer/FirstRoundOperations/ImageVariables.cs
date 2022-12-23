using System;
using System.IO;
using System.Reflection;
using System.Web.UI;
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
    public static Mat NeedleImage2 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\800needle2.png"));
    public static Mat NeedleImage3 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\800needle3.png"));
    
    public static Mat FirstRoundOfHalf1 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\FirstRoundOfHalf1.png"));
    public static Mat FirstRoundOfHalf2 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\FirstRoundOfHalf2.png"));
    public static Mat FirstRoundOfHalf3 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\FirstRoundOfHalf3.png"));
    public static Mat FirstRoundOfHalf4 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\FirstRoundOfHalf4.png"));
    public static Mat FirstRoundOfHalf5 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\FirstRoundOfHalf5.png"));
    public static Mat FirstRoundOfHalf6 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\FirstRoundOfHalf6.png"));
    public static Mat FirstRoundOfHalf7 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\FirstRoundOfHalf7.png"));
    public static Mat FirstRoundOfHalf8 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\FirstRoundOfHalf8.png"));
    public static Mat FirstRoundOfHalf9 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\FirstRoundOfHalf9.png"));
    
    
    public static Mat AutoLockAgentNeedle1 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\AutoLockAgentNeedle1.png"));
    public static Mat AutoLockAgentNeedle2 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\AutoLockAgentNeedle2.png"));
    public static Mat AutoLockAgentNeedle3 = Cv2.ImRead(Path.Combine (Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"FirstRoundOperations\Needles\AutoLockAgentNeedle3.png"));
    
    
    public static Mat NeedleImageToGray = new Mat();
    public static Mat NeedleImageBlurred = new Mat();
    public static Mat NeedleImageSharppened = new Mat();
    public static Mat HsvNeedleImage = new Mat();
    public static Mat MaskNeedleImage = new Mat();
    public static Mat MaskNeedleImageBitOperationResult = new Mat();

    public static Mat MatchResultImage = new Mat();
    
    public static Double maxVal;
    public static Point maxLoc;
    
    

}