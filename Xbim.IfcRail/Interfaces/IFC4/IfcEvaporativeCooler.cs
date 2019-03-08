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
	public partial class @IfcEvaporativeCooler : IIfcEvaporativeCooler
	{

		[CrossSchemaAttribute(typeof(IIfcEvaporativeCooler), 9)]
		Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum? IIfcEvaporativeCooler.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER;
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER;
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER;
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER;
					case IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEAIRWASHER:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEAIRWASHER;
					case IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEPACKAGEAIRCOOLER:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEPACKAGEAIRCOOLER;
					case IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEWETCOIL:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEWETCOIL;
					case IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER;
					case IfcEvaporativeCoolerTypeEnum.INDIRECTDIRECTCOMBINATION:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.INDIRECTDIRECTCOMBINATION;
					case IfcEvaporativeCoolerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.USERDEFINED;
					case IfcEvaporativeCoolerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERANDOMMEDIAAIRCOOLER;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVERIGIDMEDIAAIRCOOLER;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVESLINGERSPACKAGEDAIRCOOLER;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEPACKAGEDROTARYAIRCOOLER;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEAIRWASHER:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.DIRECTEVAPORATIVEAIRWASHER;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEPACKAGEAIRCOOLER:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEPACKAGEAIRCOOLER;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEWETCOIL:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVEWETCOIL;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.INDIRECTEVAPORATIVECOOLINGTOWERORCOILCOOLER;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.INDIRECTDIRECTCOMBINATION:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.INDIRECTDIRECTCOMBINATION;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.USERDEFINED:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcEvaporativeCoolerTypeEnum.NOTDEFINED:
						PredefinedType = IfcEvaporativeCoolerTypeEnum.NOTDEFINED;
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