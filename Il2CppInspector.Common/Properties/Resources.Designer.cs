﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Il2CppInspector.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Il2CppInspector.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Generated C++ file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
        ///
        ///#define WIN32_LEAN_AND_MEAN
        ///#include &quot;windows.h&quot;
        ///#include &quot;dllmain.h&quot;
        ///
        ///// DLL entry point
        ///BOOL APIENTRY DllMain( HMODULE hModule,
        ///                       DWORD  ul_reason_for_call,
        ///                       LPVOID lpReserved
        ///                     )
        ///{
        ///    switch (ul_reason_for_call)
        ///    {
        ///    case DLL_PROCESS_ATTACH:
        ///        init_il2cpp();
        ///        CreateThread(NULL, 0, (LPTHREAD_START_ROUTINE) Run, NULL,  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Cpp_DLLMainCpp {
            get {
                return ResourceManager.GetString("Cpp-DLLMainCpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Generated C++ file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
        ///
        ///// Entry point declaration for custom injected code
        ///void Run();
        ///
        ///// IL2CPP initializer
        ///void init_il2cpp();.
        /// </summary>
        internal static string Cpp_DLLMainH {
            get {
                return ResourceManager.GetString("Cpp-DLLMainH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Generated C++ file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
        ///// Logging functions
        ///
        ///#define WIN32_LEAN_AND_MEAN
        ///#define WIN32_EXTRA_LEAN
        ///#include &lt;windows.h&gt;
        ///#include &quot;helpers.h&quot;
        ///
        ///// Write some text to the log file
        ///void LogWrite(std::string text)
        ///{
        ///    HANDLE hfile = CreateFileW(LOG_FILE, FILE_APPEND_DATA, FILE_SHARE_READ, NULL, OPEN_ALWAYS, FILE_ATTRIBUTE_NORMAL, NULL);
        ///
        ///    if (hfile == INVALID_HANDLE_VALUE)
        ///        MessageBox(0, L&quot;Could not open log file&quot;, 0,  [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Cpp_HelpersCpp {
            get {
                return ResourceManager.GetString("Cpp-HelpersCpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Generated C++ file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
        ///// Logging functions
        ///
        ///#pragma once
        ///#include &lt;string&gt;
        ///#include &lt;sstream&gt;
        ///#include &lt;iomanip&gt;
        ///
        ///extern const LPCWSTR LOG_FILE;
        ///
        ///// Helper function to append text to a file
        ///void LogWrite(std::string text);
        ///
        ///// Helper function to convert a pointer to hex
        ///template&lt;typename T&gt; std::string to_hex_string(T i) {
        ///    std::stringstream stream;
        ///    stream &lt;&lt; &quot;0x&quot; &lt;&lt; std::setfill(&apos;0&apos;) &lt;&lt; std::setw(sizeof(T) * 2) &lt;&lt; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Cpp_HelpersH {
            get {
                return ResourceManager.GetString("Cpp-HelpersH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Generated C++ file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
        ///// IL2CPP application initializer
        ///
        ///#pragma once
        ///
        ///#include &lt;cstdint&gt;
        ///
        ///// Application-specific types
        ///#include &quot;il2cpp-types.h&quot;
        ///
        ///// IL2CPP API function pointers
        ///#include &quot;il2cpp-function-ptr.h&quot;
        ///
        ///// IL2CPP APIs
        ///#define DO_API(r, n, p) r (*n) p
        ///#include &quot;il2cpp-api-functions.h&quot;
        ///#undef DO_API
        ///
        ///// Application-specific functions
        ///#define DO_APP_FUNC(a, r, n, p) r (*n) p
        ///#include &quot;il2cpp-functions.h&quot;
        ///#und [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string Cpp_IL2CPPInitH {
            get {
                return ResourceManager.GetString("Cpp-IL2CPPInitH", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to // Generated C++ file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
        ///// Custom injected code entry point
        ///
        ///#include &quot;il2cpp-init.h&quot;
        ///#include &quot;helpers.h&quot;
        ///
        ///using namespace app;
        ///
        ///// Set the name of your log file here
        ///extern const LPCWSTR LOG_FILE = L&quot;il2cpp-log.txt&quot;;
        ///
        ///// Injected code entry point
        ///void Run()
        ///{
        ///    LogWrite(&quot;Startup&quot;);
        ///
        ///    // Place your custom code here
        ///}.
        /// </summary>
        internal static string Cpp_MainCpp {
            get {
                return ResourceManager.GetString("Cpp-MainCpp", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project DefaultTargets=&quot;Build&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;ItemGroup Label=&quot;ProjectConfigurations&quot;&gt;
        ///    &lt;ProjectConfiguration Include=&quot;Debug|Win32&quot;&gt;
        ///      &lt;Configuration&gt;Debug&lt;/Configuration&gt;
        ///      &lt;Platform&gt;Win32&lt;/Platform&gt;
        ///    &lt;/ProjectConfiguration&gt;
        ///    &lt;ProjectConfiguration Include=&quot;Release|Win32&quot;&gt;
        ///      &lt;Configuration&gt;Release&lt;/Configuration&gt;
        ///      &lt;Platform&gt;Win32&lt;/Platform&gt;
        ///    &lt;/ProjectConfiguration&gt;
        ///    &lt;ProjectCon [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CppProjTemplate {
            get {
                return ResourceManager.GetString("CppProjTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft Visual Studio Solution File, Format Version 12.00
        ///# Visual Studio Version 16
        ///VisualStudioVersion = 16.0.30204.135
        ///MinimumVisualStudioVersion = 10.0.40219.1
        ///Project(&quot;{8BC9CEB8-8B4A-11D0-8D11-00A0C91BC942}&quot;) = &quot;%PROJECTNAME%&quot;, &quot;%PROJECTFILE%&quot;, &quot;{%PROJECTGUID%}&quot;
        ///EndProject
        ///Global
        ///	GlobalSection(SolutionConfigurationPlatforms) = preSolution
        ///		Debug|x64 = Debug|x64
        ///		Debug|x86 = Debug|x86
        ///		Release|x64 = Release|x64
        ///		Release|x86 = Release|x86
        ///	EndGlobalSection
        ///	GlobalSection(ProjectConfig [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CppSlnTemplate {
            get {
                return ResourceManager.GetString("CppSlnTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        ///&lt;Project ToolsVersion=&quot;4.0&quot; DefaultTargets=&quot;Build&quot; xmlns=&quot;http://schemas.microsoft.com/developer/msbuild/2003&quot;&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;LangVersion&gt;latest&lt;/LangVersion&gt;
        ///  &lt;/PropertyGroup&gt;
        ///  &lt;PropertyGroup&gt;
        ///    &lt;Configuration Condition=&quot; &apos;$(Configuration)&apos; == &apos;&apos; &quot;&gt;Debug&lt;/Configuration&gt;
        ///    &lt;Platform Condition=&quot; &apos;$(Platform)&apos; == &apos;&apos; &quot;&gt;AnyCPU&lt;/Platform&gt;
        ///    &lt;ProjectGuid&gt;{%PROJECTGUID%}&lt;/ProjectGuid&gt;
        ///    &lt;!--&lt;ProductVersion/&gt;--&gt;
        ///    &lt;!--&lt;SchemaVersion/&gt;--&gt;
        ///    &lt;OutputType&gt;Li [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string CsProjTemplate {
            get {
                return ResourceManager.GetString("CsProjTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Microsoft Visual Studio Solution File, Format Version 12.00
        ///# Visual Studio Version 16
        ///%PROJECTDEFINITIONS%
        ///Global
        ///	GlobalSection(SolutionConfigurationPlatforms) = preSolution
        ///		Debug|Any CPU = Debug|Any CPU
        ///		Release|Any CPU = Release|Any CPU
        ///	EndGlobalSection
        ///	GlobalSection(ProjectConfigurationPlatforms) = postSolution
        ///%PROJECTCONFIGURATIONS%
        ///	EndGlobalSection
        ///	GlobalSection(SolutionProperties) = preSolution
        ///		HideSolutionNode = FALSE
        ///	EndGlobalSection
        ///EndGlobal
        ///.
        /// </summary>
        internal static string CsSlnTemplate {
            get {
                return ResourceManager.GetString("CsSlnTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 		{%PROJECTGUID%}.Debug|Any CPU.ActiveCfg = Debug|Any CPU
        ///		{%PROJECTGUID%}.Debug|Any CPU.Build.0 = Debug|Any CPU
        ///		{%PROJECTGUID%}.Release|Any CPU.ActiveCfg = Release|Any CPU
        ///		{%PROJECTGUID%}.Release|Any CPU.Build.0 = Release|Any CPU
        ///.
        /// </summary>
        internal static string SlnProjectConfiguration {
            get {
                return ResourceManager.GetString("SlnProjectConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Project(&quot;{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}&quot;) = &quot;%PROJECTNAME%&quot;, &quot;%CSPROJRELATIVEPATH%&quot;, &quot;{%PROJECTGUID%}&quot;
        ///EndProject
        ///.
        /// </summary>
        internal static string SlnProjectDefinition {
            get {
                return ResourceManager.GetString("SlnProjectDefinition", resourceCulture);
            }
        }
    }
}
