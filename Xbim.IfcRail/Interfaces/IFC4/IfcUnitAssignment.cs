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
namespace Xbim.IfcRail.MeasureResource
{
	public partial class @IfcUnitAssignment : IIfcUnitAssignment
	{

		[CrossSchemaAttribute(typeof(IIfcUnitAssignment), 1)]
		IItemSet<IIfcUnit> IIfcUnitAssignment.Units 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcUnit, IIfcUnit>(Units);
			} 
		}
	//## Custom code
	//##
	}
}