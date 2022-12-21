using System;
using OpenCvSharp;

namespace ValorantAutoBuyer.FirstRoundOperations;

public class MatchTemplateToGetFirstRound
{

    public static void GetPredictionMatchForFirstRound(Mat srcImage, Mat template)
    {
        
        Cv2.MatchTemplate(srcImage, template, FirstRoundOperations.ImageVariables.MatchResultImage, TemplateMatchModes.CCoeffNormed);
        FirstRoundOperations.ImageVariables.MatchResultImage.MinMaxLoc(out _,out FirstRoundOperations.ImageVariables.maxVal,out _,out FirstRoundOperations.ImageVariables.maxLoc);
        
        // Just to draw the result to see
        // FirstRoundOperations.ImageVariables.ValorantImage.Rectangle(new OpenCvSharp.Point(FirstRoundOperations.ImageVariables.maxLoc.X, FirstRoundOperations.ImageVariables.maxLoc.Y),
        // new OpenCvSharp.Point(FirstRoundOperations.ImageVariables.maxLoc.X + template.Width , FirstRoundOperations.ImageVariables.maxLoc.Y + template.Height),
        // Scalar.Red);
    }
    
    
    
    
    
}