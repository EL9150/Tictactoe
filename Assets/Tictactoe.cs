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
    public Button btGrid1;
    public Button btGrid2;
    public Button btGrid3;
    public Button btGrid4;
    public Button btGrid5;
    public Button btGrid6;
    public Button btGrid7;
    public Button btGrid8;
    public Button btGrid9;

    // grid text
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
    public Text txtTurn = null; // show whose turn it is

    // make all grids button not interactable
    public void after_score()
    {
        btGrid1.interactable = false;
        btGrid2.interactable = false;
        btGrid3.interactable = false;
        btGrid4.interactable = false;
        btGrid5.interactable = false;
        btGrid6.interactable = false;
        btGrid7.interactable = false;
        btGrid8.interactable = false;
        btGrid9.interactable = false;
    }

    // make all grids button interactable
    public void after_reset()
    {
        btGrid1.interactable = true;
        btGrid2.interactable = true;
        btGrid3.interactable = true;
        btGrid4.interactable = true;
        btGrid5.interactable = true;
        btGrid6.interactable = true;
        btGrid7.interactable = true;
        btGrid8.interactable = true;
        btGrid9.interactable = true;
    }

    // change to O's turn
    public void O_turn()
    {
        turn_X = false;
        txtTurn.text = "O's turn";
    }

    // change to X's turn
    public void X_turn()
    {
        turn_X = true;
        txtTurn.text = "X's turn";
    }

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
            after_score();
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
            after_score();
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
            after_score();
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
            after_score();
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
            after_score();
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
            after_score();
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
            after_score();
        }

        // 8. second diagonal
        else if (btText3.text == player && btText5.text == player && btText7.text == player)
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
            after_score();
        }
    }

    // When the user click on one of the 9 grids (buttons), put the corresponding symbol on the grid and check if the user has scored.

    // grid 1
    public void btText1_Click()
    {
        if (turn_X) // X's turn
        {
            btText1.text = "X";
            O_turn(); // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText1.text = "O";
            X_turn(); // the next turn is X's turn
            score("O"); // check if O scored
        }

        btGrid1.interactable = false; // disable the button after it has been selected
    }

    // grid 2
    public void btText2_Click()
    {
        if (turn_X) // X's turn
        {
            btText2.text = "X";
            O_turn(); // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText2.text = "O";
            X_turn(); // the next turn is X's turn
            score("O"); // check if O scored
        }

        btGrid2.interactable = false; // disable the button after it has been selected
    }

    // grid 3
    public void btText3_Click()
    {
        if (turn_X) // X's turn
        {
            btText3.text = "X";
            O_turn(); // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText3.text = "O";
            X_turn(); // the next turn is X's turn
            score("O"); // check if O scored
        }

        btGrid3.interactable = false; // disable the button after it has been selected
    }

    // grid 4
    public void btText4_Click()
    {
        if (turn_X) // X's turn
        {
            btText4.text = "X";
            O_turn(); // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText4.text = "O";
            X_turn(); // the next turn is X's turn
            score("O"); // check if O scored
        }

        btGrid4.interactable = false; // disable the button after it has been selected
    }

    // grid 5 
    public void btText5_Click()
    {
        if (turn_X) // X's turn
        {
            btText5.text = "X";
            O_turn(); // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText5.text = "O";
            X_turn(); // the next turn is X's turn
            score("O"); // check if O scored
        }

        btGrid5.interactable = false; // disable the button after it has been selected
    }

    // grid 6
    public void btText6_Click()
    {
        if (turn_X) // X's turn
        {
            btText6.text = "X";
            O_turn(); // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText6.text = "O";
            X_turn(); // the next turn is X's turn
            score("O"); // check if O scored
        }

        btGrid6.interactable = false; // disable the button after it has been selected
    }

    // grid 7 
    public void btText7_Click()
    {
        if (turn_X) // X's turn
        {
            btText7.text = "X";
            O_turn(); // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText7.text = "O";
            X_turn(); // the next turn is X's turn
            score("O"); // check if O scored
        }

        btGrid7.interactable = false; // disable the button after it has been selected
    }

    // grid 8
    public void btText8_Click()
    {
        if (turn_X) // X's turn
        {
            btText8.text = "X";
            O_turn(); // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText8.text = "O";
            X_turn(); // the next turn is X's turn
            score("O"); // check if O scored
        }

        btGrid8.interactable = false; // disable the button after it has been selected
    }

    // grid 9
    public void btText9_Click()
    {
        if (turn_X) // X's turn
        {
            btText9.text = "X";
            O_turn(); // the next turn is O's turn
            score("X"); // check if X scored
        }
        else
        {
            btText9.text = "O";
            X_turn(); // the next turn is X's turn
            score("O"); // check if O scored
        }

        btGrid9.interactable = false; // disable the button after it has been selected
    }


    // reset the grids
    public void btReset_Click()
    {
        // reset text in the 9 grids, then reset text color
        btText1.text = "";
        btText1.color = Color.black;
        btText2.text = "";
        btText2.color = Color.black;
        btText3.text = "";
        btText3.color = Color.black;
        btText4.text = "";
        btText4.color = Color.black;
        btText5.text = "";
        btText5.color = Color.black;
        btText6.text = "";
        btText6.color = Color.black;
        btText7.text = "";
        btText7.color = Color.black;
        btText8.text = "";
        btText8.color = Color.black;
        btText9.text = "";
        btText9.color = Color.black;

        // make all button interactable
        after_reset();
    }

    // start a new game, reset the score
    public void btNewgame_Click()
    {
        btReset_Click(); // reset the grids
        // reset the score
        txtPlayerO.text = "0";
        txtPlayerX.text = "0";
    }
}
