using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void Newstart(){
    SceneManager.LoadScene(0);
    // Загружает самую первую (0) установленную в проекте сцену. 
    // Если необходимо загрузить не её укажите какую именно сцену нужно загрузить
    }
}
