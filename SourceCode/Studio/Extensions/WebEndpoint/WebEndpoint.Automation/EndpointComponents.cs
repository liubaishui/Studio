﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AbstractEndpoint;

namespace WebEndpoint
{
    partial class EndpointComponents : IAbstractEndpointComponents
    {
        public IAbstractComponentLink CreateComponentLink(string name, Action<IAbstractComponentLink> initializer = null, bool raiseInstantiateEvents = true)
        {
            var result = CreateComponentLink(name, new Action<IComponentLink>(initializer), raiseInstantiateEvents);
            result.SetNextOrderNumber();
            return result;
        }
        
        public IEnumerable<IAbstractComponentLink> AbstractComponentLinks
        {
            get
            {
                return this.ComponentLinks.Cast<IAbstractComponentLink>();
            }
        }
    }
}
