// 
// System.Data/DataSet.cs
//
// Author:
//   Stuart Caborn <stuart.caborn@virgin.net>
//
// (C) Stuart Caborn 2002

using System.Xml;
using System.Xml.Schema;

namespace System.Data 
{
///<summary>
///Constants class to hold XmlSerialisation
///strings
///</summary>
internal class XmlConstants
{
	///<summary>The namespace prefix for the xml schema namespace</summary>
	public const string SchemaPrefix = "xs";
	
	///<summary>
	/// The w3 XmlSchema namespace
	/// </summary>
	public const string SchemaNamespace = "http://www.w3.org/2001/XMLSchema";
	
	
	//xs elements and values 
	//TODO - these must exist somwhere else???
	public const string SchemaElement = "schema";
	public const string AttributeFormDefault = "attributeFormDefault";
	public const string ElementFormDefault = "elementFormDefault";
	public const string Qualified = "qualified";
	public const string Unqualified = "unqualified";
	public const string Element = "element";
	public const string Choice = "choice";
	public const string ComplexType = "complexType";
	public const string SimpleType = "simpleType";
	public const string Restriction = "restriction";
	public const string MaxLength = "maxLength";
	public const string Sequence = "sequence";
	public const string MaxOccurs = "maxOccurs";
	public const string MinOccurs = "minOccurs";
	public const string Unbounded = "unbounded";
	public const string Name = "name";
	public const string Type = "type";
	public const string Id = "id";
	public const string TargetNamespace = "targetNamespace";
	public const string Form = "form";
	public const string Attribute = "attribute";
	public const string Default = "default";
	public const string Caption = "Caption";
	public const string Base = "base";
	public const string Value = "value";

	//ms schema objects	
	public const string MsdataPrefix = "msdata";	
	public const string MsdataNamespace = "urn:schemas-microsoft-com:xml-msdata";
	public const string DiffgrPrefix = "diffgr";
	public const string DiffgrNamespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
	public const string TnsPrefix = "mstns";
	public const string IsDataSet = "IsDataSet";
	public const string Locale = "Locale";
	public const string Ordinal = "Ordinal";
	public const string IsNested = "IsNested";
	public const string RelationName = "RelationName";
	public const string ConstraintName = "ConstraintName";

	public static XmlQualifiedName QnString = new XmlQualifiedName ("string", XmlSchema.Namespace);
	public static XmlQualifiedName QnShort = new XmlQualifiedName ("short", XmlSchema.Namespace);
	public static XmlQualifiedName QnInt = new XmlQualifiedName ("int", XmlSchema.Namespace);
	public static XmlQualifiedName QnLong = new XmlQualifiedName ("long", XmlSchema.Namespace);
	public static XmlQualifiedName QnBoolean = new XmlQualifiedName ("boolean", XmlSchema.Namespace);
	public static XmlQualifiedName QnUnsignedByte = new XmlQualifiedName ("unsignedByte", XmlSchema.Namespace);
	public static XmlQualifiedName QnChar = new XmlQualifiedName ("char", XmlSchema.Namespace);
	public static XmlQualifiedName QnDateTime = new XmlQualifiedName ("dateTime", XmlSchema.Namespace);
	public static XmlQualifiedName QnDecimal = new XmlQualifiedName ("decimal", XmlSchema.Namespace);
	public static XmlQualifiedName QnDouble = new XmlQualifiedName ("double", XmlSchema.Namespace);
	public static XmlQualifiedName QnSbyte = new XmlQualifiedName ("byte", XmlSchema.Namespace);
	public static XmlQualifiedName QnFloat = new XmlQualifiedName ("float", XmlSchema.Namespace);
	public static XmlQualifiedName QnDuration = new XmlQualifiedName ("duration", XmlSchema.Namespace);
	public static XmlQualifiedName QnUsignedShort = new XmlQualifiedName ("usignedShort", XmlSchema.Namespace);
	public static XmlQualifiedName QnUnsignedInt = new XmlQualifiedName ("unsignedInt", XmlSchema.Namespace);
	public static XmlQualifiedName QnUnsignedLong = new XmlQualifiedName ("unsignedLong", XmlSchema.Namespace);
	public static XmlQualifiedName QnUri = new XmlQualifiedName ("anyURI", XmlSchema.Namespace);
	public static XmlQualifiedName QnBase64Binary = new XmlQualifiedName ("base64Binary", XmlSchema.Namespace);
	public static XmlQualifiedName QnXmlQualifiedName = new XmlQualifiedName ("QName", XmlSchema.Namespace);
}

}
