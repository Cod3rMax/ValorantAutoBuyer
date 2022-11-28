using WindowsInput;
using WindowsInput.Native;

namespace ValorantAutoBuyer.Functions;

public class KeyboardInteraction
{
    public static void PressButtonB()
    {
        new InputSimulator().Keyboard.KeyPress(VirtualKeyCode.VK_B);
    }
}