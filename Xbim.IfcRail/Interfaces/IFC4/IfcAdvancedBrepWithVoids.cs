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
namespace Xbim.IfcRail.GeometricModelResource
{
	public partial class @IfcAdvancedBrepWithVoids : IIfcAdvancedBrepWithVoids
	{

		[CrossSchemaAttribute(typeof(IIfcAdvancedBrepWithVoids), 2)]
		IItemSet<IIfcClosedShell> IIfcAdvancedBrepWithVoids.Voids 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<TopologyResource.IfcClosedShell, IIfcClosedShell>(Voids);
			} 
		}
	//## Custom code
	//##
	}
}