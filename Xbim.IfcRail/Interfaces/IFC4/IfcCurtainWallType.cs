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
	public partial class @IfcCurtainWallType : IIfcCurtainWallType
	{

		[CrossSchemaAttribute(typeof(IIfcCurtainWallType), 10)]
		Ifc4.Interfaces.IfcCurtainWallTypeEnum IIfcCurtainWallType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCurtainWallTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCurtainWallTypeEnum.USERDEFINED;
					case IfcCurtainWallTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCurtainWallTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcCurtainWallTypeEnum.USERDEFINED:
						PredefinedType = IfcCurtainWallTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCurtainWallTypeEnum.NOTDEFINED:
						PredefinedType = IfcCurtainWallTypeEnum.NOTDEFINED;
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