using OpenCvSharp;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class NeedleOperations
{
    
    
    public static void NeedleProcessor(Mat NeedleImage)
    {
        // Convert the needle image to gray
        Cv2.CvtColor(NeedleImage, FirstRoundOperations.ImageVariables.NeedleImageToGray, ColorConversionCodes.BGR2GRAY);
    }
    
    
    
    
    
}