using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPoints : MonoBehaviour


{
    private static bool creado = false;

    void Awake()
    {
        if (!creado)
        {
            // Asegurar que el GameObject no se destruya al cargar una nueva escena
            DontDestroyOnLoad(gameObject);
            creado = true;
        }
        else
        {
            // Si ya existe una instancia, destruir esta
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }
}
