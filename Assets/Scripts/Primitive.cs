using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Primitive : MonoBehaviour
{
    public string p_name { set
        {
            if (value.Length >= 8 || value.Length < 1)
            {
                Debug.LogError("Name too long or too short!");
            } else
            {
                p_name = value;
            }
        } get { return p_name; }
    }
    public Color color { get; private set; }

    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        color = GetComponent<Renderer>().material.color;
    }

    public virtual void DisplayText()
    {
        text.text = "Default Text";
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        DisplayText();
    }
}
