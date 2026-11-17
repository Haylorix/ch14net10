using System.Globalization;
//using System.Reflection;
//using System.Reflection.Emit;

WriteLine("This is an ahead-of-time (AOT) compiled app.");
WriteLine("Current culture: {0}", CultureInfo.CurrentCulture.DisplayName);
WriteLine("OS version: {0}", Environment.OSVersion);
Write("Press any key to exit.");
ReadKey(intercept: true);

//AssemblyBuilder ab = AssemblyBuilder.DefineDynamicAssembly(new AssemblyName("MyAssembly"), AssemblyBuilderAccess.Run);
