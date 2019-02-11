using UnityEngine;
using UnityEditor;
using System.IO;

public class ExportPackage
{
    private readonly static string[] Paths = {
        "Assets/Plugins/MemoryInfoPlugin",
    };
    
    [MenuItem("Assets/Export MemoryInfoPlugin")]
    private static void Export()
    {
        AssetDatabase.ExportPackage(Paths, "MemoryInfoPlugin-for-Unity.unitypackage", ExportPackageOptions.Recurse);
        Debug.Log("Export complete!");

        AssetDatabase.Refresh();
    }
}
