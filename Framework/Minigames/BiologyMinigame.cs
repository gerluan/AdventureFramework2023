using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace Framework.Minigames.MinigameDefClasses;

public class BiologyMinigame : MinigameDefBase
{
    int currentScore = 0;
    int lives = 3;
    int questionNumber = 0;
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
    public Text QuestionText {get; set;}
    [Element]
    public Text ScoreText {get; set;}
    [Element]
    public Text RealLifeText {get; set;}
    [Element]
    public Text RealScoreText {get; set;}
    [Element]
    public Text TitleOrVictoryOrFailure {get; set;}
    public GameObjectContainer<Rectangle> Rects {get; set;} = new();
    public GameObjectContainer<Rectangle> Rects2 {get; set;} = new();
    public GameObjectContainer<Text> TheTexts {get; set;} = new();
    public GameObjectContainer<Text> TheTexts2 {get; set;} = new();
    public GameObjectContainer<Text> LifeTexts {get; set;} = new();
    public GameObjectContainer<Text> ScoreTexts {get; set;} = new();
    public GameObjectContainer<Text> RealScoreTexts {get; set;} = new();
    public BiologyMinigame()
    {
        TitleOrVictoryOrFailure = new()
        {
            InnerText = "Get 5 points to win!",
            X = 500,
            Y = 100,
            FontSize = 75,
            FontFamily = "sans-serif",
            Fill = "yellow"
        };
        ScoreText = new()
        {
            InnerText = "Score:",
            X = 100,
            Y = 200,
            FontSize = 75,
            FontFamily = "sans-serif",
            Fill = "red"
        };
        ScoreTexts.Add(ScoreText);
        QuestionText = new()
        {
            InnerText = "Alle Säugetiere legen Eier",
            X = 400,
            Y = 400,
            FontSize = 34,
            FontFamily = "sans-serif",
            Fill = "black"
        };
        
        RealLifeText = new()
        {
            InnerText = "3",
            X = 350,
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
            Fill = "red",
            
        };
        LifeTexts.Add(LifeText);

        RealScoreText = new()
        {
            InnerText = "0",
            X = 350,
            Y = 200,
            FontSize = 75,
            FontFamily = "sans-serif",
            Fill = "red",            
        };
        RealScoreTexts.Add(RealScoreText);

        TheText = new()
        {
            InnerText = "Richtig",
            X = 300,
            Y = 1000,
            FontSize = 100,
            FontFamily = "sans-serif",
            Fill = "white",
            OnClick = (args) => { int x = Convert.ToInt16(RealLifeText.InnerText);
                int y = Convert.ToInt16(RealScoreText.InnerText);
                string z = QuestionText.InnerText;
                string a = TitleOrVictoryOrFailure.InnerText;
                questionNumber++;
                if (questionNumber % 2 != 0 && x > 1 && questionNumber == 1)
                {
                    x = x - 1;
                    z = "Pflanzen produzieren Sauerstoff durch Photosynthese";
                }
                else if (questionNumber % 2 != 0 && x > 1 && questionNumber == 2)
                {
                    x = x - 1;
                    z = "Ein Virus kann sich ohne einen Wirt vermehren";
                }
                else if (questionNumber % 2 != 0 && x > 1 && questionNumber == 3)
                {
                    x = x - 1;
                    z = "Menschen haben 206 Knochen";
                }
                else if (questionNumber % 2 != 0 && x > 1 && questionNumber == 4)
                {
                    x = x - 1;
                    z = "Pilze sind Pflanzen";
                }
                else if (questionNumber % 2 != 0 && x > 1 && questionNumber == 5)
                {
                    x = x - 1;
                    z = "Der Herzschlag beträgt 70/min im Ruhezustand";
                }
                else if (questionNumber % 2 != 0 && x > 1 && questionNumber == 6)
                {
                    x = x - 1;
                    z = "Fische atmen Luft durch die Lungen";
                }
                else if (questionNumber % 2 == 0 && y < 4 && questionNumber == 1)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Pflanzen produtzieren Sauerstoff durch Photosynthese";
                }
                else if (questionNumber % 2 == 0 && y < 4 && questionNumber == 2)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Ein Virus kann sich ohne Wirt vermehren";
                }
                else if (questionNumber % 2 == 0 && y < 4 && questionNumber == 3)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Menschen haben 206 Knochen im Körper";
                }
                else if (questionNumber % 2 == 0 && y < 4 && questionNumber == 4)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Pilze sind Pflanzen";
                }
                else if (questionNumber % 2 == 0 && y < 4 && questionNumber == 5)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Der Herzschlag beträgt 70/min im Ruhezustand";
                }
                else if (questionNumber % 2 == 0 && y < 4 && questionNumber == 6)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Fische atmen Luft durch die Lungen";
                }
                else if (x == 1)
                {
                    x = 0;
                    z = "";
                    a = "Game Over!";
                }
                else if (y == 4)
                {
                    y = 5;
                    z = "";
                    a = "You win!";
                }
                RealLifeText.InnerText = x.ToString();
                RealScoreText.InnerText = y.ToString(); 
                QuestionText.InnerText = z.ToString();
                TitleOrVictoryOrFailure.InnerText = a.ToString();
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
                int y = Convert.ToInt16(RealScoreText.InnerText);
                string z = QuestionText.InnerText;
                string a = TitleOrVictoryOrFailure.InnerText;
                questionNumber++;
                if (questionNumber % 2 == 0 && x > 1 && questionNumber == 1)
                {
                    x = x - 1;
                    z = "Pflanzen produzieren Sauerstoff durch Photosynthese";
                }
                else if (questionNumber % 2 == 0 && x > 1 && questionNumber == 2)
                {
                    x = x - 1;
                    z = "Ein Virus kann sich ohne Wirt vermehren";
                }
                else if (questionNumber % 2 == 0 && x > 1 && questionNumber == 3)
                {
                    x = x - 1;
                    z = "Menscheb haben 206 Knochen im Körper";
                }
                else if (questionNumber % 2 == 0 && x > 1 && questionNumber == 4)
                {
                    x = x - 1;
                    z = "Pilze sind Pflanzen";
                }
                else if (questionNumber % 2 == 0 && x > 1 && questionNumber == 5)
                {
                    x = x - 1;
                    z = "Der Herzschlag beträgt 70/min im Ruhezustand";
                }
                else if (questionNumber % 2 == 0 && x > 1 && questionNumber == 6)
                {
                    x = x - 1;
                    z = "Fische atmen Luft durch die Lungen";
                }
                else if (questionNumber % 2 != 0 && y < 4 && questionNumber == 1)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Pflanzen produzieren Sauerstoff durch Photosynthese";
                }
                else if (questionNumber % 2 != 0 && y < 4 && questionNumber == 2)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Ein Virus kann sich ohne Wirt vermehren";
                }
                else if (questionNumber % 2 != 0 && y < 4 && questionNumber == 3)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Menschen haben 206 Knochen im Körper";
                }
                else if (questionNumber % 2 != 0 && y < 4 && questionNumber == 4)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Pilze sind Pflanzen";
                }
                else if (questionNumber % 2 != 0 && y < 4 && questionNumber == 5)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Der Herzschlag beträgt 70/min im Ruhezustand";
                }
                else if (questionNumber % 2 != 0 && y < 4 && questionNumber == 6)
                {
                    y = y + 1;
                    currentScore++;
                    z = "Fische atmen Luft durch Lungen";
                }
                else if (x == 1)
                {
                    x = 0;
                    z = "";
                    a = "Game Over!";
                }
                else if (y == 4)
                {
                    y = 5;
                    z = "";
                    a = "You win!";
                }
                RealLifeText.InnerText = x.ToString(); 
                RealScoreText.InnerText = y.ToString();
                QuestionText.InnerText = z.ToString();
                TitleOrVictoryOrFailure.InnerText = a.ToString();
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