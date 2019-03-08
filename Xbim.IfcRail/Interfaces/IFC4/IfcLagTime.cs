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
namespace Xbim.IfcRail.DateTimeResource
{
	public partial class @IfcLagTime : IIfcLagTime
	{

		[CrossSchemaAttribute(typeof(IIfcLagTime), 4)]
		IIfcTimeOrRatioSelect IIfcLagTime.LagValue 
		{ 
			get
			{
				if (LagValue == null) return null;
				if (LagValue is IfcDuration) 
					return new Ifc4.DateTimeResource.IfcDuration((IfcDuration)LagValue);
				if (LagValue is MeasureResource.IfcRatioMeasure) 
					return new Ifc4.MeasureResource.IfcRatioMeasure((MeasureResource.IfcRatioMeasure)LagValue);
				return null;
			} 
			set
			{
				if (value == null)
				{
					LagValue = null;
					return;
				}	
				if (value is Ifc4.DateTimeResource.IfcDuration) 
				{
					LagValue = new IfcDuration((Ifc4.DateTimeResource.IfcDuration)value);
					return;
				}
				if (value is Ifc4.MeasureResource.IfcRatioMeasure) 
				{
					LagValue = new MeasureResource.IfcRatioMeasure((Ifc4.MeasureResource.IfcRatioMeasure)value);
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLagTime), 5)]
		Ifc4.Interfaces.IfcTaskDurationEnum IIfcLagTime.DurationType 
		{ 
			get
			{
				//## Custom code to handle enumeration of DurationType
				//##
				switch (DurationType)
				{
					case IfcTaskDurationEnum.ELAPSEDTIME:
						return Ifc4.Interfaces.IfcTaskDurationEnum.ELAPSEDTIME;
					case IfcTaskDurationEnum.WORKTIME:
						return Ifc4.Interfaces.IfcTaskDurationEnum.WORKTIME;
					case IfcTaskDurationEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcTaskDurationEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of DurationType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcTaskDurationEnum.ELAPSEDTIME:
						DurationType = IfcTaskDurationEnum.ELAPSEDTIME;
						return;
					case Ifc4.Interfaces.IfcTaskDurationEnum.WORKTIME:
						DurationType = IfcTaskDurationEnum.WORKTIME;
						return;
					case Ifc4.Interfaces.IfcTaskDurationEnum.NOTDEFINED:
						DurationType = IfcTaskDurationEnum.NOTDEFINED;
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