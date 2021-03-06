using System;
using UnityEditor.Modules;
namespace UnityEditor
{
	internal class EditorPluginImporterExtension : DefaultPluginImporterExtension
	{
		internal enum EditorPluginCPUArchitecture
		{
			AnyCPU,
			x86,
			x86_64
		}
		internal enum EditorPluginOSArchitecture
		{
			AnyOS,
			OSX,
			Windows,
			Linux
		}
		private EditorPluginImporterExtension.EditorPluginCPUArchitecture cpu;
		private EditorPluginImporterExtension.EditorPluginOSArchitecture os;
		public EditorPluginImporterExtension() : base(EditorPluginImporterExtension.GetProperties())
		{
		}
		private static DefaultPluginImporterExtension.Property[] GetProperties()
		{
			return new DefaultPluginImporterExtension.Property[]
			{
				new DefaultPluginImporterExtension.Property(EditorGUIUtility.TextContent("PluginImporter.EditorCPU"), "CPU", EditorPluginImporterExtension.EditorPluginCPUArchitecture.AnyCPU, BuildPipeline.GetEditorTargetName()),
				new DefaultPluginImporterExtension.Property(EditorGUIUtility.TextContent("PluginImporter.EditorOS"), "OS", EditorPluginImporterExtension.EditorPluginOSArchitecture.AnyOS, BuildPipeline.GetEditorTargetName())
			};
		}
	}
}
