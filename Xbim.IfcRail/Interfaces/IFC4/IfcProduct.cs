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
namespace Xbim.IfcRail.Kernel
{
	public partial class @IfcProduct : IIfcProduct
	{

		[CrossSchemaAttribute(typeof(IIfcProduct), 6)]
		IIfcObjectPlacement IIfcProduct.ObjectPlacement 
		{ 
			get
			{
				return ObjectPlacement;
			} 
			set
			{
				ObjectPlacement = value as GeometricConstraintResource.IfcObjectPlacement;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcProduct), 7)]
		IIfcProductRepresentation IIfcProduct.Representation 
		{ 
			get
			{
				return Representation;
			} 
			set
			{
				Representation = value as RepresentationResource.IfcProductRepresentation;
				
			}
		}
		IEnumerable<IIfcRelAssignsToProduct> IIfcProduct.ReferencedBy 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssignsToProduct>(e => (e.RelatingProduct as IfcProduct) == this, "RelatingProduct", this);
			} 
		}
	//## Custom code
	//##
	}
}