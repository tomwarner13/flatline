using System;
using System.IO;

namespace FlatlineCore
{
  public class Builder
  {
    private readonly bool _fullRebuild;
    private readonly DirectoryInfo sourceDir;
    private readonly DirectoryInfo outputPath;

    public Builder(string sourcePath, string outputPath, bool fullRebuild)
    {
      _fullRebuild = fullRebuild;

      sourceDir = new DirectoryInfo (sourcePath);
      if(!sourceDir.Exists)
      {
        throw new FileNotFoundException($"Unable to locate source path: {sourcePath}");
      }

    }
  }
}

