using UnityEngine;
using static StaticFunc;

public class Trening : MonoBehaviour
{
    public int DialogueID = 0;
    public int MultiDialogue = 1;
    public int LastDialogue = 0;
    public bool AwaitForChoice = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(1) && !AwaitForChoice || Input.GetKeyDown(KeyCode.Return) && !AwaitForChoice )
        {
            DialogueID++;
        }

        //Testowe
        if (Input.GetKeyDown(KeyCode.Q))
        {
            DialogueID = 1;
        }

        switch (DialogueID)
        {
            case 1:
                Dialogue.OutputText.text =
                    "<i>Grupa przyjaciół umówiła się po końcu roku szkolnego, by uczcić wakacje. \n" +
                    "Wszyscy spotkali sie u Lukiego, i każdy przyniósł coś od siebie. Regi kupił Orzeszki w czekoladzie, Boltu napoje, a Matt... Zapomniał, ale każdy przymknął na to oko. \n" +
                    "Uroczystość odbyła się wieczorem po 19. Jako iż było lato, uznali że zdążą wszystko przygotować zanim się ściemni...</i>";
                break;
            case 2:
                Dialogue.OutputText.text = "<color=red>Boltu:</color> \n" +
                    "<size=80%>Cichać, zaczyna się!";
                break;
            case 3:
                Dialogue.OutputText.text = "<color=green>Luki:</color> \n" +
                    "<size=80%>Boltu, wiesz może kiedy przyjdzie Rawi?";
                break;
            case 4:
                Dialogue.FirstText.text = "Opanowanie";
                Dialogue.SecoundText.text = "Pewnie";
                Dialogue.ThirdText.text = "Niepewnie";
                Dialogue.FourthText.text = "Wymijająco";
                if (Input.GetKeyDown(KeyCode.Return) && AwaitForChoice)
                {
                    if (Dialogue.DialScroll != -1)
                        MultiDialogue = Dialogue.DialScroll;
                    switch (MultiDialogue)
                    {
                        case 1:
                            Dialogue.OutputText.text = "<color=red>Boltu:</color> \n" +
                             "<size=80%>Na pewno niedługo przyjdzie.";
                            break;
                        case 2:
                            Dialogue.OutputText.text = "<color=red>Boltu:</color> \n" +
                            "<size=80%>Zaraz będzie, coś wspominała że się spóźni.";
                            break;
                        case 3:
                            Dialogue.OutputText.text = "<color=red>Boltu:</color> \n" +
                            "<size=80%>Nie... Skąd mam wiedzieć.";
                            break;
                        case 4:
                            Dialogue.OutputText.text = "<color=red>Boltu:</color> \n" +
                            "<size=80%>A jak życie mija...?";
                            break;
                    }
                    AwaitForChoice = false;
                    DecisionsClose();
                }
                SetDialogue();
                break;
            case 5:
                switch (MultiDialogue)
                {
                    case 1:
                        Dialogue.OutputText.text = "<color=green>Luki:</color> \n" +
                        "<size=80%>Mam nadzieję.";
                        break;
                    case 2:
                        Dialogue.OutputText.text = "<color=green>Luki:</color> \n" +
                        "<size=80%>Spoko.";
                        break;
                    case 3:
                        Dialogue.OutputText.text = "<color=green>Luki:</color> \n" +
                        "<size=80%>Tylko żeby nie zapomniała...";
                        break;
                    case 4:
                        Dialogue.OutputText.text = "<color=green>Luki:</color> \n" +
                        "<size=80%>Co to za pytanie... A nie ważne.";
                        break;
                }
                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            case 9:

                break;
            case 10:

                break;
            case 11:

                break;
            case 12:

                break;
            case 13:

                break;
            case 14:

                break;
            case 15:

                break;
        }
    }

    private void SetDialogue()
    {
        if (LastDialogue != DialogueID)
        {
            AwaitForChoice = true;
            DecisionsOpen();
            LastDialogue = DialogueID;
        }
    }
}
