﻿
namespace Framework.Minigames.MinigameDefClasses;
public class Material : SVGImage
{
    public Rectangle PlaceHolder { get; set; }
    public SVGImage HintImage { get; set; }
    public string HintImageUrl { get; set; }
    public int PlaceHolderX { get; set; }
    public int PlaceHolderY { get; set; }
    public int CorrectX { get; set; }
    public int CorrectY { get; set; }
    public int CurrentX { get; set; } = -1;
    public int CurrentY { get; set; } = -1;
    public Text Label { get; set; }
    public string LabelText { get; set; }
}

public class PhMinigame : MinigameDefBase
{
    public override string BackgroundImage { get; set; } = "images/PhMinigame/edited/Platform1.png";
    public Material? SelectedMaterial { get; set; }
    static int ColumnCount = 6;
    static int RowCount = 8;
    int WhiteBoardRectangleWidth = 128;
    int WhiteBoardRectangleHeight = 105;
    int NumberOfVerticalSticks = 7;
    int NumberOfHorizontalSticks = 4;

    List<Material> Materials { get; set; } = new List<Material>();
    public Rectangle[,] WhiteBoardRectangles = new Rectangle[ColumnCount, RowCount];

    public PhMinigame()
    {
        StartGame();
    }

    void StartGame()
    {
        CreateBackgroundElement();
        CreateWhiteBoardRectangles();
        CreateMaterials();

    }

    void CreateBackgroundElement()
    {
        var BackgroundElement = new Rectangle()
        {
            X = 0,
            Y = 0,
            Width = 2000,
            Height = 2000,
            Fill = "transparent",
            OnClick = (args) =>
            {
                if (SelectedMaterial == null) return;
                ResetMaterial(SelectedMaterial);
                SelectedMaterial = null;
            },
        };

        AddElement(BackgroundElement);
    }

    void CreateWhiteBoardRectangles()
    {
        for (int x = 0; x < ColumnCount; x++)
        {
            for (int y = 0; y < RowCount; y++)
            {
                Rectangle WhiteBoard = new Rectangle()
                {
                    X = (x * WhiteBoardRectangleWidth) + 380,
                    Y = (y * WhiteBoardRectangleHeight) + 95,
                    Width = WhiteBoardRectangleWidth,
                    Height = WhiteBoardRectangleHeight,
                    Fill = "transparent"
                    //Fill = "rgba(0,255,0,.5)",
                };

                int WhiteBoardPointX = x;
                int WhiteBoardPointY = y;

                WhiteBoard.OnClick = (args) =>
                {
                    if (SelectedMaterial == null) return;
                    PlaceMaterialTo(SelectedMaterial, WhiteBoardPointX, WhiteBoardPointY);
                };

                AddElement(WhiteBoard);
                WhiteBoardRectangles[x, y] = WhiteBoard;

            }
        }
    }

