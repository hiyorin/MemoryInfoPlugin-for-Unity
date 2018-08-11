# MemoryInfoPlugin-for-Unity
A set of tools for Unity to allow handling memory info for Android and iOS.

# Install
MemoryInfoPlugin-for-Unity.unitypackage

# Usage
```cs
using MemoryInfo;
```

#### Example
```cs
public void Example()
{
  var plugin = new MemoryInfoPlugin();
  var info = plugin.GetMemoryInfo();
  var text = string.Format("{0}/{1} KB ({2}%)", info.UsedSize, info.TotalSize, (int)(100f * info.UsedSize / info.TotalSize));
  Debug.Log(text);
}
```
