using OpenCvSharp;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class OriginalValorantSource
{
    public static void ImageOperationsOnOriginalImageSource(Mat OriginalImage)
    {
        // Convert the original valorant images to gray
        Cv2.CvtColor(OriginalImage, FirstRoundOperations.ImageVariables.ValorantImageToGray, ColorConversionCodes.BGR2GRAY);
            
        // Blure the original valorant images
        Cv2.GaussianBlur(FirstRoundOperations.ImageVariables.ValorantImageToGray, FirstRoundOperations.ImageVariables.ValorantImageBlurred, new OpenCvSharp.Size(3,3),1, 1, 0);
            
        // Sharppen the original image
        Cv2.Laplacian(FirstRoundOperations.ImageVariables.ValorantImageBlurred, FirstRoundOperations.ImageVariables.ValorantImageSharppened, MatType.CV_8UC1, 3);
            
        // Convert the original image to HSV
        Cv2.CvtColor(FirstRoundOperations.ImageVariables.ValorantImage, FirstRoundOperations.ImageVariables.HsvValorantImage, ColorConversionCodes.BGR2HSV);
            
        // Get the white color and mask everything else
        Cv2.InRange(FirstRoundOperations.ImageVariables.HsvValorantImage, new Scalar(0,0,160), new Scalar(40,25,255), FirstRoundOperations.ImageVariables.MaskValorantImage);
            
        // Make the operation to see the colors in real shape
        Cv2.BitwiseAnd(FirstRoundOperations.ImageVariables.ValorantImage, FirstRoundOperations.ImageVariables.ValorantImage, FirstRoundOperations.ImageVariables.MaskValorantImageBitOperationResult, FirstRoundOperations.ImageVariables.MaskValorantImage);

    }
}