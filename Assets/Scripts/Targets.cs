using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targets : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float defaultSpeed { get; set; }
    [SerializeField] protected int addedscore;

    private GameManager gameManagerScript;

    public SoundManager soundManagerScript;
    
    // Start is called before the first frame update
    void Start()
    {
        SetSpeed();
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
        if (gameManagerScript.gameOver==false)
        {
            soundManagerScript = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();
            soundManagerScript.PlayHitAudio();
            gameManagerScript.score += addedscore;
            Destroy(gameObject);
        }
        else
        {
            addedscore = 0;
        }
    }
    protected virtual void SetSpeed()
    {
        speed = defaultSpeed;
    }
}
