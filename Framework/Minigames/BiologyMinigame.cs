using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Framework.Minigames.MinigameDefClasses;

public class BiologyMinigame : MinigameDefBase
{
    int currentScore = 0;
    int lives = 3;
    int questionNumber = 1;
    bool answer = true;
    public override string BackgroundImage {get; set;} = "/images/Cooles_Bild.JPG";
    [Element]
    public Rectangle Rect {get; set;}
    [Element]
    public Rectangle Rect2{get; set;}
    [Element]
    public Text TheText {get; set;} 
    [Element]
    public Text TheText2 {get; set;}
    [Element]
    public Text LifeText {get; set;}
    [Element]
    public Text QuestionOne {get; set;}
    [Element]
    public Text ScoreText {get; set;}
    [Element]
    public Text RealLifeText {get; set;}
    public GameObjectContainer<Rectangle> Rects {get; set;} = new();
    public GameObjectContainer<Rectangle> Rects2 {get; set;} = new();
    public GameObjectContainer<Text> TheTexts {get; set;} = new();
    public GameObjectContainer<Text> TheTexts2 {get; set;} = new();
    public GameObjectContainer<Text> LifeTexts {get; set;} = new();
    public GameObjectContainer<Text> ScoreTexts {get; set;} = new();
    public BiologyMinigame()
    {
        ScoreText = new()
        {
            InnerText = "Score: " + currentScore + "/5",
            X = 100,
            Y = 200,
            FontSize = 75,
            FontFamily = "sans-serif",
            Fill = "red"
        };
        ScoreTexts.Add(ScoreText);
        QuestionOne = new()
        {
            InnerText = "Ist x ein y?",
            X = 1000,
            Y = 100,
            FontSize = 100,
            FontFamily = "sans-serif",
            Fill = "green"
        };
        
        RealLifeText = new()
        {
            InnerText = "3",
            X = 500,
            Y = 100,
            FontSize = 75,
            FontFamily = "sans-serif",
            Fill = "red" 
        };

        LifeText = new()
        {
            InnerText = "Lives: ",
            X = 100,
            Y = 100,
            FontSize = 75,
            FontFamily = "sans-serif",
            Fill = "red" 
        };
        LifeTexts.Add(LifeText);

        TheText = new()
        {
            InnerText = "Richtig",
            X = 300,
            Y = 1000,
            FontSize = 100,
            FontFamily = "sans-serif",
            Fill = "white",
            OnClick = (args) => { int x = Convert.ToInt16(RealLifeText.InnerText);
                if (questionNumber % 2 != 0)
                {
                    x = x - 1;
                }
                else
                {
                    currentScore++;
                }
                questionNumber++;
                RealLifeText.InnerText = x.ToString(); 
                Update();
            }
        };    
        TheTexts.Add(TheText);
        
        TheText2 = new()
        {
            InnerText = "Falsch",
            X = 1100,
            Y = 1000,
            FontSize = 100,
            FontFamily = "sans-serif",
            Fill = "white",
            OnClick = (args) => { int x = Convert.ToInt16(RealLifeText.InnerText);
                if (questionNumber % 2 == 0)
                {
                    x = x - 1;
                }
                else
                {
                    currentScore++;
                }
                questionNumber++;
                RealLifeText.InnerText = x.ToString(); 
                Update();
            }
        };
        TheTexts2.Add(TheText2);
        
        Rect = new ()
        {
            X = 200,
            Y = 800,
            Width = 500,
            Height = 300,
            Fill = "green",
        };
        Rects.Add(Rect);
        
        Rect2 = new ()
        {
            X = 1000,
            Y = 800,
            Width = 500,
            Height = 300,
            Fill = "red",
        };
        Rects.Add(Rect2);
    }
}