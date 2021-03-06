﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractEndpoint;
using NServiceBusStudio;
using NServiceBusStudio.Core;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Patterning.Runtime;

namespace NServiceBusHost
{
    partial interface IComponentLink : IAbstractComponentLink
    {
    }

    partial class ComponentLink
    {
        public IEnumerable<IAbstractComponentLink> Siblings
        {
            get
            {
                return this.Parent.ComponentLinks;
            }
        }

        private ElementReference<IComponent> componentReference;

        public IElementReference<IComponent> ComponentReference
        {
            get
            {
                var components = this.As<IProductElement>().Root.As<NServiceBusStudio.IApplication>().Design.Services.Service.SelectMany(s => s.Components.Component);

                return this.componentReference ??
                    (this.componentReference = new ElementReference<IComponent>(
                        () => components,
                        new PropertyReference<string>(() => this.ComponentId, value => this.ComponentId = value),
                        new PropertyReference<string>(() => this.ComponentName, value => this.ComponentName = value)));
            }
        }

        partial void Initialize()
        {
            Action<object, EventArgs> nameChange = (sender, args) => this.InstanceName = this.ComponentReference.Value == null ? "(None)" : string.Format("{0:D2}. {1}.{2}", this.Order, this.ComponentReference.Value.Parent.Parent.InstanceName, this.ComponentReference.Value.InstanceName);

            this.ComponentIdChanged += new EventHandler(nameChange);
            this.OrderChanged += (sender, args) => { reorderNext(this); nameChange(sender, args); };
            if (this.ComponentReference.Value == null)
                this.InstanceName = "(None)";
            else
                nameChange(null, null);
        }

        public void SetNextOrderNumber()
        {
            var allOrders = this.Parent.ComponentLinks.Select(cl => cl.Order);

            this.Order = allOrders.Where(p => !allOrders.Any(s => s == (p + 1))).Min() + 1;

        }

        private void reorderNext(ComponentLink componentLink)
        {
            var next = componentLink.Parent.ComponentLinks.FirstOrDefault(s => s.Order == componentLink.Order && s != componentLink);
            if (next != null)
            {
                next.Order++;
            }
        }
    }
}
