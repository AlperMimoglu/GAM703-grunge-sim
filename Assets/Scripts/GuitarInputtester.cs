using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class GuitarInputtester : MonoBehaviour
{
    public Sprite GreenButtonPressedImage;
    public Sprite GreenButtonUnpressedImage;
    public Button GreenUIButton;
    public Sprite RedButtonPressedImage;
    public Sprite RedButtonUnpressedImage;
    public Button RedUIButton;
    public Sprite YellowButtonPressedImage;
    public Sprite YellowButtonUnpressedImage;
    public Button YellowUIButton;
    public Sprite BlueButtonPressedImage;
    public Sprite BlueButtonUnpressedImage;
    public Button BlueUIButton;
    public Sprite OrangeButtonPressedImage;
    public Sprite OrangeButtonUnpressedImage;
    public Button OrangeUIButton;

    public InputAction green;
    public InputAction red;
    public InputAction yellow;
    public InputAction blue;
    public InputAction orange;
    public InputAction strumUp;
    public InputAction strumDown;


    // public AudioSource TheMusic;
    public AudioSource HighEString;
    public AudioSource AString;
    public AudioSource DString;
    public AudioSource GString;
    public AudioSource BString;
    public AudioSource ASharp5;
    public AudioSource BFlat5;
    public AudioSource C5;
    public AudioSource E5;
    public AudioSource FSharp5;
    public AudioSource F5;
    public AudioSource GFlat54thFR;

    public BeatScroller BeatScrollerRef;

    public bool greenistrue;
    public bool redistrue;
    public bool yellowistrue;
    public bool blueistrue;
    public bool orangeistrue;
    public bool strumDownistrue;
    public bool CanBePressed;
    public bool StartPlaying;

    public GameObject GreenNote;
    public GameObject RedNote;
    public GameObject YellowNote;
    public GameObject BlueNote;
    public GameObject OrangeNote;

    public NoteDetection noteDetection;




    public void Awake()
    {
        // GreenSR = GetComponentInChildren<SpriteRenderer>();
        //RedSR = GetComponentInChildren<SpriteRenderer>();
        //YellowSR = GetComponentInChildren<SpriteRenderer>();
        //BlueSR = GetComponentInChildren<SpriteRenderer>();
        //OrangeSR = GetComponentInChildren<SpriteRenderer>();

        // assign a callback for the "jump" action.
        green.performed += ctx => { GreenButtonPressed(ctx); };
        green.canceled += ctx => { GreenButtonReleased(ctx); };
        red.performed += ctx => { RedButtonPressed(ctx); };
        red.canceled += ctx => { RedButtonReleased(ctx); };
        yellow.performed += ctx => { YellowButtonPressed(ctx); };
        yellow.canceled += ctx => { YellowButtonReleased(ctx); };
        blue.performed += ctx => { BlueButtonPressed(ctx); };
        blue.canceled += ctx => { BlueButtonReleased(ctx); };
        orange.performed += ctx => { OrengeButtonPressed(ctx); };
        orange.canceled += ctx => { OrengeButtonReleased(ctx); };
        // strumUp.performed += ctx => { StrumUpButtonPressed(ctx); };
        strumDown.performed += ctx => { StrumDownButtonPressed(ctx); };
        strumDown.canceled += ctx => { StrumDownButtonReleased(ctx); };

        greenistrue = false;
        redistrue = false;
        yellowistrue = false;
        blueistrue = false;
        orangeistrue = false;
        strumDownistrue = false;

    }

    public void GreenButtonOnclick()
    {
        GreenUIButton.image.sprite = GreenButtonPressedImage;
        GreenNote.SetActive(false);


    }
    public void RedButtonOnclick()
    {
        RedUIButton.image.sprite = RedButtonPressedImage;
        RedNote.SetActive(false);



    }
    public void YellowButtonOnclick()
    {
        YellowUIButton.image.sprite = YellowButtonPressedImage;
       YellowNote.SetActive(false);

    }
    public void BlueButtonOnclick()
    {
        BlueUIButton.image.sprite = BlueButtonPressedImage;
        BlueNote.SetActive(false);


    }
    public void OrangeButtonOnclick()
    {
        OrangeUIButton.image.sprite = OrangeButtonPressedImage;
        OrangeNote.SetActive(false);
       


    }
    public void Update()
    {
        if (!StartPlaying)
        {
            BeatScrollerRef.hasStarted = false;
        }
        else
        {
            BeatScrollerRef.hasStarted = true;
            //TheMusic.Play();

        }

        if (greenistrue == true)
        {
            if (strumDownistrue == true)
            {
                GreenButtonOnclick();
                CanBePressed = true;
                noteDetection.CanBePressed = true;
                noteDetection.obtained = true;
                F5.Play();


            }


        }
        if (redistrue == true)
        {
            if (strumDownistrue == true)
            {
                RedButtonOnclick();
                CanBePressed = true;
                noteDetection.CanBePressed = true;
                noteDetection.obtained = true;
                ASharp5.Play();

            }
        }

        if (yellowistrue == true)
        {
            if (strumDownistrue == true)
            {
                YellowButtonOnclick();
                CanBePressed = true;
                noteDetection.CanBePressed = true;
                noteDetection.obtained = true;
                GFlat54thFR.Play();

            }
        }

        if (blueistrue == true)
        {
            if (strumDownistrue == true)
            {
                BlueButtonOnclick();
                CanBePressed = true;
                noteDetection.CanBePressed = true;
                noteDetection.obtained = true;
                C5.Play();

            }
        }

        if (orangeistrue == true)
        {
            if (strumDownistrue == true)
            {
                OrangeButtonOnclick();
                CanBePressed = true;
                noteDetection.CanBePressed = true;
                noteDetection.obtained = true;
                E5.Play();

            }
        }
    }



    public void GreenButtonPressed(InputAction.CallbackContext context)
    {

        greenistrue = true;
        noteDetection.obtained = true;
        //CanBePressed  = true;
        //HighEString.Play();



    }

    public void GreenButtonReleased(InputAction.CallbackContext context)
    {
        GreenUIButton.image.sprite = GreenButtonUnpressedImage;
        greenistrue = false;
      //  CanBePressed = false;

    }

    public void RedButtonPressed(InputAction.CallbackContext context)
    {
        redistrue = true;
       // noteDetection.obtained = true;
        //AString.Play();


    }

    public void RedButtonReleased(InputAction.CallbackContext context)
    {
        RedUIButton.image.sprite = RedButtonUnpressedImage;
        redistrue = false;
        //CanBePressed = false;
    }

    public void YellowButtonPressed(InputAction.CallbackContext context)
    {
        yellowistrue = true;
       // noteDetection.obtained = true;
        //DString.Play();


    }

    public void YellowButtonReleased(InputAction.CallbackContext context)
    {
        yellowistrue = false;
        //CanBePressed = false;
        YellowUIButton.image.sprite = YellowButtonUnpressedImage;
    }
    public void BlueButtonPressed(InputAction.CallbackContext context)
    {

        blueistrue = true;
        //noteDetection.obtained = true;
        //GString.Play();

    }
    public void BlueButtonReleased(InputAction.CallbackContext context)
    {
        blueistrue = false;
        //CanBePressed = false;
        BlueUIButton.image.sprite = BlueButtonUnpressedImage;

    }
    public void OrengeButtonPressed(InputAction.CallbackContext context)
    {
      //  noteDetection.obtained = true;
        orangeistrue = true;
        //BString.Play();


    }

    public void OrengeButtonReleased(InputAction.CallbackContext context)
    {
        orangeistrue = false;
        //CanBePressed = false;
        OrangeUIButton.image.sprite = OrangeButtonUnpressedImage;
    }

    //public void StrumUpButtonPressed(InputAction.CallbackContext context)
    //  {

    // }

    public void StrumDownButtonPressed(InputAction.CallbackContext context)
    {
        strumDownistrue = true;

    }

    public void StrumDownButtonReleased(InputAction.CallbackContext context)
    {
        strumDownistrue = false;
    }

    // the actions must be enabled and disabled
    // when the GameObject is enabled or disabled

    public void OnEnable()
    {
        //moveAction.Enable();
        green.Enable();
        red.Enable();
        yellow.Enable();
        blue.Enable();
        orange.Enable();
        strumUp.Enable();
        strumDown.Enable();
    }

    public void OnDisable()
    {

        green.Disable();
        greenistrue = false;
        red.Disable();
        yellow.Disable();
        blue.Disable();
        orange.Disable();
        strumUp.Disable();
        strumDown.Disable();
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "ButtonPress")
        {
           

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "ButtonPress")
        {
            CanBePressed = false;
            noteDetection.CanBePressed = false;



        }
    }


}
