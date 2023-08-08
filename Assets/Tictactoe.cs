using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;


public class NewBehaviourScript : MonoBehaviour
{
    bool turn_X = true; // if false, it's player O's turn
    int oldscore = 0; 

    // grid buttons
    // text will be " ", 'X', or 'O'
    public Text btText1 = null;
    public Text btText2 = null;
    public Text btText3 = null;
    public Text btText4 = null;
    public Text btText5 = null;
    public Text btText6 = null;
    public Text btText7 = null;
    public Text btText8 = null;
    public Text btText9 = null;

    // other buttons
    public Text btReset = null;
    public Text btNewgame = null; 
    public Text txtPlayerO = null; // player O's score
    public Text txtPlayerX = null; // player X's score
    public Text feedback = null; // this feedback will show the winner

    // Check if the player has scored.
    public void score(string player) 
    {
        // 8 win conditions 
        
        // 1. first row
        if (btText1.text == player && btText2.text == player && btText3.text == player)
        {
            // change the color of the grids that form a line
            btText1.color = Color.blue;
            btText2.color = Color.blue;
            btText3.color = Color.blue;
            feedback.text = "Winner: Player " + player;

            if (player == "X") // X won, add score by 1
            {
                oldscore = int.Parse(txtPlayerX.text); 
                txtPlayerX.text = Convert.ToString(oldscore + 1);
            }
            else // O won, add score by 1
            {
                oldscore = int.Parse(txtPlayerO.text);
                txtPlayerO.text = Convert.ToString(oldscore + 1);
            }
        }

        // 2. second row
        else if (btText4.text == player && btText5.text == player && btText6.text == player)
        {
            // change the color of the grids that form a line
            btText4.color = Color.blue;
            btText5.color = Color.blue;
            btText6.color = Color.blue;
            feedback.text = "Winner: Player " + player;

            if (player == "X") // X won, add score by 1
            {
                oldscore = int.Parse(txtPlayerX.text);
                txtPlayerX.text = Convert.ToString(oldscore + 1);
            }
            else // O won, add score by 1
            {
                oldscore = int.Parse(txtPlayerO.text);
                txtPlayerO.text = Convert.ToString(oldscore + 1);
            }
        }

        // 3. third row
        else if (btText7.text == player && btText8.text == player && btText9.text == player)
        {
            // change the color of the grids that form a line
            btText7.color = Color.blue;
            btText8.color = Color.blue;
            btText9.color = Color.blue;
            feedback.text = "Winner: Player " + player;

            if (player == "X") // X won, add score by 1
            {
                oldscore = int.Parse(txtPlayerX.text);
                txtPlayerX.text = Convert.ToString(oldscore + 1);
            }
            else // O won, add score by 1
            {
                oldscore = int.Parse(txtPlayerO.text);
                txtPlayerO.text = Convert.ToString(oldscore + 1);
            }
        }

        // 4. first column 
        else if (btText1.text == player && btText4.text == player && btText7.text == player)
        {
            // change the color of the grids that form a line
            btText1.color = Color.blue;
            btText4.color = Color.blue;
            btText7.color = Color.blue;
            feedback.text = "Winner: Player " + player;

            if (player == "X") // X won, add score by 1
            {
                oldscore = int.Parse(txtPlayerX.text);
                txtPlayerX.text = Convert.ToString(oldscore + 1);
            }
            else // O won, add score by 1
            {
                oldscore = int.Parse(txtPlayerO.text);
                txtPlayerO.text = Convert.ToString(oldscore + 1);
            }
        }

        // 5. second column 
        else if (btText2.text == player && btText5.text == player && btText8.text == player)
        {
            // change the color of the grids that form a line
            btText2.color = Color.blue;
            btText5.color = Color.blue;
            btText8.color = Color.blue;
            feedback.text = "Winner: Player " + player;

            if (player == "X") // X won, add score by 1
            {
                oldscore = int.Parse(txtPlayerX.text);
                txtPlayerX.text = Convert.ToString(oldscore + 1);
            }
            else // O won, add score by 1
            {
                oldscore = int.Parse(txtPlayerO.text);
                txtPlayerO.text = Convert.ToString(oldscore + 1);
            }
        }

        // 6. third column
        else if (btText3.text == player && btText6.text == player && btText9.text == player)
        {
            // change the color of the grids that form a line
            btText3.color = Color.blue;
            btText6.color = Color.blue;
            btText9.color = Color.blue;
            feedback.text = "Winner: Player " + player;

            if (player == "X") // X won, add score by 1
            {
                oldscore = int.Parse(txtPlayerX.text);
                txtPlayerX.text = Convert.ToString(oldscore + 1);
            }
            else // O won, add score by 1
            {
                oldscore = int.Parse(txtPlayerO.text);
                txtPlayerO.text = Convert.ToString(oldscore + 1);
            }
        }

        // 7. first diagonal
        else if (btText1.text == player && btText5.text == player && btText9.text == player)
        {
            // change the color of the grids that form a line
            btText1.color = Color.blue;
            btText5.color = Color.blue;
            btText9.color = Color.blue;
            feedback.text = "Winner: Player " + player;

            if (player == "X") // X won, add score by 1
            {
                oldscore = int.Parse(txtPlayerX.text);
                txtPlayerX.text = Convert.ToString(oldscore + 1);
            }
            else // O won, add score by 1
            {
                oldscore = int.Parse(txtPlayerO.text);
                txtPlayerO.text = Convert.ToString(oldscore + 1);
            }
        }

        // 8. second diagonal
        else if (btText9.text == player && btText5.text == player && btText7.text == player)
        {
            // change the color of the grids that form a line
            btText3.color = Color.blue;
            btText5.color = Color.blue;
            btText7.color = Color.blue;
            feedback.text = "Winner: Player " + player;

            if (player == "X") // X won, add score by 1
            {
                oldscore = int.Parse(txtPlayerX.text);
                txtPlayerX.text = Convert.ToString(oldscore + 1);
            }
            else // O won, add score by 1
            {
                oldscore = int.Parse(txtPlayerO.text);
                txtPlayerO.text = Convert.ToString(oldscore + 1);
            }
        }
    }

