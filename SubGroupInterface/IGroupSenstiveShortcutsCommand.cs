using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// A group sensitive shortcuts is a command where all the shortcut make an intent and can't be understand without a global translation. It require more resource and it is why it is a sperate classe.
/// </summary>
public interface IGroupSenstiveShortcutsCommand : IGroupOfShortcutCommand
{}
public interface IGroupSenstiveShortcutsCommandSettable : IGroupOfShortcutCommandSettable
{}
