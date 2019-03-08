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
namespace Xbim.IfcRail.ElectricalDomain
{
	public partial class @IfcElectricMotor : IIfcElectricMotor
	{

		[CrossSchemaAttribute(typeof(IIfcElectricMotor), 9)]
		Ifc4.Interfaces.IfcElectricMotorTypeEnum? IIfcElectricMotor.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcElectricMotorTypeEnum.DC:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.DC;
					case IfcElectricMotorTypeEnum.INDUCTION:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.INDUCTION;
					case IfcElectricMotorTypeEnum.POLYPHASE:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.POLYPHASE;
					case IfcElectricMotorTypeEnum.RELUCTANCESYNCHRONOUS:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.RELUCTANCESYNCHRONOUS;
					case IfcElectricMotorTypeEnum.SYNCHRONOUS:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.SYNCHRONOUS;
					case IfcElectricMotorTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.USERDEFINED;
					case IfcElectricMotorTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcElectricMotorTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcElectricMotorTypeEnum.DC:
						PredefinedType = IfcElectricMotorTypeEnum.DC;
						return;
					case Ifc4.Interfaces.IfcElectricMotorTypeEnum.INDUCTION:
						PredefinedType = IfcElectricMotorTypeEnum.INDUCTION;
						return;
					case Ifc4.Interfaces.IfcElectricMotorTypeEnum.POLYPHASE:
						PredefinedType = IfcElectricMotorTypeEnum.POLYPHASE;
						return;
					case Ifc4.Interfaces.IfcElectricMotorTypeEnum.RELUCTANCESYNCHRONOUS:
						PredefinedType = IfcElectricMotorTypeEnum.RELUCTANCESYNCHRONOUS;
						return;
					case Ifc4.Interfaces.IfcElectricMotorTypeEnum.SYNCHRONOUS:
						PredefinedType = IfcElectricMotorTypeEnum.SYNCHRONOUS;
						return;
					case Ifc4.Interfaces.IfcElectricMotorTypeEnum.USERDEFINED:
						PredefinedType = IfcElectricMotorTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcElectricMotorTypeEnum.NOTDEFINED:
						PredefinedType = IfcElectricMotorTypeEnum.NOTDEFINED;
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