﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TeamArchitect.PowerTools.Features;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Patterning.Runtime;
using NServiceBusStudio.Automation.Extensions;

namespace NServiceBusHost.Automation.ValueProviders
{
    [CLSCompliant(false)]
    [DisplayName("Gets MessageEndpointMappingsConfig")]
    [Category("General")]
    [Description("Returns MessageEndpointMappingsConfig.")]
    public class MessageEndpointMappingsConfigProvider : ValueProvider
    {
        /// <summary>
        /// Gets or sets the current element.
        /// </summary>
        [Required]
        [Import(AllowDefault = true)]
        public IProductElement CurrentElement
        {
            get;
            set;
        }

        public override object Evaluate()
        {
            return (this.CurrentElement as IProduct).GetMessageEndpointMappingsConfig();
        }
    }
}
