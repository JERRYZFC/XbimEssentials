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
namespace Xbim.IfcRail.ApprovalResource
{
	public partial class @IfcApprovalRelationship : IIfcApprovalRelationship
	{

		[CrossSchemaAttribute(typeof(IIfcApprovalRelationship), 3)]
		IIfcApproval IIfcApprovalRelationship.RelatingApproval 
		{ 
			get
			{
				return RelatingApproval;
			} 
			set
			{
				RelatingApproval = value as IfcApproval;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcApprovalRelationship), 4)]
		IItemSet<IIfcApproval> IIfcApprovalRelationship.RelatedApprovals 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcApproval, IIfcApproval>(RelatedApprovals);
			} 
		}
	//## Custom code
	//##
	}
}