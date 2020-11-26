using System.Collections;
using System.Collections.Generic;
using UnityEngine;
///klassen her indholder alt info som vi har brug for en dialogue 

[System.Serializable]
public class Dialogue 
{
    public string name;

    [TextArea(3,10)]
    public string[] sentences; 
 }
