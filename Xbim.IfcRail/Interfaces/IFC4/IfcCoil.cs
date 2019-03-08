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
	public partial class @IfcCoil : IIfcCoil
	{

		[CrossSchemaAttribute(typeof(IIfcCoil), 9)]
		Ifc4.Interfaces.IfcCoilTypeEnum? IIfcCoil.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCoilTypeEnum.DXCOOLINGCOIL:
						return Ifc4.Interfaces.IfcCoilTypeEnum.DXCOOLINGCOIL;
					case IfcCoilTypeEnum.ELECTRICHEATINGCOIL:
						return Ifc4.Interfaces.IfcCoilTypeEnum.ELECTRICHEATINGCOIL;
					case IfcCoilTypeEnum.GASHEATINGCOIL:
						return Ifc4.Interfaces.IfcCoilTypeEnum.GASHEATINGCOIL;
					case IfcCoilTypeEnum.HYDRONICCOIL:
						return Ifc4.Interfaces.IfcCoilTypeEnum.HYDRONICCOIL;
					case IfcCoilTypeEnum.STEAMHEATINGCOIL:
						return Ifc4.Interfaces.IfcCoilTypeEnum.STEAMHEATINGCOIL;
					case IfcCoilTypeEnum.WATERCOOLINGCOIL:
						return Ifc4.Interfaces.IfcCoilTypeEnum.WATERCOOLINGCOIL;
					case IfcCoilTypeEnum.WATERHEATINGCOIL:
						return Ifc4.Interfaces.IfcCoilTypeEnum.WATERHEATINGCOIL;
					case IfcCoilTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCoilTypeEnum.USERDEFINED;
					case IfcCoilTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCoilTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcCoilTypeEnum.DXCOOLINGCOIL:
						PredefinedType = IfcCoilTypeEnum.DXCOOLINGCOIL;
						return;
					case Ifc4.Interfaces.IfcCoilTypeEnum.ELECTRICHEATINGCOIL:
						PredefinedType = IfcCoilTypeEnum.ELECTRICHEATINGCOIL;
						return;
					case Ifc4.Interfaces.IfcCoilTypeEnum.GASHEATINGCOIL:
						PredefinedType = IfcCoilTypeEnum.GASHEATINGCOIL;
						return;
					case Ifc4.Interfaces.IfcCoilTypeEnum.HYDRONICCOIL:
						PredefinedType = IfcCoilTypeEnum.HYDRONICCOIL;
						return;
					case Ifc4.Interfaces.IfcCoilTypeEnum.STEAMHEATINGCOIL:
						PredefinedType = IfcCoilTypeEnum.STEAMHEATINGCOIL;
						return;
					case Ifc4.Interfaces.IfcCoilTypeEnum.WATERCOOLINGCOIL:
						PredefinedType = IfcCoilTypeEnum.WATERCOOLINGCOIL;
						return;
					case Ifc4.Interfaces.IfcCoilTypeEnum.WATERHEATINGCOIL:
						PredefinedType = IfcCoilTypeEnum.WATERHEATINGCOIL;
						return;
					case Ifc4.Interfaces.IfcCoilTypeEnum.USERDEFINED:
						PredefinedType = IfcCoilTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCoilTypeEnum.NOTDEFINED:
						PredefinedType = IfcCoilTypeEnum.NOTDEFINED;
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