using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonScript : MonoBehaviour
{
    public void OnClick()
    {
        
        SceneManager.LoadScene("Nivel 1");
    }
}
