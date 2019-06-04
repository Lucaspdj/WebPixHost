using System;
using System.Diagnostics;
using System.Threading;
using WpHostEntidade;

namespace WebPixHostContanier
{
    class Program
    {
        static void Main()
        {
            LaunchCommandLineApp();
        }

        /// <summary>
        /// Launch the legacy application with some options set.
        /// </summary>
        static void LaunchCommandLineApp()
        {
            var ListaMotores = Helper.ManipulateMotors.getMotors();
            foreach(Motores x in ListaMotores)
            {

                Process p = new Process();
                ProcessStartInfo psi = new ProcessStartInfo();

                psi.FileName = x.ArquivoBat;
                psi.CreateNoWindow = false;
                psi.UseShellExecute = false;
                psi.WindowStyle = ProcessWindowStyle.Hidden;
                p.StartInfo = psi;


                ThreadStart ths = new ThreadStart(() => p.Start());
                Thread th = new Thread(ths);
                th.Start();
            }

            Console.WriteLine("press [enter] to exit");
            Console.ReadLine();
        }
    }
}
