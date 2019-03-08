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
	public partial class @IfcLaborResource : IIfcLaborResource
	{

		[CrossSchemaAttribute(typeof(IIfcLaborResource), 11)]
		Ifc4.Interfaces.IfcLaborResourceTypeEnum? IIfcLaborResource.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcLaborResourceTypeEnum.ADMINISTRATION:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.ADMINISTRATION;
					case IfcLaborResourceTypeEnum.CARPENTRY:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.CARPENTRY;
					case IfcLaborResourceTypeEnum.CLEANING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.CLEANING;
					case IfcLaborResourceTypeEnum.CONCRETE:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.CONCRETE;
					case IfcLaborResourceTypeEnum.DRYWALL:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.DRYWALL;
					case IfcLaborResourceTypeEnum.ELECTRIC:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.ELECTRIC;
					case IfcLaborResourceTypeEnum.FINISHING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.FINISHING;
					case IfcLaborResourceTypeEnum.FLOORING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.FLOORING;
					case IfcLaborResourceTypeEnum.GENERAL:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.GENERAL;
					case IfcLaborResourceTypeEnum.HVAC:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.HVAC;
					case IfcLaborResourceTypeEnum.LANDSCAPING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.LANDSCAPING;
					case IfcLaborResourceTypeEnum.MASONRY:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.MASONRY;
					case IfcLaborResourceTypeEnum.PAINTING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.PAINTING;
					case IfcLaborResourceTypeEnum.PAVING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.PAVING;
					case IfcLaborResourceTypeEnum.PLUMBING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.PLUMBING;
					case IfcLaborResourceTypeEnum.ROOFING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.ROOFING;
					case IfcLaborResourceTypeEnum.SITEGRADING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.SITEGRADING;
					case IfcLaborResourceTypeEnum.STEELWORK:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.STEELWORK;
					case IfcLaborResourceTypeEnum.SURVEYING:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.SURVEYING;
					case IfcLaborResourceTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.USERDEFINED;
					case IfcLaborResourceTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcLaborResourceTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.ADMINISTRATION:
						PredefinedType = IfcLaborResourceTypeEnum.ADMINISTRATION;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.CARPENTRY:
						PredefinedType = IfcLaborResourceTypeEnum.CARPENTRY;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.CLEANING:
						PredefinedType = IfcLaborResourceTypeEnum.CLEANING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.CONCRETE:
						PredefinedType = IfcLaborResourceTypeEnum.CONCRETE;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.DRYWALL:
						PredefinedType = IfcLaborResourceTypeEnum.DRYWALL;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.ELECTRIC:
						PredefinedType = IfcLaborResourceTypeEnum.ELECTRIC;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.FINISHING:
						PredefinedType = IfcLaborResourceTypeEnum.FINISHING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.FLOORING:
						PredefinedType = IfcLaborResourceTypeEnum.FLOORING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.GENERAL:
						PredefinedType = IfcLaborResourceTypeEnum.GENERAL;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.HVAC:
						PredefinedType = IfcLaborResourceTypeEnum.HVAC;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.LANDSCAPING:
						PredefinedType = IfcLaborResourceTypeEnum.LANDSCAPING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.MASONRY:
						PredefinedType = IfcLaborResourceTypeEnum.MASONRY;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.PAINTING:
						PredefinedType = IfcLaborResourceTypeEnum.PAINTING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.PAVING:
						PredefinedType = IfcLaborResourceTypeEnum.PAVING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.PLUMBING:
						PredefinedType = IfcLaborResourceTypeEnum.PLUMBING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.ROOFING:
						PredefinedType = IfcLaborResourceTypeEnum.ROOFING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.SITEGRADING:
						PredefinedType = IfcLaborResourceTypeEnum.SITEGRADING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.STEELWORK:
						PredefinedType = IfcLaborResourceTypeEnum.STEELWORK;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.SURVEYING:
						PredefinedType = IfcLaborResourceTypeEnum.SURVEYING;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.USERDEFINED:
						PredefinedType = IfcLaborResourceTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcLaborResourceTypeEnum.NOTDEFINED:
						PredefinedType = IfcLaborResourceTypeEnum.NOTDEFINED;
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