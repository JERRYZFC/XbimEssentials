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
namespace Xbim.IfcRail.Kernel
{
	public partial class @IfcRelDefinesByType : IIfcRelDefinesByType
	{

		[CrossSchemaAttribute(typeof(IIfcRelDefinesByType), 5)]
		IItemSet<IIfcObject> IIfcRelDefinesByType.RelatedObjects 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcObject, IIfcObject>(RelatedObjects);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcRelDefinesByType), 6)]
		IIfcTypeObject IIfcRelDefinesByType.RelatingType 
		{ 
			get
			{
				return RelatingType;
			} 
			set
			{
				RelatingType = value as IfcTypeObject;
				
			}
		}
	//## Custom code
	//##
	}
}