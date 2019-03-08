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
namespace Xbim.IfcRail.StructuralElementsDomain
{
	public partial class @IfcReinforcingBar : IIfcReinforcingBar
	{

		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 10)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingBar.NominalDiameter 
		{ 
			get
			{
				if (!NominalDiameter.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(NominalDiameter.Value);
			} 
			set
			{
				NominalDiameter = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 11)]
		Ifc4.MeasureResource.IfcAreaMeasure? IIfcReinforcingBar.CrossSectionArea 
		{ 
			get
			{
				if (!CrossSectionArea.HasValue) return null;
				return new Ifc4.MeasureResource.IfcAreaMeasure(CrossSectionArea.Value);
			} 
			set
			{
				CrossSectionArea = value.HasValue ? 
					new MeasureResource.IfcAreaMeasure(value.Value) :  
					 new MeasureResource.IfcAreaMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 12)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcReinforcingBar.BarLength 
		{ 
			get
			{
				if (!BarLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(BarLength.Value);
			} 
			set
			{
				BarLength = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 13)]
		Ifc4.Interfaces.IfcReinforcingBarTypeEnum? IIfcReinforcingBar.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcReinforcingBarTypeEnum.ANCHORING:
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.ANCHORING;
					case IfcReinforcingBarTypeEnum.EDGE:
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.EDGE;
					case IfcReinforcingBarTypeEnum.LIGATURE:
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.LIGATURE;
					case IfcReinforcingBarTypeEnum.MAIN:
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.MAIN;
					case IfcReinforcingBarTypeEnum.PUNCHING:
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.PUNCHING;
					case IfcReinforcingBarTypeEnum.RING:
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.RING;
					case IfcReinforcingBarTypeEnum.SHEAR:
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.SHEAR;
					case IfcReinforcingBarTypeEnum.STUD:
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.STUD;
					case IfcReinforcingBarTypeEnum.SPACEBAR:
						//## Handle translation of SPACEBAR member from IfcReinforcingBarTypeEnum in property PredefinedType
						//TODO: Handle translation of SPACEBAR member from IfcReinforcingBarTypeEnum in property PredefinedType
						throw new System.NotImplementedException();
						//##
					case IfcReinforcingBarTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.USERDEFINED;
					case IfcReinforcingBarTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcReinforcingBarTypeEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of PredefinedType
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.ANCHORING:
						PredefinedType = IfcReinforcingBarTypeEnum.ANCHORING;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.EDGE:
						PredefinedType = IfcReinforcingBarTypeEnum.EDGE;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.LIGATURE:
						PredefinedType = IfcReinforcingBarTypeEnum.LIGATURE;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.MAIN:
						PredefinedType = IfcReinforcingBarTypeEnum.MAIN;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.PUNCHING:
						PredefinedType = IfcReinforcingBarTypeEnum.PUNCHING;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.RING:
						PredefinedType = IfcReinforcingBarTypeEnum.RING;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.SHEAR:
						PredefinedType = IfcReinforcingBarTypeEnum.SHEAR;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.STUD:
						PredefinedType = IfcReinforcingBarTypeEnum.STUD;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.USERDEFINED:
						PredefinedType = IfcReinforcingBarTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarTypeEnum.NOTDEFINED:
						PredefinedType = IfcReinforcingBarTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcReinforcingBar), 14)]
		Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum? IIfcReinforcingBar.BarSurface 
		{ 
			get
			{
				//## Custom code to handle enumeration of BarSurface
				//##
				switch (BarSurface)
				{
					case ProfileResource.IfcReinforcingBarSurfaceEnum.PLAIN:
						return Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.PLAIN;
					case ProfileResource.IfcReinforcingBarSurfaceEnum.TEXTURED:
						return Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.TEXTURED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of BarSurface
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.PLAIN:
						BarSurface = ProfileResource.IfcReinforcingBarSurfaceEnum.PLAIN;
						return;
					case Ifc4.Interfaces.IfcReinforcingBarSurfaceEnum.TEXTURED:
						BarSurface = ProfileResource.IfcReinforcingBarSurfaceEnum.TEXTURED;
						return;
					
					case null:
						BarSurface = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
	//## Custom code
	//##
	}
}