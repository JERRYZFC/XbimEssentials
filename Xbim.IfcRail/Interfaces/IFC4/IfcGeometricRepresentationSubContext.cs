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
namespace Xbim.IfcRail.RepresentationResource
{
	public partial class @IfcGeometricRepresentationSubContext : IIfcGeometricRepresentationSubContext
	{

		[CrossSchemaAttribute(typeof(IIfcGeometricRepresentationSubContext), 7)]
		IIfcGeometricRepresentationContext IIfcGeometricRepresentationSubContext.ParentContext 
		{ 
			get
			{
				return ParentContext;
			} 
			set
			{
				ParentContext = value as IfcGeometricRepresentationContext;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcGeometricRepresentationSubContext), 8)]
		Ifc4.MeasureResource.IfcPositiveRatioMeasure? IIfcGeometricRepresentationSubContext.TargetScale 
		{ 
			get
			{
				if (!TargetScale.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveRatioMeasure(TargetScale.Value);
			} 
			set
			{
				TargetScale = value.HasValue ? 
					new MeasureResource.IfcPositiveRatioMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveRatioMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcGeometricRepresentationSubContext), 9)]
		Ifc4.Interfaces.IfcGeometricProjectionEnum IIfcGeometricRepresentationSubContext.TargetView 
		{ 
			get
			{
				//## Custom code to handle enumeration of TargetView
				//##
				switch (TargetView)
				{
					case IfcGeometricProjectionEnum.GRAPH_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.GRAPH_VIEW;
					case IfcGeometricProjectionEnum.SKETCH_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.SKETCH_VIEW;
					case IfcGeometricProjectionEnum.MODEL_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.MODEL_VIEW;
					case IfcGeometricProjectionEnum.PLAN_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.PLAN_VIEW;
					case IfcGeometricProjectionEnum.REFLECTED_PLAN_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.REFLECTED_PLAN_VIEW;
					case IfcGeometricProjectionEnum.SECTION_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.SECTION_VIEW;
					case IfcGeometricProjectionEnum.ELEVATION_VIEW:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.ELEVATION_VIEW;
					case IfcGeometricProjectionEnum.USERDEFINED:
						//## Optional custom handling of TargetView == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.USERDEFINED;
					case IfcGeometricProjectionEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcGeometricProjectionEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of TargetView
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcGeometricProjectionEnum.GRAPH_VIEW:
						TargetView = IfcGeometricProjectionEnum.GRAPH_VIEW;
						return;
					case Ifc4.Interfaces.IfcGeometricProjectionEnum.SKETCH_VIEW:
						TargetView = IfcGeometricProjectionEnum.SKETCH_VIEW;
						return;
					case Ifc4.Interfaces.IfcGeometricProjectionEnum.MODEL_VIEW:
						TargetView = IfcGeometricProjectionEnum.MODEL_VIEW;
						return;
					case Ifc4.Interfaces.IfcGeometricProjectionEnum.PLAN_VIEW:
						TargetView = IfcGeometricProjectionEnum.PLAN_VIEW;
						return;
					case Ifc4.Interfaces.IfcGeometricProjectionEnum.REFLECTED_PLAN_VIEW:
						TargetView = IfcGeometricProjectionEnum.REFLECTED_PLAN_VIEW;
						return;
					case Ifc4.Interfaces.IfcGeometricProjectionEnum.SECTION_VIEW:
						TargetView = IfcGeometricProjectionEnum.SECTION_VIEW;
						return;
					case Ifc4.Interfaces.IfcGeometricProjectionEnum.ELEVATION_VIEW:
						TargetView = IfcGeometricProjectionEnum.ELEVATION_VIEW;
						return;
					case Ifc4.Interfaces.IfcGeometricProjectionEnum.USERDEFINED:
						TargetView = IfcGeometricProjectionEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcGeometricProjectionEnum.NOTDEFINED:
						TargetView = IfcGeometricProjectionEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcGeometricRepresentationSubContext), 10)]
		Ifc4.MeasureResource.IfcLabel? IIfcGeometricRepresentationSubContext.UserDefinedTargetView 
		{ 
			get
			{
				if (!UserDefinedTargetView.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedTargetView.Value);
			} 
			set
			{
				UserDefinedTargetView = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}