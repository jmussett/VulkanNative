using System.Xml.Serialization;

namespace VulkanNative.Generator.Registry;

[XmlRoot("platform")]
public class VkPlatform
{
    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("protect")]
    public string? Protect { get; set; }

    [XmlAttribute("comment")]
    public string? Comment { get; set; }
}

[XmlRoot("tag")]
public class VkTag
{
    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("author")]
    public string? Author { get; set; }

    [XmlAttribute("contact")]
    public string? Contact { get; set; }
}

[XmlRoot("type")]
public class VkType
{
    [XmlAttribute("name")]
    public string? NameAttribute { get; set; }

    [XmlElement("name")]
    public string? Name { get; set; }

    [XmlAttribute("category")]
    public string? Category { get; set; }

    [XmlText]
    public List<string> TextEntries { get; set; }

    [XmlAttribute("requires")]
    public string? Requires { get; set; }

    [XmlAttribute("deprecated")]
    public string? Deprecated { get; set; }

    [XmlElement("type")]
    public List<string> Types { get; set; }

    [XmlAttribute("api")]
    public string? Api { get; set; }

    [XmlAttribute("alias")]
    public string? Alias { get; set; }

    [XmlAttribute("bitvalues")]
    public string? BitValues { get; set; }

    [XmlAttribute("objtypeenum")]
    public string? ObjTypeEnum { get; set; }

    [XmlAttribute("parent")]
    public string? Parent { get; set; }

    [XmlElement("member")]
    public List<VkMember> Members { get; set; } = new();

    [XmlAttribute("returnedonly")]
    public string? ReturnedOnly { get; set; }

    [XmlAttribute("structextends")]
    public string[] StructExtends { get; set; } = Array.Empty<string>();

    [XmlAttribute("allowduplicate")]
    public string? AllowDuplicate { get; set; }
}

[XmlRoot("member")]
public class VkMember
{
    [XmlElement("type")]
    public string? Type { get; set; }

    [XmlText]
    public string? PostTypeText { get; set; }

    [XmlElement("name")]
    public string? Name { get; set; }

    [XmlAttribute("optional")]
    public string[] OptionalValues { get; set; } = Array.Empty<string>();

    [XmlAttribute("noautovalidity")]
    public string? Noautovalidity { get; set; }

    [XmlAttribute("limittype")]
    public string[] LimitType { get; set; } = Array.Empty<string>();

    [XmlElement("enum")]
    public string? Enum { get; set; }

    [XmlElement("comment")]
    public string? Comment { get; set; }

    [XmlAttribute("values")]
    public string? Values { get; set; }

    [XmlAttribute("len")]
    public string[] Len { get; set; } = Array.Empty<string>();

    [XmlAttribute("deprecated")]
    public string? Deprecated { get; set; }

    [XmlAttribute("altlen")]
    public string? AltLen { get; set; }

    [XmlAttribute("api")]
    public string? Api { get; set; }

    [XmlAttribute("objecttype")]
    public string? ObjectType { get; set; }

    [XmlAttribute("externsync")]
    public string? ExternSync { get; set; }

    [XmlAttribute("selection")]
    public string[] Selection { get; set; } = Array.Empty<string>();

    [XmlAttribute("selector")]
    public string? Selector { get; set; }
}

[XmlRoot("enum")]
public class VkEnum
{
    [XmlAttribute("type")]
    public string? Type { get; set; }

    [XmlAttribute("value")]
    public string? Value { get; set; }

    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("alias")]
    public string? Alias { get; set; }

    [XmlAttribute("comment")]
    public string? Comment { get; set; }

    [XmlAttribute("bitpos")]
    public string? Bitpos { get; set; }

    [XmlAttribute("api")]
    public string? Api { get; set; }

    [XmlAttribute("deprecated")]
    public string? Deprecated { get; set; }

    [XmlAttribute("extends")]
    public string? Extends { get; set; }

    [XmlAttribute("extnumber")]
    public string? Extnumber { get; set; }

    [XmlAttribute("offset")]
    public string? Offset { get; set; }

    [XmlAttribute("dir")]
    public string? Dir { get; set; }

    [XmlAttribute("protect")]
    public string? Protect { get; set; }
}

[XmlRoot("enums")]
public class VkEnums
{
    [XmlElement("enum")]
    public List<VkEnum> Enums { get; set; } = new();

    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("comment")]
    public string? Comment { get; set; }

    [XmlAttribute("type")]
    public string? Type { get; set; }

    [XmlElement("unused")]
    public VkUnused? Unused { get; set; }

    [XmlAttribute("bitwidth")]
    public string? BitWidth { get; set; }
}

