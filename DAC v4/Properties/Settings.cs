// Decompiled with JetBrains decompiler
// Type: DAC_v4.Properties.Settings
// Assembly: DAC v4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADCD26C7-7115-49CB-A171-B101A2567B86
// Assembly location: C:\Users\Yssentrick\Desktop\DAC v4\DAC v4.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace DAC_v4.Properties
{
  [CompilerGenerated]
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings defaultInstance = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());

    public static Settings Default
    {
      get
      {
        Settings defaultInstance = Settings.defaultInstance;
        return defaultInstance;
      }
    }
  }
}
