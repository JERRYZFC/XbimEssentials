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
	public partial class @IfcBlobTexture : IIfcBlobTexture
	{

		[CrossSchemaAttribute(typeof(IIfcBlobTexture), 6)]
		Ifc4.MeasureResource.IfcIdentifier IIfcBlobTexture.RasterFormat 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcIdentifier(RasterFormat);
			} 
			set
			{
				RasterFormat = new MeasureResource.IfcIdentifier(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcBlobTexture), 7)]
		Ifc4.MeasureResource.IfcBinary IIfcBlobTexture.RasterCode 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcBinary(RasterCode);
			} 
			set
			{
				RasterCode = new MeasureResource.IfcBinary(value);
				
			}
		}
	//## Custom code
	//##
	}
}