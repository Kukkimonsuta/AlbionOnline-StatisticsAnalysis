using System.Text;
using System.Xml;
using StatisticAnalysisTool.Extractor.IO;

namespace StatisticAnalysisTool.Extractor;

internal class LocalizationData : IDisposable
{
    public const string ItemPrefix = "@ITEMS_";
    public const string DescPostfix = "_DESC";

    public Dictionary<string, Dictionary<string, string>> LocalizedNames = new();
    public Dictionary<string, Dictionary<string, string>> LocalizedDescriptions = new();

    public async Task LoadDataAsync(string mainGameFolder)
    {
        var localizationBinFilePath = Path.Combine(mainGameFolder, ".\\Albion-Online_Data\\StreamingAssets\\GameData\\localization.bin");

        await using var stream = new BinFileStream(localizationBinFilePath);
        using var reader = new StreamReader(stream, Encoding.UTF8);

        var xmlDoc = new XmlDocument();
        xmlDoc.Load(reader);

        using var rootNode = xmlDoc.LastChild?.LastChild?.ChildNodes;

        if (rootNode is null)
        {
            return;
        }

        foreach (XmlNode node in rootNode)
        {
            if (node.NodeType != XmlNodeType.Element)
            {
                continue;
            }

            var tuId = node.Attributes?["tuid"];

            if (tuId?.Value.StartsWith(ItemPrefix) != true)
            {
                continue;
            }

            Dictionary<string, string> languages;

            try
            {
                languages = node.ChildNodes
                    .Cast<XmlNode>()
                    .ToDictionary(x => x.Attributes!["xml:lang"]!.Value, y => y.LastChild!.InnerText);
            }
            catch (Exception)
            {
                continue;
            }

            // Is item description
            if (tuId.Value.EndsWith(DescPostfix))
            {
                LocalizedDescriptions[tuId.Value] = languages;
            }
            // Is item name
            else
            {
                LocalizedNames[tuId.Value] = languages;
            }
        }
    }

    public bool IsDataLoaded()
    {
        return LocalizedNames.Count > 0 && LocalizedDescriptions.Count > 0;
    }

    public void Dispose()
    {
        LocalizedNames.Clear();
        LocalizedDescriptions.Clear();
    }
}
