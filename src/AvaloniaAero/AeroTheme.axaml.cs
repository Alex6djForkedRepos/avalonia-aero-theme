using System;
using System.Diagnostics;
using System.IO;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Markup.Xaml.Styling;
using Avalonia.Styling;

namespace AvaloniaAero
{
    /// <summary>
    /// Includes the aero theme in an application.
    /// </summary>
    public sealed partial class AeroTheme
        : Styles
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AeroTheme"/> class.
        /// </summary>
        public AeroTheme()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}