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
namespace Xbim.IfcRail.TopologyResource
{
	public partial class @IfcVertexPoint : IIfcVertexPoint
	{

		[CrossSchemaAttribute(typeof(IIfcVertexPoint), 1)]
		IIfcPoint IIfcVertexPoint.VertexGeometry 
		{ 
			get
			{
				return VertexGeometry;
			} 
			set
			{
				VertexGeometry = value as GeometryResource.IfcPoint;
				
			}
		}
	//## Custom code
	//##
	}
}