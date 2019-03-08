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
namespace Xbim.IfcRail.SharedBldgElements
{
	public partial class @IfcRamp : IIfcRamp
	{

		[CrossSchemaAttribute(typeof(IIfcRamp), 9)]
		Ifc4.Interfaces.IfcRampTypeEnum? IIfcRamp.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcRampTypeEnum.STRAIGHT_RUN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.STRAIGHT_RUN_RAMP;
					case IfcRampTypeEnum.TWO_STRAIGHT_RUN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.TWO_STRAIGHT_RUN_RAMP;
					case IfcRampTypeEnum.QUARTER_TURN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.QUARTER_TURN_RAMP;
					case IfcRampTypeEnum.TWO_QUARTER_TURN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.TWO_QUARTER_TURN_RAMP;
					case IfcRampTypeEnum.HALF_TURN_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.HALF_TURN_RAMP;
					case IfcRampTypeEnum.SPIRAL_RAMP:
						return Ifc4.Interfaces.IfcRampTypeEnum.SPIRAL_RAMP;
					case IfcRampTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcRampTypeEnum.USERDEFINED;
					case IfcRampTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcRampTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcRampTypeEnum.STRAIGHT_RUN_RAMP:
						PredefinedType = IfcRampTypeEnum.STRAIGHT_RUN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.TWO_STRAIGHT_RUN_RAMP:
						PredefinedType = IfcRampTypeEnum.TWO_STRAIGHT_RUN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.QUARTER_TURN_RAMP:
						PredefinedType = IfcRampTypeEnum.QUARTER_TURN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.TWO_QUARTER_TURN_RAMP:
						PredefinedType = IfcRampTypeEnum.TWO_QUARTER_TURN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.HALF_TURN_RAMP:
						PredefinedType = IfcRampTypeEnum.HALF_TURN_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.SPIRAL_RAMP:
						PredefinedType = IfcRampTypeEnum.SPIRAL_RAMP;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.USERDEFINED:
						PredefinedType = IfcRampTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcRampTypeEnum.NOTDEFINED:
						PredefinedType = IfcRampTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
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