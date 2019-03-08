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
	public partial class @IfcSpaceHeater : IIfcSpaceHeater
	{

		[CrossSchemaAttribute(typeof(IIfcSpaceHeater), 9)]
		Ifc4.Interfaces.IfcSpaceHeaterTypeEnum? IIfcSpaceHeater.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcSpaceHeaterTypeEnum.CONVECTOR:
						return Ifc4.Interfaces.IfcSpaceHeaterTypeEnum.CONVECTOR;
					case IfcSpaceHeaterTypeEnum.RADIATOR:
						return Ifc4.Interfaces.IfcSpaceHeaterTypeEnum.RADIATOR;
					case IfcSpaceHeaterTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcSpaceHeaterTypeEnum.USERDEFINED;
					case IfcSpaceHeaterTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcSpaceHeaterTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcSpaceHeaterTypeEnum.CONVECTOR:
						PredefinedType = IfcSpaceHeaterTypeEnum.CONVECTOR;
						return;
					case Ifc4.Interfaces.IfcSpaceHeaterTypeEnum.RADIATOR:
						PredefinedType = IfcSpaceHeaterTypeEnum.RADIATOR;
						return;
					case Ifc4.Interfaces.IfcSpaceHeaterTypeEnum.USERDEFINED:
						PredefinedType = IfcSpaceHeaterTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcSpaceHeaterTypeEnum.NOTDEFINED:
						PredefinedType = IfcSpaceHeaterTypeEnum.NOTDEFINED;
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