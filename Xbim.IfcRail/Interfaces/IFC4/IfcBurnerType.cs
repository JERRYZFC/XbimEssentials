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
	public partial class @IfcBurnerType : IIfcBurnerType
	{

		[CrossSchemaAttribute(typeof(IIfcBurnerType), 10)]
		Ifc4.Interfaces.IfcBurnerTypeEnum IIfcBurnerType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcBurnerTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcBurnerTypeEnum.USERDEFINED;
					case IfcBurnerTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcBurnerTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcBurnerTypeEnum.USERDEFINED:
						PredefinedType = IfcBurnerTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcBurnerTypeEnum.NOTDEFINED:
						PredefinedType = IfcBurnerTypeEnum.NOTDEFINED;
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