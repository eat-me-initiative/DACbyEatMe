// Decompiled with JetBrains decompiler
// Type: DAC_v4.Properties.Resources
// Assembly: DAC v4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: ADCD26C7-7115-49CB-A171-B101A2567B86
// Assembly location: C:\Users\Yssentrick\Desktop\DAC v4\DAC v4.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DAC_v4.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (DAC_v4.Properties.Resources.resourceMan == null)
          DAC_v4.Properties.Resources.resourceMan = new ResourceManager("DAC_v4.Properties.Resources", typeof (DAC_v4.Properties.Resources).Assembly);
        return DAC_v4.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        return DAC_v4.Properties.Resources.resourceCulture;
      }
      set
      {
        DAC_v4.Properties.Resources.resourceCulture = value;
      }
    }
  }
}