    void CreateMaterials()
    {
        Materials = new List<Material>()
        {
            new Material()
            {
                Id = "HorizontalStick1",
                Image = "images/PhMinigame/edited/HorizontalStick.png",
                HintImageUrl = "images/PhMinigame/edited/HorizontalStick_hint.png",
                Height = 80,
                Width = 190,
                CorrectX = 2,
                CorrectY = 1,
                PlaceHolderX = 1430,
                PlaceHolderY = 680,
                LabelText = $"Horizontal Sticks, There are: {NumberOfHorizontalSticks} sticks"

            },
            new Material()
            {
                Id = "HorizontalStick2",
                Image = "images/PhMinigame/edited/HorizontalStick.png",
                HintImageUrl = "images/PhMinigame/edited/HorizontalStick_hint.png",
                Height = 80,
                Width = 190,
                CorrectX = 3,
                CorrectY = 1,
                PlaceHolderX = 1430,
                PlaceHolderY = 680,
            },
            new Material()
            {
                Id = "HorizontalStick3",
                Image = "images/PhMinigame/edited/HorizontalStick.png",
                HintImageUrl = "images/PhMinigame/edited/HorizontalStick_hint.png",
                Height = 80,
                Width = 190,
                CorrectX = 2,
                CorrectY = 6,
                PlaceHolderX = 1430,
                PlaceHolderY = 680,
            },
             new Material()
            {
                Id = "HorizontalStick4",
                Image = "images/PhMinigame/edited/HorizontalStick.png",
                HintImageUrl = "images/PhMinigame/edited/HorizontalStick_hint.png",
                Height = 80,
                Width = 190,
                CorrectX = 3,
                CorrectY = 6,
                PlaceHolderX = 1430,
                PlaceHolderY = 680,
            },
            new Material()
            {
                Id = "VerticalStick1",
                Image = "images/PhMinigame/edited/VerticalStick.png",
                HintImageUrl = "images/PhMinigame/edited/VerticalStick_hint.png",
                Height = 100,
                Width = 190,
                CorrectX = 4,
                CorrectY = 2,
                PlaceHolderX = 1430,
                PlaceHolderY = 820,
                LabelText = $"Vertical Sticks, There are : {NumberOfVerticalSticks} sticks"

            },
            new Material()
            {
                Id = "VerticalStick2",
                Image = "images/PhMinigame/edited/VerticalStick.png",
                HintImageUrl = "images/PhMinigame/edited/VerticalStick_hint.png",
                Height = 100,
                Width = 190,
                CorrectX = 4,
                CorrectY = 3,
                PlaceHolderX = 1430,
                PlaceHolderY = 820,
            },
            new Material()
            {
                Id = "VerticalStick3",
                Image = "images/PhMinigame/edited/VerticalStick.png",
                HintImageUrl = "images/PhMinigame/edited/VerticalStick_hint.png",
                Height = 100,
                Width = 190,
                CorrectX = 4,
                CorrectY = 4,
                PlaceHolderX = 1430,
                PlaceHolderY = 820,
            },
             new Material()
            {
                Id = "VerticalStick4",
                Image = "images/PhMinigame/edited/VerticalStick.png",
                HintImageUrl = "images/PhMinigame/edited/VerticalStick_hint.png",
                Height = 100,
                Width = 190,
                CorrectX = 4,
                CorrectY = 5,
                PlaceHolderX = 1430,
                PlaceHolderY = 820,
            },
            new Material()
            {
                Id = "VerticalStick5",
                Image = "images/PhMinigame/edited/VerticalStick.png",
                HintImageUrl = "images/PhMinigame/edited/VerticalStick_hint.png",
                Height = 100,
                Width = 190,
                CorrectX = 1,
                CorrectY = 2,
                PlaceHolderX = 1430,
                PlaceHolderY = 820,
            },
            new Material()
            {
                Id = "VerticalStick6",
                Image = "images/PhMinigame/edited/VerticalStick.png",
                HintImageUrl = "images/PhMinigame/edited/VerticalStick_hint.png",
                Height = 100,
                Width = 190,
                CorrectX = 1,
                CorrectY = 3,
                PlaceHolderX = 1430,
                PlaceHolderY = 820,
            },
            new Material()
            {
                Id = "VerticalStick7",
                Image = "images/PhMinigame/edited/VerticalStick.png",
                HintImageUrl = "images/PhMinigame/edited/VerticalStick_hint.png",
                Height = 100,
                Width = 190,
                CorrectX = 1,
                CorrectY = 5,
                PlaceHolderX = 1430,
                PlaceHolderY = 820,
            },
            new Material()
            {
                Id = "Potentiometer",
                Image = "images/PhMinigame/edited/Potentiometer.png",
                HintImageUrl = "images/PhMinigame/edited/Potentiometer_hint.png",
                Height = 170,
                Width = 190,
                CorrectX = 4,
                CorrectY = 1,
                PlaceHolderX = 1420,
                PlaceHolderY = 30,
                LabelText = "Potentiometer"
            },
            new Material()
            {
                Id = "Switch 1",
                Image = "images/PhMinigame/edited/Switch1.png",
                HintImageUrl = "images/PhMinigame/edited/Switch_hint.png",
                Height = 170,
                Width = 190,
                CorrectX = 1,
                CorrectY = 6,
                PlaceHolderX = 1425,
                PlaceHolderY = 245,
                LabelText = "Switch 1"
            },
            new Material()
            {
                Id = "Switch 2",
                Image = "images/PhMinigame/edited/Switch2.png",
                HintImageUrl = "images/PhMinigame/edited/Switch_hint.png",
                Height = 170,
                Width = 190,
                CorrectX = 4,
                CorrectY = 6,
                PlaceHolderX = 1430,
                PlaceHolderY = 460,
                LabelText = "Switch 2"
            },
            new Material()
            {
                Id = "Lamp",
                Image = "images/PhMinigame/edited/HorizontalLamp.png",
                HintImageUrl = "images/PhMinigame/edited/HorizontalLamp_hint.png",
                Height = 80,
                Width = 190,
                CorrectX = 1,
                CorrectY = 4,
                PlaceHolderX = 1430,
                PlaceHolderY = 940,
                LabelText = "Lamp"
            },
            new Material()
            {
                Id = "Battery",
                Image = "images/PhMinigame/edited/Battery.png",
                HintImageUrl = "images/PhMinigame/edited/Battery_hint.png",
                Height = 170,
                Width = 190,
                CorrectX = 1,
                CorrectY = 1,
                PlaceHolderX = 1190,
                PlaceHolderY = 78,
                LabelText = "Battery"
            },
        };

        foreach (var material in Materials)
        {
            AddMaterialToGame(material);
        }
    }

