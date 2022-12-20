using OpenCvSharp;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class NeedleOperations
{
    
    
    public static void NeedleProcessor(Mat NeedleImage)
    {
        // Convert the needle image to gray
        Cv2.CvtColor(NeedleImage, FirstRoundOperations.ImageVariables.NeedleImageToGray, ColorConversionCodes.BGR2GRAY);
        
        // Blure the original valorant image
        Cv2.GaussianBlur(FirstRoundOperations.ImageVariables.NeedleImageToGray, FirstRoundOperations.ImageVariables.NeedleImageBlurred, new OpenCvSharp.Size(3,3),1, 1, 0);
        
        // Sharppen the needle image
        Cv2.Laplacian(FirstRoundOperations.ImageVariables.NeedleImageBlurred, FirstRoundOperations.ImageVariables.NeedleImageSharppened, MatType.CV_8UC1, 3);
        
        
    }
    
    
    
    
    
}