﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutofacContrib.Multitenant.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("AutofacContrib.Multitenant.Properties.Resources", typeof(Resources).Assembly);
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
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; may not be empty..
        /// </summary>
        public static string ArgumentException_StringEmpty {
            get {
                return ResourceManager.GetString("ArgumentException_StringEmpty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The AutofacHostFactory.Container static property must be set before services can be instantiated..
        /// </summary>
        public static string AutofacHostFactory_ContainerIsNull {
            get {
                return ResourceManager.GetString("AutofacHostFactory_ContainerIsNull", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to No type to host was provided by the &apos;{0}&apos; for the service &apos;{1}&apos;..
        /// </summary>
        public static string AutofacHostFactory_NoServiceHostType {
            get {
                return ResourceManager.GetString("AutofacHostFactory_NoServiceHostType", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The &apos;{0}&apos; did not provide a type to be hosted by WCF that was a concrete implementation type. WCF requires a service host to host a class, not an interface. Consider using a reflection-based registration or an expression-based registration where the return value is a class type. The current service type being returned by &apos;{0}&apos; for constructor string &apos;{1}&apos; is &apos;{2}&apos;..
        /// </summary>
        public static string AutofacHostFactory_ServiceHostTypeNotClass {
            get {
                return ResourceManager.GetString("AutofacHostFactory_ServiceHostTypeNotClass", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service &apos;{0}&apos; configured for WCF is not registered with the Autofac container..
        /// </summary>
        public static string AutofacHostFactory_ServiceNotRegistered {
            get {
                return ResourceManager.GetString("AutofacHostFactory_ServiceNotRegistered", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Default Tenant.
        /// </summary>
        public static string DefaultTenantId_ToString {
            get {
                return ResourceManager.GetString("DefaultTenantId_ToString", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interface type &apos;{0}&apos; is a generic type definition. You may not create WCF dynamic proxies from open generic interfaces..
        /// </summary>
        public static string DynamicProxy_InterfaceTypeToProxyIsGeneric {
            get {
                return ResourceManager.GetString("DynamicProxy_InterfaceTypeToProxyIsGeneric", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; cannot be turned into a proxy type for WCF hosting because it is not an interface. Multitenant WCF hosting requires you to implement a separate interface for your service contract..
        /// </summary>
        public static string DynamicProxy_InterfaceTypeToProxyNotInterface {
            get {
                return ResourceManager.GetString("DynamicProxy_InterfaceTypeToProxyNotInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Interface type &apos;{0}&apos; is not public. It must be accessible so a dynamic proxy object can be created from it..
        /// </summary>
        public static string DynamicProxy_InterfaceTypeToProxyNotPublic {
            get {
                return ResourceManager.GetString("DynamicProxy_InterfaceTypeToProxyNotPublic", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The type &apos;{0}&apos; cannot be turned into a proxy type for WCF hosting because it is not marked with System.ServiceModel.ServiceContractAttribute. Multitenant WCF hosting requires you to implement a separate interface for your service contract..
        /// </summary>
        public static string DynamicProxy_InterfaceTypeToProxyNotServiceContract {
            get {
                return ResourceManager.GetString("DynamicProxy_InterfaceTypeToProxyNotServiceContract", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The service implementation to proxy, type &apos;{0}&apos;, does not implement the service interface &apos;{1}&apos; that the proxy will implement. Check your Autofac registrations to make sure the service implementation type isn&apos;t somehow tied to the service interface..
        /// </summary>
        public static string DynamicProxy_ProxyTargetDoesNotImplementInterface {
            get {
                return ResourceManager.GetString("DynamicProxy_ProxyTargetDoesNotImplementInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The tenant with ID &apos;{0}&apos; has already been configured. It cannot be reconfigured..
        /// </summary>
        public static string MultitenantContainer_TenantAlreadyConfigured {
            get {
                return ResourceManager.GetString("MultitenantContainer_TenantAlreadyConfigured", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string &apos;{0}&apos; resolved to type &apos;{1}&apos; which is not an interface. For multitenancy to work, the service type to host should be the service interface rather than the concrete implementation type. You then register the concrete implementation type as the interface with Autofac, like: builder.RegisterType&lt;ImplementationType&gt;().As&lt;InterfaceType&gt;();.
        /// </summary>
        public static string MultitenantServiceImplementationDataProvider_ServiceInterfaceTypeNotInterface {
            get {
                return ResourceManager.GetString("MultitenantServiceImplementationDataProvider_ServiceInterfaceTypeNotInterface", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string &apos;{0}&apos; could not be resolved to a type. Make sure you specify the fully qualified type name, like &quot;Namespace.TypeName, AssemblyName&quot; and not just the type name..
        /// </summary>
        public static string MultitenantServiceImplementationDataProvider_ServiceInterfaceTypeNotResolvable {
            get {
                return ResourceManager.GetString("MultitenantServiceImplementationDataProvider_ServiceInterfaceTypeNotResolvable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The string &apos;{0}&apos; resolved to type &apos;{1}&apos; which is not marked with the System.ServiceModel.ServiceContractAttribute. For multitenancy to work, the service type to host should be the service contract interface. You then register the concrete implementation type as the interface with Autofac, like: builder.RegisterType&lt;ImplementationType&gt;().As&lt;InterfaceType&gt;();.
        /// </summary>
        public static string MultitenantServiceImplementationDataProvider_ServiceInterfaceTypeNotServiceContract {
            get {
                return ResourceManager.GetString("MultitenantServiceImplementationDataProvider_ServiceInterfaceTypeNotServiceContra" +
                        "ct", resourceCulture);
            }
        }
    }
}
