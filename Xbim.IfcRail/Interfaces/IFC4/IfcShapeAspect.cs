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
namespace Xbim.IfcRail.RepresentationResource
{
	public partial class @IfcShapeAspect : IIfcShapeAspect
	{

		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 1)]
		IItemSet<IIfcShapeModel> IIfcShapeAspect.ShapeRepresentations 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<IfcShapeModel, IIfcShapeModel>(ShapeRepresentations);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 2)]
		Ifc4.MeasureResource.IfcLabel? IIfcShapeAspect.Name 
		{ 
			get
			{
				if (!Name.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Name.Value);
			} 
			set
			{
				Name = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 3)]
		Ifc4.MeasureResource.IfcText? IIfcShapeAspect.Description 
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

		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 4)]
		Ifc4.MeasureResource.IfcLogical IIfcShapeAspect.ProductDefinitional 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLogical(ProductDefinitional);
			} 
			set
			{
				ProductDefinitional = new MeasureResource.IfcLogical(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcShapeAspect), 5)]
		IIfcProductRepresentationSelect IIfcShapeAspect.PartOfProductDefinitionShape 
		{ 
			get
			{
				if (PartOfProductDefinitionShape == null) return null;
				var ifcproductdefinitionshape = PartOfProductDefinitionShape as IfcProductDefinitionShape;
				if (ifcproductdefinitionshape != null) 
					return ifcproductdefinitionshape;
				var ifcrepresentationmap = PartOfProductDefinitionShape as GeometryResource.IfcRepresentationMap;
				if (ifcrepresentationmap != null) 
					return ifcrepresentationmap;
				return null;
			} 
			set
			{
				if (value == null)
				{
					PartOfProductDefinitionShape = null;
					return;
				}	
				var ifcproductdefinitionshape = value as IfcProductDefinitionShape;
				if (ifcproductdefinitionshape != null) 
				{
					PartOfProductDefinitionShape = ifcproductdefinitionshape;
					return;
				}
				var ifcrepresentationmap = value as GeometryResource.IfcRepresentationMap;
				if (ifcrepresentationmap != null) 
				{
					PartOfProductDefinitionShape = ifcrepresentationmap;
					return;
				}
				
			}
		}
	//## Custom code
	//##
	}
}