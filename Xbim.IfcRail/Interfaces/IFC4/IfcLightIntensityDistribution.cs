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
namespace Xbim.IfcRail.PresentationOrganizationResource
{
	public partial class @IfcLightIntensityDistribution : IIfcLightIntensityDistribution
	{

		[CrossSchemaAttribute(typeof(IIfcLightIntensityDistribution), 1)]
		Ifc4.Interfaces.IfcLightDistributionCurveEnum IIfcLightIntensityDistribution.LightDistributionCurve 
		{ 
			get
			{
				//## Custom code to handle enumeration of LightDistributionCurve
				//##
				switch (LightDistributionCurve)
				{
					case IfcLightDistributionCurveEnum.TYPE_A:
						return Ifc4.Interfaces.IfcLightDistributionCurveEnum.TYPE_A;
					case IfcLightDistributionCurveEnum.TYPE_B:
						return Ifc4.Interfaces.IfcLightDistributionCurveEnum.TYPE_B;
					case IfcLightDistributionCurveEnum.TYPE_C:
						return Ifc4.Interfaces.IfcLightDistributionCurveEnum.TYPE_C;
					case IfcLightDistributionCurveEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcLightDistributionCurveEnum.NOTDEFINED;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of LightDistributionCurve
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcLightDistributionCurveEnum.TYPE_A:
						LightDistributionCurve = IfcLightDistributionCurveEnum.TYPE_A;
						return;
					case Ifc4.Interfaces.IfcLightDistributionCurveEnum.TYPE_B:
						LightDistributionCurve = IfcLightDistributionCurveEnum.TYPE_B;
						return;
					case Ifc4.Interfaces.IfcLightDistributionCurveEnum.TYPE_C:
						LightDistributionCurve = IfcLightDistributionCurveEnum.TYPE_C;
						return;
					case Ifc4.Interfaces.IfcLightDistributionCurveEnum.NOTDEFINED:
						LightDistributionCurve = IfcLightDistributionCurveEnum.NOTDEFINED;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcLightIntensityDistribution), 2)]
		IItemSet<IIfcLightDistributionData> IIfcLightIntensityDistribution.DistributionData 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcLightDistributionData, IIfcLightDistributionData>(DistributionData);
			} 
		}
	//## Custom code
	//##
	}
}