using Microsoft.SemanticKernel;
using System.ComponentModel;

namespace ConsoleApp17;

public class ColorMode
{
    public bool IsOn { get; set; } = false;

    [KernelFunction, Description("画面モードの状態を取得します。")]
    public string GetMode()
    {
        return IsOn ? "画面モードは黄色モード" : "画面モードは通常モード";
    }

    [KernelFunction, Description("画面モードを切り替えます。")]
    public string ToggleMode()
    {
        IsOn = !IsOn;
        if (IsOn)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;           
        }
        else
        {
            Console.ResetColor();
        }


        return GetMode();
    }
}
