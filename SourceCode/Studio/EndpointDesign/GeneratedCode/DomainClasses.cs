﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
namespace NServiceBus.Modeling.EndpointDesign
{
	/// <summary>
	/// DomainClass EndpointModel
	/// The root in which all other elements are embedded. Appears as a diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("NServiceBus.Modeling.EndpointDesign.EndpointModel.DisplayName", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NServiceBus.Modeling.EndpointDesign.EndpointModel.Description", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("18842bda-0564-4835-bd10-69a56e7903b1")]
	public partial class EndpointModel : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// EndpointModel domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x18842bda, 0x0564, 0x4835, 0xbd, 0x10, 0x69, 0xa5, 0x6e, 0x79, 0x03, 0xb1);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public EndpointModel(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public EndpointModel(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Events opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Events.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.EndpointModel
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Event> Events
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Event>, Event>(global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.EndpointModelDomainRoleId);
			}
		}
		#endregion
		#region Endpoints opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Endpoints.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.EndpointModel
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Endpoint> Endpoints
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Endpoint>, Endpoint>(global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.EndpointModelDomainRoleId);
			}
		}
		#endregion
		#region Commands opposite domain role accessor
		
		/// <summary>
		/// Gets a list of Commands.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.EndpointModel
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Command> Commands
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Command>, Command>(global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.EndpointModelDomainRoleId);
			}
		}
		#endregion
		#region ElementGroupPrototype Merge methods
		/// <summary>
		/// Returns a value indicating whether the source element represented by the
		/// specified root ProtoElement can be added to this element.
		/// </summary>
		/// <param name="rootElement">
		/// The root ProtoElement representing a source element.  This can be null, 
		/// in which case the ElementGroupPrototype does not contain an ProtoElements
		/// and the code should inspect the ElementGroupPrototype context information.
		/// </param>
		/// <param name="elementGroupPrototype">The ElementGroupPrototype that contains the root ProtoElement.</param>
		/// <returns>true if the source element represented by the ProtoElement can be added to this target element.</returns>
		protected override bool CanMerge(DslModeling::ProtoElementBase rootElement, DslModeling::ElementGroupPrototype elementGroupPrototype)
		{
			if ( elementGroupPrototype == null ) throw new global::System.ArgumentNullException("elementGroupPrototype");
			
			if (rootElement != null)
			{
				DslModeling::DomainClassInfo rootElementDomainInfo = this.Partition.DomainDataDirectory.GetDomainClass(rootElement.DomainClassId);
				
				if (rootElementDomainInfo.IsDerivedFrom(global::NServiceBus.Modeling.EndpointDesign.Event.DomainClassId)) 
				{
					return true;
				}
				
				if (rootElementDomainInfo.IsDerivedFrom(global::NServiceBus.Modeling.EndpointDesign.Endpoint.DomainClassId)) 
				{
					return true;
				}
				
				if (rootElementDomainInfo.IsDerivedFrom(global::NServiceBus.Modeling.EndpointDesign.Command.DomainClassId)) 
				{
					return true;
				}
			}
			return base.CanMerge(rootElement, elementGroupPrototype);
		}
		
		/// <summary>
		/// Called by the Merge process to create a relationship between 
		/// this target element and the specified source element. 
		/// Typically, a parent-child relationship is established
		/// between the target element (the parent) and the source element 
		/// (the child), but any relationship can be established.
		/// </summary>
		/// <param name="sourceElement">The element that is to be related to this model element.</param>
		/// <param name="elementGroup">The group of source ModelElements that have been rehydrated into the target store.</param>
		/// <remarks>
		/// This method is overriden to create the relationship between the target element and the specified source element.
		/// The base method does nothing.
		/// </remarks>
		protected override void MergeRelate(DslModeling::ModelElement sourceElement, DslModeling::ElementGroup elementGroup)
		{
			// In general, sourceElement is allowed to be null, meaning that the elementGroup must be parsed for special cases.
			// However this is not supported in generated code.  Use double-deriving on this class and then override MergeRelate completely if you 
			// need to support this case.
			if ( sourceElement == null ) throw new global::System.ArgumentNullException("sourceElement");
		
				
			global::NServiceBus.Modeling.EndpointDesign.Event sourceEvent1 = sourceElement as global::NServiceBus.Modeling.EndpointDesign.Event;
			if (sourceEvent1 != null)
			{
				// Create link for path EndpointModelHasEvents.Events
				this.Events.Add(sourceEvent1);

				return;
			}
				
			global::NServiceBus.Modeling.EndpointDesign.Endpoint sourceEndpoint2 = sourceElement as global::NServiceBus.Modeling.EndpointDesign.Endpoint;
			if (sourceEndpoint2 != null)
			{
				// Create link for path EndpointModelHasEndpoints.Endpoints
				this.Endpoints.Add(sourceEndpoint2);

				return;
			}
				
			global::NServiceBus.Modeling.EndpointDesign.Command sourceCommand3 = sourceElement as global::NServiceBus.Modeling.EndpointDesign.Command;
			if (sourceCommand3 != null)
			{
				// Create link for path EndpointModelHasCommands.Commands
				this.Commands.Add(sourceCommand3);

				return;
			}
		
			// Sdk workaround to runtime bug #879350 (DSL: can't copy and paste a MEL that has a MEX). Avoid MergeRelate on ModelElementExtension
			// during a "Paste".
			if (sourceElement is DslModeling::ExtensionElement
				&& sourceElement.Store.TransactionManager.CurrentTransaction.TopLevelTransaction.Context.ContextInfo.ContainsKey("{9DAFD42A-DC0E-4d78-8C3F-8266B2CF8B33}"))
			{
				return;
			}
		
			// Fall through to base class if this class hasn't handled the merge.
			base.MergeRelate(sourceElement, elementGroup);
		}
		
		/// <summary>
		/// Performs operation opposite to MergeRelate - i.e. disconnects a given
		/// element from the current one (removes links created by MergeRelate).
		/// </summary>
		/// <param name="sourceElement">Element to be unmerged/disconnected.</param>
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
		protected override void MergeDisconnect(DslModeling::ModelElement sourceElement)
		{
			if (sourceElement == null) throw new global::System.ArgumentNullException("sourceElement");
				
			global::NServiceBus.Modeling.EndpointDesign.Event sourceEvent1 = sourceElement as global::NServiceBus.Modeling.EndpointDesign.Event;
			if (sourceEvent1 != null)
			{
				// Delete link for path EndpointModelHasEvents.Events
				
				foreach (DslModeling::ElementLink link in global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.GetLinks((global::NServiceBus.Modeling.EndpointDesign.EndpointModel)this, sourceEvent1))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.EndpointModelDomainRoleId, global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.EventDomainRoleId);
				}

				return;
			}
				
			global::NServiceBus.Modeling.EndpointDesign.Endpoint sourceEndpoint2 = sourceElement as global::NServiceBus.Modeling.EndpointDesign.Endpoint;
			if (sourceEndpoint2 != null)
			{
				// Delete link for path EndpointModelHasEndpoints.Endpoints
				
				foreach (DslModeling::ElementLink link in global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.GetLinks((global::NServiceBus.Modeling.EndpointDesign.EndpointModel)this, sourceEndpoint2))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.EndpointModelDomainRoleId, global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.EndpointDomainRoleId);
				}

				return;
			}
				
			global::NServiceBus.Modeling.EndpointDesign.Command sourceCommand3 = sourceElement as global::NServiceBus.Modeling.EndpointDesign.Command;
			if (sourceCommand3 != null)
			{
				// Delete link for path EndpointModelHasCommands.Commands
				
				foreach (DslModeling::ElementLink link in global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.GetLinks((global::NServiceBus.Modeling.EndpointDesign.EndpointModel)this, sourceCommand3))
				{
					// Delete the link, but without possible delete propagation to the element since it's moving to a new location.
					link.Delete(global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.EndpointModelDomainRoleId, global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.CommandDomainRoleId);
				}

				return;
			}
			// Fall through to base class if this class hasn't handled the unmerge.
			base.MergeDisconnect(sourceElement);
		}
		#endregion
	}
}
namespace NServiceBus.Modeling.EndpointDesign
{
	/// <summary>
	/// DomainClass SendEndpoint
	/// Elements embedded in the model. Appear as boxes on the diagram.
	/// </summary>
	[DslDesign::DisplayNameResource("NServiceBus.Modeling.EndpointDesign.SendEndpoint.DisplayName", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NServiceBus.Modeling.EndpointDesign.SendEndpoint.Description", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("e21c4731-2726-4484-8fac-640a7335b17b")]
	public partial class SendEndpoint : Endpoint
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// SendEndpoint domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xe21c4731, 0x2726, 0x4484, 0x8f, 0xac, 0x64, 0x0a, 0x73, 0x35, 0xb1, 0x7b);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public SendEndpoint(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public SendEndpoint(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region EmittedCommands opposite domain role accessor
		
		/// <summary>
		/// Gets a list of EmittedCommands.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.SendEndpointEmitsCommands.SendEndpoint
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Command> EmittedCommands
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Command>, Command>(global::NServiceBus.Modeling.EndpointDesign.SendEndpointEmitsCommands.SendEndpointDomainRoleId);
			}
		}
		#endregion
	}
}
namespace NServiceBus.Modeling.EndpointDesign
{
	/// <summary>
	/// DomainClass NamedElement
	/// Description for NServiceBus.Modeling.EndpointDesign.NamedElement
	/// </summary>
	[DslDesign::DisplayNameResource("NServiceBus.Modeling.EndpointDesign.NamedElement.DisplayName", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NServiceBus.Modeling.EndpointDesign.NamedElement.Description", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel))]
	[global::System.CLSCompliant(true)]
	[global::System.Diagnostics.DebuggerDisplay("{GetType().Name,nq} (Name = {namePropertyStorage})")]
	[DslModeling::DomainObjectId("fb4969d1-0587-4190-9e24-58ed1027cf0e")]
	public abstract partial class NamedElement : DslModeling::ModelElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// NamedElement domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xfb4969d1, 0x0587, 0x4190, 0x9e, 0x24, 0x58, 0xed, 0x10, 0x27, 0xcf, 0x0e);
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		protected NamedElement(DslModeling::Partition partition, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Name domain property code
		
		/// <summary>
		/// Name domain property Id.
		/// </summary>
		public static readonly global::System.Guid NameDomainPropertyId = new global::System.Guid(0x11d22a89, 0x919a, 0x48fe, 0xaa, 0xef, 0xd3, 0x19, 0x86, 0xcd, 0xab, 0x2d);
		
		/// <summary>
		/// Storage for Name
		/// </summary>
		private global::System.String namePropertyStorage = string.Empty;
		
		/// <summary>
		/// Gets or sets the value of Name domain property.
		/// Description for NServiceBus.Modeling.EndpointDesign.NamedElement.Name
		/// </summary>
		[DslDesign::DisplayNameResource("NServiceBus.Modeling.EndpointDesign.NamedElement/Name.DisplayName", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
		[DslDesign::CategoryResource("NServiceBus.Modeling.EndpointDesign.NamedElement/Name.Category", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("NServiceBus.Modeling.EndpointDesign.NamedElement/Name.Description", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
		[DslModeling::ElementName]
		[DslModeling::DomainObjectId("11d22a89-919a-48fe-aaef-d31986cdab2d")]
		public global::System.String Name
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return namePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				NamePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the NamedElement.Name domain property.
		/// </summary>
		internal sealed partial class NamePropertyHandler : DslModeling::DomainPropertyValueHandler<NamedElement, global::System.String>
		{
			private NamePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the NamedElement.Name domain property value handler.
			/// </summary>
			public static readonly NamePropertyHandler Instance = new NamePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the NamedElement.Name domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return NameDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::System.String GetValue(NamedElement element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.namePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(NamedElement element, global::System.String newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::System.String oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.namePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
	}
}
namespace NServiceBus.Modeling.EndpointDesign
{
	/// <summary>
	/// DomainClass SendReceiveEndpoint
	/// Description for NServiceBus.Modeling.EndpointDesign.SendReceiveEndpoint
	/// </summary>
	[DslDesign::DisplayNameResource("NServiceBus.Modeling.EndpointDesign.SendReceiveEndpoint.DisplayName", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NServiceBus.Modeling.EndpointDesign.SendReceiveEndpoint.Description", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("f2b8d64e-2f61-4da1-ab47-65803bb9a09a")]
	public partial class SendReceiveEndpoint : Endpoint
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// SendReceiveEndpoint domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xf2b8d64e, 0x2f61, 0x4da1, 0xab, 0x47, 0x65, 0x80, 0x3b, 0xb9, 0xa0, 0x9a);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public SendReceiveEndpoint(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public SendReceiveEndpoint(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region ProcessCommands opposite domain role accessor
		
		/// <summary>
		/// Gets a list of ProcessCommands.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.CommandIsProcessedBySendReceiveEndpoint.SendReceiveEndpoint
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Command> ProcessCommands
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Command>, Command>(global::NServiceBus.Modeling.EndpointDesign.CommandIsProcessedBySendReceiveEndpoint.SendReceiveEndpointDomainRoleId);
			}
		}
		#endregion
		#region ProcessEvents opposite domain role accessor
		
		/// <summary>
		/// Gets a list of ProcessEvents.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.EventsAreProcessedBySendReceiveEndpoints.SendReceiveEndpoint
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Event> ProcessEvents
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Event>, Event>(global::NServiceBus.Modeling.EndpointDesign.EventsAreProcessedBySendReceiveEndpoints.SendReceiveEndpointDomainRoleId);
			}
		}
		#endregion
		#region EmittedEvents opposite domain role accessor
		
		/// <summary>
		/// Gets a list of EmittedEvents.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitsEvents.SendReceiveEndpoint
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Event> EmittedEvents
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Event>, Event>(global::NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitsEvents.SendReceiveEndpointDomainRoleId);
			}
		}
		#endregion
		#region EmittedCommands opposite domain role accessor
		
		/// <summary>
		/// Gets a list of EmittedCommands.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitCommands.SendReceiveEndpoint
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<Command> EmittedCommands
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<Command>, Command>(global::NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitCommands.SendReceiveEndpointDomainRoleId);
			}
		}
		#endregion
	}
}
namespace NServiceBus.Modeling.EndpointDesign
{
	/// <summary>
	/// DomainClass Event
	/// Description for NServiceBus.Modeling.EndpointDesign.Event
	/// </summary>
	[DslDesign::DisplayNameResource("NServiceBus.Modeling.EndpointDesign.Event.DisplayName", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NServiceBus.Modeling.EndpointDesign.Event.Description", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("0ba0f6e6-7c0c-4ab0-9f68-7e5330b858a3")]
	public partial class Event : NamedElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Event domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x0ba0f6e6, 0x7c0c, 0x4ab0, 0x9f, 0x68, 0x7e, 0x53, 0x30, 0xb8, 0x58, 0xa3);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Event(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Event(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region EndpointModel opposite domain role accessor
		/// <summary>
		/// Gets or sets EndpointModel.
		/// Description for NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.Event
		/// </summary>
		public virtual EndpointModel EndpointModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.EventDomainRoleId) as EndpointModel;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEvents.EventDomainRoleId, value);
			}
		}
		#endregion
		#region ProcessingEndpoints opposite domain role accessor
		
		/// <summary>
		/// Gets a list of ProcessingEndpoints.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.EventsAreProcessedBySendReceiveEndpoints.Event
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<SendReceiveEndpoint> ProcessingEndpoints
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<SendReceiveEndpoint>, SendReceiveEndpoint>(global::NServiceBus.Modeling.EndpointDesign.EventsAreProcessedBySendReceiveEndpoints.EventDomainRoleId);
			}
		}
		#endregion
		#region EmitterEndpoint opposite domain role accessor
		
