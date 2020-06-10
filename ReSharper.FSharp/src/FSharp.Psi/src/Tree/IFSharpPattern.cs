using System.Collections.Generic;
using JetBrains.ReSharper.Psi.Tree;

namespace JetBrains.ReSharper.Plugins.FSharp.Psi.Tree
{
  public partial interface IFSharpPattern
  {
    bool IsDeclaration { get; }
    IEnumerable<IDeclaration> Declarations { get; }

    TreeNodeCollection<IAttribute> Attributes { get; }
  }
}