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
	public partial class @IfcIndexedPolygonalFace : IIfcIndexedPolygonalFace
	{

		[CrossSchemaAttribute(typeof(IIfcIndexedPolygonalFace), 1)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcPositiveInteger> IIfcIndexedPolygonalFace.CoordIndex 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcPositiveInteger, Ifc4.MeasureResource.IfcPositiveInteger>(CoordIndex, 
					s => new Ifc4.MeasureResource.IfcPositiveInteger(s), 
					t => new MeasureResource.IfcPositiveInteger(t));
			} 
		}
		IEnumerable<IIfcPolygonalFaceSet> IIfcIndexedPolygonalFace.ToFaceSet 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPolygonalFaceSet>(e => e.Faces != null &&  e.Faces.Contains(this), "Faces", this);
			} 
		}
	//## Custom code
	//##
	}
}