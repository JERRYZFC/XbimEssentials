// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.IfcRail.PropertyResource
{
	public partial class @IfcExtendedProperties : IIfcExtendedProperties
	{

		[CrossSchemaAttribute(typeof(IIfcExtendedProperties), 1)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcExtendedProperties.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcExtendedProperties), 2)]
		Ifc4.MeasureResource.IfcText? IIfcExtendedProperties.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcExtendedProperties), 3)]
		IEnumerable<IIfcProperty> IIfcExtendedProperties.Properties 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcProperty, IIfcProperty>(Properties);
			} 
		}
	//## Custom code
	//##
	}
}