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
namespace Xbim.IfcRail.MaterialResource
{
	public partial class @IfcMaterial : IIfcMaterial
	{

		[CrossSchemaAttribute(typeof(IIfcMaterial), 1)]
		Ifc4.MeasureResource.IfcLabel IIfcMaterial.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				Name = new MeasureResource.IfcLabel(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterial), 2)]
		Ifc4.MeasureResource.IfcText? IIfcMaterial.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcMaterial), 3)]
		Ifc4.MeasureResource.IfcLabel? IIfcMaterial.Category 
		{ 
			get
			{
				if (!Category.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Category.Value);
			} 
			set
			{
				Category = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IEnumerable<IIfcMaterialDefinitionRepresentation> IIfcMaterial.HasRepresentation 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialDefinitionRepresentation>(e => (e.RepresentedMaterial as IfcMaterial) == this, "RepresentedMaterial", this);
			} 
		}
		IEnumerable<IIfcMaterialRelationship> IIfcMaterial.IsRelatedWith 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialRelationship>(e => e.RelatedMaterials != null &&  e.RelatedMaterials.Contains(this), "RelatedMaterials", this);
			} 
		}
		IEnumerable<IIfcMaterialRelationship> IIfcMaterial.RelatesTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMaterialRelationship>(e => (e.RelatingMaterial as IfcMaterial) == this, "RelatingMaterial", this);
			} 
		}
	//## Custom code
	//##
	}
}