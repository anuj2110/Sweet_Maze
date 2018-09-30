using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour {
    public float speed;
    private Rigidbody ball;
    public Light lit;
    public GameObject maze;
    public GameObject riddle;
    public Camera cam;
    //HB objects
    public float currenthealth { get; set; }
    public float maxhealth { get; set; }
    public Slider healthbar;
    public float dec = 2.0f;
    private bool prnt;
    private int level = 1;
    public GameObject blockages;
    private int vakat;
    private Text [] newText;
    private Text Level;

    public AudioClip foodSound;

    private AudioSource source;

    //  public GameObject Riddle1;

    // Use this for initialization
    void Start () {
        ball = GetComponent<Rigidbody>();
        //cam = GetComponent<Camera>();
        //HB code
       
        maxhealth = 100.0f;
        currenthealth = maxhealth;
        healthbar.value = calculate_health();
        prnt = false;
        transform.position = new Vector3(7f, 61f, -2f);
        cam.transform.localPosition = new Vector3(7f, 70f, -5.5f);
        this.gameObject.SetActive(true);
        ball.velocity = new Vector3(0.0f, 0.0f, 0.0f);
        vakat = 0;
        newText = cam.GetComponentsInChildren<Text>();

        source = GetComponent<AudioSource>();

        //level += 1;
        if (level == 1)
        {
            lit.intensity = 1;
            newText[0].text = "Look for the teleporter";
            newText[1].text = "Level 1";
            GameObject cube = blockages.transform.Find("WallBrick").gameObject;
            cube.SetActive(true);

            GameObject teleporter = blockages.transform.Find("Teleporter").gameObject;
            teleporter.SetActive(true);
        }
        else if (level == 2)
        {
            lit.intensity = 0.85f;
            newText[0].text = "Look for the Destroyer Capsule";
            newText[1].text = "Level 2";
            GameObject cube = blockages.transform.Find("WallBrick").gameObject;
            cube.SetActive(false);
            GameObject teleporter = blockages.transform.Find("Teleporter").gameObject;
            teleporter.SetActive(false);
            GameObject Destroyer = blockages.transform.Find("DestroyerCapsule").gameObject;
            Destroyer.SetActive(true);
        }
        else if(level==3)
        {
            lit.intensity = 0.70f;
            newText[0].text = "Consume fruits";
            newText[1].text = "Level 3";
            cam.transform.rotation = Quaternion.Euler(60.0f, 0f, 0f);
            maze.SetActive(true);
            currenthealth = 40;
            GameObject tele3 = blockages.transform.Find("TeleporterLevel3").gameObject;
            tele3.SetActive(true);
            GameObject f1 = blockages.transform.Find("FruitL3-1").gameObject;
            f1.SetActive(true);
            GameObject f2 = blockages.transform.Find("FruitL3-2").gameObject;
            f2.SetActive(true);
            GameObject f3 = blockages.transform.Find("FruitL3-3").gameObject;
            f3.SetActive(true);
            GameObject f4 = blockages.transform.Find("FruitL3-4").gameObject;
            f4.SetActive(true);
            GameObject f5 = blockages.transform.Find("FruitL3-5").gameObject;
            f5.SetActive(true);
        }
        else if (level == 4)
        {
            lit.intensity = 0.55f;
            newText[0].text = "Find a way to eat sweets";
            newText[1].text = "Level 4";
            GameObject tele3 = blockages.transform.Find("TeleporterLevel3").gameObject;
            tele3.SetActive(false);
            GameObject f = blockages.transform.Find("FruitL3-2").gameObject;
            f.SetActive(true);
            GameObject Dest = blockages.transform.Find("DestL5").gameObject;
            Dest.SetActive(true);
        }
        else if (level == 5)
        {
            lit.intensity = 0.40f;
            newText[0].text = "Find a way to eat sweets";
            newText[1].text = "Level 5";
            cam.transform.rotation = Quaternion.Euler(60.0f, 0f, 0f);
            maze.SetActive(true);
            GameObject T1 = blockages.transform.Find("TeleporterL5-1").gameObject;
            T1.SetActive(true);
            GameObject T2 = blockages.transform.Find("TeleporterL5-2").gameObject;
            T2.SetActive(true);
            GameObject Block = blockages.transform.Find("BlockL5").gameObject;
            Block.SetActive(true);
            //GameObject F1 = blockages.transform.Find("FruitL5-1").gameObject;
            //F1.SetActive(true);
            GameObject F2 = blockages.transform.Find("FruitL5-2").gameObject;
            F2.SetActive(true);
            GameObject F3 = blockages.transform.Find("FruitL5-3").gameObject;
            F3.SetActive(true);
        }
        else if (level==6)
        {
            lit.intensity = 0.25f;
            newText[0].text = "Find a way to eat sweets";
            newText[1].text = "Level 6";
            GameObject T1 = blockages.transform.Find("TeleporterL5-1").gameObject;
            T1.SetActive(false);
            GameObject T2 = blockages.transform.Find("TeleporterL5-2").gameObject;
            T2.SetActive(false);
            GameObject F1 = blockages.transform.Find("FruitL6-1").gameObject;
            F1.SetActive(true);
            GameObject F2 = blockages.transform.Find("FruitL6-2").gameObject;
            F2.SetActive(true);
            GameObject F3 = blockages.transform.Find("FruitL6-3").gameObject;
            F3.SetActive(true);
            GameObject F4 = blockages.transform.Find("FruitL6-4").gameObject;
            F4.SetActive(true);
            GameObject F5 = blockages.transform.Find("FruitL6-5").gameObject;
            F5.SetActive(true);
            GameObject DC = blockages.transform.Find("DestL6").gameObject;
            DC.SetActive(true);
            GameObject T = blockages.transform.Find("TeleporterL6").gameObject;
            T.SetActive(true);
            GameObject Block = blockages.transform.Find("BlockL5").gameObject;
            Block.SetActive(false);
        }
        else if (level==7)
        {
            lit.intensity = 0.10f;
            newText[0].text = "Find a way to eat sweets";
            newText[1].text = "Level 7";
            GameObject DC = blockages.transform.Find("DestL6").gameObject;
            DC.SetActive(false);
            GameObject F5 = blockages.transform.Find("FruitL6-5").gameObject;
            F5.SetActive(false);
            GameObject T = blockages.transform.Find("TeleporterL6").gameObject;
            T.SetActive(false);
            GameObject FN = blockages.transform.Find("FruitL6-5").gameObject;
            FN.SetActive(true);
            cam.transform.rotation = Quaternion.Euler(60.0f, 0f, 0f);
            maze.SetActive(true);
            GameObject F2 = blockages.transform.Find("FruitL6-2").gameObject;
            F2.SetActive(true);
            GameObject F3 = blockages.transform.Find("FruitL6-3").gameObject;
            F3.SetActive(true);
        }
        else
        {
            newText[0].text = "You Won!!!";
            this.gameObject.SetActive(false);
            Invoke("GameWon", 2f);
        }
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        /*For PC*/
        if (prnt == true)
            vakat += 1;
        if (vakat == 120)
        {
            vakat = 0;
            prnt = false;
            newText[0].text = "";

        }
        if (transform.localPosition.y<2)
        {
            float horizontalF = Input.GetAxis("Horizontal");
            float verticalF = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(horizontalF, 0.0f, verticalF);
            ball.AddForce(movement * speed);
            //HB Code
            deal_damage(dec);
        }
        
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("WELCOME");
        }
               
    }
    void OnTriggerEnter(Collider other)
    {
        source.PlayOneShot(foodSound);   

        if (other.gameObject.CompareTag("DestroyerCapsule"))
        {
            other.gameObject.SetActive(false);
            maze.SetActive(false);

            newText[0].text = "FEEL FREE TO EAT!";
            prnt = true;
            FixedUpdate();
           
            cam.transform.rotation = Quaternion.Euler(45.0f, 0f, 0f);
        }
        else if(other.gameObject.CompareTag("Teleporter1"))
        {
            transform.localPosition = new Vector3(52f, transform.localPosition.y+30, 28f);
            ball.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            newText[0].text = "Teleported";
            prnt = true;
            FixedUpdate();

        }
        else if (other.gameObject.CompareTag("Teleporter2"))
        {
            transform.localPosition = new Vector3(22f, transform.localPosition.y + 30, -7f);
            ball.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            newText[0].text = "Teleported";
            prnt = true;
            FixedUpdate();

        }
        else if (other.gameObject.CompareTag("FinalFood"))
        {
         //   this.gameObject.SetActive(false);
            LevelChange();
            ball.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            //newText[0].text = "Promoted to next level";
            prnt = true;
        }
        else if (other.gameObject.CompareTag("RiddleTrigger"))
        {

            this.gameObject.SetActive(false);
            other.gameObject.SetActive(false);
            riddle.SetActive(true);
            ball.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            healthbar.enabled = false;
            //newText[0].text = "Answer ME";
            //prnt = true;
        }

        else if(other.gameObject.CompareTag("Fruit"))
        {
            currenthealth += 15;
            other.gameObject.SetActive(false);
            ball.velocity = new Vector3(0.0f, 0.0f, 0.0f);
            newText[0].text = "Health +15";
            prnt = true;
        }
        //HB function

    }
    public float calculate_health()
    {
        return currenthealth / maxhealth;
    }

    public void deal_damage(float dec, string name = "REPLAY")
    {
        currenthealth -= dec * Time.deltaTime;
        healthbar.value = calculate_health();
        if (currenthealth <= 0)
        {
            this.gameObject.SetActive(false);
            level = 0;
            SceneManager.LoadScene(name);
            
        }
        else if(currenthealth>100)
        {
            currenthealth = 100;
        }
            
    }

    void GameWon()
    {
        SceneManager.LoadScene("WELCOME");
    }

    public void LevelChange()
    {
        level += 1;
        Start();
    }

}
