using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
   public List<QuestionAndAnswer> QnA;
   public GameObject[] options;
   public int currentQuestion;


   public TMP_Text QuestionTxt;
   public TMP_Text ScoreTxt;

   int totalQuestions = 0;
   public int score;


   public GameObject Quizpanel;
   public GameObject GOPanel;



   private void Start()
   {
       totalQuestions = QnA.Count;
       GOPanel.SetActive(false);
       generateQuestion();

   }

   public void retry()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

   }

   public void GameOver()
   {
       Quizpanel.SetActive(false);
       GOPanel.SetActive(true);
       ScoreTxt.text = score  + " / "  + totalQuestions;
   }

   public void correct()
   {
       // correct
       score += 1;
       QnA.RemoveAt(currentQuestion);
       generateQuestion();
   }

   public void wrong()
   {
       //when ans  is wrong
        QnA.RemoveAt(currentQuestion);
        generateQuestion();
   }
   

   void SetAnswers()
   {
       for (int i = 0; i < options.Length; i++)
       {
           options[i].transform.GetChild(0).GetComponent<TMP_Text>().text = QnA[currentQuestion].Answers[i];

           AnswerScript answerScript = options[i].GetComponentInChildren<AnswerScript>();
           answerScript.isCorrect = (i == QnA[currentQuestion].CorrectAnswer);
           answerScript.quizManager = this;
       }
       
   }
   

   void generateQuestion()
   {
       if(QnA.Count > 0)
       {
           currentQuestion = Random.Range(0, QnA.Count);

           QuestionTxt.text = QnA[currentQuestion].Question;
           SetAnswers();

       }
       else
       {
           Debug.Log("Out of Question");
           GameOver();
       }
       
   }



}
