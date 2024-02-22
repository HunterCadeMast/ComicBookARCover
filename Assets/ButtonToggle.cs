using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonToggle : MonoBehaviour
{
    public List<TextMeshPro> textInputs;
    public SpriteRenderer specificSpriteRenderer;
    private List<string> textSets;
    private int currentTextSetIndex = 0;
    void Start()
    {
        textSets = new List<string>();
        foreach (TextMeshPro textInput in textInputs)
        {
            textSets.Add(textInput.text);
        }
        SetText();
        specificSpriteRenderer.gameObject.SetActive(false);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ToggleText();
        }
    }
    public void ToggleText()
    {
        currentTextSetIndex = (currentTextSetIndex + 1) % textSets.Count;
        SetText();
    }
    private void SetText()
    {
        for (int i = 0; i < textInputs.Count; i++)
        {
            if (i == currentTextSetIndex)
            {
                textInputs[i].text = textSets[currentTextSetIndex];
            }
            else
            {
                textInputs[i].text = "";
            }
        }
        if (currentTextSetIndex == 0)
        {
            specificSpriteRenderer.gameObject.SetActive(false);
        }
        else
        {
            specificSpriteRenderer.gameObject.SetActive(true);
        }
    }
}