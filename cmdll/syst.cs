using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Hosting;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace cmdll
{
    
    public static class Func
        
    {
        private static readonly string File = "Run";
        private static String arg;




        public static object run(string who) {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("who");

            Process process = new Process();
            process.StartInfo = processStartInfo;
            processStartInfo.FileName = File;
            processStartInfo.Arguments = who;
            processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            if (!process.Start())
            {
                
                
            }
            else { MessageBox.Show("Error", "неправильно указан путь!", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            return 0;
        } 
        



        public static int Start(String who) {
            Process.Start(who);
            return 0; }
        public static int Cmd(String who) {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c{who}",
                WindowStyle = ProcessWindowStyle.Hidden
            }).WaitForExit();
            return 0; }
    }
}
