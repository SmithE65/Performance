﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shared {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource1 {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource1() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Shared.Resource1", typeof(Resource1).Assembly);
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
        ///   Looks up a localized string similar to ;FLAVOR:Marlin
        ///;TIME:78824
        ///;Filament used: 56.8847m
        ///;Layer height: 0.2
        ///;MINX:46.007
        ///;MINY:79.556
        ///;MINZ:0.2
        ///;MAXX:307.012
        ///;MAXY:240.546
        ///;MAXZ:56.6
        ///;Generated with Cura_SteamEngine 5.2.1
        ///M140 S60
        ///M105
        ///M190 S60
        ///M104 S200
        ///M105
        ///M109 S200
        ///M82 ;absolute extrusion mode
        ///M201 X500.00 Y500.00 Z100.00 E5000.00 ;Setup machine max acceleration
        ///M203 X500.00 Y500.00 Z10.00 E50.00 ;Setup machine max feedrate
        ///M204 P500.00 R1000.00 T500.00 ;Setup Print/Retract/Travel acceleration
        ///M205 X8.00 Y8.00 Z0.40 E5 [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GCodeSample1 {
            get {
                return ResourceManager.GetString("GCodeSample1", resourceCulture);
            }
        }
    }
}