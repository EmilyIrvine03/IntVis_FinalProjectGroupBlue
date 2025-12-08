using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void OpenMain_Menu()
    {
        SceneManager.LoadScene("Main_Menu");
        Debug.Log("Main_Menu requested");
    }

    public void OpenEmily_uterus_scene()
    {
        SceneManager.LoadScene("Emily_uterus_scene");
        Debug.Log("Emily_uterus_scene requested");
    }

    public void OpenNicole_placenta_scene()
    {
        SceneManager.LoadScene("Nicole_placenta_scene");
        Debug.Log("Nicole_placenta_scene requested");
    }

    public void OpenMarta_quiz_scene()
    {
        SceneManager.LoadScene("Marta_quiz_scene");
        Debug.Log("Marta_quiz_scene requested");
    }

}