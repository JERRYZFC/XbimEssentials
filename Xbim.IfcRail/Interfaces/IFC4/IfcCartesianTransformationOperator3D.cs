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
namespace Xbim.IfcRail.GeometryResource
{
	public partial class @IfcCartesianTransformationOperator3D : IIfcCartesianTransformationOperator3D
	{

		[CrossSchemaAttribute(typeof(IIfcCartesianTransformationOperator3D), 5)]
		IIfcDirection IIfcCartesianTransformationOperator3D.Axis3 
		{ 
			get
			{
				return Axis3;
			} 
			set
			{
				Axis3 = value as IfcDirection;
				
			}
		}
		List<Common.Geometry.XbimVector3D> IIfcCartesianTransformationOperator3D.U 
		{
			get 
			{
				return U;
			}
		}

	//## Custom code
	//##
	}
}