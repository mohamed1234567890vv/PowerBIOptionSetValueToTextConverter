using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace PowerBIOptionSetValueToTextConverter
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Power BI Option Set Value To Text Converter"),
        ExportMetadata("Description", "This tool generates a function in Power Query that takes a Dynamics CRM Option Set value as input and returns the corresponding Option Set text"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "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"),
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "Lavender"),
        ExportMetadata("PrimaryFontColor", "Black"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MyPlugin : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MyPluginControl();
        }

        /// <summary>
        /// Constructor 
        /// </summary>
        public MyPlugin()
        {
            // If you have external assemblies that you need to load, uncomment the following to 
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}