[XmlRoot("unused")]
public class VkUnused
{
    [XmlAttribute("start")]
    public string? Start { get; set; }

    [XmlAttribute("comment")]
    public string? Comment { get; set; }
}

[XmlRoot("proto")]
public class VkProto
{
    [XmlElement("type")]
    public string? Type { get; set; }

    [XmlElement("name")]
    public string? Name { get; set; }
}

[XmlRoot("param")]
public class VkParam
{
    [XmlElement("type")]
    public string? Type { get; set; }

    [XmlText]
    public string? PostTypeText { get; set; }

    [XmlElement("name")]
    public string? Name { get; set; }

    [XmlAttribute("optional")]
    public string[] Optional { get; set; } = Array.Empty<string>();

    [XmlAttribute("externsync")]
    public string? ExternSync { get; set; }

    [XmlAttribute("len")]
    public string? Len { get; set; }

    [XmlAttribute("noautovalidity")]
    public string? NoAutoValidity { get; set; }

    [XmlAttribute("stride")]
    public string? Stride { get; set; }

    [XmlAttribute("api")]
    public string? Api { get; set; }

    [XmlAttribute("objecttype")]
    public string? Objecttype { get; set; }

    [XmlAttribute("altlen")]
    public string? Altlen { get; set; }

    [XmlAttribute("validstructs")]
    public string? Validstructs { get; set; }
}

[XmlRoot("command")]
public class VkCommand
{
    [XmlElement("proto")]
    public VkProto? Proto { get; set; }

    [XmlElement("param")]
    public List<VkParam> Params { get; set; } = new();

    [XmlAttribute("successcodes")]
    public string[] SuccessCodes { get; set; } = Array.Empty<string>();

    [XmlAttribute("errorcodes")]
    public string[] ErrorCodes { get; set; } = Array.Empty<string>();

    [XmlElement("implicitexternsyncparams")]
    public VkImplicitExternSyncParams? ImplicitExternSyncParams { get; set; }

    [XmlAttribute("api")]
    public string? Api { get; set; }

    [XmlAttribute("queues")]
    public string[] Queues { get; set; } = Array.Empty<string>();

    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("alias")]
    public string? Alias { get; set; }

    [XmlAttribute("renderpass")]
    public string? RenderPass { get; set; }


    [XmlAttribute("cmdbufferlevel")]
    public string? CmdBufferLevel { get; set; }

    [XmlAttribute("tasks")]
    public string? Tasks { get; set; }

    [XmlAttribute("comment")]
    public string? Comment { get; set; }

    [XmlAttribute("videocoding")]
    public string? VideoCoding { get; set; }
}

[XmlRoot("implicitexternsyncparams")]
public class VkImplicitExternSyncParams
{
    [XmlElement("param")]
    public string? Param { get; set; }
}

[XmlRoot("require")]
public class VkRequire
{
    [XmlElement("type")]
    public List<VkType> Types { get; set; } = new();

    [XmlAttribute("comment")]
    public string? Comment { get; set; }

    [XmlElement("enum")]
    public List<VkEnum> Enums { get; set; } = new();

    [XmlElement("command")]
    public List<VkCommand> Commands { get; set; } = new();

    [XmlAttribute("depends")]
    public string[] Depends { get; set; } = Array.Empty<string>();

    [XmlAttribute("api")]
    public string? Api { get; set; }
}

[XmlRoot("feature")]
public class VkFeature
{
    [XmlElement("require")]
    public List<VkRequire> Requires { get; set; } = new();

    [XmlAttribute("api")]
    public string[] Apis { get; set; } = Array.Empty<string>();

    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("number")]
    public string? Number { get; set; }

    [XmlAttribute("comment")]
    public string? Comment { get; set; }
}

[XmlRoot("extension")]
public class VkExtension
{
    [XmlElement("require")]
    public List<VkRequire> Requires { get; set; } = new();

    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("number")]
    public string? Number { get; set; }

    [XmlAttribute("type")]
    public string? Type { get; set; }

    [XmlAttribute("author")]
    public string? Author { get; set; }

    [XmlAttribute("contact")]
    public string? Contact { get; set; }

    [XmlAttribute("supported")]
    public string? Supported { get; set; }

    [XmlAttribute("depends")]
    public string? Depends { get; set; }

    [XmlAttribute("platform")]
    public string? Platform { get; set; }

    [XmlAttribute("comment")]
    public string? Comment { get; set; }

    [XmlAttribute("specialuse")]
    public string? SpecialUse { get; set; }

    [XmlAttribute("deprecatedby")]
    public string? DeprecatedBy { get; set; }

    [XmlAttribute("promotedto")]
    public string? PromotedTo { get; set; }

    [XmlAttribute("obsoletedby")]
    public string? ObsoletedBy { get; set; }

    [XmlAttribute("provisional")]
    public string? Provisional { get; set; }

    [XmlAttribute("sortorder")]
    public string? SortOrder { get; set; }
}

