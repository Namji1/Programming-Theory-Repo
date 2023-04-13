using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float defaultSpeed { get; set; }
    [SerializeField] protected int addedscore;

    private GameManager gameManagerScript;

    public AudioClip hitAudioClip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Moving();
        DestroyOutOfBounds();
    }
    
    protected void GetGameManager()
    {
        gameManagerScript = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    protected void Moving()
    {
        if (gameManagerScript.gameOver == false)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
    protected void DestroyOutOfBounds()
    {
        if (gameObject.transform.position.x > 9)
        {
            Destroy(gameObject);
        }
    }
    protected private void OnMouseDown()
    {
        MeshRenderer rend = GetComponent<MeshRenderer>();
        if (rend.enabled == true && gameManagerScript.gameOver==false)
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(hitAudioClip);
            gameManagerScript.score += addedscore;
            rend.enabled = false;
        }
        else
        {
            addedscore = 0;
        }
    }
}
