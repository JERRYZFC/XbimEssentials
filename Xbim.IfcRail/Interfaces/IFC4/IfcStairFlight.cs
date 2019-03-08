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
namespace Xbim.IfcRail.SharedBldgElements
{
	public partial class @IfcStairFlight : IIfcStairFlight
	{

		[CrossSchemaAttribute(typeof(IIfcStairFlight), 9)]
		Ifc4.MeasureResource.IfcInteger? IIfcStairFlight.NumberOfRisers 
		{ 
			get
			{
				if (!NumberOfRisers.HasValue) return null;
				return new Ifc4.MeasureResource.IfcInteger(NumberOfRisers.Value);
			} 
			set
			{
				NumberOfRisers = value.HasValue ? 
					new MeasureResource.IfcInteger(value.Value) :  
					 new MeasureResource.IfcInteger?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStairFlight), 10)]
		Ifc4.MeasureResource.IfcInteger? IIfcStairFlight.NumberOfTreads 
		{ 
			get
			{
				if (!NumberOfTreads.HasValue) return null;
				return new Ifc4.MeasureResource.IfcInteger(NumberOfTreads.Value);
			} 
			set
			{
				NumberOfTreads = value.HasValue ? 
					new MeasureResource.IfcInteger(value.Value) :  
					 new MeasureResource.IfcInteger?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStairFlight), 11)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcStairFlight.RiserHeight 
		{ 
			get
			{
				if (!RiserHeight.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(RiserHeight.Value);
			} 
			set
			{
				RiserHeight = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStairFlight), 12)]
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcStairFlight.TreadLength 
		{ 
			get
			{
				if (!TreadLength.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(TreadLength.Value);
			} 
			set
			{
				TreadLength = value.HasValue ? 
					new MeasureResource.IfcPositiveLengthMeasure(value.Value) :  
					 new MeasureResource.IfcPositiveLengthMeasure?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcStairFlight), 13)]
		Ifc4.Interfaces.IfcStairFlightTypeEnum? IIfcStairFlight.PredefinedType 
		{ 
			get
			{
				//## Custom code to handle enumeration of PredefinedType
				//##
				switch (PredefinedType)
				{
					case IfcStairFlightTypeEnum.STRAIGHT:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.STRAIGHT;
					case IfcStairFlightTypeEnum.WINDER:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.WINDER;
					case IfcStairFlightTypeEnum.SPIRAL:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.SPIRAL;
					case IfcStairFlightTypeEnum.CURVED:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.CURVED;
					case IfcStairFlightTypeEnum.FREEFORM:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.FREEFORM;
					case IfcStairFlightTypeEnum.USERDEFINED:
						//## Optional custom handling of PredefinedType == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.USERDEFINED;
					case IfcStairFlightTypeEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcStairFlightTypeEnum.NOTDEFINED;
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
					case Ifc4.Interfaces.IfcStairFlightTypeEnum.STRAIGHT:
						PredefinedType = IfcStairFlightTypeEnum.STRAIGHT;
						return;
					case Ifc4.Interfaces.IfcStairFlightTypeEnum.WINDER:
						PredefinedType = IfcStairFlightTypeEnum.WINDER;
						return;
					case Ifc4.Interfaces.IfcStairFlightTypeEnum.SPIRAL:
						PredefinedType = IfcStairFlightTypeEnum.SPIRAL;
						return;
					case Ifc4.Interfaces.IfcStairFlightTypeEnum.CURVED:
						PredefinedType = IfcStairFlightTypeEnum.CURVED;
						return;
					case Ifc4.Interfaces.IfcStairFlightTypeEnum.FREEFORM:
						PredefinedType = IfcStairFlightTypeEnum.FREEFORM;
						return;
					case Ifc4.Interfaces.IfcStairFlightTypeEnum.USERDEFINED:
						PredefinedType = IfcStairFlightTypeEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcStairFlightTypeEnum.NOTDEFINED:
						PredefinedType = IfcStairFlightTypeEnum.NOTDEFINED;
						return;
					
					case null:
						PredefinedType = null;
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