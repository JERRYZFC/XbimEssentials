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
namespace Xbim.IfcRail.PresentationAppearanceResource
{
	public partial class @IfcFillAreaStyle : IIfcFillAreaStyle
	{

		[CrossSchemaAttribute(typeof(IIfcFillAreaStyle), 2)]
		IItemSet<IIfcFillStyleSelect> IIfcFillAreaStyle.FillStyles 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcFillStyleSelect, IIfcFillStyleSelect>(FillStyles);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcFillAreaStyle), 3)]
		Ifc4.MeasureResource.IfcBoolean? IIfcFillAreaStyle.ModelorDraughting 
		{ 
			get
			{
				if (!ModelorDraughting.HasValue) return null;
				return new Ifc4.MeasureResource.IfcBoolean(ModelorDraughting.Value);
			} 
			set
			{
				ModelorDraughting = value.HasValue ? 
					new MeasureResource.IfcBoolean(value.Value) :  
					 new MeasureResource.IfcBoolean?() ;
				
			}
		}
	//## Custom code
	//##
	}
}