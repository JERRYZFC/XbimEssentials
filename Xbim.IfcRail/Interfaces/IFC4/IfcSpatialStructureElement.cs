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
namespace Xbim.IfcRail.ProductExtension
{
	public partial class @IfcSpatialStructureElement : IIfcSpatialStructureElement
	{

		[CrossSchemaAttribute(typeof(IIfcSpatialStructureElement), 9)]
		Ifc4.Interfaces.IfcElementCompositionEnum? IIfcSpatialStructureElement.CompositionType 
		{ 
			get
			{
				//## Custom code to handle enumeration of CompositionType
				//##
				switch (CompositionType)
				{
					case IfcElementCompositionEnum.COMPLEX:
						return Ifc4.Interfaces.IfcElementCompositionEnum.COMPLEX;
					case IfcElementCompositionEnum.ELEMENT:
						return Ifc4.Interfaces.IfcElementCompositionEnum.ELEMENT;
					case IfcElementCompositionEnum.PARTIAL:
						return Ifc4.Interfaces.IfcElementCompositionEnum.PARTIAL;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of CompositionType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcElementCompositionEnum.COMPLEX:
						CompositionType = IfcElementCompositionEnum.COMPLEX;
						return;
					case Ifc4.Interfaces.IfcElementCompositionEnum.ELEMENT:
						CompositionType = IfcElementCompositionEnum.ELEMENT;
						return;
					case Ifc4.Interfaces.IfcElementCompositionEnum.PARTIAL:
						CompositionType = IfcElementCompositionEnum.PARTIAL;
						return;
					
					case null:
						CompositionType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}