		/// <summary>
		/// Gets a list of EmitterEndpoint.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitsEvents.Event
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<SendReceiveEndpoint> EmitterEndpoint
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<SendReceiveEndpoint>, SendReceiveEndpoint>(global::NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitsEvents.EventDomainRoleId);
			}
		}
		#endregion
	}
}
namespace NServiceBus.Modeling.EndpointDesign
{
	/// <summary>
	/// DomainClass Command
	/// Description for NServiceBus.Modeling.EndpointDesign.Command
	/// </summary>
	[DslDesign::DisplayNameResource("NServiceBus.Modeling.EndpointDesign.Command.DisplayName", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NServiceBus.Modeling.EndpointDesign.Command.Description", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("84f56034-ebeb-47e5-9bf6-e7ee36e36218")]
	public partial class Command : NamedElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Command domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x84f56034, 0xebeb, 0x47e5, 0x9b, 0xf6, 0xe7, 0xee, 0x36, 0xe3, 0x62, 0x18);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Command(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public Command(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region EndpointModel opposite domain role accessor
		/// <summary>
		/// Gets or sets EndpointModel.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.Command
		/// </summary>
		public virtual EndpointModel EndpointModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.CommandDomainRoleId) as EndpointModel;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasCommands.CommandDomainRoleId, value);
			}
		}
		#endregion
		#region ProcessingEndpoint opposite domain role accessor
		
		/// <summary>
		/// Gets a list of ProcessingEndpoint.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.CommandIsProcessedBySendReceiveEndpoint.Command
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<SendReceiveEndpoint> ProcessingEndpoint
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<SendReceiveEndpoint>, SendReceiveEndpoint>(global::NServiceBus.Modeling.EndpointDesign.CommandIsProcessedBySendReceiveEndpoint.CommandDomainRoleId);
			}
		}
		#endregion
		#region SendEndpoints opposite domain role accessor
		
		/// <summary>
		/// Gets a list of SendEndpoints.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.SendEndpointEmitsCommands.Command
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<SendEndpoint> SendEndpoints
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<SendEndpoint>, SendEndpoint>(global::NServiceBus.Modeling.EndpointDesign.SendEndpointEmitsCommands.CommandDomainRoleId);
			}
		}
		#endregion
		#region SendReceiveEndpoints opposite domain role accessor
		
		/// <summary>
		/// Gets a list of SendReceiveEndpoints.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitCommands.Command
		/// </summary>
		public virtual DslModeling::LinkedElementCollection<SendReceiveEndpoint> SendReceiveEndpoints
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return GetRoleCollection<DslModeling::LinkedElementCollection<SendReceiveEndpoint>, SendReceiveEndpoint>(global::NServiceBus.Modeling.EndpointDesign.SendReceiveEndpointEmitCommands.CommandDomainRoleId);
			}
		}
		#endregion
	}
}
namespace NServiceBus.Modeling.EndpointDesign
{
	/// <summary>
	/// DomainClass Endpoint
	/// Description for NServiceBus.Modeling.EndpointDesign.Endpoint
	/// </summary>
	[DslDesign::DisplayNameResource("NServiceBus.Modeling.EndpointDesign.Endpoint.DisplayName", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("NServiceBus.Modeling.EndpointDesign.Endpoint.Description", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("1ae46b43-25f0-4911-9a33-b61c2c1f77ee")]
	public abstract partial class Endpoint : NamedElement
	{
		#region Constructors, domain class Id
	
		/// <summary>
		/// Endpoint domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x1ae46b43, 0x25f0, 0x4911, 0x9a, 0x33, 0xb6, 0x1c, 0x2c, 0x1f, 0x77, 0xee);
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		protected Endpoint(DslModeling::Partition partition, DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
		#region Type domain property code
		
		/// <summary>
		/// Type domain property Id.
		/// </summary>
		public static readonly global::System.Guid TypeDomainPropertyId = new global::System.Guid(0xddd78a91, 0x74d8, 0x4306, 0x8b, 0x0d, 0x51, 0x75, 0x2b, 0x0b, 0x77, 0x72);
		
		/// <summary>
		/// Storage for Type
		/// </summary>
		private global::NServiceBus.Modeling.EndpointDesign.Interfaces.EndpointType typePropertyStorage;
		
		/// <summary>
		/// Gets or sets the value of Type domain property.
		/// Description for NServiceBus.Modeling.EndpointDesign.Endpoint.Type
		/// </summary>
		[DslDesign::DisplayNameResource("NServiceBus.Modeling.EndpointDesign.Endpoint/Type.DisplayName", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
		[DslDesign::DescriptionResource("NServiceBus.Modeling.EndpointDesign.Endpoint/Type.Description", typeof(global::NServiceBus.Modeling.EndpointDesign.EndpointDesignDomainModel), "NServiceBus.Modeling.EndpointDesign.GeneratedCode.DomainModelResx")]
		[DslModeling::DomainObjectId("ddd78a91-74d8-4306-8b0d-51752b0b7772")]
		public global::NServiceBus.Modeling.EndpointDesign.Interfaces.EndpointType Type
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return typePropertyStorage;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				TypePropertyHandler.Instance.SetValue(this, value);
			}
		}
		/// <summary>
		/// Value handler for the Endpoint.Type domain property.
		/// </summary>
		internal sealed partial class TypePropertyHandler : DslModeling::DomainPropertyValueHandler<Endpoint, global::NServiceBus.Modeling.EndpointDesign.Interfaces.EndpointType>
		{
			private TypePropertyHandler() { }
		
			/// <summary>
			/// Gets the singleton instance of the Endpoint.Type domain property value handler.
			/// </summary>
			public static readonly TypePropertyHandler Instance = new TypePropertyHandler();
		
			/// <summary>
			/// Gets the Id of the Endpoint.Type domain property.
			/// </summary>
			public sealed override global::System.Guid DomainPropertyId
			{
				[global::System.Diagnostics.DebuggerStepThrough]
				get
				{
					return TypeDomainPropertyId;
				}
			}
			
			/// <summary>
			/// Gets a strongly-typed value of the property on specified element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <returns>Property value.</returns>
			public override sealed global::NServiceBus.Modeling.EndpointDesign.Interfaces.EndpointType GetValue(Endpoint element)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
				return element.typePropertyStorage;
			}
		
			/// <summary>
			/// Sets property value on an element.
			/// </summary>
			/// <param name="element">Element which owns the property.</param>
			/// <param name="newValue">New property value.</param>
			public override sealed void SetValue(Endpoint element, global::NServiceBus.Modeling.EndpointDesign.Interfaces.EndpointType newValue)
			{
				if (element == null) throw new global::System.ArgumentNullException("element");
		
				global::NServiceBus.Modeling.EndpointDesign.Interfaces.EndpointType oldValue = GetValue(element);
				if (newValue != oldValue)
				{
					ValueChanging(element, oldValue, newValue);
					element.typePropertyStorage = newValue;
					ValueChanged(element, oldValue, newValue);
				}
			}
		}
		
		#endregion
		#region EndpointModel opposite domain role accessor
		/// <summary>
		/// Gets or sets EndpointModel.
		/// Description for
		/// NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.Endpoint
		/// </summary>
		public virtual EndpointModel EndpointModel
		{
			[global::System.Diagnostics.DebuggerStepThrough]
			get
			{
				return DslModeling::DomainRoleInfo.GetLinkedElement(this, global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.EndpointDomainRoleId) as EndpointModel;
			}
			[global::System.Diagnostics.DebuggerStepThrough]
			set
			{
				DslModeling::DomainRoleInfo.SetLinkedElement(this, global::NServiceBus.Modeling.EndpointDesign.EndpointModelHasEndpoints.EndpointDomainRoleId, value);
			}
		}
		#endregion
	}
}
