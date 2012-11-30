﻿
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NServiceBusStudio
{
	using global::Microsoft.VisualStudio.Patterning.Runtime;
	using global::NServiceBusStudio.Automation.TypeConverters;
	using global::System;
	using global::System.Collections.Generic;
	using global::System.ComponentModel;
	using global::System.ComponentModel.Composition;
	using global::System.ComponentModel.Design;
	using global::System.Drawing.Design;
	using Runtime = global::Microsoft.VisualStudio.Patterning.Runtime;

	///	<summary>
	///	An NServiceBus-powered application
	///	</summary>
	[Description("An NServiceBus-powered application")]
	[ToolkitInterfaceProxy(ExtensionId ="a5e9f15b-ad7f-4201-851e-186dd8db3bc9", DefinitionId = "2c52bbfe-442d-4f40-8f6f-7df75dd99cac", ProxyType = typeof(Application))]
	[System.CodeDom.Compiler.GeneratedCode("Pattern Toolkit Automation Library", "1.2.19.0")]
	[System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
	internal partial class Application : IApplication
	{
		private Runtime.IProduct target;
		private Runtime.IProductProxy<IApplication> proxy;

		/// <summary>
		/// For MEF.
		/// </summary>
		[ImportingConstructor]
		private Application() { }

		/// <summary>
		/// Initializes a new instance of the <see cref="Application"/> class.
		/// </summary>
		public Application(Runtime.IProduct target)
		{
			this.target = target;
			this.proxy = target.ProxyFor<IApplication>();
			OnCreated();
		}	

		partial void OnCreated();

		///	<summary>
		///	Description for Application.ForwardReceivedMessagesTo
		///	</summary>
		[Description("Description for Application.ForwardReceivedMessagesTo")]
		[DisplayName("Forward Received Messages To")]
		[Category("General")]
		public virtual String ForwardReceivedMessagesTo 
		{
			get { return this.proxy.GetValue(() => this.ForwardReceivedMessagesTo); }
			set { this.proxy.SetValue(() => this.ForwardReceivedMessagesTo, value); }
		}

		///	<summary>
		///	Description for Application.ErrorQueue
		///	</summary>
		[Description("Description for Application.ErrorQueue")]
		[DisplayName("Error Queue")]
		[Category("General")]
		public virtual String ErrorQueue 
		{
			get { return this.proxy.GetValue(() => this.ErrorQueue); }
			set { this.proxy.SetValue(() => this.ErrorQueue, value); }
		}

		///	<summary>
		///	Description for Application.NServiceBusVersion
		///	</summary>
		[Description("Description for Application.NServiceBusVersion")]
		[DisplayName("NService Bus Version")]
		[Category("General")]
		public virtual String NServiceBusVersion 
		{
			get { return this.proxy.GetValue(() => this.NServiceBusVersion); }
			set { this.proxy.SetValue(() => this.NServiceBusVersion, value); }
		}

		///	<summary>
		///	Description for Application.ExtensionPath
		///	</summary>
		[Description("Description for Application.ExtensionPath")]
		[DisplayName("Extension Path")]
		[Category("General")]
		public virtual String ExtensionPath 
		{
			get { return this.proxy.GetValue(() => this.ExtensionPath); }
			set { this.proxy.SetValue(() => this.ExtensionPath, value); }
		}

		///	<summary>
		///	Description for Application.Transport
		///	</summary>
		[Description("Description for Application.Transport")]
		[DisplayName("Transport")]
		[Category("General")]
		[TypeConverter(typeof(TransportTypeConverter))]
		public virtual String Transport 
		{
			get { return this.proxy.GetValue(() => this.Transport); }
			set { this.proxy.SetValue(() => this.Transport, value); }
		}

		///	<summary>
		///	Description for Application.SqlServer
		///	</summary>
		[Description("Description for Application.SqlServer")]
		[DisplayName("Sql Server")]
		[Category("General")]
		public virtual String SqlServer 
		{
			get { return this.proxy.GetValue(() => this.SqlServer); }
			set { this.proxy.SetValue(() => this.SqlServer, value); }
		}

		///	<summary>
		///	Description for Application.SqlDatabase
		///	</summary>
		[Description("Description for Application.SqlDatabase")]
		[DisplayName("Sql Database")]
		[Category("General")]
		public virtual String SqlDatabase 
		{
			get { return this.proxy.GetValue(() => this.SqlDatabase); }
			set { this.proxy.SetValue(() => this.SqlDatabase, value); }
		}
		
		///	<summary>
		///	The ToolkitInfo.
		///	</summary>
		public virtual IProductToolkitInfo ToolkitInfo 
		{ 
			get { return this.proxy.GetValue(() => this.ToolkitInfo); }
		}
		
		///	<summary>
		///	The CurrentView.
		///	</summary>
		public virtual IView CurrentView 
		{ 
			get { return this.proxy.GetValue(() => this.CurrentView); }
			set { this.proxy.SetValue(() => this.CurrentView, value); }
		}
		
		///	<summary>
		///	The name of this element instance.
		///	</summary>
		[ParenthesizePropertyName(true)]
		[Description("The name of this element instance.")]
		public virtual String InstanceName 
		{ 
			get { return this.proxy.GetValue(() => this.InstanceName); }
			set { this.proxy.SetValue(() => this.InstanceName, value); }
		}
		
		///	<summary>
		///	The order of this element relative to its siblings.
		///	</summary>
		[ReadOnly(true)]
		[Description("The order of this element relative to its siblings.")]
		public virtual Double InstanceOrder 
		{ 
			get { return this.proxy.GetValue(() => this.InstanceOrder); }
			set { this.proxy.SetValue(() => this.InstanceOrder, value); }
		}
		
		///	<summary>
		///	The references of this element.
		///	</summary>
		[Description("The references of this element.")]
		public virtual IEnumerable<IReference> References 
		{ 
			get { return this.proxy.GetValue(() => this.References); }
		}
		
		///	<summary>
		///	Notes for this element.
		///	</summary>
		[Description("Notes for this element.")]
		[Editor(typeof(MultilineStringEditor), typeof(UITypeEditor))]
		public virtual String Notes 
		{ 
			get { return this.proxy.GetValue(() => this.Notes); }
			set { this.proxy.SetValue(() => this.Notes, value); }
		}
		
		///	<summary>
		///	The InTransaction.
		///	</summary>
		public virtual Boolean InTransaction 
		{ 
			get { return this.proxy.GetValue(() => this.InTransaction); }
		}
		
		///	<summary>
		///	The IsSerializing.
		///	</summary>
		public virtual Boolean IsSerializing 
		{ 
			get { return this.proxy.GetValue(() => this.IsSerializing); }
		}

		///	<summary>
		///	Design view of your application, where you create your services and messages.
		///	</summary>
		[Description("Design view of your application, where you create your services and messages.")]
		public virtual IDesign Design
		{ 
			get { return this.proxy.GetView(() => this.Design, view => new Design(view)); }
		}

		/// <summary>
		/// Gets the generic <see cref="Runtime.IProduct"/> underlying element.
		/// </summary>
		public virtual Runtime.IProduct AsProduct()
		{
			return this.target;
		}

		/// <summary>
		/// Gets the generic underlying element as the given type if possible.
		/// </summary>
		public virtual TRuntimeInterface As<TRuntimeInterface>()
			where TRuntimeInterface : class
		{
			return this.target as TRuntimeInterface;
		}

		/// <summary>
		/// Deletes this instance.
		/// </summary>
		public virtual void Delete()
		{
			this.target.Delete();
		}
	}
}