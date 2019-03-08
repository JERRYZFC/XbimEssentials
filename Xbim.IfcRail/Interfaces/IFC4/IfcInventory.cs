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
namespace Xbim.IfcRail.SharedFacilitiesElements
{
	public partial class @IfcInventory : IIfcInventory
	{

		[CrossSchemaAttribute(typeof(IIfcInventory), 6)]
		Ifc4.Interfaces.IfcInventoryTypeEnum? IIfcInventory.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcInventoryTypeEnum.ASSETINVENTORY:
						return Ifc4.Interfaces.IfcInventoryTypeEnum.ASSETINVENTORY;
					case IfcInventoryTypeEnum.SPACEINVENTORY:
						return Ifc4.Interfaces.IfcInventoryTypeEnum.SPACEINVENTORY;
					case IfcInventoryTypeEnum.FURNITUREINVENTORY:
						return Ifc4.Interfaces.IfcInventoryTypeEnum.FURNITUREINVENTORY;
					case IfcInventoryTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcInventoryTypeEnum.USERDEFINED;
					case IfcInventoryTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcInventoryTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcInventoryTypeEnum.ASSETINVENTORY:
						PredefinedType = IfcInventoryTypeEnum.ASSETINVENTORY;
						return;
					case Ifc4.Interfaces.IfcInventoryTypeEnum.SPACEINVENTORY:
						PredefinedType = IfcInventoryTypeEnum.SPACEINVENTORY;
						return;
					case Ifc4.Interfaces.IfcInventoryTypeEnum.FURNITUREINVENTORY:
						PredefinedType = IfcInventoryTypeEnum.FURNITUREINVENTORY;
						return;
					case Ifc4.Interfaces.IfcInventoryTypeEnum.USERDEFINED:
						PredefinedType = IfcInventoryTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcInventoryTypeEnum.NOTDEFINED:
						PredefinedType = IfcInventoryTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 7)]
		IIfcActorSelect IIfcInventory.Jurisdiction 
		{ 
			get
			{
				if (Jurisdiction == null) return null;
				var ifcorganization = Jurisdiction as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = Jurisdiction as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = Jurisdiction as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				if (value == null)
				{
					Jurisdiction = null;
					return;
				}	
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					Jurisdiction = ifcorganization;
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					Jurisdiction = ifcperson;
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					Jurisdiction = ifcpersonandorganization;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 8)]
		IItemSet<IIfcPerson> IIfcInventory.ResponsiblePersons 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<ActorResource.IfcPerson, IIfcPerson>(ResponsiblePersons);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 9)]
		Ifc4.DateTimeResource.IfcDate? IIfcInventory.LastUpdateDate 
		{ 
			get
			{
				if (!LastUpdateDate.HasValue) return null;
				return new Ifc4.DateTimeResource.IfcDate(LastUpdateDate.Value);
			} 
			set
			{
				LastUpdateDate = value.HasValue ? 
					new DateTimeResource.IfcDate(value.Value) :  
					 new DateTimeResource.IfcDate?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 10)]
		IIfcCostValue IIfcInventory.CurrentValue 
		{ 
			get
			{
				return CurrentValue;
			} 
			set
			{
				CurrentValue = value as CostResource.IfcCostValue;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcInventory), 11)]
		IIfcCostValue IIfcInventory.OriginalValue 
		{ 
			get
			{
				return OriginalValue;
			} 
			set
			{
				OriginalValue = value as CostResource.IfcCostValue;
				
			}
		}
	//## Custom code
	//##
	}
}