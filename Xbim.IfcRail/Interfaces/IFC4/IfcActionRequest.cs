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
namespace Xbim.IfcRail.SharedMgmtElements
{
	public partial class @IfcActionRequest : IIfcActionRequest
	{

		[CrossSchemaAttribute(typeof(IIfcActionRequest), 7)]
		Ifc4.Interfaces.IfcActionRequestTypeEnum? IIfcActionRequest.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcActionRequestTypeEnum.EMAIL:
						return Ifc4.Interfaces.IfcActionRequestTypeEnum.EMAIL;
					case IfcActionRequestTypeEnum.FAX:
						return Ifc4.Interfaces.IfcActionRequestTypeEnum.FAX;
					case IfcActionRequestTypeEnum.PHONE:
						return Ifc4.Interfaces.IfcActionRequestTypeEnum.PHONE;
					case IfcActionRequestTypeEnum.POST:
						return Ifc4.Interfaces.IfcActionRequestTypeEnum.POST;
					case IfcActionRequestTypeEnum.VERBAL:
						return Ifc4.Interfaces.IfcActionRequestTypeEnum.VERBAL;
					case IfcActionRequestTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcActionRequestTypeEnum.USERDEFINED;
					case IfcActionRequestTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcActionRequestTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcActionRequestTypeEnum.EMAIL:
						PredefinedType = IfcActionRequestTypeEnum.EMAIL;
						return;
					case Ifc4.Interfaces.IfcActionRequestTypeEnum.FAX:
						PredefinedType = IfcActionRequestTypeEnum.FAX;
						return;
					case Ifc4.Interfaces.IfcActionRequestTypeEnum.PHONE:
						PredefinedType = IfcActionRequestTypeEnum.PHONE;
						return;
					case Ifc4.Interfaces.IfcActionRequestTypeEnum.POST:
						PredefinedType = IfcActionRequestTypeEnum.POST;
						return;
					case Ifc4.Interfaces.IfcActionRequestTypeEnum.VERBAL:
						PredefinedType = IfcActionRequestTypeEnum.VERBAL;
						return;
					case Ifc4.Interfaces.IfcActionRequestTypeEnum.USERDEFINED:
						PredefinedType = IfcActionRequestTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcActionRequestTypeEnum.NOTDEFINED:
						PredefinedType = IfcActionRequestTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcActionRequest), 8)]
		Ifc4.MeasureResource.IfcLabel? IIfcActionRequest.Status 
		{ 
			get
			{
				if (!Status.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Status.Value);
			} 
			set
			{
				Status = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcActionRequest), 9)]
		Ifc4.MeasureResource.IfcText? IIfcActionRequest.LongDescription 
		{ 
			get
			{
				if (!LongDescription.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(LongDescription.Value);
			} 
			set
			{
				LongDescription = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}
	//## Custom code
	//##
	}
}