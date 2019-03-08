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
	public partial class @IfcElectricDistributionBoard : IIfcElectricDistributionBoard
	{

		[CrossSchemaAttribute(typeof(IIfcElectricDistributionBoard), 9)]
		Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum? IIfcElectricDistributionBoard.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcElectricDistributionBoardTypeEnum.CONSUMERUNIT:
						return Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.CONSUMERUNIT;
					case IfcElectricDistributionBoardTypeEnum.DISTRIBUTIONBOARD:
						return Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.DISTRIBUTIONBOARD;
					case IfcElectricDistributionBoardTypeEnum.MOTORCONTROLCENTRE:
						return Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.MOTORCONTROLCENTRE;
					case IfcElectricDistributionBoardTypeEnum.SWITCHBOARD:
						return Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.SWITCHBOARD;
					case IfcElectricDistributionBoardTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.USERDEFINED;
					case IfcElectricDistributionBoardTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.CONSUMERUNIT:
						PredefinedType = IfcElectricDistributionBoardTypeEnum.CONSUMERUNIT;
						return;
					case Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.DISTRIBUTIONBOARD:
						PredefinedType = IfcElectricDistributionBoardTypeEnum.DISTRIBUTIONBOARD;
						return;
					case Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.MOTORCONTROLCENTRE:
						PredefinedType = IfcElectricDistributionBoardTypeEnum.MOTORCONTROLCENTRE;
						return;
					case Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.SWITCHBOARD:
						PredefinedType = IfcElectricDistributionBoardTypeEnum.SWITCHBOARD;
						return;
					case Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.USERDEFINED:
						PredefinedType = IfcElectricDistributionBoardTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcElectricDistributionBoardTypeEnum.NOTDEFINED:
						PredefinedType = IfcElectricDistributionBoardTypeEnum.NOTDEFINED;
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