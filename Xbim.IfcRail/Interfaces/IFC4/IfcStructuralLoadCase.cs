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
namespace Xbim.IfcRail.StructuralAnalysisDomain
{
	public partial class @IfcStructuralLoadCase : IIfcStructuralLoadCase
	{

		[CrossSchemaAttribute(typeof(IIfcStructuralLoadCase), 11)]
		IItemSet<Xbim.Ifc4.MeasureResource.IfcRatioMeasure> IIfcStructuralLoadCase.SelfWeightCoefficients 
		{ 
			get
			{
			
				return new Common.Collections.ProxyValueSet<MeasureResource.IfcRatioMeasure, Ifc4.MeasureResource.IfcRatioMeasure>(SelfWeightCoefficients, 
					s => new Ifc4.MeasureResource.IfcRatioMeasure(s), 
					t => new MeasureResource.IfcRatioMeasure(t));
			} 
		}
	//## Custom code
	//##
	}
}