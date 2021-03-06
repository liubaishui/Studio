﻿using System;
using System.ComponentModel.Composition;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.ComponentModelHost;
using Microsoft.VisualStudio.Patterning.Extensibility;
using Microsoft.VisualStudio.Patterning.Runtime.Shell.Properties;
using Microsoft.VisualStudio.Patterning.Runtime.UI;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.TeamArchitect.PowerTools.Features;

namespace NServiceBusStudio.Automation.CustomSolutionBuilder.Views
{
    [Guid("ED9FB3C8-D7B6-43FC-A596-132EF7B38B5D")]
    public class NServiceBusDetailsToolWindow : ToolWindowPane
    {
        public NServiceBusDetailsToolWindow()
        {
            this.Caption = "NServiceBus Studio Details";
            this.BitmapResourceID = 301;
            this.BitmapIndex = 0;
            var pane = new DetailsPanel();
            pane.CaptionHasChanged += (s, e) =>
                {
                    this.Caption = pane.Caption;
                };
            this.Content = pane;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }
    }
}
