using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// The group of shortcut don't have inter shortcut meaning but must be execute in a specific order to be well executed. It is the default of a group shortcut if not specified.
/// </summary>
public interface IEnumerableGroupOfShortcutCommand : IGroupOfShortcutCommand
{}
public interface IEnumerableGroupOfShortcutSettable : IGroupOfShortcutCommandSettable
{}
