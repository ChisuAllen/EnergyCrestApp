using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnergyManager : MonoBehaviour
{
    public Button button0;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Button button5;
    public Button button6;
    public Button button7;
    public Button button8;
    public Button button9;
    public Button button10;

    public Color newColor;
    public Color oldColor;

    public int Energy;

    public void clearColor()
    {
        button0.image.color = oldColor;
        button1.image.color = oldColor;
        button2.image.color = oldColor;
        button3.image.color = oldColor;
        button4.image.color = oldColor;
        button5.image.color = oldColor;
        button6.image.color = oldColor;
        button7.image.color = oldColor;
        button8.image.color = oldColor;
        button9.image.color = oldColor;
        button10.image.color = oldColor;
    }

    public void addEnergy(int value)
    {
        Energy = value;
        clearColor();
        displayEnergy();
    }

    public void displayEnergy()
    {
        switch(Energy)
        {
            case 0:
                button0.image.color = newColor;
                break;
            case 1:
                button1.image.color = newColor;
                break;
            case 2:
                button2.image.color = newColor;
                break;
            case 3:
                button3.image.color = newColor;
                break;
            case 4:
                button4.image.color = newColor;
                break;
            case 5:
                button5.image.color = newColor;
                break;
            case 6:
                button6.image.color = newColor;
                break;
            case 7:
                button7.image.color = newColor;
                break;
            case 8:
                button8.image.color = newColor;
                break;
            case 9:
                button9.image.color = newColor;
                break;
            case 10:
                button10.image.color = newColor;
                break;
            default:
                Debug.Log("Value was not valid");
                break;
        }
        Debug.Log("You have " + Energy);
    }

    public void Draw()
    {
        if (Energy >= 7)
        {
            Energy -= 7;
            clearColor();
            displayEnergy();
        }
    }

    public void Charge()
    {
        if (Energy >= 7)
        {
            Energy = 10;
        }
        else
        {
            Energy += 3;
        }
        clearColor();
        displayEnergy();
    }

}
