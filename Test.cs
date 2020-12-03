using RenameMe;
using System;
using System.Reflection;

namespace Test
{
	class TestCls
	{
		static TestCls()
		{
			Console.WriteLine("Pre-add AssemblyResolve");
			AppDomain.CurrentDomain.AssemblyResolve += TestCls.OnAssemblyResolve;
			Console.WriteLine("Post-add AssemblyResolve");
		}

		private static void Main(string[] args) {
			Console.WriteLine("Test.Main IsWorking: {0}", RenameMeCls.IsWorking);
		}

		private static Assembly OnAssemblyResolve(object sender, ResolveEventArgs args)
		{
			Console.WriteLine("OnAssemblyResolve!");
			if (args.Name.Contains("RenameMe"))
			{
				return Assembly.LoadFrom("Renamed.exe");
			}
			return null;
		}
	}

}
