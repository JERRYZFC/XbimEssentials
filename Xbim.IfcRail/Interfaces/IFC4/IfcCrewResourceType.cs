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
namespace Xbim.IfcRail.ConstructionMgmtDomain
{
	public partial class @IfcCrewResourceType : IIfcCrewResourceType
	{

		[CrossSchemaAttribute(typeof(IIfcCrewResourceType), 12)]
		Ifc4.Interfaces.IfcCrewResourceTypeEnum IIfcCrewResourceType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcCrewResourceTypeEnum.OFFICE:
						return Ifc4.Interfaces.IfcCrewResourceTypeEnum.OFFICE;
					case IfcCrewResourceTypeEnum.SITE:
						return Ifc4.Interfaces.IfcCrewResourceTypeEnum.SITE;
					case IfcCrewResourceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcCrewResourceTypeEnum.USERDEFINED;
					case IfcCrewResourceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcCrewResourceTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcCrewResourceTypeEnum.OFFICE:
						PredefinedType = IfcCrewResourceTypeEnum.OFFICE;
						return;
					case Ifc4.Interfaces.IfcCrewResourceTypeEnum.SITE:
						PredefinedType = IfcCrewResourceTypeEnum.SITE;
						return;
					case Ifc4.Interfaces.IfcCrewResourceTypeEnum.USERDEFINED:
						PredefinedType = IfcCrewResourceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcCrewResourceTypeEnum.NOTDEFINED:
						PredefinedType = IfcCrewResourceTypeEnum.NOTDEFINED;
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