[XmlRoot("component")]
public class VkComponent
{
    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("bits")]
    public string? Bits { get; set; }

    [XmlAttribute("numericFormat")]
    public string? NumericFormat { get; set; }

    [XmlAttribute("planeIndex")]
    public string? PlaneIndex { get; set; }
}

[XmlRoot("format")]
public class VkFormat
{
    [XmlElement("component")]
    public List<VkComponent> Components { get; set; } = new();

    [XmlAttribute("name")]
    public string? Name { get; set; }

    [XmlAttribute("class")]
    public string? Class { get; set; }

    [XmlAttribute("blockSize")]
    public string? BlockSize { get; set; }

    [XmlAttribute("texelsPerBlock")]
    public string? TexelsPerBlock { get; set; }

    [XmlAttribute("packed")]
    public string? Packed { get; set; }

    [XmlElement("spirvimageformat")]
    public VkSpirvImageFormat? SpirvImageFormat { get; set; }

    [XmlAttribute("blockExtent")]
    public string? BlockExtent { get; set; }

    [XmlAttribute("compressed")]
    public string? Compressed { get; set; }

    [XmlAttribute("chroma")]
    public string? Chroma { get; set; }

    [XmlElement("plane")]
    public List<VkPlane> Planes { get; set; } = new();
}

[XmlRoot("spirvimageformat")]
public class VkSpirvImageFormat
{
    [XmlAttribute("name")]
    public string? Name { get; set; }
}

[XmlRoot("plane")]
public class VkPlane
{
    [XmlAttribute("index")]
    public string? Index { get; set; }

    [XmlAttribute("widthDivisor")]
    public string? WidthDivisor { get; set; }

    [XmlAttribute("heightDivisor")]
    public string? HeightDivisor { get; set; }

    [XmlAttribute("compatible")]
    public string? Compatible { get; set; }
}

[XmlRoot("enable")]
public class VkEnable
{
    [XmlAttribute("version")]
    public string? Version { get; set; }

    [XmlAttribute("extension")]
    public string? Extension { get; set; }

    [XmlAttribute("struct")]
    public string? Struct { get; set; }

    [XmlAttribute("feature")]
    public string? Feature { get; set; }

    [XmlAttribute("requires")]
    public string? Requires { get; set; }

    [XmlAttribute("property")]
    public string? Property { get; set; }

    [XmlAttribute("member")]
    public string? Member { get; set; }

    [XmlAttribute("value")]
    public string? Value { get; set; }

    [XmlAttribute("alias")]
    public string? Alias { get; set; }
}

[XmlRoot("spirvextension")]
public class VkSpirvExtension
{
    [XmlElement("enable")]
    public List<VkEnable> Enables { get; set; } = new();

    [XmlAttribute("name")]
    public string? Name { get; set; }
}

[XmlRoot("spirvcapability")]
public class VkSpirvCapability
{
    [XmlElement("enable")]
    public List<VkEnable> Enables { get; set; } = new();
    [XmlAttribute("name")]
    public string? Name { get; set; }
}

[XmlRoot("registry")]
public class VkRegistry
{
    [XmlArray("platforms")]
    [XmlArrayItem("platform")]
    public List<VkPlatform> Platforms { get; set; } = new();

    [XmlArray("tags")]
    [XmlArrayItem("tags")]
    public List<VkTag> Tags { get; set; } = new();

    [XmlArray("types")]
    [XmlArrayItem("type")]
    public List<VkType> Types { get; set; } = new();

    [XmlElement("enums")]
    public List<VkEnums> Enums { get; set; } = new();

    [XmlArray("commands")]
    [XmlArrayItem("command")]
    public List<VkCommand> Commands { get; set; } = new();

    [XmlElement("feature")]
    public List<VkFeature> Feature { get; set; } = new();

    [XmlArray("extensions")]
    [XmlArrayItem("extension")]
    public List<VkExtension> Extensions { get; set; } = new();

    [XmlArray("formats")]
    [XmlArrayItem("format")]
    public List<VkFormat> Formats { get; set; } = new();

    [XmlArray("spirvextensions")]
    [XmlArrayItem("spirvextension")]
    public List<VkSpirvExtension> SpirvExtensions { get; set; } = new();

    [XmlArray("spirvcapabilities")]
    [XmlArrayItem("spirvcapability")]
    public List<VkSpirvCapability> SpirvCapabilities { get; set; } = new();
}