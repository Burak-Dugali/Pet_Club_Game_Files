using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LanguageManager : MonoBehaviour
{
    [SerializeField] public Text credits;
    [SerializeField] public Text backCredits;
    [SerializeField] public Text backSettings;
    [SerializeField] public Text LangSettings;
    [SerializeField] public Text NewGame;
    [SerializeField] public Text LoadGame;
    [SerializeField] public Text BackGameScreen;
    
    [SerializeField] public Text YemekAdi;
    [SerializeField] public Text TavukNormal;
    [SerializeField] public Text TavukEtcil;
    [SerializeField] public Text TavukOtcul;
    [SerializeField] public Text Nomoney;

    [SerializeField] public Text NoStamina;

    [SerializeField] public Wartextanakarakter RoadMapSavas2Skill5Et;
    [SerializeField] public Wartextanakarakter RoadMapSavas2Skill5Ot;
    [SerializeField] public Wartextanakarakter RoadMapSavas2Skill5Yanma;
    [SerializeField] public Wartextanakarakter RoadMapSavas3Skill5Et;
    [SerializeField] public Wartextanakarakter RoadMapSavas3Skill5Ot;
    [SerializeField] public Wartextanakarakter RoadMapSavas3Skill5Yanma;
    [SerializeField] public Wartextanakarakter RoadMapSavas4Skill5Et;
    [SerializeField] public Wartextanakarakter RoadMapSavas4Skill5Ot;
    [SerializeField] public Wartextanakarakter RoadMapSavas4Skill5Yanma;
    [SerializeField] public Wartextanakarakter RoadMapSavas5Skill5Et;
    [SerializeField] public Wartextanakarakter RoadMapSavas5Skill5Ot;
    [SerializeField] public Wartextanakarakter RoadMapSavas5Skill5Yanma;


    [SerializeField] public Wartextanakarakter CutScene1v1;
    [SerializeField] public Wartextanakarakter CutScene1v2;
    [SerializeField] public Wartextanakarakter CutScene1v3;
    [SerializeField] public Wartextanakarakter CutScene1v4;
    [SerializeField] public Wartextanakarakter CutScene1v5;

    [SerializeField] public Wartextanakarakter RoadMapSkill1;
    [SerializeField] public Wartextanakarakter RoadMapSkill2;
    [SerializeField] public Wartextanakarakter RoadMapSkill3;
    [SerializeField] public Wartextanakarakter RoadMapSkill4Kritik;
    [SerializeField] public Wartextanakarakter RoadMapSkill4Miss;

    [SerializeField] public Wartextanakarakter RoadMapSkill1v2;
    [SerializeField] public Wartextanakarakter RoadMapSkill2v2;
    [SerializeField] public Wartextanakarakter RoadMapSkill3v2;
    [SerializeField] public Wartextanakarakter RoadMapSkill4v2Kritik;

    [SerializeField] public Wartextanakarakter RoadMapSkill1v3;
    [SerializeField] public Wartextanakarakter RoadMapSkill2v3;
    [SerializeField] public Wartextanakarakter RoadMapSkill3v3;
    [SerializeField] public Wartextanakarakter RoadMapSkill4v3Kritik;

    [SerializeField] public Wartextanakarakter RoadMapSkill1v4;
    [SerializeField] public Wartextanakarakter RoadMapSkill2v4;
    [SerializeField] public Wartextanakarakter RoadMapSkill3v4;
    [SerializeField] public Wartextanakarakter RoadMapSkill4v4Kritik;

    [SerializeField] public Wartextanakarakter RoadMapSkill1v5;
    [SerializeField] public Wartextanakarakter RoadMapSkill2v5;
    [SerializeField] public Wartextanakarakter RoadMapSkill3v5;
    [SerializeField] public Wartextanakarakter RoadMapSkill4v5Kritik;

    [SerializeField] public Text CeviklikGameKazandin;
    [SerializeField] public Text CeviklikGameStartButton;
    [SerializeField] public Text GucGameKazandin;
    [SerializeField] public Text GucGameStartButton;
   
   
    [SerializeField] public Text TavukAdi;
    [SerializeField] public Text RoadMapYourTurn1;
    [SerializeField] public Text RoadMapEnemyTurn1;
    [SerializeField] public Text RoadMapYourTurn2;
    [SerializeField] public Text RoadMapEnemyTurn2;
    [SerializeField] public Text RoadMapYourTurn3;
    [SerializeField] public Text RoadMapEnemyTurn3;
    [SerializeField] public Text RoadMapYourTurn4;
    [SerializeField] public Text RoadMapEnemyTurn4;
    [SerializeField] public Text RoadMapYourTurn5;
    [SerializeField] public Text RoadMapEnemyTurn5;

    [SerializeField] public Text RoadMapSavas1Win;
    [SerializeField] public Text RoadMapSavas1Lose;
    [SerializeField] public Text RoadMapSavas1WinBackButton;
    [SerializeField] public Text RoadMapSavas1LoseBackButton;
    [SerializeField] public Text RoadMapSavas1LoseTryAgain;

    [SerializeField] public Text RoadMapSavas2Win;
    [SerializeField] public Text RoadMapSavas2Lose;
    [SerializeField] public Text RoadMapSavas2WinBackButton;
    [SerializeField] public Text RoadMapSavas2LoseBackButton;
    [SerializeField] public Text RoadMapSavas2LoseTryAgain;

    [SerializeField] public Text RoadMapSavas3Win;
    [SerializeField] public Text RoadMapSavas3Lose;
    [SerializeField] public Text RoadMapSavas3WinBackButton;
    [SerializeField] public Text RoadMapSavas3LoseBackButton;
    [SerializeField] public Text RoadMapSavas3LoseTryAgain;

    [SerializeField] public Text RoadMapSavas4Win;
    [SerializeField] public Text RoadMapSavas4Lose;
    [SerializeField] public Text RoadMapSavas4WinBackButton;
    [SerializeField] public Text RoadMapSavas4LoseBackButton;
    [SerializeField] public Text RoadMapSavas4LoseTryAgain;

    [SerializeField] public Text RoadMapSavas5Win;
    [SerializeField] public Text RoadMapSavas5Lose;
    [SerializeField] public Text RoadMapSavas5WinBackButton;
    [SerializeField] public Text RoadMapSavas5LoseBackButton;
    [SerializeField] public Text RoadMapSavas5LoseTryAgain;

    [SerializeField] public Text RoadMapSavas1Miss;
    [SerializeField] public Text RoadMapSavas2Miss;
    [SerializeField] public Text RoadMapSavas3Miss;
    [SerializeField] public Text RoadMapSavas4Miss;
    [SerializeField] public Text RoadMapSavas5Miss;
    [SerializeField] public Wartextanakarakter RoadMapSavasSkill1v4Miss;
    [SerializeField] public Wartextanakarakter RoadMapSavasSkill2v4Miss;
    [SerializeField] public Wartextanakarakter RoadMapSavasSkill3v4Miss;
    [SerializeField] public Wartextanakarakter RoadMapSavasSkill4v4Miss;
    [SerializeField] public Wartextanakarakter RoadMapSavasSkill5v4Miss;
    [SerializeField] public Text RoadMapText;
    //[SerializeField] public Text R;


    public static int dil = 1;
    private void Start()
    {
        dil = PlayerPrefs.GetInt("dil");
    }
    private void Update()
    {
        PlayerPrefs.SetInt("dil", dil);
        if (dil == 1)
        {
            RoadMapText.text = "ROAD MAP";

            NoStamina.text = "No Stamina";

            RoadMapSavas2Skill5Et.fulltext = "Did you sell the Doblo ? ";
            RoadMapSavas2Skill5Ot.fulltext = "Necrophagous !!";
            RoadMapSavas2Skill5Yanma.fulltext = "Fireball !!";
            RoadMapSavas3Skill5Et.fulltext = "Did you sell the Doblo ? ";
            RoadMapSavas3Skill5Ot.fulltext = "Necrophagous !!";
            RoadMapSavas3Skill5Yanma.fulltext = "Fireball !!";
            RoadMapSavas4Skill5Et.fulltext = "Did you sell the Doblo ? ";
            RoadMapSavas4Skill5Ot.fulltext = "Necrophagous !!";
            RoadMapSavas4Skill5Yanma.fulltext = "Fireball !!";
            RoadMapSavas5Skill5Et.fulltext = "Did you sell the Doblo ? ";
            RoadMapSavas5Skill5Ot.fulltext = "Necrophagous !!";
            RoadMapSavas5Skill5Yanma.fulltext = "Fireball !!";

            TavukNormal.text = "Normal Chicken";
            TavukEtcil.text = "Chicken The Brutal";
            TavukOtcul.text = "Chicken the Fragile";
            Nomoney.text = "Not Enough Money";
            credits.text = "CREDITS";
            backCredits.text = "BACK";
            backSettings.text = "BACK";
            LangSettings.text = "LANGUAGES";
            NewGame.text = "NEW GAME";
            LoadGame.text = "LOAD GAME";
            BackGameScreen.text = "BACK";
            CutScene1v1.fulltext = "While he was cutting the chickens in kitchen he met a very strange chicken.He looked like alive. He took the chicken which looks weird to him to the chest's place where are at the side road.";
            CutScene1v2.fulltext = "He took his salary from the safe and was prepared to go home, set off.";
            CutScene1v3.fulltext = "A few minutes after leaving Restaurant, extortionists appeared and steal all his money. They punched Gringo and threw out the white teeth.";
            CutScene1v4.fulltext = "He heard a sound coming from the back street as he was bending from the pain. Crates creaked, and the trash shook.He got up heavily from where he fell and walked to where the sound came from.He saw that the frozen chicken that had been pulled out wasdefrosting, and the chicken was staring at it.";
            CutScene1v5.fulltext = "The chicken facing Gringo started talking:My name is Benny. I was one of 7 talking chickens produced as a result of the experiments of The White Fangs. I managed to escape the gang by force, i was wounded and when i opened my eyes i was in a factory. Then i woke up on to the crates. Gringo shocked.";
            GucGameKazandin.text = "Points Earned";
            CeviklikGameKazandin.text = "Points Earned";
            
            GucGameStartButton.text = "START";           
            CeviklikGameStartButton.text = "START";
            TavukAdi.text = "Normal Chicken";

            RoadMapYourTurn1.text = "YOUR TURN";
            RoadMapEnemyTurn1.text = "ENEMY'S TURN";
            RoadMapYourTurn2.text = "YOUR TURN";
            RoadMapEnemyTurn2.text = "ENEMY'S TURN";
            RoadMapYourTurn3.text = "YOUR TURN";
            RoadMapEnemyTurn3.text = "ENEMY'S TURN";
            RoadMapYourTurn4.text = "YOUR TURN";
            RoadMapEnemyTurn4.text = "ENEMY'S TURN";
            RoadMapYourTurn5.text = "YOUR TURN";
            RoadMapEnemyTurn5.text = "ENEMY'S TURN";

            RoadMapSkill1.fulltext = "Let's try something! ";
            RoadMapSkill2.fulltext = "I'm healing myself. Be on your guard! ";
            RoadMapSkill3.fulltext = "Taste my chicken wings! ";
            RoadMapSkill4Kritik.fulltext = "Through the weak point! ";

            RoadMapSkill1v2.fulltext = "Let's try something! ";
            RoadMapSkill2v2.fulltext = "I'm healing myself. Be on your guard! ";
            RoadMapSkill3v2.fulltext = "Taste my chicken wings! ";
            RoadMapSkill4v2Kritik.fulltext = "Through the weak point! ";

            RoadMapSkill1v3.fulltext = "Let's try something! ";
            RoadMapSkill2v3.fulltext = "I'm healing myself. Be on your guard! ";
            RoadMapSkill3v3.fulltext = "Taste my chicken wings! ";
            RoadMapSkill4v3Kritik.fulltext = "Through the weak point! ";

            RoadMapSkill1v4.fulltext = "Let's try something! ";
            RoadMapSkill2v4.fulltext = "I'm healing myself. Be on your guard! ";
            RoadMapSkill3v4.fulltext = "Taste my chicken wings! ";
            RoadMapSkill4v4Kritik.fulltext = "Through the weak point! ";

            RoadMapSkill1v5.fulltext = "Let's try something! ";
            RoadMapSkill2v5.fulltext = "I'm healing myself. Be on your guard! ";
            RoadMapSkill3v5.fulltext = "Taste my chicken wings! ";
            RoadMapSkill4v5Kritik.fulltext = "Through the weak point! ";


            RoadMapSavas1Win.text = "YOU WIN";
            RoadMapSavas1WinBackButton.text = "BACK";
            RoadMapSavas1Lose.text = "YOU LOSE";
            RoadMapSavas1LoseTryAgain.text = "TRY AGAIN";
            RoadMapSavas1LoseBackButton.text = "BACK";

            RoadMapSavas2Win.text = "YOU WIN";
            RoadMapSavas2WinBackButton.text = "BACK";
            RoadMapSavas2Lose.text = "YOU LOSE";
            RoadMapSavas2LoseTryAgain.text = "TRY AGAIN";
            RoadMapSavas2LoseBackButton.text = "BACK";

            RoadMapSavas3Win.text = "YOU WIN";
            RoadMapSavas3WinBackButton.text = "BACK";
            RoadMapSavas3Lose.text = "YOU LOSE";
            RoadMapSavas3LoseTryAgain.text = "TRY AGAIN";
            RoadMapSavas3LoseBackButton.text = "BACK";

            RoadMapSavas4Win.text = "YOU WIN";
            RoadMapSavas4WinBackButton.text = "BACK";
            RoadMapSavas4Lose.text = "YOU LOSE";
            RoadMapSavas4LoseTryAgain.text = "TRY AGAIN";
            RoadMapSavas4LoseBackButton.text = "BACK";

            RoadMapSavas5Win.text = "YOU WIN";
            RoadMapSavas5WinBackButton.text = "BACK";
            RoadMapSavas5Lose.text = "YOU LOSE";
            RoadMapSavas5LoseTryAgain.text = "TRY AGAIN";
            RoadMapSavas5LoseBackButton.text = "BACK";

            RoadMapSavas1Miss.text = "MISS";
            RoadMapSavas2Miss.text = "MISS";
            RoadMapSavas3Miss.text = "MISS";
            RoadMapSavas4Miss.text = "MISS";
            RoadMapSavas5Miss.text = "MISS";
            RoadMapSavasSkill1v4Miss.fulltext = "Damn! ";
            RoadMapSavasSkill2v4Miss.fulltext = "Damn! ";
            RoadMapSavasSkill3v4Miss.fulltext = "Damn! ";
            RoadMapSavasSkill4v4Miss.fulltext = "Damn! ";
            RoadMapSavasSkill5v4Miss.fulltext = "Damn! ";

        }
        else if (dil == 0)
        {
            RoadMapText.text = "YOL HARITASI";

            NoStamina.text = "Enerji Kalmadı";

            RoadMapSavas2Skill5Et.fulltext = "Eniste dobloyu sattin mi ? ";
            RoadMapSavas2Skill5Ot.fulltext = "Ceset Yiyen !!";
            RoadMapSavas2Skill5Yanma.fulltext = "Alev Topu !!";
            RoadMapSavas3Skill5Et.fulltext = "Eniste dobloyu sattin mi ? ";
            RoadMapSavas3Skill5Ot.fulltext = "Ceset Yiyen !!";
            RoadMapSavas3Skill5Yanma.fulltext = "Alev Topu !!";
            RoadMapSavas4Skill5Et.fulltext = "Eniste dobloyu sattin mi ? ";
            RoadMapSavas4Skill5Ot.fulltext = "Ceset Yiyen !!";
            RoadMapSavas4Skill5Yanma.fulltext = "Alev Topu !!";
            RoadMapSavas5Skill5Et.fulltext = "Eniste dobloyu sattin mi ? ";
            RoadMapSavas5Skill5Ot.fulltext = "Ceset Yiyen !!";
            RoadMapSavas5Skill5Yanma.fulltext = "Alev Topu !!";

            TavukNormal.text = "Normal Tavuk";
            TavukEtcil.text = "Acimasiz Tavuk";
            TavukOtcul.text = "Narin Tavuk";
            Nomoney.text = "Yetersiz Bakiye";

            credits.text = "HAZIRLAYANLAR";
            backCredits.text = "GERI";
            backSettings.text = "GERI";
            LangSettings.text = "DILLER";
            NewGame.text = "YENI OYUN";
            LoadGame.text = "KAYITLI OYUNU YUKLE";
            BackGameScreen.text = "GERI";
            CutScene1v1.fulltext = "Mutfakta tavuklari keserken çok garip bir tavuk ile karsılastı. Sanki yasıyor gibiydi. Ona garip gelen bu tavugu arka kapidan cıkartıp ara sokaktaki kasalarin oldugu yere bıraktı. ";
            CutScene1v2.fulltext = "Kasadan maasini aldi ve eve gitmek icin hazırlandi, yola koyuldu. ";
            CutScene1v3.fulltext = "Restorant'dan ayrildiktan birkac dakika sonra karsisina gaspcılar cıktı ve butun parasini gasp ettiler. Gringo’yu dovduler ve ustune beyaz dis firlattilar. ";
            CutScene1v4.fulltext = "Acidan kivranirken ara sokaktan bir ses geldigini duydu. Kasalar gicirdadi, çop kutusu sallandi. Yattigi yerden agır bir sekilde kalkti ve sesin geldigi yone yurudu. Dısarı cıkardıgı dondurulmus tavugun buzunun çozuldugunu gordu ve tavuk ona bakiyordu. ";
            CutScene1v5.fulltext = "Gringo’ya bakan tavuk konusmaya basladı; “Benim adim Benny. The White Fangs’in deneyleri sonucu uretilen 7 konusabilen tavuktan birisiydim. Cetenin elinden zorla kactım, yaralanmistim ve gozlerimi actıgımda bir fabrikadaydım sonrasında ise kasaların uzerinde uyandım.” Gringo sasırdı. ";
            GucGameKazandin.text = "Puan Kazanıldı";
            CeviklikGameKazandin.text = "Puan Kazanıldı";
           
            GucGameStartButton.text = "BASLA";
         
            CeviklikGameStartButton.text = "BASLA";
            TavukAdi.text = "Normal Tavuk";

            RoadMapYourTurn1.text = "SIRA SENDE";
            RoadMapEnemyTurn1.text = "SIRA RAKIBINDE";
            RoadMapYourTurn2.text = "SIRA SENDE";
            RoadMapEnemyTurn2.text = "SIRA RAKIBINDE";
            RoadMapYourTurn3.text = "SIRA SENDE";
            RoadMapEnemyTurn3.text = "SIRA RAKIBINDE";
            RoadMapYourTurn4.text = "SIRA SENDE";
            RoadMapEnemyTurn4.text = "SIRA RAKIBINDE";
            RoadMapYourTurn5.text = "SIRA SENDE";
            RoadMapEnemyTurn5.text = "SIRA RAKIBINDE";

            RoadMapSkill1.fulltext = "Hadi bir şeyler deneyelim! ";
            RoadMapSkill2.fulltext = "Canımı tazeliyorum. Arkanı kolla! ";
            RoadMapSkill3.fulltext = "Tavuk kanatlarımın tadına bak! ";
            RoadMapSkill4Kritik.fulltext = "Tam 12'den! ";

            RoadMapSkill1v2.fulltext = "Hadi bir şeyler deneyelim! ";
            RoadMapSkill2v2.fulltext = "Canımı tazeliyorum. Arkanı kolla! ";
            RoadMapSkill3v2.fulltext = "Tavuk kanatlarımın tadına bak! ";
            RoadMapSkill4v2Kritik.fulltext = "Tam 12'den! ";

            RoadMapSkill1v3.fulltext = "Hadi bir şeyler deneyelim! ";
            RoadMapSkill2v3.fulltext = "Canımı tazeliyorum. Arkanı kolla! ";
            RoadMapSkill3v3.fulltext = "Tavuk kanatlarımın tadına bak! ";
            RoadMapSkill4v3Kritik.fulltext = "Tam 12'den! ";

            RoadMapSkill1v4.fulltext = "Hadi bir şeyler deneyelim! ";
            RoadMapSkill2v4.fulltext = "Canımı tazeliyorum. Arkanı kolla! ";
            RoadMapSkill3v4.fulltext = "Tavuk kanatlarımın tadına bak! ";
            RoadMapSkill4v4Kritik.fulltext = "Tam 12'den! ";

            RoadMapSkill1v5.fulltext = "Hadi bir şeyler deneyelim! ";
            RoadMapSkill2v5.fulltext = "Canımı tazeliyorum. Arkanı kolla! ";
            RoadMapSkill3v5.fulltext = "Tavuk kanatlarımın tadına bak! ";
            RoadMapSkill4v5Kritik.fulltext = "Tam 12'den! ";

            RoadMapSavas1Win.text = "KAZANDIN";
            RoadMapSavas1WinBackButton.text = "GERI";
            RoadMapSavas1Lose.text = "KAYBETTIN";
            RoadMapSavas1LoseTryAgain.text = "TEKRAR DENE";
            RoadMapSavas1LoseBackButton.text = "GERI";

            RoadMapSavas2Win.text = "KAZANDIN";
            RoadMapSavas2WinBackButton.text = "GERI";
            RoadMapSavas2Lose.text = "KAYBETTIN";
            RoadMapSavas2LoseTryAgain.text = "TEKRAR DENE";
            RoadMapSavas2LoseBackButton.text = "GERI";

            RoadMapSavas3Win.text = "KAZANDIN";
            RoadMapSavas3WinBackButton.text = "GERI";
            RoadMapSavas3Lose.text = "KAYBETTIN";
            RoadMapSavas3LoseTryAgain.text = "TEKRAR DENE";
            RoadMapSavas3LoseBackButton.text = "GERI";

            RoadMapSavas4Win.text = "KAZANDIN";
            RoadMapSavas4WinBackButton.text = "GERI";
            RoadMapSavas4Lose.text = "KAYBETTIN";
            RoadMapSavas4LoseTryAgain.text = "TEKRAR DENE";
            RoadMapSavas4LoseBackButton.text = "GERI";

            RoadMapSavas5Win.text = "KAZANDIN";
            RoadMapSavas5WinBackButton.text = "GERI";
            RoadMapSavas5Lose.text = "KAYBETTIN";
            RoadMapSavas5LoseTryAgain.text = "TEKRAR DENE";
            RoadMapSavas5LoseBackButton.text = "GERI";

            RoadMapSavas1Miss.text = "TUH";
            RoadMapSavas2Miss.text = "KACIRDIM";
            RoadMapSavas3Miss.text = "COK AZ KALMISTI";
            RoadMapSavas4Miss.text = "UCUNDAN";
            RoadMapSavas5Miss.text = "AH BE";
            RoadMapSavasSkill1v4Miss.fulltext = "Lanet Olsun! ";
            RoadMapSavasSkill2v4Miss.fulltext = "Lanet Olsun! ";
            RoadMapSavasSkill3v4Miss.fulltext = "Lanet Olsun! ";
            RoadMapSavasSkill4v4Miss.fulltext = "Lanet Olsun! ";
            RoadMapSavasSkill5v4Miss.fulltext = "Lanet Olsun! ";
        }
    }

    public void LanguageEN()
    {
        dil = 1;
    }
    public void LanguageTR()
    {
        dil = 0;
  
    }
}