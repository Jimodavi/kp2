#pragma once

namespace kp2 {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// Сводка для tournaments_form
	public ref class tournaments_form : public System::Windows::Forms::Form
	{
	public:
		tournaments_form(void)
		{
			InitializeComponent();
		}
		array<String^>^ column_name = gcnew array<String^> (19);//названия колонок таблицы "Турниры"
		
	protected:
		/// Освободить все используемые ресурсы.
		~tournaments_form()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::DataGridView^ dataGridView1;
	private: System::Windows::Forms::Button^ Download_Button;
	private: System::Windows::Forms::Button^ Add_Button;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Code_Tournament;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Name;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Code_Category;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Code_System;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Number_Participants;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Type;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Number_Groups;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Date_Begin;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Date_End;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Number_Courts;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Code_Court1;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Code_Court2;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Code_Court3;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Time_Begin;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Time_End;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Match_Length;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ FIO_Director;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Phone_Number_Director;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Number_Seeded_Players;
	private: System::Windows::Forms::Button^ Update_Button;
	private:
		/// Обязательная переменная конструктора.
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		void InitializeComponent(void)
		{
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->Code_Tournament = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Name = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Code_Category = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Code_System = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Number_Participants = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Type = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Number_Groups = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Date_Begin = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Date_End = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Number_Courts = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Code_Court1 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Code_Court2 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Code_Court3 = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Time_Begin = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Time_End = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Match_Length = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->FIO_Director = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Phone_Number_Director = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Number_Seeded_Players = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Download_Button = (gcnew System::Windows::Forms::Button());
			this->Add_Button = (gcnew System::Windows::Forms::Button());
			this->Update_Button = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->SuspendLayout();
			// 
			// dataGridView1
			// 
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(19) {
				this->Code_Tournament,
					this->Name, this->Code_Category, this->Code_System, this->Number_Participants, this->Type, this->Number_Groups, this->Date_Begin,
					this->Date_End, this->Number_Courts, this->Code_Court1, this->Code_Court2, this->Code_Court3, this->Time_Begin, this->Time_End,
					this->Match_Length, this->FIO_Director, this->Phone_Number_Director, this->Number_Seeded_Players
			});
			this->dataGridView1->Location = System::Drawing::Point(12, 12);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->Size = System::Drawing::Size(675, 258);
			this->dataGridView1->TabIndex = 0;
			// 
			// Code_Tournament
			// 
			this->Code_Tournament->HeaderText = L"Код турнира";
			this->Code_Tournament->Name = L"Code_Tournament";
			this->Code_Tournament->ReadOnly = true;
			// 
			// Name
			// 
			this->Name->HeaderText = L"Наименование";
			this->Name->Name = L"Name";
			// 
			// Code_Category
			// 
			this->Code_Category->HeaderText = L"Код категории";
			this->Code_Category->Name = L"Code_Category";
			// 
			// Code_System
			// 
			this->Code_System->HeaderText = L"Код системы проведения";
			this->Code_System->Name = L"Code_System";
			// 
			// Number_Participants
			// 
			this->Number_Participants->HeaderText = L"Количество участников";
			this->Number_Participants->Name = L"Number_Participants";
			// 
			// Type
			// 
			this->Type->HeaderText = L"Разряд";
			this->Type->Name = L"Type";
			// 
			// Number_Groups
			// 
			this->Number_Groups->HeaderText = L"Количество групп";
			this->Number_Groups->Name = L"Number_Groups";
			// 
			// Date_Begin
			// 
			this->Date_Begin->HeaderText = L"Дата начала";
			this->Date_Begin->Name = L"Date_Begin";
			// 
			// Date_End
			// 
			this->Date_End->HeaderText = L"Дата конца";
			this->Date_End->Name = L"Date_End";
			// 
			// Number_Courts
			// 
			this->Number_Courts->HeaderText = L"Количество кортов";
			this->Number_Courts->Name = L"Number_Courts";
			// 
			// Code_Court1
			// 
			this->Code_Court1->HeaderText = L"Код корта 1";
			this->Code_Court1->Name = L"Code_Court1";
			// 
			// Code_Court2
			// 
			this->Code_Court2->HeaderText = L"Код корта 2";
			this->Code_Court2->Name = L"Code_Court2";
			// 
			// Code_Court3
			// 
			this->Code_Court3->HeaderText = L"Код корта 3";
			this->Code_Court3->Name = L"Code_Court3";
			// 
			// Time_Begin
			// 
			this->Time_Begin->HeaderText = L"Время начала проведения";
			this->Time_Begin->Name = L"Time_Begin";
			// 
			// Time_End
			// 
			this->Time_End->HeaderText = L"Время конца проведения";
			this->Time_End->Name = L"Time_End";
			// 
			// Match_Length
			// 
			this->Match_Length->HeaderText = L"Длительность матча";
			this->Match_Length->Name = L"Match_Length";
			// 
			// FIO_Director
			// 
			this->FIO_Director->HeaderText = L"ФИО директора";
			this->FIO_Director->Name = L"FIO_Director";
			// 
			// Phone_Number_Director
			// 
			this->Phone_Number_Director->HeaderText = L"Телефон директора";
			this->Phone_Number_Director->Name = L"Phone_Number_Director";
			// 
			// Number_Seeded_Players
			// 
			this->Number_Seeded_Players->HeaderText = L"Количество сеянных участников";
			this->Number_Seeded_Players->Name = L"Number_Seeded_Players";
			// 
			// Download_Button
			// 
			this->Download_Button->Location = System::Drawing::Point(12, 276);
			this->Download_Button->Name = L"Download_Button";
			this->Download_Button->Size = System::Drawing::Size(170, 46);
			this->Download_Button->TabIndex = 1;
			this->Download_Button->Text = L"Загрузить";
			this->Download_Button->UseVisualStyleBackColor = true;
			this->Download_Button->Click += gcnew System::EventHandler(this, &tournaments_form::Download_Button_Click);
			// 
			// Add_Button
			// 
			this->Add_Button->Location = System::Drawing::Point(188, 276);
			this->Add_Button->Name = L"Add_Button";
			this->Add_Button->Size = System::Drawing::Size(170, 46);
			this->Add_Button->TabIndex = 2;
			this->Add_Button->Text = L"Добавить";
			this->Add_Button->UseVisualStyleBackColor = true;
			this->Add_Button->Click += gcnew System::EventHandler(this, &tournaments_form::Add_Button_Click);
			// 
			// Update_Button
			// 
			this->Update_Button->Location = System::Drawing::Point(364, 276);
			this->Update_Button->Name = L"Update_Button";
			this->Update_Button->Size = System::Drawing::Size(170, 46);
			this->Update_Button->TabIndex = 3;
			this->Update_Button->Text = L"Обновить";
			this->Update_Button->UseVisualStyleBackColor = true;
			this->Update_Button->Click += gcnew System::EventHandler(this, &tournaments_form::Update_Button_Click);
			// 
			// tournaments_form
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(840, 432);
			this->Controls->Add(this->Update_Button);
			this->Controls->Add(this->Add_Button);
			this->Controls->Add(this->Download_Button);
			this->Controls->Add(this->dataGridView1);
			/*this->Name = L"tournaments_form";*/
			this->Text = L"tournaments_form";
			this->Load += gcnew System::EventHandler(this, &tournaments_form::tournaments_form_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->ResumeLayout(false);
		}
#pragma endregion
	private: System::Void Download_Button_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Add_Button_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void Update_Button_Click(System::Object^ sender, System::EventArgs^ e);
	private: System::Void tournaments_form_Load(System::Object^ sender, System::EventArgs^ e);
};
}
