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
namespace Xbim.IfcRail.GeometryResource
{
	public partial class @IfcSurfaceCurve : IIfcSurfaceCurve
	{

		[CrossSchemaAttribute(typeof(IIfcSurfaceCurve), 1)]
		IIfcCurve IIfcSurfaceCurve.Curve3D 
		{ 
			get
			{
				return Curve3D;
			} 
			set
			{
				Curve3D = value as IfcCurve;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcSurfaceCurve), 2)]
		IItemSet<IIfcPcurve> IIfcSurfaceCurve.AssociatedGeometry 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcPcurve, IIfcPcurve>(AssociatedGeometry);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcSurfaceCurve), 3)]
		Ifc4.Interfaces.IfcPreferredSurfaceCurveRepresentation IIfcSurfaceCurve.MasterRepresentation 
		{ 
			get
			{
				//## Custom code to handle enumeration of MasterRepresentation
				//##
				switch (MasterRepresentation)
				{
					case IfcPreferredSurfaceCurveRepresentation.CURVE3D:
						return Ifc4.Interfaces.IfcPreferredSurfaceCurveRepresentation.CURVE3D;
					case IfcPreferredSurfaceCurveRepresentation.PCURVE_S1:
						return Ifc4.Interfaces.IfcPreferredSurfaceCurveRepresentation.PCURVE_S1;
					case IfcPreferredSurfaceCurveRepresentation.PCURVE_S2:
						return Ifc4.Interfaces.IfcPreferredSurfaceCurveRepresentation.PCURVE_S2;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of MasterRepresentation
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcPreferredSurfaceCurveRepresentation.CURVE3D:
						MasterRepresentation = IfcPreferredSurfaceCurveRepresentation.CURVE3D;
						return;
					case Ifc4.Interfaces.IfcPreferredSurfaceCurveRepresentation.PCURVE_S1:
						MasterRepresentation = IfcPreferredSurfaceCurveRepresentation.PCURVE_S1;
						return;
					case Ifc4.Interfaces.IfcPreferredSurfaceCurveRepresentation.PCURVE_S2:
						MasterRepresentation = IfcPreferredSurfaceCurveRepresentation.PCURVE_S2;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		List<IIfcSurface> IIfcSurfaceCurve.BasisSurface 
		{
			get 
			{
				//## Getter for BasisSurface in an interface
				//TODO: Implement getter for derived attribute BasisSurface in an interface
				throw new System.NotImplementedException();
				//##
			}
		}

	//## Custom code
	//##
	}
}