using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using API.imports;
using Microsoft.Win32;
using API.functionESC;
using API.PROC;

namespace API
{
    public class VulneratAPI
    {
        public static string ihateniggers = @"
local oldr = request 
getgenv().request = function(options)
    if options.Headers then
        options.Headers[""User-Agent""] = ""Vulnerat/RobloxApp/2.1""
    else
        options.Headers = {[""User-Agent""] = ""Vulnerat/RobloxApp/2.1""}
    end
    local response = oldr(options)
    return response
end 
request = getgenv().request





local function identifyexecutor() return ""Vulnerat V69 2.0.0.0"" end
";
        private static bool Injected;
        private static bool autoinjected;

        public VulneratAPI()
        {
            Task.Run(async () =>
            {
                while (true)
                {
                    if (ProccesChecker.IsRobloxOpen() && autoinjected && !Injected)
                    {
                        dllimports.StartClient();
                    }
                    await Task.Delay(500);
                }
            });
        }
        public static void InjectGame()
        {
            dllimports.StartClient();
        }

        public static void ExecuteSync(string script)
        {
            string modify = ihateniggers + script;
            ESC.ESCexec(modify);
        }

        public static void AutoInjectSET()
        {
            autoinjected = true;
        }

        public static void OpenFile(System.Windows.Forms.TextBox editortext)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            if (openFileDialog1.ShowDialog() == true)
            {
                openFileDialog1.Title = "Open";
                editortext.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        public static void OpenFileMonacoWebBrowser(System.Windows.Forms.WebBrowser webBrowser)
        {
            OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog
            {
                Title = "Open",
                Filter = "Text Files|*.txt|All Files|*.*"
            };

            if (openFileDialog1.ShowDialog() == true)
            {
                string fileContent = File.ReadAllText(openFileDialog1.FileName);
                string escapedContent = fileContent.Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\n", "\\n").Replace("\r", "").Replace("\t", "");
                webBrowser.Document.InvokeScript("eval", new object[] { $"editor.setValue(\"{escapedContent}\");" });
            }
        }

    }
}