    // When the user click on one of the 9 grids (buttons), put the corresponding symbol on the grid and check if the user has scored.

    // grid 1
    public void btText1_Click()
    {
        if (turn_X) // X's turn
        {
            btText1.text = "X";
            turn_X = false; // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText1.text = "O";
            turn_X = true; // the next turn is X's turn
            score("O"); // check if O scored
        }

        btText1.enabled = false; // disable the button after it has been selected
    }

    // grid 2
    public void btText2_Click()
    {
        if (turn_X) // X's turn
        {
            btText2.text = "X";
            turn_X = false; // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText2.text = "O";
            turn_X = true; // the next turn is X's turn
            score("O"); // check if O scored
        }

        btText2.enabled = false; // disable the button after it has been selected
    }

    // grid 3
    public void btText3_Click()
    {
        if (turn_X) // X's turn
        {
            btText3.text = "X";
            turn_X = false; // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText3.text = "O";
            turn_X = true; // the next turn is X's turn
            score("O"); // check if O scored
        }

        btText3.enabled = false; // disable the button after it has been selected
    }

    // grid 4
    public void btText4_Click()
    {
        if (turn_X) // X's turn
        {
            btText4.text = "X";
            turn_X = false; // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText4.text = "O";
            turn_X = true; // the next turn is X's turn
            score("O"); // check if O scored
        }

        btText4.enabled = false; // disable the button after it has been selected
    }

    // grid 5 
    public void btText5_Click()
    {
        if (turn_X) // X's turn
        {
            btText5.text = "X";
            turn_X = false; // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText5.text = "O";
            turn_X = true; // the next turn is X's turn
            score("O"); // check if O scored
        }

        btText5.enabled = false; // disable the button after it has been selected
    }

    // grid 6
    public void btText6_Click()
    {
        if (turn_X) // X's turn
        {
            btText6.text = "X";
            turn_X = false; // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText6.text = "O";
            turn_X = true; // the next turn is X's turn
            score("O"); // check if O scored
        }

        btText6.enabled = false; // disable the button after it has been selected
    }

    // grid 7 
    public void btText7_Click()
    {
        if (turn_X) // X's turn
        {
            btText7.text = "X";
            turn_X = false; // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText7.text = "O";
            turn_X = true; // the next turn is X's turn
            score("O"); // check if O scored
        }

        btText7.enabled = false; // disable the button after it has been selected
    }

    // grid 8
    public void btText8_Click()
    {
        if (turn_X) // X's turn
        {
            btText8.text = "X";
            turn_X = false; // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText8.text = "O";
            turn_X = true; // the next turn is X's turn
            score("O"); // check if O scored
        }

        btText8.enabled = false; // disable the button after it has been selected
    }

    // grid 9
    public void btText9_Click()
    {
        if (turn_X) // X's turn
        {
            btText9.text = "X";
            turn_X = false; // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText9.text = "O";
            turn_X = true; // the next turn is X's turn
            score("O"); // check if O scored
        }

        btText9.enabled = false; // disable the button after it has been selected
    }


}
