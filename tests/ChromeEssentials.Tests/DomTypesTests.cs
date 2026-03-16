using System.Text.Json;
using CloudNimble.ChromeEssentials.Protocol;

namespace CloudNimble.ChromeEssentials.Tests;

/// <summary>
/// Unit tests for DOM domain protocol types.
/// </summary>
[TestClass]
public sealed class DomTypesTests
{
    /// <summary>
    /// Verifies that GetDocumentResult deserializes the root node.
    /// </summary>
    [TestMethod]
    public void GetDocumentResult_Deserializes_RootNode()
    {
        var json = """{"root":{"nodeId":1,"backendNodeId":1,"nodeType":9,"nodeName":"#document","localName":"","nodeValue":"","childNodeCount":2}}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.GetDocumentResult);

        Assert.IsNotNull(result);
        Assert.AreEqual(1, result.Root.NodeId);
        Assert.AreEqual(9, result.Root.NodeType);
        Assert.AreEqual("#document", result.Root.NodeName);
        Assert.AreEqual(2, result.Root.ChildNodeCount);
    }

    /// <summary>
    /// Verifies that QuerySelectorParams serializes node ID and selector.
    /// </summary>
    [TestMethod]
    public void QuerySelectorParams_Serializes_Selector()
    {
        var queryParams = new QuerySelectorParams { NodeId = 1, Selector = "div.main h1" };
        var json = JsonSerializer.Serialize(queryParams, ChromeEssentialsJsonContext.Default.QuerySelectorParams);

        Assert.IsTrue(json.Contains("\"nodeId\":1"));
        Assert.IsTrue(json.Contains("\"selector\":\"div.main h1\""));
    }

    /// <summary>
    /// Verifies that QuerySelectorAllResult deserializes node ID array.
    /// </summary>
    [TestMethod]
    public void QuerySelectorAllResult_Deserializes_NodeIds()
    {
        var json = """{"nodeIds":[3,7,12]}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.QuerySelectorAllResult);

        Assert.IsNotNull(result);
        Assert.AreEqual(3, result.NodeIds.Length);
        Assert.AreEqual(3, result.NodeIds[0]);
        Assert.AreEqual(12, result.NodeIds[2]);
    }

    /// <summary>
    /// Verifies that GetOuterHTMLResult deserializes HTML content.
    /// </summary>
    [TestMethod]
    public void GetOuterHTMLResult_Deserializes_Html()
    {
        var json = """{"outerHTML":"<div class=\"test\">Hello</div>"}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.GetOuterHTMLResult);

        Assert.IsNotNull(result);
        Assert.IsTrue(result.OuterHTML.Contains("Hello"));
    }

    /// <summary>
    /// Verifies that DomNode deserializes with attributes array.
    /// </summary>
    [TestMethod]
    public void DomNode_Deserializes_WithAttributes()
    {
        var json = """{"nodeId":5,"backendNodeId":5,"nodeType":1,"nodeName":"DIV","localName":"div","nodeValue":"","attributes":["class","container","id","main"]}""";
        var result = JsonSerializer.Deserialize(json, ChromeEssentialsJsonContext.Default.DomNode);

        Assert.IsNotNull(result);
        Assert.AreEqual("DIV", result.NodeName);
        Assert.IsNotNull(result.Attributes);
        Assert.AreEqual(4, result.Attributes.Length);
        Assert.AreEqual("class", result.Attributes[0]);
        Assert.AreEqual("container", result.Attributes[1]);
    }
}
