
using UnityEngine;
using UnityEngine.Events;

public class Talk : MonoBehaviour
{
    public DialogueLine[] lines;
    public string choice1;
    public string choice2;

    public UnityEvent onChoice1;
    public UnityEvent onChoice2;

    public GameObject prompt;
    public DialogueBox dialogueBox;

    public bool showPrompt = true;

    public void Say()
    {
        if (dialogueBox != null)
            dialogueBox.Open(this);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (showPrompt && prompt != null)
                prompt.SetActive(true);

            if (dialogueBox != null)
                dialogueBox.nearTalk = this;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (prompt != null)
                prompt.SetActive(false);

            if (dialogueBox != null)
                dialogueBox.nearTalk = null;
        }
    }
}
