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
	public partial class @IfcShellBasedSurfaceModel : IIfcShellBasedSurfaceModel
	{

		[CrossSchemaAttribute(typeof(IIfcShellBasedSurfaceModel), 1)]
		IItemSet<IIfcShell> IIfcShellBasedSurfaceModel.SbsmBoundary 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<TopologyResource.IfcShell, IIfcShell>(SbsmBoundary);
			} 
		}
		Ifc4.GeometryResource.IfcDimensionCount IIfcShellBasedSurfaceModel.Dim 
		{
			get 
			{
				return new Ifc4.GeometryResource.IfcDimensionCount(Dim);
			}
		}

	//## Custom code
	//##
	}
}