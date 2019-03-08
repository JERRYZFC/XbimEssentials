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
	public partial class @IfcCommunicationsAppliance : IIfcCommunicationsAppliance
	{

		[CrossSchemaAttribute(typeof(IIfcCommunicationsAppliance), 9)]
		Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum? IIfcCommunicationsAppliance.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCommunicationsApplianceTypeEnum.ANTENNA:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.ANTENNA;
					case IfcCommunicationsApplianceTypeEnum.COMPUTER:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.COMPUTER;
					case IfcCommunicationsApplianceTypeEnum.FAX:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.FAX;
					case IfcCommunicationsApplianceTypeEnum.GATEWAY:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.GATEWAY;
					case IfcCommunicationsApplianceTypeEnum.MODEM:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.MODEM;
					case IfcCommunicationsApplianceTypeEnum.NETWORKAPPLIANCE:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.NETWORKAPPLIANCE;
					case IfcCommunicationsApplianceTypeEnum.NETWORKBRIDGE:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.NETWORKBRIDGE;
					case IfcCommunicationsApplianceTypeEnum.NETWORKHUB:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.NETWORKHUB;
					case IfcCommunicationsApplianceTypeEnum.PRINTER:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.PRINTER;
					case IfcCommunicationsApplianceTypeEnum.REPEATER:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.REPEATER;
					case IfcCommunicationsApplianceTypeEnum.ROUTER:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.ROUTER;
					case IfcCommunicationsApplianceTypeEnum.SCANNER:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.SCANNER;
					case IfcCommunicationsApplianceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.USERDEFINED;
					case IfcCommunicationsApplianceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.ANTENNA:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.ANTENNA;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.COMPUTER:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.COMPUTER;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.FAX:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.FAX;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.GATEWAY:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.GATEWAY;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.MODEM:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.MODEM;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.NETWORKAPPLIANCE:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.NETWORKAPPLIANCE;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.NETWORKBRIDGE:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.NETWORKBRIDGE;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.NETWORKHUB:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.NETWORKHUB;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.PRINTER:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.PRINTER;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.REPEATER:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.REPEATER;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.ROUTER:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.ROUTER;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.SCANNER:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.SCANNER;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.USERDEFINED:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCommunicationsApplianceTypeEnum.NOTDEFINED:
						PredefinedType = IfcCommunicationsApplianceTypeEnum.NOTDEFINED;
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