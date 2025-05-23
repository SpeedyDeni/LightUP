using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogPark : MonoBehaviour
{
    public AudioSource d_audioSource;

    public TextMeshProUGUI textComponent;
    public GameObject dialoguePanel;
    public string[] lines;
    public float textSpeed;
    public GameObject puzzle;

    public int index;
    float timer;

    void Start()
    {

    }

    private void OnEnable()
    {
        textComponent.text = string.Empty;
        dialoguePanel.SetActive(true);
        StartDialogue();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                d_audioSource.Stop();
                textComponent.text = lines[index];
            }
        }
        if (textComponent.text == lines[index] && Input.GetKeyDown(KeyCode.Space) == false)
        {
            timer += Time.deltaTime;
            if (index < lines.Length - 1)
            {
                if (timer > 5f)
                {
                    NextLine();
                    timer = 0;
                }
            }
        }
    }

    void StartDialogue()
    {
        textComponent.text = string.Empty;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        d_audioSource.Play();
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
        d_audioSource.Stop();
    }

    void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            puzzle.SetActive(true);
            index = 0;
            dialoguePanel.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}