    void AddMaterialToGame(Material material)
    {

        material.Visible = false;

        material.OnClick = (args) => OnMaterialClick(material);

        material.PlaceHolder = new Rectangle()
        {
            X = material.PlaceHolderX,
            Y = material.PlaceHolderY,
            Width = material.Width.Value,
            Height = material.Height.Value,
            //Fill = "rgba(255,0,0,.50)",
            Fill = "transparent",
            OnClick = (args) => OnMaterialClick(material)
        };

        material.HintImage = new SVGImage()
        {
            Width = material.Width,
            Height = material.Height,
            Image = material.HintImageUrl,
            OnClick = (args) => OnHintClick(material),
            Visible = false
        };

        material.Label = new Text()
        {
            X = material.PlaceHolderX + 50,
            Y = material.PlaceHolderY + 115,
            InnerText = material.LabelText,
            Fill = "white",
        };



        AddElement(material.PlaceHolder);
        AddElement(material.HintImage);
        AddElement(material.Label);
        AddElement(material);
    }



    void OnHintClick(Material material)
    {
        material.CurrentX = material.CorrectX;
        material.CurrentY = material.CorrectY;

        PlaceImageToWhiteBoardCenter(material, WhiteBoardRectangles[material.CorrectX, material.CorrectY]);

        CheckIsFinished();
    }

    void OnMaterialClick(Material material)
    {
        material.HintImage.Visible = true;
        material.PlaceHolder.Visible = false;

        PlaceImageToWhiteBoardCenter(material.HintImage, WhiteBoardRectangles[material.CorrectX, material.CorrectY]);

        if (SelectedMaterial != null && SelectedMaterial != material)
        {
            HideHint(SelectedMaterial);
        }

        SelectedMaterial = material;
    }

    void HideHint(Material material)
    {
        material.HintImage.Visible = false;
        Update();
    }

    void ResetMaterial(Material material)
    {
        material.PlaceHolder.Visible = true;
        material.Visible = false;
        material.CurrentX = -1;
        material.CurrentY = -1;

        HideHint(material);
    }
    void PlaceMaterialTo(Material material, int x, int y)
    {
        PlaceImageToWhiteBoardCenter(material, WhiteBoardRectangles[x, y]);
        material.CurrentX = x;
        material.CurrentY = y;
    }
    public void PlaceImageToWhiteBoardCenter(SVGImage image, Rectangle whiteBoard)
    {
        image.X = whiteBoard.X + whiteBoard.Width / 2 - image.Width / 2;
        image.Y = whiteBoard.Y + whiteBoard.Height / 2 - image.Width / 2;

        image.Visible = true;

        Update();
    }
    public void CheckIsFinished()
    {
        bool isFinished = true;

        foreach (var material in Materials)
        {

            if (material.CurrentX != material.CorrectX || material.CurrentY != material.CorrectY)
            {

                isFinished = false;
                break;
            }
        }

        if (isFinished)
        {
            foreach (var material in Materials)
            {
                material.Visible = false;
                material.HintImage.Visible = false;
                SelectedMaterial = null;

            }
            BackgroundImage = "images/PhMinigame/edited/FinishedGameBackground.png";
            Finish(true);
            Update();
        }
    }
}