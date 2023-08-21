using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int ScoreToReach = 21;
    public int SetsToReach = 5;
    //public int[] Sets;

    public int ActualSet = 0;
    public struct SetsStr {
        public int Jogador1;
        public int Jogador2;
    }

    public SetsStr sets;

    public int pontuacaoDoJogador1;
    public int pontuacaoDoJogador2;
    public Text textoDePontuacao1;
    public Text textoDePontuacao2;
    public Text textoDePontuacao3;
    public Text textoDePontuacao4;

    public Text textoDosSets;

    public AudioSource somDoGol;

    public bool FlowTime = false;
    public GameObject PauseButton;

    // Start is called before the first frame update
    void Start()
    {
        textoDosSets.text = $"{sets.Jogador2} / {sets.Jogador1}";
        PauseButton.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (FlowTime == true)
            {
                Time.timeScale = 1;
                PauseButton.SetActive(false);
                FlowTime = false;
            }
            else if (FlowTime == false)
            {
                Time.timeScale = 0;
                PauseButton.SetActive(true);
                FlowTime = true;
            }
            print($"{FlowTime}");
        }
    }

    public void AumentarPontuacaoDoJogador(int playerNum)
    {
        if (playerNum == 1)
        {
            pontuacaoDoJogador1++;
            AtualizarTextoDePontuacao();
        }
        if (playerNum == 2)
        {
            pontuacaoDoJogador2++;
            AtualizarTextoDePontuacao();
        }
    }

    public void AtualizarTextoDePontuacao()
    {
        textoDePontuacao1.text = " " + pontuacaoDoJogador1;
        textoDePontuacao2.text = " " + pontuacaoDoJogador2;

        CheckScore();
        somDoGol.Play(); //inclus�o do som
    }


    private void CheckScore()
    {
        if((pontuacaoDoJogador1 >= ScoreToReach) && (pontuacaoDoJogador1 > pontuacaoDoJogador2 + 1)){
            sets.Jogador1 +=1;
            ActualSet++;
            print($"Vitória do Jogador 1, {ActualSet}");
            //print($"[{string.Join(", ", Sets)}]");

            pontuacaoDoJogador1 = 0;
            pontuacaoDoJogador2 = 0;
            textoDosSets.text = $"{sets.Jogador2} / {sets.Jogador1}";
        }
        if((pontuacaoDoJogador2 >= ScoreToReach) && (pontuacaoDoJogador2 > pontuacaoDoJogador1 + 1)){
            sets.Jogador2 += 1;
            ActualSet++;
            print($"Vitória do Jogador 2, {ActualSet}");
            //print($"[{string.Join(", ", Sets)}]");

            pontuacaoDoJogador1 = 0;
            pontuacaoDoJogador2 = 0;
            textoDosSets.text = $"{sets.Jogador2} / {sets.Jogador1}";
        }
        

        if (ActualSet > SetsToReach){
            print($"O Jogador {(sets.Jogador1 > sets.Jogador2 ? 1 : 2)} é o vencedor");

            textoDosSets.text = $"{sets.Jogador2} / {sets.Jogador1}";

            //print($"[{string.Join(", ", Sets)}]");
            Time.timeScale = 0;
        }

        //print(Sets.GroupBy(x => x));

    }
}