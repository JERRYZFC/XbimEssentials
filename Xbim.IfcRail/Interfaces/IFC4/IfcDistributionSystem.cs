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
namespace Xbim.IfcRail.SharedBldgServiceElements
{
	public partial class @IfcDistributionSystem : IIfcDistributionSystem
	{

		[CrossSchemaAttribute(typeof(IIfcDistributionSystem), 6)]
		Ifc4.MeasureResource.IfcLabel? IIfcDistributionSystem.LongName 
		{ 
			get
			{
				if (!LongName.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(LongName.Value);
			} 
			set
			{
				LongName = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDistributionSystem), 7)]
		Ifc4.Interfaces.IfcDistributionSystemEnum? IIfcDistributionSystem.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcDistributionSystemEnum.AIRCONDITIONING:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.AIRCONDITIONING;
					case IfcDistributionSystemEnum.AUDIOVISUAL:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.AUDIOVISUAL;
					case IfcDistributionSystemEnum.CHEMICAL:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.CHEMICAL;
					case IfcDistributionSystemEnum.CHILLEDWATER:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.CHILLEDWATER;
					case IfcDistributionSystemEnum.COMMUNICATION:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.COMMUNICATION;
					case IfcDistributionSystemEnum.COMPRESSEDAIR:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.COMPRESSEDAIR;
					case IfcDistributionSystemEnum.CONDENSERWATER:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.CONDENSERWATER;
					case IfcDistributionSystemEnum.CONTROL:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.CONTROL;
					case IfcDistributionSystemEnum.CONVEYING:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.CONVEYING;
					case IfcDistributionSystemEnum.DATA:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.DATA;
					case IfcDistributionSystemEnum.DISPOSAL:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.DISPOSAL;
					case IfcDistributionSystemEnum.DOMESTICCOLDWATER:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.DOMESTICCOLDWATER;
					case IfcDistributionSystemEnum.DOMESTICHOTWATER:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.DOMESTICHOTWATER;
					case IfcDistributionSystemEnum.DRAINAGE:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.DRAINAGE;
					case IfcDistributionSystemEnum.EARTHING:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.EARTHING;
					case IfcDistributionSystemEnum.ELECTRICAL:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.ELECTRICAL;
					case IfcDistributionSystemEnum.ELECTROACOUSTIC:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.ELECTROACOUSTIC;
					case IfcDistributionSystemEnum.EXHAUST:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.EXHAUST;
					case IfcDistributionSystemEnum.FIREPROTECTION:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.FIREPROTECTION;
					case IfcDistributionSystemEnum.FUEL:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.FUEL;
					case IfcDistributionSystemEnum.GAS:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.GAS;
					case IfcDistributionSystemEnum.HAZARDOUS:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.HAZARDOUS;
					case IfcDistributionSystemEnum.HEATING:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.HEATING;
					case IfcDistributionSystemEnum.LIGHTING:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.LIGHTING;
					case IfcDistributionSystemEnum.LIGHTNINGPROTECTION:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.LIGHTNINGPROTECTION;
					case IfcDistributionSystemEnum.MUNICIPALSOLIDWASTE:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.MUNICIPALSOLIDWASTE;
					case IfcDistributionSystemEnum.OIL:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.OIL;
					case IfcDistributionSystemEnum.OPERATIONAL:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.OPERATIONAL;
					case IfcDistributionSystemEnum.POWERGENERATION:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.POWERGENERATION;
					case IfcDistributionSystemEnum.RAINWATER:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.RAINWATER;
					case IfcDistributionSystemEnum.REFRIGERATION:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.REFRIGERATION;
					case IfcDistributionSystemEnum.SECURITY:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.SECURITY;
					case IfcDistributionSystemEnum.SEWAGE:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.SEWAGE;
					case IfcDistributionSystemEnum.SIGNAL:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.SIGNAL;
					case IfcDistributionSystemEnum.STORMWATER:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.STORMWATER;
					case IfcDistributionSystemEnum.TELEPHONE:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.TELEPHONE;
					case IfcDistributionSystemEnum.TV:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.TV;
					case IfcDistributionSystemEnum.VACUUM:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.VACUUM;
					case IfcDistributionSystemEnum.VENT:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.VENT;
					case IfcDistributionSystemEnum.VENTILATION:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.VENTILATION;
					case IfcDistributionSystemEnum.WASTEWATER:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.WASTEWATER;
					case IfcDistributionSystemEnum.WATERSUPPLY:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.WATERSUPPLY;
					case IfcDistributionSystemEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDistributionSystemEnum.USERDEFINED;
					case IfcDistributionSystemEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDistributionSystemEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcDistributionSystemEnum.AIRCONDITIONING:
						PredefinedType = IfcDistributionSystemEnum.AIRCONDITIONING;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.AUDIOVISUAL:
						PredefinedType = IfcDistributionSystemEnum.AUDIOVISUAL;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.CHEMICAL:
						PredefinedType = IfcDistributionSystemEnum.CHEMICAL;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.CHILLEDWATER:
						PredefinedType = IfcDistributionSystemEnum.CHILLEDWATER;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.COMMUNICATION:
						PredefinedType = IfcDistributionSystemEnum.COMMUNICATION;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.COMPRESSEDAIR:
						PredefinedType = IfcDistributionSystemEnum.COMPRESSEDAIR;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.CONDENSERWATER:
						PredefinedType = IfcDistributionSystemEnum.CONDENSERWATER;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.CONTROL:
						PredefinedType = IfcDistributionSystemEnum.CONTROL;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.CONVEYING:
						PredefinedType = IfcDistributionSystemEnum.CONVEYING;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.DATA:
						PredefinedType = IfcDistributionSystemEnum.DATA;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.DISPOSAL:
						PredefinedType = IfcDistributionSystemEnum.DISPOSAL;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.DOMESTICCOLDWATER:
						PredefinedType = IfcDistributionSystemEnum.DOMESTICCOLDWATER;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.DOMESTICHOTWATER:
						PredefinedType = IfcDistributionSystemEnum.DOMESTICHOTWATER;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.DRAINAGE:
						PredefinedType = IfcDistributionSystemEnum.DRAINAGE;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.EARTHING:
						PredefinedType = IfcDistributionSystemEnum.EARTHING;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.ELECTRICAL:
						PredefinedType = IfcDistributionSystemEnum.ELECTRICAL;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.ELECTROACOUSTIC:
						PredefinedType = IfcDistributionSystemEnum.ELECTROACOUSTIC;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.EXHAUST:
						PredefinedType = IfcDistributionSystemEnum.EXHAUST;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.FIREPROTECTION:
						PredefinedType = IfcDistributionSystemEnum.FIREPROTECTION;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.FUEL:
						PredefinedType = IfcDistributionSystemEnum.FUEL;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.GAS:
						PredefinedType = IfcDistributionSystemEnum.GAS;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.HAZARDOUS:
						PredefinedType = IfcDistributionSystemEnum.HAZARDOUS;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.HEATING:
						PredefinedType = IfcDistributionSystemEnum.HEATING;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.LIGHTING:
						PredefinedType = IfcDistributionSystemEnum.LIGHTING;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.LIGHTNINGPROTECTION:
						PredefinedType = IfcDistributionSystemEnum.LIGHTNINGPROTECTION;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.MUNICIPALSOLIDWASTE:
						PredefinedType = IfcDistributionSystemEnum.MUNICIPALSOLIDWASTE;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.OIL:
						PredefinedType = IfcDistributionSystemEnum.OIL;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.OPERATIONAL:
						PredefinedType = IfcDistributionSystemEnum.OPERATIONAL;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.POWERGENERATION:
						PredefinedType = IfcDistributionSystemEnum.POWERGENERATION;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.RAINWATER:
						PredefinedType = IfcDistributionSystemEnum.RAINWATER;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.REFRIGERATION:
						PredefinedType = IfcDistributionSystemEnum.REFRIGERATION;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.SECURITY:
						PredefinedType = IfcDistributionSystemEnum.SECURITY;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.SEWAGE:
						PredefinedType = IfcDistributionSystemEnum.SEWAGE;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.SIGNAL:
						PredefinedType = IfcDistributionSystemEnum.SIGNAL;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.STORMWATER:
						PredefinedType = IfcDistributionSystemEnum.STORMWATER;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.TELEPHONE:
						PredefinedType = IfcDistributionSystemEnum.TELEPHONE;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.TV:
						PredefinedType = IfcDistributionSystemEnum.TV;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.VACUUM:
						PredefinedType = IfcDistributionSystemEnum.VACUUM;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.VENT:
						PredefinedType = IfcDistributionSystemEnum.VENT;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.VENTILATION:
						PredefinedType = IfcDistributionSystemEnum.VENTILATION;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.WASTEWATER:
						PredefinedType = IfcDistributionSystemEnum.WASTEWATER;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.WATERSUPPLY:
						PredefinedType = IfcDistributionSystemEnum.WATERSUPPLY;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.USERDEFINED:
						PredefinedType = IfcDistributionSystemEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcDistributionSystemEnum.NOTDEFINED:
						PredefinedType = IfcDistributionSystemEnum.NOTDEFINED;
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