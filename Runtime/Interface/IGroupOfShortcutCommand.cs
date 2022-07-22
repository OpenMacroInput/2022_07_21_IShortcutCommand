using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGroupOfShortcutCommand: IGroupOfShortcutCommandGet
{}

public interface IGroupOfShortcutCommandGet {
    public void GetShortcuts(out IEnumerable<IShortcutCommand> commands);
    public void GetShortcuts(out IShortcutCommand[] commands);
    public void GetShortcutAt(in int index, out IShortcutCommand commands);
    public void GetCount(out int countElementInGroup);
}

public interface IGroupOfShortcutCommandSettable : IGroupOfShortcutCommandGet, IGroupOfShortcutCommandSet
{}
public interface IGroupOfShortcutCommandSet
{
    public void SetShortcutsWith(out IEnumerable<IShortcutCommand> commands);
    public void SetShortcutsWith(out IShortcutCommand[] commands);
    public void OverrideShortcutAt(in int index, out IShortcutCommand commands);
}