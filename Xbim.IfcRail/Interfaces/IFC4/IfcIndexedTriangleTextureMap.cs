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
namespace Xbim.IfcRail.PresentationAppearanceResource
{
	public partial class @IfcIndexedTriangleTextureMap : IIfcIndexedTriangleTextureMap
	{

		[CrossSchemaAttribute(typeof(IIfcIndexedTriangleTextureMap), 4)]
		IItemSet<IItemSet<Xbim.Ifc4.MeasureResource.IfcPositiveInteger>> IIfcIndexedTriangleTextureMap.TexCoordIndex 
		{ 
			get
			{
				return new Common.Collections.ProxyNestedItemSet<MeasureResource.IfcPositiveInteger, Ifc4.MeasureResource.IfcPositiveInteger>(TexCoordIndex);
			} 
		}
	//## Custom code
	//##
	}
}