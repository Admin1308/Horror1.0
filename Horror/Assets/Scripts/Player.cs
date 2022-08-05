using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    [SerializeField] private float staminaValue;
    [SerializeField] private float staminaRetern = 10f;
    [SerializeField] private Slider StaminaSliider;
    [SerializeField] private Text textStamina;
    [SerializeField] private AudioSource Move;
    [Range (0,10)][SerializeField] public float smootchMoving;
    public bool isShift = true;

    [Header("Mooving Speed Player")]
    public float speedMove = 1f;
    public float speedrun = 2f;
    public float speed_Current;

    private void Start ()
    {
       textStamina = StaminaSliider.transform.GetChild(0).GetComponent<Text>();
    }



    private void FixedUpdate()
    {
        GetInput();
        Stamina();
 
    }
    private void GetInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.localPosition += transform.forward * speed_Current * Time.deltaTime;  
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.localPosition += -transform.forward * speed_Current * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.localPosition += -transform.right * speed_Current * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.localPosition += transform.right * speed_Current * Time.deltaTime;
        }
        if (isShift == true)
        {
            if ((Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W))))
            {
                speed_Current = speed_Current = Mathf.Lerp(speed_Current, speedrun, Time.deltaTime);
                staminaValue -= staminaRetern * Time.deltaTime * 5;
            }
     }

}
    private void Stamina()
    {
        if (staminaValue > 100f) staminaValue = 100f;
        if (staminaValue < 0) staminaValue = 0;
        textStamina.text = StaminaSliider.value.ToString();
        StaminaSliider.value = staminaValue;
        staminaValue += staminaRetern * Time.deltaTime * 2;

        if (staminaValue <= 1f)
        {

            isShift = false;
            speed_Current = speedMove;
            Move.Play();
            return;
            
        }
        if (staminaValue > 42f)
        {
            isShift = true;    
        }
        
    }

}

     

