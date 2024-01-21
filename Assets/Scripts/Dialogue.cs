using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    // Start is called before the first frame update
    void Start()
    {
                
    }

    // Update is called once per frame
    void Update()
    {
        textComponent.textStyle = string.Empty;
        StartDialogue()
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
}

    IEnumerator TypeLine()
    {

            foreach(char_c in lines[index].ToCharArray())
        {
            textComponent.text +char C;
            yield return new WaitForSeconds(textSpeed);
        }


    }
}
