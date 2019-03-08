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
	public partial class @IfcFilter : IIfcFilter
	{

		[CrossSchemaAttribute(typeof(IIfcFilter), 9)]
		Ifc4.Interfaces.IfcFilterTypeEnum? IIfcFilter.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcFilterTypeEnum.AIRPARTICLEFILTER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.AIRPARTICLEFILTER;
					case IfcFilterTypeEnum.COMPRESSEDAIRFILTER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.COMPRESSEDAIRFILTER;
					case IfcFilterTypeEnum.ODORFILTER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.ODORFILTER;
					case IfcFilterTypeEnum.OILFILTER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.OILFILTER;
					case IfcFilterTypeEnum.STRAINER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.STRAINER;
					case IfcFilterTypeEnum.WATERFILTER:
						return Ifc4.Interfaces.IfcFilterTypeEnum.WATERFILTER;
					case IfcFilterTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcFilterTypeEnum.USERDEFINED;
					case IfcFilterTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcFilterTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcFilterTypeEnum.AIRPARTICLEFILTER:
						PredefinedType = IfcFilterTypeEnum.AIRPARTICLEFILTER;
						return;
					case Ifc4.Interfaces.IfcFilterTypeEnum.COMPRESSEDAIRFILTER:
						PredefinedType = IfcFilterTypeEnum.COMPRESSEDAIRFILTER;
						return;
					case Ifc4.Interfaces.IfcFilterTypeEnum.ODORFILTER:
						PredefinedType = IfcFilterTypeEnum.ODORFILTER;
						return;
					case Ifc4.Interfaces.IfcFilterTypeEnum.OILFILTER:
						PredefinedType = IfcFilterTypeEnum.OILFILTER;
						return;
					case Ifc4.Interfaces.IfcFilterTypeEnum.STRAINER:
						PredefinedType = IfcFilterTypeEnum.STRAINER;
						return;
					case Ifc4.Interfaces.IfcFilterTypeEnum.WATERFILTER:
						PredefinedType = IfcFilterTypeEnum.WATERFILTER;
						return;
					case Ifc4.Interfaces.IfcFilterTypeEnum.USERDEFINED:
						PredefinedType = IfcFilterTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcFilterTypeEnum.NOTDEFINED:
						PredefinedType = IfcFilterTypeEnum.NOTDEFINED;
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