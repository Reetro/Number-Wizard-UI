using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Intro : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI IntroText;

    public NumberWizard WizardScript;

    // Start is called before the first frame update
    void Start()
    {
      string IntroTextStart = "Guess a number between " + WizardScript.min;
      string IntroTextEnd = " and " + WizardScript.max;
      string FinalText = IntroTextStart + IntroTextEnd;

      IntroText.text = FinalText;
    }
}
