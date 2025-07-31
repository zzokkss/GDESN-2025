using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class DialogueScript : MonoBehaviour
{

    //References
    [SerializeField] int dialogueIndex;
    [SerializeField] TextMeshProUGUI dialogueText;
    [TextArea]
    [SerializeField] List<string> dialogue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dialogueText.text = dialogue[dialogueIndex];
    }

    public void NextDialogue()
    {
        dialogueIndex += 1;
        if(dialogueIndex >= dialogue.Count)
        {
            Debug.Log("No more dialogue");
        }
        else
        {
            dialogueText.text = dialogue[dialogueIndex];
        }
            
    }

}
