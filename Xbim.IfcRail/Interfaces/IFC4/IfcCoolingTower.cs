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
namespace Xbim.IfcRail.HvacDomain
{
	public partial class @IfcCoolingTower : IIfcCoolingTower
	{

		[CrossSchemaAttribute(typeof(IIfcCoolingTower), 9)]
		Ifc4.Interfaces.IfcCoolingTowerTypeEnum? IIfcCoolingTower.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCoolingTowerTypeEnum.NATURALDRAFT:
						return Ifc4.Interfaces.IfcCoolingTowerTypeEnum.NATURALDRAFT;
					case IfcCoolingTowerTypeEnum.MECHANICALINDUCEDDRAFT:
						return Ifc4.Interfaces.IfcCoolingTowerTypeEnum.MECHANICALINDUCEDDRAFT;
					case IfcCoolingTowerTypeEnum.MECHANICALFORCEDDRAFT:
						return Ifc4.Interfaces.IfcCoolingTowerTypeEnum.MECHANICALFORCEDDRAFT;
					case IfcCoolingTowerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCoolingTowerTypeEnum.USERDEFINED;
					case IfcCoolingTowerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCoolingTowerTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcCoolingTowerTypeEnum.NATURALDRAFT:
						PredefinedType = IfcCoolingTowerTypeEnum.NATURALDRAFT;
						return;
					case Ifc4.Interfaces.IfcCoolingTowerTypeEnum.MECHANICALINDUCEDDRAFT:
						PredefinedType = IfcCoolingTowerTypeEnum.MECHANICALINDUCEDDRAFT;
						return;
					case Ifc4.Interfaces.IfcCoolingTowerTypeEnum.MECHANICALFORCEDDRAFT:
						PredefinedType = IfcCoolingTowerTypeEnum.MECHANICALFORCEDDRAFT;
						return;
					case Ifc4.Interfaces.IfcCoolingTowerTypeEnum.USERDEFINED:
						PredefinedType = IfcCoolingTowerTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCoolingTowerTypeEnum.NOTDEFINED:
						PredefinedType = IfcCoolingTowerTypeEnum.NOTDEFINED;
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