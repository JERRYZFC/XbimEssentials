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
	public partial class @IfcPresentationLayerWithStyle : IIfcPresentationLayerWithStyle
	{

		[CrossSchemaAttribute(typeof(IIfcPresentationLayerWithStyle), 5)]
		Ifc4.MeasureResource.IfcLogical IIfcPresentationLayerWithStyle.LayerOn 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLogical(LayerOn);
			} 
			set
			{
				LayerOn = new MeasureResource.IfcLogical(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPresentationLayerWithStyle), 6)]
		Ifc4.MeasureResource.IfcLogical IIfcPresentationLayerWithStyle.LayerFrozen 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLogical(LayerFrozen);
			} 
			set
			{
				LayerFrozen = new MeasureResource.IfcLogical(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPresentationLayerWithStyle), 7)]
		Ifc4.MeasureResource.IfcLogical IIfcPresentationLayerWithStyle.LayerBlocked 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLogical(LayerBlocked);
			} 
			set
			{
				LayerBlocked = new MeasureResource.IfcLogical(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcPresentationLayerWithStyle), 8)]
		IItemSet<IIfcPresentationStyle> IIfcPresentationLayerWithStyle.LayerStyles 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<PresentationAppearanceResource.IfcPresentationStyle, IIfcPresentationStyle>(LayerStyles);
			} 
		}
	//## Custom code
	//##
	}
}