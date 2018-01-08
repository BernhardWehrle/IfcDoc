// This file was automatically generated from IFCDOC at www.buildingsmart-tech.org.
// IFC content is copyright (C) 1996-2018 BuildingSMART International Ltd.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;


namespace BuildingSmart.IFC.IfcMeasureResource
{
	[Guid("f35610cd-065e-4917-84ec-747793b4f51e")]
	public partial struct IfcText :
		BuildingSmart.IFC.IfcConstraintResource.IfcMetricValueSelect,
		BuildingSmart.IFC.IfcMeasureResource.IfcSimpleValue
	{
		[XmlText]
		public String Value;
	
		public IfcText(String value)
		{
			this.Value = value;
		}
	}
	
}