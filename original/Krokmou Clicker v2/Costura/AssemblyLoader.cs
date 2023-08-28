using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Costura
{
	// Token: 0x0200000E RID: 14
	[CompilerGenerated]
	internal static class AssemblyLoader
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000B16A File Offset: 0x0000936A
		private static string CultureToString(CultureInfo culture)
		{
			if (culture == null)
			{
				return "";
			}
			return culture.Name;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000B17C File Offset: 0x0000937C
		private static Assembly ReadExistingAssembly(AssemblyName name)
		{
			AppDomain currentDomain = AppDomain.CurrentDomain;
			Assembly[] assemblies = currentDomain.GetAssemblies();
			foreach (Assembly assembly in assemblies)
			{
				AssemblyName name2 = assembly.GetName();
				if (string.Equals(name2.Name, name.Name, StringComparison.InvariantCultureIgnoreCase) && string.Equals(AssemblyLoader.CultureToString(name2.CultureInfo), AssemblyLoader.CultureToString(name.CultureInfo), StringComparison.InvariantCultureIgnoreCase))
				{
					return assembly;
				}
			}
			return null;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000B1EC File Offset: 0x000093EC
		private static void CopyTo(Stream source, Stream destination)
		{
			byte[] array = new byte[81920];
			int count;
			while ((count = source.Read(array, 0, array.Length)) != 0)
			{
				destination.Write(array, 0, count);
			}
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000B220 File Offset: 0x00009420
		private static Stream LoadStream(string fullName)
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			if (fullName.EndsWith(".compressed"))
			{
				using (Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(fullName))
				{
					using (DeflateStream deflateStream = new DeflateStream(manifestResourceStream, CompressionMode.Decompress))
					{
						MemoryStream memoryStream = new MemoryStream();
						AssemblyLoader.CopyTo(deflateStream, memoryStream);
						memoryStream.Position = 0L;
						return memoryStream;
					}
				}
			}
			return executingAssembly.GetManifestResourceStream(fullName);
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000B2A4 File Offset: 0x000094A4
		private static Stream LoadStream(Dictionary<string, string> resourceNames, string name)
		{
			string fullName;
			if (resourceNames.TryGetValue(name, out fullName))
			{
				return AssemblyLoader.LoadStream(fullName);
			}
			return null;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000B2C4 File Offset: 0x000094C4
		private static byte[] ReadStream(Stream stream)
		{
			byte[] array = new byte[stream.Length];
			stream.Read(array, 0, array.Length);
			return array;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000B2EC File Offset: 0x000094EC
		private static Assembly ReadFromEmbeddedResources(Dictionary<string, string> assemblyNames, Dictionary<string, string> symbolNames, AssemblyName requestedAssemblyName)
		{
			string text = requestedAssemblyName.Name.ToLowerInvariant();
			if (requestedAssemblyName.CultureInfo != null && !string.IsNullOrEmpty(requestedAssemblyName.CultureInfo.Name))
			{
				text = requestedAssemblyName.CultureInfo.Name + "." + text;
			}
			byte[] rawAssembly;
			using (Stream stream = AssemblyLoader.LoadStream(assemblyNames, text))
			{
				if (stream == null)
				{
					return null;
				}
				rawAssembly = AssemblyLoader.ReadStream(stream);
			}
			using (Stream stream2 = AssemblyLoader.LoadStream(symbolNames, text))
			{
				if (stream2 != null)
				{
					byte[] rawSymbolStore = AssemblyLoader.ReadStream(stream2);
					return Assembly.Load(rawAssembly, rawSymbolStore);
				}
			}
			return Assembly.Load(rawAssembly);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000B3AC File Offset: 0x000095AC
		public static Assembly ResolveAssembly(object sender, ResolveEventArgs e)
		{
			object obj = AssemblyLoader.nullCacheLock;
			lock (obj)
			{
				if (AssemblyLoader.nullCache.ContainsKey(e.Name))
				{
					return null;
				}
			}
			AssemblyName assemblyName = new AssemblyName(e.Name);
			Assembly assembly = AssemblyLoader.ReadExistingAssembly(assemblyName);
			if (assembly != null)
			{
				return assembly;
			}
			assembly = AssemblyLoader.ReadFromEmbeddedResources(AssemblyLoader.assemblyNames, AssemblyLoader.symbolNames, assemblyName);
			if (assembly == null)
			{
				object obj2 = AssemblyLoader.nullCacheLock;
				lock (obj2)
				{
					AssemblyLoader.nullCache[e.Name] = true;
				}
				if ((assemblyName.Flags & AssemblyNameFlags.Retargetable) != AssemblyNameFlags.None)
				{
					assembly = Assembly.Load(assemblyName);
				}
			}
			return assembly;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000B484 File Offset: 0x00009684
		// Note: this type is marked as 'beforefieldinit'.
		static AssemblyLoader()
		{
			AssemblyLoader.assemblyNames.Add("bunifu.licensing", "costura.bunifu.licensing.dll.compressed");
			AssemblyLoader.symbolNames.Add("bunifu.licensing", "costura.bunifu.licensing.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("bunifu.ui.winforms.1.5.3", "costura.bunifu.ui.winforms.1.5.3.dll.compressed");
			AssemblyLoader.assemblyNames.Add("costura", "costura.costura.dll.compressed");
			AssemblyLoader.symbolNames.Add("costura", "costura.costura.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("guna.ui2", "costura.guna.ui2.dll.compressed");
			AssemblyLoader.assemblyNames.Add("metroframework.design", "costura.metroframework.design.dll.compressed");
			AssemblyLoader.assemblyNames.Add("metroframework", "costura.metroframework.dll.compressed");
			AssemblyLoader.assemblyNames.Add("metroframework.fonts", "costura.metroframework.fonts.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.hosting.abstractions", "costura.microsoft.aspnetcore.hosting.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.hosting.server.abstractions", "costura.microsoft.aspnetcore.hosting.server.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.http.abstractions", "costura.microsoft.aspnetcore.http.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.http.extensions", "costura.microsoft.aspnetcore.http.extensions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.http.features", "costura.microsoft.aspnetcore.http.features.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.routing.abstractions", "costura.microsoft.aspnetcore.routing.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.routing", "costura.microsoft.aspnetcore.routing.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.aspnetcore.staticfiles", "costura.microsoft.aspnetcore.staticfiles.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.bcl.asyncinterfaces", "costura.microsoft.bcl.asyncinterfaces.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.configuration.abstractions", "costura.microsoft.extensions.configuration.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.dependencyinjection.abstractions", "costura.microsoft.extensions.dependencyinjection.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.fileproviders.abstractions", "costura.microsoft.extensions.fileproviders.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.fileproviders.embedded", "costura.microsoft.extensions.fileproviders.embedded.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.hosting.abstractions", "costura.microsoft.extensions.hosting.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.logging.abstractions", "costura.microsoft.extensions.logging.abstractions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.objectpool", "costura.microsoft.extensions.objectpool.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.options", "costura.microsoft.extensions.options.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.primitives", "costura.microsoft.extensions.primitives.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.extensions.webencoders", "costura.microsoft.extensions.webencoders.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.net.http.headers", "costura.microsoft.net.http.headers.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.win32.registry.accesscontrol", "costura.microsoft.win32.registry.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.win32.registry", "costura.microsoft.win32.registry.dll.compressed");
			AssemblyLoader.assemblyNames.Add("microsoft.win32.systemevents", "costura.microsoft.win32.systemevents.dll.compressed");
			AssemblyLoader.assemblyNames.Add("newtonsoft.json", "costura.newtonsoft.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("opentk", "costura.opentk.dll.compressed");
			AssemblyLoader.symbolNames.Add("opentk", "costura.opentk.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("restsharp", "costura.restsharp.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.buffers", "costura.system.buffers.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.codedom", "costura.system.codedom.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.configuration.configurationmanager", "costura.system.configuration.configurationmanager.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.data.odbc", "costura.system.data.odbc.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.data.oledb", "costura.system.data.oledb.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.data.sqlclient", "costura.system.data.sqlclient.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.diagnosticsource", "costura.system.diagnostics.diagnosticsource.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.eventlog", "costura.system.diagnostics.eventlog.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.diagnostics.performancecounter", "costura.system.diagnostics.performancecounter.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.drawing.common", "costura.system.drawing.common.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.filesystem.accesscontrol", "costura.system.io.filesystem.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.packaging", "costura.system.io.packaging.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.pipes.accesscontrol", "costura.system.io.pipes.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.io.ports", "costura.system.io.ports.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.memory", "costura.system.memory.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.numerics.vectors", "costura.system.numerics.vectors.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.runtime.compilerservices.unsafe", "costura.system.runtime.compilerservices.unsafe.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.accesscontrol", "costura.system.security.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.cng", "costura.system.security.cryptography.cng.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.pkcs", "costura.system.security.cryptography.pkcs.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.protecteddata", "costura.system.security.cryptography.protecteddata.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.cryptography.xml", "costura.system.security.cryptography.xml.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.permissions", "costura.system.security.permissions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.security.principal.windows", "costura.system.security.principal.windows.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.duplex", "costura.system.servicemodel.duplex.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.duplex", "costura.system.servicemodel.duplex.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.http", "costura.system.servicemodel.http.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.http", "costura.system.servicemodel.http.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.nettcp", "costura.system.servicemodel.nettcp.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.nettcp", "costura.system.servicemodel.nettcp.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.primitives", "costura.system.servicemodel.primitives.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.primitives", "costura.system.servicemodel.primitives.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.security", "costura.system.servicemodel.security.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.servicemodel.security", "costura.system.servicemodel.security.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("system.servicemodel.syndication", "costura.system.servicemodel.syndication.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.serviceprocess.servicecontroller", "costura.system.serviceprocess.servicecontroller.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.text.encoding.codepages", "costura.system.text.encoding.codepages.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.text.encodings.web", "costura.system.text.encodings.web.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.text.json", "costura.system.text.json.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.threading.accesscontrol", "costura.system.threading.accesscontrol.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.threading.tasks.extensions", "costura.system.threading.tasks.extensions.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.valuetuple", "costura.system.valuetuple.dll.compressed");
			AssemblyLoader.assemblyNames.Add("system.web.services.description", "costura.system.web.services.description.dll.compressed");
			AssemblyLoader.symbolNames.Add("system.web.services.description", "costura.system.web.services.description.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("xamarin.forms.core", "costura.xamarin.forms.core.dll.compressed");
			AssemblyLoader.symbolNames.Add("xamarin.forms.core", "costura.xamarin.forms.core.pdb.compressed");
			AssemblyLoader.assemblyNames.Add("xamarin.forms.platform", "costura.xamarin.forms.platform.dll.compressed");
			AssemblyLoader.assemblyNames.Add("xamarin.forms.xaml", "costura.xamarin.forms.xaml.dll.compressed");
			AssemblyLoader.symbolNames.Add("xamarin.forms.xaml", "costura.xamarin.forms.xaml.pdb.compressed");
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000BB60 File Offset: 0x00009D60
		public static void Attach()
		{
			if (Interlocked.Exchange(ref AssemblyLoader.isAttached, 1) == 1)
			{
				return;
			}
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += AssemblyLoader.ResolveAssembly;
		}

		// Token: 0x040000B4 RID: 180
		private static object nullCacheLock = new object();

		// Token: 0x040000B5 RID: 181
		private static Dictionary<string, bool> nullCache = new Dictionary<string, bool>();

		// Token: 0x040000B6 RID: 182
		private static Dictionary<string, string> assemblyNames = new Dictionary<string, string>();

		// Token: 0x040000B7 RID: 183
		private static Dictionary<string, string> symbolNames = new Dictionary<string, string>();

		// Token: 0x040000B8 RID: 184
		private static int isAttached;
	}
}
