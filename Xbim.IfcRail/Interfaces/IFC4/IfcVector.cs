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
	public partial class @IfcVector : IIfcVector
	{

		[CrossSchemaAttribute(typeof(IIfcVector), 1)]
		IIfcDirection IIfcVector.Orientation 
		{ 
			get
			{
				return Orientation;
			} 
			set
			{
				Orientation = value as IfcDirection;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcVector), 2)]
		Ifc4.MeasureResource.IfcLengthMeasure IIfcVector.Magnitude 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(Magnitude);
			} 
			set
			{
				Magnitude = new MeasureResource.IfcLengthMeasure(value);
				
			}
		}
		Ifc4.GeometryResource.IfcDimensionCount IIfcVector.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}