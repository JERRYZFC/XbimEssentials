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
namespace Xbim.IfcRail.GeometricConstraintResource
{
	public partial class @IfcConnectionPointGeometry : IIfcConnectionPointGeometry
	{

		[CrossSchemaAttribute(typeof(IIfcConnectionPointGeometry), 1)]
		IIfcPointOrVertexPoint IIfcConnectionPointGeometry.PointOnRelatingElement 
		{ 
			get
			{
				if (PointOnRelatingElement == null) return null;
				var ifcpoint = PointOnRelatingElement as GeometryResource.IfcPoint;
				if (ifcpoint != null) 
					return ifcpoint;
				var ifcvertexpoint = PointOnRelatingElement as TopologyResource.IfcVertexPoint;
				if (ifcvertexpoint != null) 
					return ifcvertexpoint;
				return null;
			} 
			set
			{
				if (value == null)
				{
					PointOnRelatingElement = null;
					return;
				}	
				var ifcpoint = value as GeometryResource.IfcPoint;
				if (ifcpoint != null) 
				{
					PointOnRelatingElement = ifcpoint;
					return;
				}
				var ifcvertexpoint = value as TopologyResource.IfcVertexPoint;
				if (ifcvertexpoint != null) 
				{
					PointOnRelatingElement = ifcvertexpoint;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcConnectionPointGeometry), 2)]
		IIfcPointOrVertexPoint IIfcConnectionPointGeometry.PointOnRelatedElement 
		{ 
			get
			{
				if (PointOnRelatedElement == null) return null;
				var ifcpoint = PointOnRelatedElement as GeometryResource.IfcPoint;
				if (ifcpoint != null) 
					return ifcpoint;
				var ifcvertexpoint = PointOnRelatedElement as TopologyResource.IfcVertexPoint;
				if (ifcvertexpoint != null) 
					return ifcvertexpoint;
				return null;
			} 
			set
			{
				if (value == null)
				{
					PointOnRelatedElement = null;
					return;
				}	
				var ifcpoint = value as GeometryResource.IfcPoint;
				if (ifcpoint != null) 
				{
					PointOnRelatedElement = ifcpoint;
					return;
				}
				var ifcvertexpoint = value as TopologyResource.IfcVertexPoint;
				if (ifcvertexpoint != null) 
				{
					PointOnRelatedElement = ifcvertexpoint;
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}