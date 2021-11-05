using System.Windows;

namespace UndertaleModTool
{
    public partial class App : Application
    {
        internal static void Main()
        {
            UndertaleModTool.App app = new UndertaleModTool.App();
            app.InitializeComponent();
            app.Run();
        }
    }
}

