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
namespace Xbim.IfcRail.PlumbingFireProtectionDomain
{
	public partial class @IfcWasteTerminalType : IIfcWasteTerminalType
	{

		[CrossSchemaAttribute(typeof(IIfcWasteTerminalType), 10)]
		Ifc4.Interfaces.IfcWasteTerminalTypeEnum IIfcWasteTerminalType.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcWasteTerminalTypeEnum.FLOORTRAP:
						return Ifc4.Interfaces.IfcWasteTerminalTypeEnum.FLOORTRAP;
					case IfcWasteTerminalTypeEnum.FLOORWASTE:
						return Ifc4.Interfaces.IfcWasteTerminalTypeEnum.FLOORWASTE;
					case IfcWasteTerminalTypeEnum.GULLYSUMP:
						return Ifc4.Interfaces.IfcWasteTerminalTypeEnum.GULLYSUMP;
					case IfcWasteTerminalTypeEnum.GULLYTRAP:
						return Ifc4.Interfaces.IfcWasteTerminalTypeEnum.GULLYTRAP;
					case IfcWasteTerminalTypeEnum.ROOFDRAIN:
						return Ifc4.Interfaces.IfcWasteTerminalTypeEnum.ROOFDRAIN;
					case IfcWasteTerminalTypeEnum.WASTEDISPOSALUNIT:
						return Ifc4.Interfaces.IfcWasteTerminalTypeEnum.WASTEDISPOSALUNIT;
					case IfcWasteTerminalTypeEnum.WASTETRAP:
						return Ifc4.Interfaces.IfcWasteTerminalTypeEnum.WASTETRAP;
					case IfcWasteTerminalTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcWasteTerminalTypeEnum.USERDEFINED;
					case IfcWasteTerminalTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcWasteTerminalTypeEnum.NOTDEFINED;
					
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
					case Ifc4.Interfaces.IfcWasteTerminalTypeEnum.FLOORTRAP:
						PredefinedType = IfcWasteTerminalTypeEnum.FLOORTRAP;
						return;
					case Ifc4.Interfaces.IfcWasteTerminalTypeEnum.FLOORWASTE:
						PredefinedType = IfcWasteTerminalTypeEnum.FLOORWASTE;
						return;
					case Ifc4.Interfaces.IfcWasteTerminalTypeEnum.GULLYSUMP:
						PredefinedType = IfcWasteTerminalTypeEnum.GULLYSUMP;
						return;
					case Ifc4.Interfaces.IfcWasteTerminalTypeEnum.GULLYTRAP:
						PredefinedType = IfcWasteTerminalTypeEnum.GULLYTRAP;
						return;
					case Ifc4.Interfaces.IfcWasteTerminalTypeEnum.ROOFDRAIN:
						PredefinedType = IfcWasteTerminalTypeEnum.ROOFDRAIN;
						return;
					case Ifc4.Interfaces.IfcWasteTerminalTypeEnum.WASTEDISPOSALUNIT:
						PredefinedType = IfcWasteTerminalTypeEnum.WASTEDISPOSALUNIT;
						return;
					case Ifc4.Interfaces.IfcWasteTerminalTypeEnum.WASTETRAP:
						PredefinedType = IfcWasteTerminalTypeEnum.WASTETRAP;
						return;
					case Ifc4.Interfaces.IfcWasteTerminalTypeEnum.USERDEFINED:
						PredefinedType = IfcWasteTerminalTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcWasteTerminalTypeEnum.NOTDEFINED:
						PredefinedType = IfcWasteTerminalTypeEnum.NOTDEFINED;
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