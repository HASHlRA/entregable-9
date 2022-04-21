using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsManager : MonoBehaviour
{
    // variables
    public TMP_InputField nicknameUI;
    public TMP_Dropdown difficultyUI;
    public TextMeshProUGUI roundNumber;

    private string nickname = "User";

    private int difficulty = 0;
    private string[] difficultyNames = { "Principiante", "Intermedio", "Experto" };

    private int totalRounds = 3;
    private int maxRounds = 6;
    private int minRounds = 1;
    


    // Al iniciar el juego
    private void Start()
    {
        nicknameUI.text = nickname;
        difficultyUI.value = difficulty;
        roundNumber.text = totalRounds.ToString();
    }


    // Establece el nombre de usuario
    public void SetNickname(string name)
    {
        // Guarda el nombre
        nickname = name;

        // Muestra por consola el Nickname insertado.
        Debug.Log($"Usuario cambiado a {nickname}");
    }

    // Establece la dificultad
    public void SetDifficulty(int index)
    {
        // Un switch seg�n el valor de index
        switch (index)
        {
            // Si index es valor 0
            case 0:

                // Guarda la dificultad y para la ejecuci�n del Switch
                difficulty = index;
                break;

            // Si index es valor 1
            case 1:

                // Guarda la dificultad y para la ejecuci�n del Switch
                difficulty = index;
                break;

            // Si index es valor 2
            case 2:

                // Guarda la dificultad y para la ejecuci�n del Switch
                difficulty = index;
                break;
        }

        // Muestra por consola la dificultad seleccionada.
        Debug.Log($" Modo {difficultyNames[difficulty]}");
    }

    // Suma 1 ronda
    public void AddRounds()
    {
        // Si el total de rondas es menor al m�ximo
        if (totalRounds < maxRounds)
        {
            // Suma uno al total
            totalRounds++;

            // Cambia el valor mostrado por pantalla
            roundNumber.text = totalRounds.ToString();

            // Muestra en consola
            Debug.Log($" N�mero de rondas {totalRounds}");
        }
    }

    // Resta 1 ronda
    public void RemoveRounds()
    {
        // Si el total de rondas es mayor al m�nimo
        if (totalRounds > minRounds)
        {
            // Resta uno al toal
            totalRounds--;

            // Cambia el valor mostrado por pantalla 
            roundNumber.text = totalRounds.ToString();

            // Muestra en consola
            Debug.Log($" N�mero de rondas {totalRounds}");
        }
    }
}
