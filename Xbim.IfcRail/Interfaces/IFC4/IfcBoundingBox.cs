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
namespace Xbim.IfcRail.GeometricModelResource
{
	public partial class @IfcBoundingBox : IIfcBoundingBox
	{

		[CrossSchemaAttribute(typeof(IIfcBoundingBox), 1)]
		IIfcCartesianPoint IIfcBoundingBox.Corner 
		{ 
			get
			{
				return Corner;
			} 
			set
			{
				Corner = value as GeometryResource.IfcCartesianPoint;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBoundingBox), 2)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcBoundingBox.XDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(XDim);
			} 
			set
			{
				XDim = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBoundingBox), 3)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcBoundingBox.YDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(YDim);
			} 
			set
			{
				YDim = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBoundingBox), 4)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcBoundingBox.ZDim 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(ZDim);
			} 
			set
			{
				ZDim = new MeasureResource.IfcPositiveLengthMeasure(value);
				
			}
		}
		Ifc4.GeometryResource.IfcDimensionCount IIfcBoundingBox.Dim 
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