using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{

  [SerializeField] public int max = 1000;
  [SerializeField] public int min = 1;
  [SerializeField] TextMeshProUGUI GuessText;

  int guess;

  // Use this for initialization
  void Start()
  {
    StartGame();
  }

  void StartGame()
  {
    NextGuess();
  }

  public void OnPressedHigher()
  {
    min = guess + 1;
    NextGuess();
  }
  public void OnPressedLower()
  {
    max = guess - 1;
    NextGuess();
  }

  void NextGuess()
  {
    guess = Random.Range(min, max + 1) / 2;
    GuessText.text = guess.ToString();
  }
}
