using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// Short cut definition is a small piece of text without-->space or return line<-- that represent an action to do if understood by an interpreter. 
/// </summary>
public interface IShortcutCommand : IShortcutCommandGet, IShortcutCommandSet
{}


public interface IShortcutCommandGet
{
    public void GetInRefContainer(ref string container);
    public void GetText(out string text);
    public string GetText();
}

public interface IShortcutCommandSet
{
    public void SetText(in string textWithNoSpace);
}
