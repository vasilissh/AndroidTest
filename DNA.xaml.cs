namespace AndroidTest;

public partial class DNA : ContentPage
{
	Dictionary<string, string> RNAConvert = new Dictionary<string, string>();
	
	public DNA()
	{
		InitializeComponent();
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "����");
		RNAConvert.Add("���", "����");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "����");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");
		RNAConvert.Add("���", "���");

        RNAConvert.Add("���", "�����������");
        RNAConvert.Add("���", "�����������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "����");
        RNAConvert.Add("���", "����");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "����");
        RNAConvert.Add("���", "���������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "��������");
        RNAConvert.Add("���", "��������");
        RNAConvert.Add("���", "��������");
        RNAConvert.Add("���", "��������");
        RNAConvert.Add("���", "���������");
        RNAConvert.Add("���", "���������");
        RNAConvert.Add("���", "���������");
        RNAConvert.Add("���", "��������");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "���������");
        RNAConvert.Add("���", "���������");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "�������");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "�����");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������������� �������");
        RNAConvert.Add("���", "������������� �������");
        RNAConvert.Add("���", "������������ �������");
        RNAConvert.Add("���", "������������ �������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");
        RNAConvert.Add("���", "������");


    }

    private void DNA_convert_Clicked(object sender, EventArgs e)
    {
		string DNAReverse = "";
		foreach (char C in DNA_editor.Text.ToUpper()) 
		{ 
			switch (C) 
			{
				case '�':
					DNAReverse += '�';
					break;
				case '�':
					DNAReverse += '�';
					break;
				case '�':
					DNAReverse += '�';
					break;
				case '�':
					DNAReverse += '�';
					break;
			}
		}

		DNA_Show_Result.Text = DNAReverse;

		string RNA = "";
		foreach (char D in DNAReverse) 
		{
		 switch(D)
			{
				case '�':
					RNA += '�';
					break;
				case '�':
					RNA += '�';
					break;
				case '�':
					RNA += '�';
					break;
				case '�':
					RNA += '�';
					break;
			}
		}

		RNA_Show_Result.Text = RNA;
    }
}