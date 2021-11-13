using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardMechanics : MonoBehaviour
{
    public Color WantedColor;
    public Color ResetColor;

    private void HighlightKey()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            SetButtonColor(GameObject.Find("Key A").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.A))
        {
            ResetButtonColor(GameObject.Find("Key A").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.B))
        {
            SetButtonColor(GameObject.Find("Key B").GetComponent<Button>());
                    }
        else if (Input.GetKeyUp(KeyCode.B))
        {
            ResetButtonColor(GameObject.Find("Key B").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.C))
        {
            SetButtonColor(GameObject.Find("Key C").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.C))
        {
            ResetButtonColor(GameObject.Find("Key C").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.D))
        {
            SetButtonColor(GameObject.Find("Key D").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.D))
        {
            ResetButtonColor(GameObject.Find("Key D").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.E))
        {
            SetButtonColor(GameObject.Find("Key E").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.E))
        {
            ResetButtonColor(GameObject.Find("Key E").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.F))
        {
            SetButtonColor(GameObject.Find("Key F").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.F))
        {
            ResetButtonColor(GameObject.Find("Key F").GetComponent<Button>());
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            SetButtonColor(GameObject.Find("Key G").GetComponent<Button>());
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            ResetButtonColor(GameObject.Find("Key G").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.H))
        {
            SetButtonColor(GameObject.Find("Key H").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.H))
        {
            ResetButtonColor(GameObject.Find("Key H").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.I))
        {
            SetButtonColor(GameObject.Find("Key I").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.I))
        {
            ResetButtonColor(GameObject.Find("Key I").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.J))
        {
            SetButtonColor(GameObject.Find("Key J").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.J))
        {
            ResetButtonColor(GameObject.Find("Key J").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.K))
        {
            SetButtonColor(GameObject.Find("Key K").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.K))
        {
            ResetButtonColor(GameObject.Find("Key K").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.L))
        {
            SetButtonColor(GameObject.Find("Key L").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.L))
        {
            ResetButtonColor(GameObject.Find("Key L").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.M))
        {
            SetButtonColor(GameObject.Find("Key M").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.M))
        {
            ResetButtonColor(GameObject.Find("Key M").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.N))
        {
            SetButtonColor(GameObject.Find("Key N").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.N))
        {
            ResetButtonColor(GameObject.Find("Key N").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.O))
        {
            SetButtonColor(GameObject.Find("Key O").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.O))
        {
            ResetButtonColor(GameObject.Find("Key O").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.P))
        {
            SetButtonColor(GameObject.Find("Key P").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.P))
        {
            ResetButtonColor(GameObject.Find("Key P").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            SetButtonColor(GameObject.Find("Key Q").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            ResetButtonColor(GameObject.Find("Key Q").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SetButtonColor(GameObject.Find("Key R").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.R))
        {
            ResetButtonColor(GameObject.Find("Key R").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SetButtonColor(GameObject.Find("Key S").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.S))
        {
            ResetButtonColor(GameObject.Find("Key S").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.T))
        {
            SetButtonColor(GameObject.Find("Key T").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.T))
        {
            ResetButtonColor(GameObject.Find("Key T").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.U))
        {
            SetButtonColor(GameObject.Find("Key U").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.U))
        {
            ResetButtonColor(GameObject.Find("Key U").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.V))
        {
            SetButtonColor(GameObject.Find("Key V").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.V))
        {
            ResetButtonColor(GameObject.Find("Key V").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.W))
        {
            SetButtonColor(GameObject.Find("Key W").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.W))
        {
            ResetButtonColor(GameObject.Find("Key W").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.X))
        {
            SetButtonColor(GameObject.Find("Key X").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.X))
        {
            ResetButtonColor(GameObject.Find("Key X").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.Y))
        {
            SetButtonColor(GameObject.Find("Key Y").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.Y))
        {
            ResetButtonColor(GameObject.Find("Key Y").GetComponent<Button>());
                    }

        if (Input.GetKeyDown(KeyCode.Z))
        {
            SetButtonColor(GameObject.Find("Key Z").GetComponent<Button>());
                    }
        if (Input.GetKeyUp(KeyCode.Z))
        {
            ResetButtonColor(GameObject.Find("Key Z").GetComponent<Button>());
                    }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HighlightKey();        

        //if (Input.anyKeyDown)
        //{
        //    string inKey = Input.inputString;
        //    if (inKey.Length == 1)
        //    {
        //        Button KeyButton = GameObject.Find("Key " + inKey.ToUpper()).GetComponent<Button>();
        //        SetButtonColor(KeyButton);
        //        ResetButtonColor(KeyButton);
        //    }
        //}
    }

    public void SetButtonColor(Button inKey)
    {
        ColorBlock cb = inKey.colors;
        cb.normalColor = WantedColor;
        cb.pressedColor = WantedColor;
        cb.highlightedColor = WantedColor;
        inKey.colors = cb;
    }

    public void ResetButtonColor(Button inKey)
    {
        ColorBlock cb = inKey.colors;
        cb.normalColor = ResetColor;
        cb.pressedColor = WantedColor;
        cb.highlightedColor = WantedColor;
        inKey.colors = cb;
    }
}
