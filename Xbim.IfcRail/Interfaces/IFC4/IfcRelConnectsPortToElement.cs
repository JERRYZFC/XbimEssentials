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
namespace Xbim.IfcRail.ProductExtension
{
	public partial class @IfcRelConnectsPortToElement : IIfcRelConnectsPortToElement
	{

		[CrossSchemaAttribute(typeof(IIfcRelConnectsPortToElement), 5)]
		IIfcPort IIfcRelConnectsPortToElement.RelatingPort 
		{ 
			get
			{
				return RelatingPort;
			} 
			set
			{
				RelatingPort = value as IfcPort;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcRelConnectsPortToElement), 6)]
		IIfcDistributionElement IIfcRelConnectsPortToElement.RelatedElement 
		{ 
			get
			{
				return RelatedElement;
			} 
			set
			{
				RelatedElement = value as IfcDistributionElement;
				
			}
		}
	//## Custom code
	//##
	}
}