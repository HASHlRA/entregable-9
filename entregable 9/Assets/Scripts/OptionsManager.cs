using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OptionsManager : MonoBehaviour
{
    // UI
    public TMP_InputField nicknameUI;
    public TMP_Dropdown difficultyUI;
    public Toggle AutoguardadoUI;
    public TextMeshProUGUI roundsUI;
    public Slider GraficosUI;

    // por defecto
    private string DefaultNickname = "Hashira";
    private int DefaultDifficulty = 0;
    private bool DefaultAutoguardado = true;
    private float DefaultGraficos = 0.5f;
    private int DefaultRounds = 3;

    // data persistence
    private DataPersistence dataPersistence;

    private void Start()
    {
        // obtiene el script datapersistence
        dataPersistence = FindObjectOfType<DataPersistence>();

        // guarda las opciones
        LoadSavedSettings();
    }

    // guarda las opciones
    private void LoadSavedSettings()
    {
        GetNickname();
        GetDifficulty();
        GetAutoguardado();
        GetGraficos();
        GetRounds();
    }


    // obtiene el nombre de usuario
    public void GetNickname()
    {
        // si no está, establece un valor
        if (!dataPersistence.HasKey("Nickname"))
        {
            SetNickname(DefaultNickname);
        }

        // recibe el valor
        nicknameUI.text = dataPersistence.GetString("Nickname");
    }

    // obtiene la dificultad
    public void GetDifficulty()
    {
        // si no está, establece un valor
        if (!dataPersistence.HasKey("Difficulty"))
        {
            SetDifficulty(DefaultDifficulty);
        }

        // recibe el valor
        difficultyUI.value = dataPersistence.GetInt("Difficulty");
    }

    // obtiene el autoguardado
    public void GetAutoguardado()
    {
        // si no está, establece un valor
        if (!dataPersistence.HasKey("Autoguardado"))
        {
            SetAutoguardado(DefaultAutoguardado);
        }

        // recibe el valor
        AutoguardadoUI.isOn = dataPersistence.GetBool("Autoguardado");
    }

    // obtiene los graficos
    public void GetGraficos()
    {
        // si no está, establece un valor
        if (!dataPersistence.HasKey("Graficos"))
        {
            SetGraficos(DefaultGraficos);
        }

        // recibe el valor
        GraficosUI.value = dataPersistence.GetFloat("Graficos");
    }

    // obtiene las rondas
    public void GetRounds()
    {
        // si no está, establece un valor
        if (!dataPersistence.HasKey("Rounds"))
        {
            SetRounds(DefaultRounds);
        }

        // recibe el valor
        roundsUI.text = dataPersistence.GetInt("Rounds").ToString();
    }


    // guarda el usuario
    public void SetNickname(string name)
    {
        dataPersistence.SetString("Nickname", name);
    }

    // guarda la dificultad
    public void SetDifficulty(int index)
    {
        dataPersistence.SetInt("Difficulty", index);
    }

    // guarda el autoguardado
    public void SetAutoguardado(bool mode)
    {
        dataPersistence.SetBool("Autoguardado", mode);
    }


    // guarda los graficos
    public void SetGraficos(float quality)
    {
        dataPersistence.SetFloat("Graficos", quality);
    }

    // guarda las rondas
    public void SetRounds(int rounds)
    {
        dataPersistence.SetInt("Rounds", rounds);
    }

    // añade 1 ronda
    public void AddRounds()
    {
        // texto + 1
        int temp = int.Parse(roundsUI.text) + 1;

        // min. 1 - max. 10
        temp = Mathf.Clamp(temp, 1, 10);

        // actualiza
        roundsUI.text = temp.ToString();

        // lo guarda
        SetRounds(temp);
    }

    // resta 1 ronda
    public void RemoveRounds()
    {
        // texto - 1
        int temp = int.Parse(roundsUI.text) - 1;

        // min. 1 - max. 10
        temp = Mathf.Clamp(temp, 1, 10);

        // actualiza
        roundsUI.text = temp.ToString();

        // lo guarda
        SetRounds(temp);
    }
}