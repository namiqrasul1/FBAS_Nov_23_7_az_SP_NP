using System;
using System.Security;
using System.Security.Permissions;

namespace Lesson1AppDomain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var appDomain = AppDomain.CreateDomain("BabatAppDomain");
            ////Virus virus = new Virus();

            //Type type = typeof(Virus);
            ////Console.WriteLine(type.FullName);
            ////Console.WriteLine(type.Name);
            ////Console.WriteLine(type.Assembly.FullName);

            //appDomain.CreateInstance(type.Assembly.FullName, type.FullName);

            //AppDomain.Unload(appDomain);
            //Console.ReadKey();

            var perm = new PermissionSet(PermissionState.None);
            perm.AddPermission(new FileIOPermission(FileIOPermissionAccess.NoAccess, "C://"));

            var setup = new AppDomainSetup();
            setup.ApplicationBase = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

            var appDomain = AppDomain.CreateDomain("BabatAppDomain", null, setup, perm);


            AppDomain.Unload(appDomain);

        }
    }

    class Virus
    {
        public Virus()
        {
            Console.WriteLine("Ogurluq vaxtidir!!!");
        }

        ~Virus()
        {
            Console.WriteLine("Ogurluq bitdi. Gedirem!");
        }
    }
}
