namespace AndroidTest;

public partial class DNA : ContentPage
{
	Dictionary<string, string> RNAConvert = new Dictionary<string, string>();
	
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

        RNAConvert.Add("УУУ", "Фенилаланин");
        RNAConvert.Add("УУЦ", "Фенилаланин");
        RNAConvert.Add("УУА", "Лейцин");
        RNAConvert.Add("УУГ", "Лейцин");
        RNAConvert.Add("УЦУ", "Серин");
        RNAConvert.Add("УЦЦ", "Серин");
        RNAConvert.Add("УЦА", "Серин");
        RNAConvert.Add("УЦГ", "Серин");
        RNAConvert.Add("УАУ", "Тирозин");
        RNAConvert.Add("УАЦ", "Тирозин");
        RNAConvert.Add("УАА", "СТОП");
        RNAConvert.Add("УАГ", "СТОП");
        RNAConvert.Add("УГУ", "Цистеин");
        RNAConvert.Add("УГЦ", "Цистеин");
        RNAConvert.Add("УГА", "СТОП");
        RNAConvert.Add("УГГ", "Триптофан");
        RNAConvert.Add("ЦУУ", "Лейцин");
        RNAConvert.Add("ЦУЦ", "Лейцин");
        RNAConvert.Add("ЦУА", "Лейцин");
        RNAConvert.Add("ЦУГ", "Лейцин");
        RNAConvert.Add("ЦЦУ", "Пролин");
        RNAConvert.Add("ЦЦЦ", "Пролин");
        RNAConvert.Add("ЦЦА", "Пролин");
        RNAConvert.Add("ЦЦГ", "Пролин");
        RNAConvert.Add("ЦАУ", "Гистидин");
        RNAConvert.Add("ЦАЦ", "Гистидин");
        RNAConvert.Add("ЦАА", "Глутамин");
        RNAConvert.Add("ЦАГ", "Глутамин");
        RNAConvert.Add("АУУ", "Изолейцин");
        RNAConvert.Add("АУЦ", "Изолейцин");
        RNAConvert.Add("АУА", "Изолейцин");
        RNAConvert.Add("АУГ", "Метионин");
        RNAConvert.Add("АЦУ", "Треонин");
        RNAConvert.Add("АЦЦ", "Треонин");
        RNAConvert.Add("АЦА", "Треонин");
        RNAConvert.Add("АЦГ", "Треонин");
        RNAConvert.Add("ААУ", "Аспарагин");
        RNAConvert.Add("ААЦ", "Аспарагин");
        RNAConvert.Add("ААА", "Лизин");
        RNAConvert.Add("ААГ", "Лизин");
        RNAConvert.Add("АГУ", "Серин");
        RNAConvert.Add("АГЦ", "Серин");
        RNAConvert.Add("АГА", "Аргинин");
        RNAConvert.Add("АГГ", "Аргинин");
        RNAConvert.Add("ГУУ", "Валин");
        RNAConvert.Add("ГУЦ", "Валин");
        RNAConvert.Add("ГУА", "Валин");
        RNAConvert.Add("ГУГ", "Валин");
        RNAConvert.Add("ГЦУ", "Аланин");
        RNAConvert.Add("ГЦЦ", "Аланин");
        RNAConvert.Add("ГЦА", "Аланин");
        RNAConvert.Add("ГЦГ", "Аланин");
        RNAConvert.Add("ГАУ", "Аспарагиновая кислота");
        RNAConvert.Add("ГАЦ", "Аспарагиновая кислота");
        RNAConvert.Add("ГАА", "Глутаминовая кислота");
        RNAConvert.Add("ГАГ", "Глутаминовая кислота");
        RNAConvert.Add("ГГУ", "Глицин");
        RNAConvert.Add("ГГЦ", "Глицин");
        RNAConvert.Add("ГГА", "Глицин");
        RNAConvert.Add("ГГГ", "Глицин");


    }

    private void DNA_convert_Clicked(object sender, EventArgs e)
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
		 switch(D)
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
    }
}