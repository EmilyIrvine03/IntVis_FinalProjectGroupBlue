using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class ManageQuestions : MonoBehaviour
{
    public GameObject userResponse;

    public GameObject CorrectResponse;

    [SerializeField]

    private GameObject positiveFeedback; 

    [SerializeField]

    private GameObject negativeFeedback;

    [SerializeField]

    private ToggleGroup myToggleGroup;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnNextClick()
    {
        // This will compare the answer vs correct answer 
        Toggle selectedToggle = myToggleGroup.ActiveToggles().FirstOrDefault(); 
        userResponse = selectedToggle.gameObject;

        // Set all toggles as non interactable 
        for (int i = 0; i < myToggleGroup.transform.childCount; i++)
        {
            myToggleGroup.transform.GetChild(i).GetComponent<Toggle>().interactable = false;
        }

        if ( userResponse == CorrectResponse)
        {
            //shows positive feedback
            positiveFeedback.SetActive(true);

            transform.parent.GetComponent<ManageQuiz>().score += 1;
        }
        else 
        {
            //shows negative feedback 
            negativeFeedback.SetActive(true);
        }
    }
}
