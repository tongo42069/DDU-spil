using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManger : MonoBehaviour
{


//mening at jeg skulle have lavet en array, men de forslåer at jeg lave queue. Det her variable holder styr sætninger i spillet. data typen Queue vil load ind den næste dialog
    private Queue<string> sentences; 

    // Start is called before the first frame update
    void Start()
    {
    sentences = new Queue<string>();        
    }

    public void StartDialogue (Dialogue dialogue)
    {
        Debug.Log ("Starting conversation with " + dialogue.name);
    }

    
}
