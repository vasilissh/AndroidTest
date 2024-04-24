namespace AndroidTest;

public partial class DNA : ContentPage
{
	Dictionary<string, string> RNAConvert = new Dictionary<string, string>();
	Dictionary<string, string> RNAConvertFull = new Dictionary<string, string>();
	
	public DNA()
	{
		InitializeComponent();
		RNAConvert.Add("УУУ", "Фен");
		RNAConvert.Add("УУЦ", "Фен");
		RNAConvert.Add("УУА", "Лей");
		RNAConvert.Add("УУГ", "Лей");
		RNAConvert.Add("УЦУ", "Сер");
		RNAConvert.Add("УЦЦ", "Сер");
		RNAConvert.Add("УЦА", "Сер");
		RNAConvert.Add("УЦГ", "Сер");
		RNAConvert.Add("УАУ", "Тир");
		RNAConvert.Add("УАЦ", "Тир");
		RNAConvert.Add("УАА", "СТОП");
		RNAConvert.Add("УАГ", "СТОП");
		RNAConvert.Add("УГУ", "Цис");
		RNAConvert.Add("УГЦ", "Цис");
		RNAConvert.Add("УГА", "СТОП");
		RNAConvert.Add("УГГ", "Три");
		RNAConvert.Add("ЦУУ", "Лей");
		RNAConvert.Add("ЦУЦ", "Лей");
		RNAConvert.Add("ЦУА", "Лей");
		RNAConvert.Add("ЦУГ", "Лей");
		RNAConvert.Add("ЦЦУ", "Про");
		RNAConvert.Add("ЦЦЦ", "Про");
		RNAConvert.Add("ЦЦА", "Про");
		RNAConvert.Add("ЦЦГ", "Про");
		RNAConvert.Add("ЦАУ", "Гис");
		RNAConvert.Add("ЦАЦ", "Гис");
		RNAConvert.Add("ЦАА", "Глн");
		RNAConvert.Add("ЦАГ", "Глн");
		RNAConvert.Add("ЦГУ", "Арг");
		RNAConvert.Add("ЦГЦ", "Арг");
		RNAConvert.Add("ЦГА", "Арг");
		RNAConvert.Add("ЦГГ", "Арг");
		RNAConvert.Add("АУУ", "Иле");
		RNAConvert.Add("АУЦ", "Иле");
		RNAConvert.Add("АУА", "Иле");
		RNAConvert.Add("АУГ", "Мет");
		RNAConvert.Add("АЦУ", "Тре");
		RNAConvert.Add("АЦЦ", "Тре");
		RNAConvert.Add("АЦА", "Тре");
		RNAConvert.Add("АЦГ", "Тре");
		RNAConvert.Add("ААУ", "Асн");
		RNAConvert.Add("ААЦ", "Асн");
		RNAConvert.Add("ААА", "Лиз");
		RNAConvert.Add("ААГ", "Лиз");
		RNAConvert.Add("АГУ", "Сер");
		RNAConvert.Add("АГЦ", "Сер");
		RNAConvert.Add("АГА", "Арг");
		RNAConvert.Add("АГГ", "Арг");
		RNAConvert.Add("ГУУ", "Вал");
		RNAConvert.Add("ГУЦ", "Вал");
		RNAConvert.Add("ГУА", "Вал");
		RNAConvert.Add("ГУГ", "Вал");
		RNAConvert.Add("ГЦУ", "Ала");
		RNAConvert.Add("ГЦЦ", "Ала");
		RNAConvert.Add("ГЦА", "Ала");
		RNAConvert.Add("ГЦГ", "Ала");
		RNAConvert.Add("ГАУ", "Асп");
		RNAConvert.Add("ГАЦ", "Асп");
		RNAConvert.Add("ГАА", "Глу");
		RNAConvert.Add("ГАГ", "Глу");
		RNAConvert.Add("ГГУ", "Гли");
		RNAConvert.Add("ГГЦ", "Гли");
		RNAConvert.Add("ГГА", "Гли");
		RNAConvert.Add("ГГГ", "Гли");

        RNAConvertFull.Add("УУУ", "Фенилаланин");
        RNAConvertFull.Add("УУЦ", "Фенилаланин");
        RNAConvertFull.Add("УУА", "Лейцин");
        RNAConvertFull.Add("УУГ", "Лейцин");
        RNAConvertFull.Add("УЦУ", "Серин");
        RNAConvertFull.Add("УЦЦ", "Серин");
        RNAConvertFull.Add("УЦА", "Серин");
        RNAConvertFull.Add("УЦГ", "Серин");
        RNAConvertFull.Add("УАУ", "Тирозин");
        RNAConvertFull.Add("УАЦ", "Тирозин");
        RNAConvertFull.Add("УАА", "СТОП");
        RNAConvertFull.Add("УАГ", "СТОП");
        RNAConvertFull.Add("УГУ", "Цистеин");
        RNAConvertFull.Add("УГЦ", "Цистеин");
        RNAConvertFull.Add("УГА", "СТОП");
        RNAConvertFull.Add("УГГ", "Триптофан");
        RNAConvertFull.Add("ЦУУ", "Лейцин");
        RNAConvertFull.Add("ЦУЦ", "Лейцин");
        RNAConvertFull.Add("ЦУА", "Лейцин");
        RNAConvertFull.Add("ЦУГ", "Лейцин");
        RNAConvertFull.Add("ЦЦУ", "Пролин");
        RNAConvertFull.Add("ЦЦЦ", "Пролин");
        RNAConvertFull.Add("ЦЦА", "Пролин");
        RNAConvertFull.Add("ЦЦГ", "Пролин");
        RNAConvertFull.Add("ЦАУ", "Гистидин");
        RNAConvertFull.Add("ЦАЦ", "Гистидин");
        RNAConvertFull.Add("ЦАА", "Глутамин");
        RNAConvertFull.Add("ЦАГ", "Глутамин");
        RNAConvertFull.Add("ЦГУ", "Аргинин");
        RNAConvertFull.Add("ЦГЦ", "Аргинин");
        RNAConvertFull.Add("ЦГА", "Аргинин");
        RNAConvertFull.Add("ЦГГ", "Аргинин");
        RNAConvertFull.Add("АУУ", "Изолейцин");
        RNAConvertFull.Add("АУЦ", "Изолейцин");
        RNAConvertFull.Add("АУА", "Изолейцин");
        RNAConvertFull.Add("АУГ", "Метионин");
        RNAConvertFull.Add("АЦУ", "Треонин");
        RNAConvertFull.Add("АЦЦ", "Треонин");
        RNAConvertFull.Add("АЦА", "Треонин");
        RNAConvertFull.Add("АЦГ", "Треонин");
        RNAConvertFull.Add("ААУ", "Аспарагин");
        RNAConvertFull.Add("ААЦ", "Аспарагин");
        RNAConvertFull.Add("ААА", "Лизин");
        RNAConvertFull.Add("ААГ", "Лизин");
        RNAConvertFull.Add("АГУ", "Серин");
        RNAConvertFull.Add("АГЦ", "Серин");
        RNAConvertFull.Add("АГА", "Аргинин");
        RNAConvertFull.Add("АГГ", "Аргинин");
        RNAConvertFull.Add("ГУУ", "Валин");
        RNAConvertFull.Add("ГУЦ", "Валин");
        RNAConvertFull.Add("ГУА", "Валин");
        RNAConvertFull.Add("ГУГ", "Валин");
        RNAConvertFull.Add("ГЦУ", "Аланин");
        RNAConvertFull.Add("ГЦЦ", "Аланин");
        RNAConvertFull.Add("ГЦА", "Аланин");
        RNAConvertFull.Add("ГЦГ", "Аланин");
        RNAConvertFull.Add("ГАУ", "Аспарагиновая кислота");
        RNAConvertFull.Add("ГАЦ", "Аспарагиновая кислота");
        RNAConvertFull.Add("ГАА", "Глутаминовая кислота");
        RNAConvertFull.Add("ГАГ", "Глутаминовая кислота");
        RNAConvertFull.Add("ГГУ", "Глицин");
        RNAConvertFull.Add("ГГЦ", "Глицин");
        RNAConvertFull.Add("ГГА", "Глицин");
        RNAConvertFull.Add("ГГГ", "Глицин");


    }

   
    /// <summary>
    /// Преобразование ДНК и иРНК + выдача названия аминокислот
    /// </summary>

