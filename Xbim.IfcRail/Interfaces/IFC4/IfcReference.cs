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
namespace Xbim.IfcRail.ConstraintResource
{
	public partial class @IfcReference : IIfcReference
	{

		[CrossSchemaAttribute(typeof(IIfcReference), 1)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcReference.TypeIdentifier 
		{ 
			get
			{
				if (!TypeIdentifier.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(TypeIdentifier.Value);
			} 
			set
			{
				TypeIdentifier = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReference), 2)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcReference.AttributeIdentifier 
		{ 
			get
			{
				if (!AttributeIdentifier.HasValue) return null;
				return new Ifc4.MeasureResource.IfcIdentifier(AttributeIdentifier.Value);
			} 
			set
			{
				AttributeIdentifier = value.HasValue ? 
					new MeasureResource.IfcIdentifier(value.Value) :  
					 new MeasureResource.IfcIdentifier?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReference), 3)]
		Ifc4.MeasureResource.IfcLabel? IIfcReference.InstanceName 
		{ 
			get
			{
				if (!InstanceName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(InstanceName.Value);
			} 
			set
			{
				InstanceName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReference), 4)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcInteger> IIfcReference.ListPositions 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcInteger, Ifc4.MeasureResource.IfcInteger>(ListPositions, 
					s => new Ifc4.MeasureResource.IfcInteger(s), 
					t => new MeasureResource.IfcInteger(t));
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcReference), 5)]
		IIfcReference IIfcReference.InnerReference 
		{ 
			get
			{
				return InnerReference;
			} 
			set
			{
				InnerReference = value as IfcReference;
				
			}
		}
	//## Custom code
	//##
	}
}