using UnityEngine;
using UnityEngine.UI;

public class ControlPlayer : MonoBehaviour{
    public float speed = 50f;

    private Rigidbody _rb;

    public Text scoreText;

    private int _score = 0;

    public void Awake(){
        _rb = GetComponent<Rigidbody>();
    }  

    public float destroyY = -10f; // Задайте значение Y-координаты, ниже которого объект будет уничтожен.  

    private void FixedUpdate(){
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _rb.AddForce(new Vector3(h, 0, v)* speed * Time.fixedDeltaTime);

        if (transform.position.y < destroyY){
            Destroy(gameObject);
            scoreText.text = "You loose";
        }
        if(_score == 5)
            _rb.constraints = RigidbodyConstraints.FreezeAll;
    }
    private void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "CollectiveCube"){
            _score++;
            Destroy(other.gameObject);

            if(_score < 5)
                scoreText.text = "Score: " + _score;
            else
                scoreText.text = "You win";
                // _rb.velocity = Vector3.zero;
                // _rb.constraints = RigidbodyConstraints.FreezeAll;
        }
    }
}