    private void Full_Convert()
    {
        string DNAReverse = "";
        foreach (char C in DNA_editor.Text.ToUpper())
        {
            switch (C)
            {
                case 'А':
                    DNAReverse += 'Т';
                    break;
                case 'Г':
                    DNAReverse += 'Ц';
                    break;
                case 'Т':
                    DNAReverse += 'А';
                    break;
                case 'Ц':
                    DNAReverse += 'Г';
                    break;
            }
        }

        DNA_Show_Result.Text = DNAReverse;

        string RNA = "";
        foreach (char D in DNAReverse)
        {
            switch (D)
            {
                case 'А':
                    RNA += 'У';
                    break;
                case 'Г':
                    RNA += 'Ц';
                    break;
                case 'Т':
                    RNA += 'А';
                    break;
                case 'Ц':
                    RNA += 'Г';
                    break;
            }
        }

        RNA_Show_Result.Text = RNA;

        Protein_Label.Text = RNAToProtein(RNA);
        int StartCodon = RNA.IndexOf("xxx");
    }

    /// <summary>
    /// Превращает Рнк в названия Аминокислот
    /// </summary>
    /// <param name="RNA">Входной РНК код</param>
    /// <returns></returns>
    private string RNAToProtein(string RNA)
    {
        int Start = FindStartCodon(RNA); 
        if( Start == -1 ) { return ""; };
        
        string Protein = "";
        for (int i = Start; i < RNA.Count(); i += 3)
        {
            if (i + 3 >= RNA.Count()) break;
            string Triplet = RNA.Substring(i, 3);
            Protein += Full_Named.IsChecked
                ? RNAConvertFull[Triplet] + " "
                : RNAConvert[Triplet] + " ";

        }

        return Protein;
    }

    /// <summary>
    /// Осуществляет поиск старт кодона
    /// </summary>
    /// <param name="RNA">Входной РНК код</param>
    /// <returns></returns>

    private int FindStartCodon(string RNA)
    {
        if (!RNA.Contains("АУГ")) return -1;
        return RNA.IndexOf("АУГ");
    }

    private void DNA_editor_TextChanged(object sender, TextChangedEventArgs e)
    {
        Full_Convert();
    }

    private void Full_Named_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        Full_Convert();
    }
}