using UnityEngine;
using UnityEngine.UI;


public class Player : MonoBehaviour
{

    [SerializeField] float staminaValue;
    [SerializeField] float staminaRetern = 10f;
    [SerializeField] Slider StaminaSliider;
    [SerializeField] Text textStamina;

    [Header("Mooving Speed Player")]
    public float speedMove = 1f;
    public float speedrun = 2f;
    public float speed_Current;

    void Start ()
    {
        textStamina = StaminaSliider.transform.GetChild(0).GetComponent<Text>();
    }

    

   void FixedUpdate()
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
        if (Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.W)))
        {
            speed_Current = speedrun;
            staminaValue -= staminaRetern * Time.deltaTime * 5;
        }
        else
        {
            speed_Current = speedMove;
            staminaValue += staminaRetern * Time.deltaTime*2;
        }
    }
    private void Stamina()
    {
        if (staminaValue > 100) staminaValue = 100;
        if (staminaValue < 0) staminaValue = 0;
        textStamina.text = StaminaSliider.value.ToString();
        StaminaSliider.value = staminaValue;

    }
}
