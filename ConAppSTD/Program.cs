using System;
using ConAppSTD.Class;

namespace ConAppSTD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                cConsole.DisableQuickEdit();
                new cMQReceiver().C_MQRxProcess();
            }
            catch (Exception)
            {

            }
        }
    }
}
