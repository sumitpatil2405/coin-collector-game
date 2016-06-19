using UnityEngine;
using UnityEngine.UI; 
using System.Collections;

public class collect : MonoBehaviour {

	public Text countText;
	public Text winText;

	private int count;
    public GameObject bbox;
    public GameObject coin;
    private float timer = 60;
    public int i = 0;
    public Text time;
    public AudioClip ac1;
    public AudioClip ac2;
    private AudioSource sur;

    void Start ()
	{
		count = 0;
		SetCountText ();
        timer = 60;
		
	}
    void Awake()
    {
        sur = GetComponent<AudioSource>();
    }

    void Update()
    {
        timer = timer - Time.deltaTime;
        time.text = "Remaining time: " + (int) timer;
        if (timer <= 0)
            SetCountText();
    }

	void OnTriggerEnter(Collider other)
	{
        
        if (other.gameObject.CompareTag("Pick Up"))
        {
            sur.PlayOneShot(ac2);
            Destroy(other.gameObject);
            count = count + 1;
            SetCountText();

            //other.gameObject.SetActive (false);
            
            
        }

        if (other.gameObject.CompareTag ("sumit")) 
		{
            i = Random.Range(1, 10);
            sur.PlayOneShot(ac1);
            if (i%2 == 0)
            {
                Vector3 pos = gameObject.transform.position;
                pos.y = pos.y + 3;
                GameObject c = Instantiate(coin, pos, Quaternion.identity) as GameObject;
                Destroy(c, 30);
            }
            Destroy(other.gameObject);
            //other.gameObject.SetActive(false);
            GameObject b = Instantiate(bbox, gameObject.transform.position, Quaternion.identity) as GameObject;
            
            Destroy(b,1);
            
		}

        
    }

	void SetCountText()
	{
		countText.text = "Count: " + count.ToString ();
		if (count == 6)
        {
            Application.LoadLevel(3);
        
		}
        if (timer <=0)
        {
            Application.LoadLevel(2);
        }
	}
}